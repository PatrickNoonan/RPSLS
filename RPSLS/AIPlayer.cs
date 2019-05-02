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
        }
        //Can do this
        public override string ChooseYourGesture()
        {
            int index = random.Next(GestureList.Count);
            GestureChoice = GestureList[index];
            Validate.IsItValid(GestureChoice);
            return GestureChoice;

        }
    }
}
