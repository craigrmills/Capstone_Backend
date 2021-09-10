using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BattleSmithAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
