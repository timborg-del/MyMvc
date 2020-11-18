using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvc.Models
{
    public class GuessedNumber
    {
        static readonly string higher = "To High";
        static readonly string correct = "Good Jobb";
        static readonly string toolow = "To Low";
        public static string Numbers(int Number, int randomNumber)
        {

            //string goodNumber = "Good Jobb";
            //string badNumber = "Wrong Number";
            if (randomNumber < Number)
            {
                return higher;
            }
            else if (randomNumber == Number)
            {
                return correct;
            }
            else 
            {
                return toolow;
            }
       
        }

    }
}
