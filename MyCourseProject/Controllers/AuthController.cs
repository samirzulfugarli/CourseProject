using DAL.DataContext;
using DTO.AuthDtos;
using DTO.LoginDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyCourseProject.Utility;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyCourseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly MyContext _ctx;
        public AuthController(IConfiguration configuration,MyContext ctx)
        {
            _ctx = ctx;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            Auth auth = new Auth(_ctx);
            LoginResponsDto loginResponsDto = auth.Login(dto);
            if (loginResponsDto.Success)
            {
                var issuer = _configuration["Jwt:Issuer"];
                var audience = _configuration["Jwt:Audience"];
                var key = Encoding.ASCII.GetBytes
                (_configuration["Jwt:Key"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                      new Claim(ClaimTypes.NameIdentifier, loginResponsDto.User.Id.ToString()),
                      new Claim(ClaimTypes.Role, loginResponsDto.User.Role.Key),
                      new Claim("Fullname", loginResponsDto.User.Fullname),
                      new Claim(JwtRegisteredClaimNames.Sub,loginResponsDto.User.Username),
                        }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    Issuer = issuer,
                    Audience = audience,
                    SigningCredentials = new SigningCredentials
                    (new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var jwtToken = tokenHandler.WriteToken(token);
                var stringToken = tokenHandler.WriteToken(token);
                loginResponsDto.Token = stringToken;
            }
            return Ok(loginResponsDto);
        }
}
    }
