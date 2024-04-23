using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoosterLottery.Client.Model
{
    public class LotteryDate
    {
        public LotteryDate() {
            Lotteries = new List<Lottery>();
        }
        public int Id {  get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public List<Lottery> Lotteries { get; set; }
    }
}
