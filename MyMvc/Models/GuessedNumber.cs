using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvc.Models
{
    public class GuessedNumber
    {
        public static string Numbers(int Number, int randomNumber)
        {

            string goodNumber = "Good Jobb";
            string badNumber = "Wrong Number";
            if (randomNumber == Number)
            {
                return goodNumber;
            }
            else
            {
                return badNumber;
            }
        }

    }
}
