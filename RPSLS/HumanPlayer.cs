using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : Player
    {
        //Does have
        //mostly inherited

        //Constructor
        public HumanPlayer()
        {


        }
        //Can do this
        public override string ChooseYourGesture()
        {
            Console.WriteLine("What gesture would you like to choose(Rock, Paper, Scissors, Lizard, Spock)");
            GestureChoice = Console.ReadLine().ToLower();
            Validate.IsItValid(GestureChoice);
            return GestureChoice;
        }


    }
}
