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
        int d;
        int PlayerOnesNum;
        int PlayerTwosNum;
        List<string> GestureList;
        //array of gestures because the size is always the same
        //when can you use a list?
        //string CurrentGesture;
        //string OpposingGesture;

        //constructor
        public Gestures2()
        {
            GestureList = new List<string>() { "rock", "paper", "scissors", "spock", "lizard" };
        }

        //can do 

        public string CompareGesture(string PlayerOnesChoice, string PlayerTwosChoice)
        {
            PlayerOnesNum = GestureList.IndexOf(PlayerOnesChoice);
            PlayerTwosNum = GestureList.IndexOf(PlayerTwosChoice);
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
                string YorN = Console.ReadLine().ToLower();
                if (YorN == "yes")
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
        }

    }
}
