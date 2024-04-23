using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoosterLottery.Server.Model;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LotteryController : ControllerBase
    {
        private AppDbContext _appDbContext { get; set; }
        public LotteryController(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }

        [HttpGet("[action]"), ActionName("GetOpenLottery")]
        public Lottery GetOpenLottery()
        {
            try
            {
                var lottery = _appDbContext.Lotteries.FromSql($"sp_GetOpenLotteryAndCreatedIfNotExisted").ToList();

                return lottery.FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpGet("[action]"), ActionName("GetHistoryLotteries")]
        public List<UserLottery> GetHistoryLotteries(int userID)
        {
            try
            {
               var userLottery = _appDbContext.UsersLotteries.Where(ul => ul.UserId == userID)
                    .Include(i => i.Lottery).ThenInclude(y => y.LotteryDate).ToList();
               
                return userLottery;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost("[action]"), ActionName("SubmitLottery")]
        public bool SubmitLottery(UserLottery userLottery)
        {
            try
            {
                var exist = _appDbContext.UsersLotteries.Where(u => u.UserId == userLottery.UserId && u.LotteryId == userLottery.LotteryId);
                if (exist.Count() == 0)
                {
                    _appDbContext.UsersLotteries.Add(userLottery);
                    _appDbContext.SaveChanges();
                    return true;
                }
                return false;
                
            }
            catch
            {
                return false;
            }
            
        }
    }
}
