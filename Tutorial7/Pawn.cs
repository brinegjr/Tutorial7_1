using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial7
{
    public class Pawn
    {
        public string type = null;
        public bool hasMoved = false;
        public bool captured = false;

        public Pawn(string side)
        {
            type = side;
        }

        public bool isCaptured()
        {
            return this.captured;
        }
    }
}
