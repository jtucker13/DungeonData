using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonData.Models
{
    public enum SpellLevel
    { 
        Cantrip,
        First,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Eighth,
        Ninth
    }
    public class SpellSlot
    {
        public int SpellSlotsID { get; set; }
        public int CharClassID { get; set; }
        public CharClass CharClass { get; set; }
        public int ClassLevel { get; set; }
        public SpellLevel SpellLevel { get; set; }
        public int Number { get; set; }

    }
}
