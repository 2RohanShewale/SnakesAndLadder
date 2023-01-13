using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadder
{
    internal class Player
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int NumberOfRolls { get; set; }
        public bool Ladder { get; set; }
    }
}
