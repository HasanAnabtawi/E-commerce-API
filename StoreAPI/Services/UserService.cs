using Microsoft.IdentityModel.Tokens;
using StoreAPI.Data;
using StoreAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StoreAPI.Services
{
    //public class UserService : IUserService
    //{

       

    //    private readonly IConfiguration _configuration;
    //    private readonly ApplicationDbContext _db;

    //    public UserService(IConfiguration configuration,ApplicationDbContext db)
    //    {
    //        _configuration = configuration;
    //        _db= db;    
    //    }


    //    public string Login(UserModel user)
    //    {
    //        var LoginUser = _users.SingleOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);

    //        if (LoginUser == null)
    //        {
    //            return

    //                string.Empty;
    //        }

    //        var tokenHandler = new JwtSecurityTokenHandler();
    //        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
    //        var tokenDescriptor = new SecurityTokenDescriptor
    //        {
    //            Subject = new ClaimsIdentity(new Claim[]
    //            {
    //                new Claim(ClaimTypes.Name, user.UserName),
    //            }),
    //            Expires = DateTime.UtcNow.AddMinutes(30),
    //            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
    //        };
    //        var token = tokenHandler.CreateToken(tokenDescriptor);
    //        string userToken = tokenHandler.WriteToken(token);
    //        return userToken;
    //    }
    //}
}

