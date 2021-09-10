using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BattleSmithAPI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Store")]
        public int HomeStore { get; set; }
        public Store Store { get; set; }

        public string Role { get; set; }
    }
}
