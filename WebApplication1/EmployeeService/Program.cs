
using EmployeeService.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace EmployeeService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(options=>
            {
                options.OutputFormatters
                       .Add(new XmlSerializerOutputFormatter()); 
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //configure the dependency injection for DataAccess
            builder.Services.AddScoped<IEmployeeDataAccess,EmployeeDataAccess>();
            //add authentication service
            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                var key = Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]);

                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = builder.Configuration["JWT:Issuer"],
                    ValidAudience= builder.Configuration["JWT:Audience"],
                    IssuerSigningKey=new SymmetricSecurityKey(key)
                };
            });


            //configure GlobalException Handler
            builder.Services.AddScoped<GlobalExceptionHandler>();

            //configure the DbContext dependency injection
            builder.Services.AddDbContext<EmployeeDbContext>(options =>
            {
                var sqlConStr = builder.Configuration.GetConnectionString("sqlConStr");
                options.UseSqlServer(sqlConStr);
            });

            //configure CORS policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("clients-allowed", opts =>
                {
                    opts.WithOrigins("http://localhost:5146")
                        .AllowAnyMethod();
                });
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            //use the middleware
            app.UseMiddleware<GlobalExceptionHandler>();

            //use the cors policy
            app.UseCors("clients-allowed");
            app.Run();
        }
    }
}
