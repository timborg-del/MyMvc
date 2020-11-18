using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvc.Models
{
    public class FeverCheck
    {

        public static string Fever(int Temp)
        {
           string sick = "You are sick";
            string good = "Happy";
            if (Temp < 37 || (Temp > 37))
            {
                return sick;
            }
            else
            {
                return good;
            }



        }

    }

}
