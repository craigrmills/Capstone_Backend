using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BattleSmithAPI.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [ForeignKey("User")]
        public string Player1 { get; set; }
        public User User1 { get; set; }

        [ForeignKey("User")]
        public string Player2 { get; set; }
        public User User2 { get; set; }

        [ForeignKey("Faction")]
        public string P1Faction { get; set; }
        public Faction Faction1 { get; set; }

        [ForeignKey("Faction")]
        public string P2Faction { get; set; }
        public Faction Faction2 { get; set; }

        public int P1Score { get; set; }
        public int P2Score { get; set; }

        [ForeignKey("Faction")]
        public string Loser { get; set; }
        public Faction FactionL { get; set; }

        [ForeignKey("Faction")]
        public string Winner { get; set; }
        public Faction FactionW { get; set; }
    }
}