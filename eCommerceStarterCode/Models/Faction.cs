using Microsoft.AspNetCore.Identity;

namespace BattleSmithAPI.Models
{
    public class Faction
    {
        public int FactionId { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int WinRate { get; set; }
    }
}