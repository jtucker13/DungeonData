using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonData.Models
{
    public class CharClass
    {
        public int CharClassID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public string Specialization { get; set; }
        public int HitDicePerLevel { get; set; }
        public int HPPerLevel { get; set; }
        
    }
}
