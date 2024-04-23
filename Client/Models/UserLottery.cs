using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoosterLottery.Client.Model
{
    public class UserLottery
    {
        public UserLottery() { }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Number { get; set; }
        public int Status { get; set; }
        public int LotteryId { get; set; }
        public User User { get; set; }
        public Lottery Lottery { get; set; }

    }
}
