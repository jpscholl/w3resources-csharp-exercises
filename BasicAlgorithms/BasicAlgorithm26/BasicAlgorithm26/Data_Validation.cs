using System;
using System.Linq;

namespace Data_Validation
{
    public static class Data_Validation
    {
        //check for valid integer with tryparse
        public static int validPosNum(string input)
        {
            int userNumber;
            int x = Convert.ToInt32(input);
            
            do
            {
                Console.WriteLine("Not a valid number, Try again!");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out userNumber) && x >= 0);

            return Convert.ToInt32(input);
        }
        //checks if input is a pure integer
        public static bool checkIntType(string input)
        {
            int number = 0;
            return int.TryParse(input, out number);
        }
        //checks the input for numbers
        public static bool checkStringForDigit(string input)
        {
            return input.Any(char.IsDigit);
        }
        //checks if the input is null/empty
        public static bool checkEmptyString(string input)
        {
            return string.IsNullOrEmpty(input);
        }
        //checks for number range
        public static bool checkWithinRange(int inputNum)
        {
            string input = Convert.ToString(inputNum);
            if (checkIntType(input) == true)
            {
                return inputNum >= 1 && inputNum <= 10;
            }
            else
            {
                return false;
            }
        }
        //validation that forces user to input characters
        public static string preventNullString(string input)
        {
            if (input.All(Char.IsWhiteSpace))
            {
                do
                {
                    Console.WriteLine("String cannot be empty, try again");
                    var str = Console.ReadLine();
                    input = str;
                }
                while (input.All(Char.IsWhiteSpace));
            }
            return input;
        }
        //prevents negative integer
        public static int preventNegativeInt(int input)
        {
            while (input < 0)
            {
                Console.WriteLine("Number must be greater than 0");
                input = Convert.ToInt32(Console.ReadLine());
            }
            return input;
        }
        }
    }

