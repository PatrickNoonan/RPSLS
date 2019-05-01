using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RPSLS
{
    class InputValidation
    {
        //has this
        string regex = @"^[a-zA-Z]+$";
        string ValidationRetry;

        //constructor
        public InputValidation()
        {

        }

        //does this
        public void IsItValid(string Input)
        {
            var match = Regex.Match(Input, regex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                Console.WriteLine("Sorry I didn't quite catch that, try again... or else");
                ValidationRetry = Console.ReadLine();
                IsItValid(ValidationRetry);
            }
        }
    }
}
