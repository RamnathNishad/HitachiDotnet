
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace EmployeeService.Models
{
    public class GlobalExceptionHandler : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                ProblemDetails details = new ProblemDetails
                {
                    Detail="Some error occurred:" + ex.Message,
                    Type="Server error",
                    Title="Internal server error"
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(details));
            }
        }
    }
}
