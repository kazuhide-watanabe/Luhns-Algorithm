using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhns_Algorithm
{
    internal class Validate_Card_Number
    {
        public static bool IsCardNumberValid(string cardNumber)
        {
            int i, checkSum = 0;

            for (i = cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (cardNumber[i] - '0');

            for (i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            return ((checkSum % 10) == 0);
        }
    }
}
