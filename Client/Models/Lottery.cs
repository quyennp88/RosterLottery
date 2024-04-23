
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoosterLottery.Client.Model
{
    public class Lottery
    {
        public Lottery() { }
        public int Id { get; set; }
        public int Hour { get; set; }
        public int LotteryNumber { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public Model.LotteryDate LotteryDate { get; set; }
        public List<User>  Users { get; set; }
    }
}
