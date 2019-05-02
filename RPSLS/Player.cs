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
        public List<string> GestureList = new List<string>() { "rock", "paper", "scissors", "spock", "lizard" };
        public string GestureChoice;
        public double WinCount;
        public InputValidation Validate = new InputValidation();
        public Random random = new Random();

        //Constructor
        public Player()
        {
            WinCount = 0;



        }
        //Can do this
        //public virtual string ChooseYourGesture()
        //{

        //}

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
