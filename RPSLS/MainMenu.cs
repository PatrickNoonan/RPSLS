using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class MainMenu
    {
        //has this
        Player PlayerTwo;
        InputValidation Validate;
        Player PlayerOne;
        Gestures2 MadeGestures;
        string MatchCount;
        string KeepPlaying;
        string WhoWon;
        string ChoiceOne;
        string ChoiceTwo;
        double MatchCountInt;
        double MatchHalf;
        double round;

        //constructor
        public MainMenu()
        {
            Validate = new InputValidation();
            PlayerOne = new HumanPlayer();
            MadeGestures = new Gestures2();
            round = 0;

        }
        public void RunGame()
        {
            if (round == 0)
            {
                EnterMainMenu();
            }
            StartGame();
            DecideWinner();
            CalculateSeriesLeader();
            CheckForGameOver(MatchCountInt);
            DisplaySeriesWinner();
        }

        //does this
        public void EnterMainMenu()
        {
            Console.WriteLine("Hello.  Would you like to play vs an AI, or vs a Human? (AI or Human)");
            string PlayerTwoAIStatus = Console.ReadLine().ToLower();
            Validate.IsItValid(PlayerTwoAIStatus);
            Console.WriteLine("Would you like the match to be a best of 3, 5, or 7?");
            MatchCount = Console.ReadLine().ToLower();
            MatchCountInt = int.Parse(MatchCount);

            if (PlayerTwoAIStatus == "human")
            {
                PlayerTwo = new HumanPlayer();
            }
            else if (PlayerTwoAIStatus == "ai")
            {
                PlayerTwo = new AIPlayer();
            }

        }

        public void StartGame()
        {
            ChoiceOne = PlayerOne.ChooseYourGesture();
            ChoiceTwo = PlayerTwo.ChooseYourGesture();            

        }

        public void DecideWinner()
        {
            WhoWon = MadeGestures.CompareGesture(ChoiceOne, ChoiceTwo);            
        }

        public void CalculateSeriesLeader()
        { 

            if (WhoWon == "PlayerOne")
            {
                PlayerOne.ThisPlayerWon();
            }
            else if (WhoWon == "PlayerTwo")
            {
                PlayerTwo.ThisPlayerWon();
            }
            else
            {
                PlayerOne.NoPlayerWon();
            }                       
        }

        public void CheckForGameOver(double Matches)
        {
            MatchHalf = Matches / 2;
            while (PlayerOne.WinCount < MatchHalf && PlayerTwo.WinCount < MatchHalf)
            {
                Console.WriteLine($"The win count (Best of {Matches}) is " + PlayerOne.WinCount + " to " + PlayerTwo.WinCount + "... Keep Playing?");
                KeepPlaying = Console.ReadLine().ToLower();
                Validate.IsItValid(KeepPlaying);
                if (KeepPlaying == "yes")
                {
                    round++;
                    RunGame();
                }
                else
                {
                    Console.WriteLine("Then close the console you quitter");
                    Console.ReadLine();
                }
            }
        }

        public void DisplaySeriesWinner()
        {          

            Console.WriteLine("The Final Score is PlayerOne: " + PlayerOne.WinCount + " to PlayerTwo: " + PlayerTwo.WinCount + " GG EZ");
            Console.ReadLine();        
            
        }
    }
}
