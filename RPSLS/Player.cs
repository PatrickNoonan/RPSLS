using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //Does have
        bool IsAI;
        double WinCount;

        //Constructor
        public Player()
        {
            IsAI = false;
            WinCount = 0;

        }
        //Can do this
        public void MakePlayerAI()
        {
            IsAI = true;
        }

        public void ThisPlayerWon()
        {
            WinCount++;
        }

    }
}
