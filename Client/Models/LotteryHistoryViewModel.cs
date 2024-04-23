using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class LotteryHistoryViewModel
    {
        public int LotteryID { get; set; }
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public int Number { get; set; }
        public string Status { get; set; }

    }
}
