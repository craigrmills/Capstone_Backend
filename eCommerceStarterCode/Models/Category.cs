using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BattleSmithAPI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
