using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoosterLottery.Server.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<LotteryDate> LotteryDates { get; set; }
        public DbSet<Lottery> Lotteries { get; set; }
        public DbSet<UserLottery>  UsersLotteries { get; set; }

    }
}
