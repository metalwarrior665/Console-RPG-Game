using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public  class Dice
    {
        Random sixDice = new Random((int)DateTime.Now.Ticks);
        public int Roll ()
        {
            
            return sixDice.Next(1, 6);
        }
    }
}
