using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    public class NumberLetterCounts
    {
        private string ZeroToNine(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";

                case 1:
                    return "one";

                case 2:
                    return "two";

                case 3:
                    return "three";

                case 4:
                    return "four";

                case 5:
                    return "five";

                case 6:
                    return "six";

                case 7:
                    return "seven";

                case 8:
                    return "eight";

                case 9:
                    return "nine";

                default:
                    return "";
            }
        }

        private string TenToNineteen(int number)
        {
            switch (number)
            {
                case 10:
                    return "ten";

                case 11:
                    return "eleven";

                case 12:
                    return "twelve";

                case 13:
                    return "thirteen";

                case 14:
                    return "fourteen";

                case 15:
                    return "fifteen";

                case 16:
                    return "sixteen";

                case 17:
                    return "seventeen";

                case 18:
                    return "eighteen";

                case 19:
                    return "nineteen";

                default:
                    return "";
            }
        }

        private string MultipleTens(int number)
        {
            switch (number)
            {
                case 20:
                    return "twenty";

                case 30:
                    return "thirty";

                case 40:
                    return "forty";

                case 50:
                    return "fifty";

                case 60:
                    return "sixty";

                case 70:
                    return "seventy";

                case 80:
                    return "eighty";

                case 90:
                    return "ninety";

                default:
                    return "";
            }
        }

        public string ToString(int number)
        {
            if (number < 10)
            {
                return ZeroToNine(number);
            }
            else if (number < 20)
            {
                return TenToNineteen(number);
            }
            else if (number < 100)
            {
                return MultipleTens(number / 10 * 10) + (number % 10 == 0 ? "" : ("-" + ToString(number % 10)));
            }
            else if (number < 1000)
            {
                return ZeroToNine(number / 100) + " hundred" + (number % 100 == 0 ? "" : (" and " + ToString(number % 100)));
            }
            else if (number < 10000)
            {
                return ZeroToNine(number / 1000) + " thousand" + (number % 1000 == 0 ? "" : (" and " + ToString(number % 1000)));
            }

            throw new NotImplementedException();
        }
    }
}
