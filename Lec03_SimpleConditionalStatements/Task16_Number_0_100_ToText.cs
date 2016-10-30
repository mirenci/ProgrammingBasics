using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Task 16
 * 
 */
class Number_0_100_ToText
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= 100 && number >= 0)
        {
            int units = 0;
            int tenths = 0;
            int hundreds = 0;

            string numberWithWords = string.Empty;
            string hundredsWithWords = string.Empty;
            string tenthsWithWords = string.Empty;
            string unitsWithWords = string.Empty;

            hundreds = number / 100;
            tenths = (number % 100) / 10;
            units = (number % 100) % 10;

            if (hundreds == 0 && units == 0 && tenths == 0)
            {
                unitsWithWords = "zero";
            }

            if (hundreds != 0)
            {
                hundredsWithWords = "one hundred";
            }

            if (units > 0 && tenths != 1)
            {
                switch (units)
                {
                    case 1:
                        unitsWithWords = "one";
                        break;
                    case 2:
                        unitsWithWords = "two";
                        break;
                    case 3:
                        unitsWithWords = "three";
                        break;
                    case 4:
                        unitsWithWords = "four";
                        break;
                    case 5:
                        unitsWithWords = "five";
                        break;
                    case 6:
                        unitsWithWords = "six";
                        break;
                    case 7:
                        unitsWithWords = "seven";
                        break;
                    case 8:
                        unitsWithWords = "eight";
                        break;
                    case 9:
                        unitsWithWords = "nine";
                        break;
                }
            }

            if (tenths > 1)
            {
                switch (tenths)
                {
                    case 2:
                        tenthsWithWords = "twenty";
                        break;
                    case 3:
                        tenthsWithWords = "thirty";
                        break;
                    case 4:
                        tenthsWithWords = "fourty";
                        break;
                    case 5:
                        tenthsWithWords = "fifty";
                        break;
                    case 6:
                        tenthsWithWords = "sixty";
                        break;
                    case 7:
                        tenthsWithWords = "seventy";
                        break;
                    case 8:
                        tenthsWithWords = "eighty";
                        break;
                    case 9:
                        tenthsWithWords = "ninety";
                        break;
                }
            }
            else if (tenths == 1)
            {
                switch (units)
                {
                    case 0:
                        tenthsWithWords = "ten";
                        break;
                    case 1:
                        tenthsWithWords = "eleven";
                        break;
                    case 2:
                        tenthsWithWords = "twelve";
                        break;
                    case 3:
                        tenthsWithWords = "thirteen";
                        break;
                    case 4:
                        tenthsWithWords = "fourteen";
                        break;
                    case 5:
                        tenthsWithWords = "fifteen";
                        break;
                    case 6:
                        tenthsWithWords = "sixteen";
                        break;
                    case 7:
                        tenthsWithWords = "seventeen";
                        break;
                    case 8:
                        tenthsWithWords = "eighteen";
                        break;
                    case 9:
                        tenthsWithWords = "nineteen";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(hundredsWithWords))
            {
                numberWithWords += hundredsWithWords;
            }

            if (string.IsNullOrEmpty(tenthsWithWords) == false)
            {
                if (string.IsNullOrEmpty(hundredsWithWords) == false)
                {
                    numberWithWords += " " + tenthsWithWords;
                }
                else
                {
                    numberWithWords += tenthsWithWords;
                }
            }

            if (string.IsNullOrEmpty(unitsWithWords) == false)
            {
                if (string.IsNullOrEmpty(tenthsWithWords) == false)
                {
                    numberWithWords += " " + unitsWithWords;
                }
                else
                {
                    numberWithWords += unitsWithWords;
                }
            }

            Console.WriteLine(numberWithWords);
        }
        else
        {
            Console.WriteLine("invalid number");
        }
    }
}
