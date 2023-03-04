using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyGlobal
{
    public class LiczbyPierwsze
    {
        public string Test(string userInput)
        {
            try
            {
                int testresult = Int32.Parse(userInput);
                if (testresult < 0)
                {
                    throw new InvalidOperationException("InvalidArgumentException");
                }
            }
            catch (FormatException)
            {
                throw new InvalidOperationException("InvalidArgumentException");
            }

            int counter = 0;
            int result = Int32.Parse(userInput);

            if (result == 0 || result == 1)
            {
                return "To nie jest liczba pierwsza";
                //String lengths are both 27. Strings differ at index 17.
            }
            for (int i = 1; i <= result; i++)
            {
                if (result % i == 0)
                {
                    counter++;
                }
            }
            if (counter > 2)
            {
                return "To nie jest liczba pierwsza";
            }
            else
            {
                return "To jest liczba pierwsza";
            }
        }
    }
}