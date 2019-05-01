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
            GestureChoice = "Not yet chosen";


        }
        //Can do this
        public override string ChooseYourGesture()
        {
            Console.WriteLine("What gesture would you like to choose(Rock,Paper,Scissors,Lizard,Spock)(This will be hidden from the other player)");
            GestureChoice = Console.ReadLine();
            Validate.IsItValid(GestureChoice);
            return GestureChoice;
        }


    }
}
