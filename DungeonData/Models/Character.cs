using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonData.Models
{
    
    
    public enum Status
    {
        Healthy,
        Blinded,
        Charmed,
        Deafened,
        Frightened,
        Grappled,
        Incapacitated,
        Invisible,
        Paralyzed,
        Petrified,
        Poisoned,
        Prone,
        Restrained,
        Stunned,
        Unconscious
    }

    /// <summary>
    /// 
    /// </summary>
    public enum Alignment
    {
        CEvil,
        CNeutral,
        CGood,
        TEvil,
        TNeutral,
        TGood,
        LEvil,
        LNeutral,
        LGood
    }
    /// <summary>
    /// 
    /// </summary>
    public class Character
    {
        public int CharacterID { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Exhaustion { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Speed { get; set; }
    }
}
