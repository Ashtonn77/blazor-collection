using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorWASM_JwtAuth.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Server.Controllers
{
 [ApiController]
	public class AuthController : ControllerBase
	{
		private string CreateJWT(User user)
		{
			var secretkey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("THIS IS THE SECRET KEY")); // NOTE: SAME KEY AS USED IN Startup.cs FILE
			var credentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);

			var claims = new[] // NOTE: could also use List<Claim> here
			{
				new Claim(ClaimTypes.Name, user.Email), // NOTE: this will be the "User.Identity.Name" value
				new Claim(JwtRegisteredClaimNames.Sub, user.Email),
				new Claim(JwtRegisteredClaimNames.Email, user.Email),
				new Claim(JwtRegisteredClaimNames.Jti, user.Email) // NOTE: this could a unique ID assigned to the user by a database
			};

			var token = new JwtSecurityToken(issuer: "domain.com", audience: "domain.com", claims: claims, expires: DateTime.Now.AddMinutes(60), signingCredentials: credentials);
			return new JwtSecurityTokenHandler().WriteToken(token);
		}

		private IUserDatabase userdb { get; }

		public AuthController(IUserDatabase userdb)
		{
			this.userdb = userdb;
		}

		[HttpPost]
		[Route("api/auth/register")]
		public async Task<LoginResult> Post([FromBody] RegisterModel reg)
		{
			if (reg.Password != reg.ConfirmPassword)
				return new LoginResult { Message = "Password and confirm password do not match.", Success = false };
			User newuser = await userdb.AddUser(reg.Email, reg.Password);
			if (newuser != null)
				return new LoginResult { Message = "Registration successful.", JwtBearer= CreateJWT(newuser), Email = reg.Email, Success = true };
			return new LoginResult { Message = "User already exists.", Success = false };
		}

		[HttpPost]
		[Route("api/auth/login")]
		public async Task<LoginResult> Post([FromBody] LoginModel log)
		{
			User user = await userdb.AuthenticateUser(log.Email, log.Password);
			if (user != null)
				return new LoginResult { Message = "Login successful.", JwtBearer = CreateJWT(user), Email = log.Email, Success = true };
			return new LoginResult { Message = "User/password not found.", Success = false };
		}
	}
}