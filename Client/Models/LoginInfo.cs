using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoosterLottery.Client.Model
{
    public static class LoginInfo
    {
        public static string Name { get; set; }
        public static string Phone { get; set; }
        public static DateTime? Birthday { get; set; }
        public static User User { get; set; }
        public static Lottery? OpenLottery { get; set; }
        public static Lottery? Betting { get; set; }
    }
}
