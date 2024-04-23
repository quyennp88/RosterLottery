using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoosterLottery.Server.Model
{
    public class Lottery
    {
        public Lottery() { 
            Users = new List<User>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Hour { get; set; }
        public int LotteryNumber { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public LotteryDate LotteryDate { get; set; }
        public List<User>?  Users { get; set; }
    }
}
