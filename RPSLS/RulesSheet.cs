using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RulesSheet
    {
        /*Using the concepts of OOP by creating classes and using objects (instances of thoseclasses) to interact with each other, 
         * create a console version of the classic game Rock Paper Scissors Lizard Spock.
         * User stories:
         * (5 points):  As a developer, I want to make good, consistent commits. 
         * (15 points): As a developer, I want to find a way to properly incorporate inheritance into my game.
         * (5 points): As a developer, I want to account for and handle bad user input, ensuring that any user input is validated and reobtained if necessary.
         * (10 points): As a developer, I want to store all of the gesture options/choices in a List<T>.
         * (10 points): As a player, I want the correct player to win a given round based on the choices* made by each player. 
         * (10 points): As a player, I want the game of RPSLS to be at minimum a ‘best of three’ to decide a winner.
         * (10 points): As a player, I want the option of a single player (human vs AI) or a multiplayer (human vs human) game
         * 
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
         * 
         * List the steps that will be needed to complete the best out of 3 scenario of this game
         * +-First I want the user to choose whether or not to play a single player vs AI or a 2 player game
         * --play in console or window form choice?
         * +--After that choice I can instantiate two Player objects, changing one of their statuses to AI if needed
         * +---If one of the players is AI, choose a random gesture during their turn
         * -I will also create a win/loss counting system to keep track of who has won during the best of 3 series
         * --After every round, reset variables? and add win count to one player
         * 
         * -An object holding all gestures (or new object for each gesture?)
         * -test PlayerOne.gesture against PlayerTwo.gesture
         * 
         * 
         * 
         * List classes you think you will need to include to make this game
         * -Player class
         * -Gesture class (or gestures?)
         */
    }
}
