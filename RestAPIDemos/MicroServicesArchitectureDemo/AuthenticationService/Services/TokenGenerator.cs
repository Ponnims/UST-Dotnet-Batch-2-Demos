using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace AuthenticationService.Services
{
    public class TokenGenerator : ITokenGenerator
    {
        public string GenerateToken(string email,string role)
        {
            //1. Create a token payload (you can include user information or claims)
            //2. Create the Signing Credentials (using a secret key)
            //3. Generate the token using a JWT library (like System.IdentityModel.Tokens.Jwt)

            var claims = new[] { new Claim(ClaimTypes.Email, email),new Claim(ClaimTypes.Role, role) };
            //var claims= new[] {new Claim("email",email), new Claim("role",role)};

            var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This_Is_A_Secret_Key_For_Token_Generatiion"));
            var credentials= new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer:"Auth",
                audience:"Trainee",
                claims:claims,
                signingCredentials: credentials,
                expires: DateTime.Now.AddMinutes(30)
                );

            var response= new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
               
            };

            return JsonConvert.SerializeObject(response);
        }
    }
}
