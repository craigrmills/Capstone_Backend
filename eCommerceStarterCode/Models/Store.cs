using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BattleSmithAPI.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
    }
}
