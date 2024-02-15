using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolindromNumber
{
    public class CheckPalindrome
    {
        public string Paly(int n)
        {
            string ms = "";
            if (n < 0)
            {
                n = -n;
            }
            if (n == 0)
            {
                ms = "Inavlid Number";
            }
            else
            {
                int temp = n, rev = 0;
                while (n > 0)
                {
                    int r = n % 10;
                    rev = rev * 10 + r;
                    n = n / 10;
                }
                if (rev == temp)
                {
                    ms = "The Number is Palindrome";
                }
                else
                {
                    ms = "The Number is not a palindrome";
                }
            }
            return ms;

        }
    }
}
