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

            //assign a number to each move (0, 1, 2, 3, 4)
            //every move beats two moves:
            //The move previous to it in the cycle(or four cases ahead)
            //The move two cases ahead in the cycle
            //So let d = (5 + a - b) % 5.Then:
            /*
             * For n >= 3 and n odd:
                Let d = (n + a - b) % n. Then:
                If d = 0 => tie
                If d % 2 = 1 => a wins
                If d % 2 = 0 => b wins
                */
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
            
            /*
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
            */

            //d = 1 or d = 3 => a wins
            //d = 2 or d = 4 => b wins
            //d = 0 => tie

            /* 0Rock, 1Paper, 2Scissors, 3Lizard, 4Spock = wrong
             * Rock Paper Scissors Spock Lizard?
             * 
             * Scissors cuts paper. 
             * Paper covers rock. 
             * Rock crushes lizard. 
             * Lizard poisons Spock. 
             * Spock smashes scissors, 
             * scissors decapitates lizard. 
             * Lizard eats paper.
             * paper disproves Spock. 
             * Spock vaporizes rock. 
             * rock crushes scissors.﻿
            */


        }

    }
}
