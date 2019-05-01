using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gestures2
    {
        //can have
        List<string> GestureList = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        int d;
        int PlayerOnesNum;
        int PlayerTwosNum;
        //array of gestures because the size is always the same
        //when can you use a list?
        //string CurrentGesture;
        //string OpposingGesture;

        //constructor
        public Gestures2()
        {

        }

        //can do 

        public string CompareGesture(string PlayerOnesChoice, string PlayerTwosChoice)
        {
            PlayerOnesNum = GestureList.IndexOf(PlayerOnesChoice);
            PlayerTwosNum = GestureList.IndexOf(PlayerTwosChoice);

            //Let's assign a number to each move (0, 1, 2, 3, 4).

            //Notice that every move beats two moves:

            //The move previous to it in the cycle(or four cases ahead)
            //The move two cases ahead in the cycle
            //So let d = (5 + a - b) % 5.Then:
            d = (5 + PlayerOnesNum - PlayerTwosNum) % 5;

            if (d == 1 || d == 3)
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! " + PlayerOnesChoice + " beats " + PlayerTwosChoice + ".");
                return "PlayerOne";
            }
            else if (d == 2 || d == 4)
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! " + PlayerTwosChoice + " beats " + PlayerOnesChoice + ".");
                return "PlayerTwo";
            }
            else
            {
                Console.WriteLine("Tie Game, try again?(Yes or No)");
                string YorN = Console.ReadLine();
                if (YorN == "Yes")
                {
                    return "Tie";
                }
                else
                {
                    Console.WriteLine("Ok so get lost then :/");
                    Console.ReadLine();
                    return "";
                }
            }

            //d = 1 or d = 3 => a wins
            //d = 2 or d = 4 => b wins
            //d = 0 => tie


        }

    }
}
