using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AIPlayer : Player
    {
        //Does have
        //bool PotentialToTakeOverHumanity = true;

        //could just use array

        //Constructor
        public AIPlayer()
        {
            GestureChoice = "Not yet chosen";
        }
        //Can do this
        public override string ChooseYourGesture()
        {
            var random = new Random();
            int index = random.Next(GestureList.Count);
            GestureChoice = GestureList[index];
            Validate.IsItValid(GestureChoice);
            return GestureChoice;

        }
    }
}
