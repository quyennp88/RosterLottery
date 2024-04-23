using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoosterLottery.Server.Model
{
    public class UserLottery
    {
        public UserLottery() {
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Number { get; set; }
        public int? Status { get; set; }
        public int LotteryId { get; set; }
        public User? User { get; set; }
        public Lottery? Lottery { get; set; }
    }
}
