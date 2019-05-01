using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gestures
    {
        //can have
        List<string> GestureList = new List<string> () {"Rock","Paper","Scissors","Lizard","Spock"};
        //array of gestures because the size is always the same
        //when can you use a list?
        //string CurrentGesture;
        //string OpposingGesture;

        //constructor
        public Gestures()
        {

        }

        //can do 
       
        public string CompareGesture(string PlayerOnesChoice, string PlayerTwosChoice)
        {
            if (PlayerOnesChoice == PlayerTwosChoice)
            {
                Console.WriteLine("Tie Game, try again?(Yes or No)");
                string YorN = Console.ReadLine();
                if ( YorN == "Yes")
                {                    
                    return "Tie";
                }
                else
                {
                    Console.WriteLine("Ok so get lost then :/");
                    Console.ReadLine();
                    return "";
                }
                //restart game
            }
            else if (PlayerOnesChoice == "Scissors" && PlayerTwosChoice == "Paper")
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo!  Scissors cuts paper.");
                Console.ReadLine();

                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Paper" && PlayerTwosChoice == "Rock")
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo!  Paper covers Rock.");
                Console.ReadLine();
                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Rock" && PlayerTwosChoice == "Lizard") 
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! Rock crushes Lizard.");
                Console.ReadLine();
                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Lizard" && PlayerTwosChoice == "Spock") 
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! Lizard poisons Spock.");
                Console.ReadLine();
                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Spock" && PlayerTwosChoice == "Scissors") 
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! Spock smashes Scissors");
                Console.ReadLine();
                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Scissors" && PlayerTwosChoice == "Lizard") 
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! Scissors decapitates Lizard.");
                Console.ReadLine();
                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Lizard" && PlayerTwosChoice == "Paper")
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! Lizard eats Paper.");
                Console.ReadLine();
                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Paper" && PlayerTwosChoice == "Spock")
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! Paper disproves Spock.");
                Console.ReadLine();
                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Spock" && PlayerTwosChoice == "Rock")
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! Spock vaporizes rock.");
                Console.ReadLine();
                return "PlayerOne";
            }
            else if (PlayerOnesChoice == "Rock" && PlayerTwosChoice == "Scissors")
            {
                Console.WriteLine("PlayerOne has beaten PlayerTwo! Rock crushes Scissors.");
                Console.ReadLine();
                return "PlayerOne";
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (PlayerTwosChoice == "Scissors" && PlayerOnesChoice == "Paper")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne!  Scissors cuts paper.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Paper" && PlayerOnesChoice == "Rock")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne!  Paper covers Rock.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Rock" && PlayerOnesChoice == "Lizard")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! Rock crushes Lizard.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Lizard" && PlayerOnesChoice == "Spock")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! Lizard poisons Spock.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Spock" && PlayerOnesChoice == "Scissors")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! Spock smashes Scissors");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Scissors" && PlayerOnesChoice == "Lizard")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! Scissors decapitates Lizard.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Lizard" && PlayerOnesChoice == "Paper")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! Lizard eats Paper.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Paper" && PlayerOnesChoice == "Spock")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! Paper disproves Spock.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Spock" && PlayerOnesChoice == "Rock")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! Spock vaporizes rock.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else if (PlayerTwosChoice == "Rock" && PlayerOnesChoice == "Scissors")
            {
                Console.WriteLine("PlayerTwo has beaten PlayerOne! Rock crushes Scissors.");
                Console.ReadLine();
                return "PlayerTwo";
            }
            else
            {
                Console.WriteLine("Something went wrong lul :/");
                return Console.ReadLine();
            }

        }

    /*
    public string RandomAIGesture()
    {
        GestureList
    }
     * Scissors cuts paper. 
     * Paper covers rock. 
     * Rock crushes lizard. 
     * Lizard poisons Spock. 
     * Spock smashes scissors, 
     * scissors decapitates lizard. 
     * Lizard eats paper, 
     * paper disproves Spock. 
     * Spock vaporizes rock. 
     * And, as it always has, rock crushes scissors.﻿
    */

}
}
