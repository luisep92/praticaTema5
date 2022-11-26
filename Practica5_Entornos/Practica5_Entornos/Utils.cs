using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5_Entornos
{
    internal class Utils
    {
        public static int CountWords(string text)
        {
            if (text == "")
                return 0;

            int result = 1;
            char prev = char.MinValue;
            foreach (char c in text)
            {
                if(c == ' ' && prev != ' ')
                {
                    result++;
                }
                prev = c;
            }
            return result;
        }
    }
}
