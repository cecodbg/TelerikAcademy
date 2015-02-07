// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

namespace NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            Console.Write("Enter number in range 0...999: ");
            int number = 0;
            bool isCorrect = int.TryParse(Console.ReadLine(), out number);
            while (isCorrect == false)
            {
                Console.Write("{0,-40}", "In correct input! Try again: ");
                isCorrect = int.TryParse(Console.ReadLine(), out number);
            }

            string strUnits = "";
            int units = number % 10;

            switch (units)
            {
                case 0: strUnits = "zero"; break;
                case 1: strUnits = "one"; break;
                case 2: strUnits = "two"; break;
                case 3: strUnits = "three"; break;
                case 4: strUnits = "for"; break;
                case 5: strUnits = "five"; break;
                case 6: strUnits = "six"; break;
                case 7: strUnits = "seven"; break;
                case 8: strUnits = "eight"; break;
                case 9: strUnits = "nine"; break;
                default:
                    break;
            }

            string specialString = "";
            int ten = (number / 10) % 10;

            if (ten == 1 && (units >= 1 && units <= 9))
            {
                switch (units)
                {
                    case 1: specialString = "eleven"; break;
                    case 2: specialString = "twelve"; break;
                    case 3: specialString = "thirteen"; break;
                    case 4: specialString = "forteen"; break;
                    case 5: specialString = "fifteen"; break;
                    case 6: specialString = "sixteen"; break;
                    case 7: specialString = "seventeen"; break;
                    case 8: specialString = "eighteen"; break;
                    case 9: specialString = "nineteen"; break;
                    default: break;
                }
            }

            string strTen = "";

            switch (ten)
            {
                case 1: strTen = "ten"; break;
                case 2: strTen = "twenty"; break;
                case 3: strTen = "thirty"; break;
                case 4: strTen = "forty"; break;
                case 5: strTen = "fifty"; break;
                case 6: strTen = "sixty"; break;
                case 7: strTen = "seventy"; break;
                case 8: strTen = "eighty"; break;
                case 9: strTen = "ninety"; break;
                default: break;
            }

            string strHundred = "";
            int hundred = (number / 100) % 10;

            switch (hundred)
            {
                case 1: strHundred = "one hundred"; break;
                case 2: strHundred = "two hundred"; break;
                case 3: strHundred = "tree hundred"; break;
                case 4: strHundred = "for hundred"; break;
                case 5: strHundred = "five hundred"; break;
                case 6: strHundred = "six hundred"; break;
                case 7: strHundred = "seven hundred"; break;
                case 8: strHundred = "eight hundred"; break;
                case 9: strHundred = "nine hundred"; break;
                default: break;
            }

            if (hundred > 0 && (units >= 1 && units <= 9) && ten == 1)
            {
                Console.WriteLine(strHundred + " " + specialString);
            }           
            else if  (hundred == 0 && (units >= 1 && units <= 9) && ten == 1)
            {
                Console.WriteLine(specialString);
            }
            else if (hundred >= 1 && ten == 0 && units == 0)
            {
                Console.WriteLine(strHundred);
            }
            else if ((hundred > 0 && ten == 0) && units > 1)
            {
                Console.WriteLine(strHundred + " " + "and" + " " + strUnits);
            }
            else if ((hundred >=1 || ten >=1) && units == 0)
            {
                Console.WriteLine(strHundred + " " + strTen);
            }
            else
            {
                Console.WriteLine(strHundred + " " + strTen + " " + strUnits);
            }
        }
    }
}
