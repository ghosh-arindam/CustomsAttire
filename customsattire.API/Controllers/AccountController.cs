using CustomsAttire.API.Models;
using CustomsAttire.Core.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
//using UserLogin = CustomsAttire.Core.Data.Entities.UserLogin;
using CustomsAttire.Core.Data;

namespace CustomsAttire.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings jwtSettings;
        private readonly CustomsAttireContext _context;
        public AccountController(JwtSettings jwtSettings, CustomsAttireContext dataContext)
        {
            this.jwtSettings = jwtSettings;
            _context = dataContext;
        }
        private IEnumerable<Users> logins = new List<Users>() {
            new Users() {
                        UserId = Guid.NewGuid(),
                        Email = "danish.afroze@gmail.com",
                        UserName = "Admin",
                        Password = "Admin",
                },
                new Users() {
                        UserId = Guid.NewGuid(),
                        Email = "storemanager@gmail.com",
                        UserName = "User1",
                        Password = "Admin",
                }
        };

        [HttpPost]
        public IActionResult GetToken(Models.UserLogin userLogins)
        {
            try
            {
                var Token = new UserTokens();
                var Valid = _context.Users.Any(x => x.EmailAddress.Equals(userLogins.EmailAddress));
                if (Valid)
                {
                    var userlist = _context.Users.Where(x => x.EmailAddress.ToLower().Equals(userLogins.EmailAddress.ToLower())).DefaultIfEmpty().ToList();
                    var userloginsList = _context.UserLogins.Where(x => x.EmailAddress.ToLower().Equals(userLogins.EmailAddress.ToLower())).DefaultIfEmpty().ToList();
                    Token = JwtHelpers.JwtHelpers.GenTokenkey(new UserTokens()
                    {
                        EmailId = userlist.Select(x => new { x.EmailAddress }).Select(x => x.EmailAddress).First(),
                        GuidId = Guid.NewGuid(),
                        UserName = userloginsList.Select(x => new { x.UserId }).Select(x => x.UserId).First(),
                        Id = userloginsList.Select(x => new { x.Id }).Select(x => x.Id).First(),
                    }, jwtSettings);
                }
                else
                {
                    return BadRequest("wrong password");
                }
                return Ok(Token);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// Get List of UserAccounts
        /// </summary>
        /// <returns>List Of UserAccounts</returns>
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetList()
        {
            return Ok(logins);
        }
    }
}
