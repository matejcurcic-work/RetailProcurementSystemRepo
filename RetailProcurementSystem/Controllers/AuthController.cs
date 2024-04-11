using Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace RetailProcurementSystem.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost, Route("login")]
        public IActionResult Login(LoginModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid client request");
            }

            var username = _config["TokenDummyData:Username"];
            var password = _config["TokenDummyData:Password"];

            if (model.UserName == username && model.Password == password)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var Sectoken = new JwtSecurityToken(
                    _config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    null,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);

                var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);


                return Ok(new { Token = "Bearer " + token });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}