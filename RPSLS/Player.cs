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
        public List<string> GestureList;
        public string GestureChoice;
        public double WinCount;
        public Random random;
        public InputValidation Validate;

        //Constructor
        public Player()
        {
            WinCount = 0;
            Validate = new InputValidation();
            random = new Random();
            GestureList = new List<string>() { "rock", "paper", "scissors", "spock", "lizard" };



    }
        //Can do this

        public void ThisPlayerWon()
        {
            WinCount++;
        }

        public void NoPlayerWon()
        {
            Console.WriteLine("Lul noobs");
        }

        public virtual string ChooseYourGesture()
        {
            return "";
        }

    }
}
