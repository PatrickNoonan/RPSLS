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
        string MatchCount;
        string KeepPlaying;
        InputValidation Validate;
        Player PlayerOne;
        Gestures2 MadeGestures;
        double MatchCountInt;
        double MatchHalf;
        string WhoWon;
        string ChoiceOne;
        string ChoiceTwo;

        //constructor
        public MainMenu()
        {
            Validate = new InputValidation();
            PlayerOne = new HumanPlayer();
            MadeGestures = new Gestures2();

        }

        //does this
        public void EnterMainMenu()
        {
            Console.WriteLine("Hello.  Would you like to play vs an AI, or vs a Human? (AI or Human)");
            string PlayerTwoAIStatus = Console.ReadLine().ToLower();
            Validate.IsItValid(PlayerTwoAIStatus);
            Console.WriteLine("Would you like the match to be a best of 3, 5, or 7?");
            MatchCount = Console.ReadLine().ToLower();

            if (PlayerTwoAIStatus == "human")
            {
                PlayerTwo = new HumanPlayer();
            }
            else if (PlayerTwoAIStatus == "ai")
            {
                PlayerTwo = new AIPlayer();
            }

            StartGame();
        }

        public void StartGame()
        {
            ChoiceOne = PlayerOne.ChooseYourGesture();
            ChoiceTwo = PlayerTwo.ChooseYourGesture();            

            DecideWinner();
        }

        public void DecideWinner()
        {

            WhoWon = MadeGestures.CompareGesture(ChoiceOne, ChoiceTwo);
            CalculateSeriesLeader();
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

            MatchCountInt = int.Parse(MatchCount);
            CheckForGameOver(MatchCountInt);
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
                    StartGame();
                }
                else
                {
                    Console.WriteLine("Then close the console you quitter");
                    Console.ReadLine();
                }
            }
            DisplaySeriesWinner();
        }

        public void DisplaySeriesWinner()
        {          

            Console.WriteLine("The Final Score is PlayerOne: " + PlayerOne.WinCount + " to PlayerTwo: " + PlayerTwo.WinCount + " GG EZ");
            Console.ReadLine();        
            
        }
    }
}
