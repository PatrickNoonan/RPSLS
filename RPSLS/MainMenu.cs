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
        Player PlayerOne = new HumanPlayer();
        Player PlayerTwo;
        InputValidation Validate = new InputValidation();
        string MatchCount;

        //constructor
        public MainMenu()
        {

        }

        //does this
        public void EnterMainMenu()
        {
            Console.WriteLine("Hello.  Would you like to play vs an AI, or vs a Human? (AI or Human)");
            string PlayerTwoAIStatus = Console.ReadLine();
            Validate.IsItValid(PlayerTwoAIStatus);
            Console.WriteLine("Would you like the match to be a best of Three, Five, or Seven?");
            string MatchCount = Console.ReadLine();
            Validate.IsItValid(MatchCount);

            if (PlayerTwoAIStatus == "Human")
            {
                PlayerTwo = new HumanPlayer();
            }
            else if (PlayerTwoAIStatus == "AI")
            {
                PlayerTwo = new AIPlayer();
            }
            StartGame();
        }

        public void StartGame()
        {
            string ChoiceOne = PlayerOne.ChooseYourGesture();
            string ChoiceTwo = PlayerTwo.ChooseYourGesture();
            Gestures2 MadeGestures = new Gestures2();

            string WhoWon = MadeGestures.CompareGesture(ChoiceOne, ChoiceTwo);

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
            CheckForGameOver();
        }

        public void CheckForGameOver()
        {
            if (MatchCount == "Three")
            {
                while (PlayerOne.WinCount < 3 && PlayerTwo.WinCount < 3)
                {
                    Console.WriteLine("The win count (Best of 3) is " + PlayerOne.WinCount + " to " + PlayerTwo.WinCount + "... Keep Playing?");
                    string KeepPlaying = Console.ReadLine();
                    Validate.IsItValid(KeepPlaying);
                    if (KeepPlaying == "Yes")
                    {
                        StartGame();
                    }
                    else
                    {
                        Console.WriteLine("The Final Score is PlayerOne: " + PlayerOne.WinCount + " to PlayerTwo: " + PlayerTwo.WinCount + " GG EZ");
                        Console.ReadLine();
                    }
                }
            }
            else if (MatchCount == "Three")
            {
                while (PlayerOne.WinCount < 4 && PlayerTwo.WinCount < 4)
                {
                    Console.WriteLine("The win count (Best of 5) is " + PlayerOne.WinCount + " to " + PlayerTwo.WinCount + "... Keep Playing?");
                    string KeepPlaying = Console.ReadLine();
                    Validate.IsItValid(KeepPlaying);
                    if (KeepPlaying == "Yes")
                    {
                        StartGame();
                    }
                    else
                    {
                        Console.WriteLine("The Final Score is PlayerOne: " + PlayerOne.WinCount + " to PlayerTwo: " + PlayerTwo.WinCount + " GG EZ");
                        Console.ReadLine();
                    }
                }
            }
            else if (MatchCount == "Seven")
            {
                while (PlayerOne.WinCount < 5 && PlayerTwo.WinCount < 5)
                {
                    Console.WriteLine("The win count (Best of 7) is " + PlayerOne.WinCount + " to " + PlayerTwo.WinCount + "... Keep Playing?");
                    string KeepPlaying = Console.ReadLine();
                    Validate.IsItValid(KeepPlaying);
                    if (KeepPlaying == "Yes")
                    {
                        StartGame();
                    }
                    else
                    {
                        Console.WriteLine("The Final Score is PlayerOne: " + PlayerOne.WinCount + " to PlayerTwo: " + PlayerTwo.WinCount + " GG EZ");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
