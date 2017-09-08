using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    class Dice
    {
        private int diceValue;
        
        public int ThrowDice() {
            Random rnd = new Random();
            diceValue = rnd.Next(1, 7);
            return diceValue;
        }
        

    }
}
