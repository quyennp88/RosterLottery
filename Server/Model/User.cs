using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RoosterLottery.Server.Model
{
    public class User
    {
        public User() {
            Lotteries = new List<Lottery>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public List<Lottery>? Lotteries { get; set; }
    }
}
