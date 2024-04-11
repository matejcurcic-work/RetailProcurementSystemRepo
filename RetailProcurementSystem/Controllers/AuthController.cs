using Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace RetailProcurementSystem.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IOptions<JwtOptions> _jwtOptions;

        public AuthController(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions;
        }

        [HttpPost, Route("login")]
        public IActionResult Login(LoginModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid client request");
            }

            var username = _jwtOptions.Value.Username;
            var password = _jwtOptions.Value.Password;
            var jwtKey = _jwtOptions.Value.Key;
            var jwtIssuer = _jwtOptions.Value.Issuer;

            if (model.UserName == username && model.Password == password)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var Sectoken = new JwtSecurityToken(
                    jwtIssuer,
                    jwtIssuer,
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