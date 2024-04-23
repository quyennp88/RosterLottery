using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoosterLottery.Server.Model;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private AppDbContext _appDbContext { get; set; }
        public UserController(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }

        [HttpPost("[action]"), ActionName("Register")]
        public Boolean Register(User user)
        {
            try
            {
                _appDbContext.Users.Add(user);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost("[action]"), ActionName("LogIn")]
        public User LogIn(User user)
        {
            try
            {
                var userResult = _appDbContext.Users.Where(u => u.Phone == user.Phone).FirstOrDefault();
                return userResult;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
