using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NLog;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BusinessLayer.Service
{
    public class TokenService
    {
        private readonly string _key;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        public TokenService(IConfiguration configuration)
        {
            _key = configuration["Jwt:Key"];
            _issuer = configuration["Jwt:Issuer"];
            _audience = configuration["Jwt:Audience"];
        }

        public string GenerateToken(string email)
        {
            try
            {
                logger.Info("TokenService - Generating token for user.");
                var claims = new[]
                {
                new Claim(JwtRegisteredClaimNames.Sub, email),//adding email to token
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())//adding unique identifier to token
                };
                
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    _issuer,
                    _audience,
                    claims,
                    expires: DateTime.UtcNow.AddHours(1),
                    signingCredentials: creds
                );

                logger.Info("TokenService - Token generated successfully.");
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception e)
            {
                logger.Error(e, "TokenService - Error generating token.");
                throw new Exception(e.Message);
            }
        }
    }
}
