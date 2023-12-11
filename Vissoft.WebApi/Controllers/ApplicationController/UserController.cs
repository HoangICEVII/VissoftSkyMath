using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Vissoft.Core.DTOs.User;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.ApplicationController
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        public UserController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpPost("LoginViaForm")]
        public async Task<IActionResult> LoginViaForm(UserLoginViaFormDto userLoginDto)
        {
            try
            {
                var userAuthen = await _userService.LoginViaForm(userLoginDto);
                string token = CreateToken(userAuthen);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("LoginViaGoogle")]
        public async Task<IActionResult> LoginViaGoogle(UserLoginViaGoogleDto userLoginViaGoogleDto)
        {
            try
            {
                var user = await _userService.LoginViaGoogle(userLoginViaGoogleDto);
                string token = CreateToken(user);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            try
            {
                await _userService.Register(userRegisterDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private string CreateToken(UserAuthenDto userAuthen)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, userAuthen.UserName),
                new Claim(ClaimTypes.Email, userAuthen.Email),
                new Claim(ClaimTypes.Role, userAuthen.Role),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                    _configuration.GetSection("AppSettings:Issuer").Value,
                    _configuration.GetSection("AppSettings:Audience").Value,
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: cred
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
    }
}
