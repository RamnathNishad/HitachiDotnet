using EmployeeService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public AccountController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(UserDetails user)
        {
            try
            {
                //check user credential in database
                if (user.Username == "admin" && user.Password == "admin123")
                {
                    //generate the JWT token
                    var tokenHandler = new JwtSecurityTokenHandler();

                    var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
                    var issuer = _configuration["JWT:Issuer"];
                    var audience = _configuration["JWT:Audience"];
                    var expires = DateTime.UtcNow.AddMinutes(10);
                    var securityKey = new SymmetricSecurityKey(tokenKey);

                    var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
                    {
                        Issuer = issuer,
                        Audience = audience,
                        Expires = expires,
                        SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
                    });

                    //write the token in the return
                    return Ok(tokenHandler.WriteToken(token));
                }
                else
                {
                    return BadRequest("invalid credential");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
