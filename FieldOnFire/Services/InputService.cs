using System;
using System.Collections.Generic;
using System.Linq;

namespace FieldOnFire.Services
{
    public static class InputService
    {
        private static int FieldWidth { get; set; }

        private static int FieldHeight { get; set; }

        public static int GetUserWidthInput()
        {
            while (FieldWidth <= 0)
            {
                try
                {
                    Console.Write("Width(X): ");
                    int userInput = int.Parse(Console.ReadLine());

                    if (ValidateInput(userInput))
                    {
                        FieldWidth = userInput;
                    }
                }
                catch (Exception ex)
                {
                    // ex can be logged in logs
                    Console.WriteLine("Invalid input! Please enter a number." + Environment.NewLine);
                }
            }

            return FieldWidth;
        }

        public static int GetUserHeightInput()
        {
            while (FieldHeight <= 0)
            {
                try
                {
                    Console.Write("Height(Y): ");
                    int userInput = int.Parse(Console.ReadLine());

                    if (ValidateInput(userInput))
                    {
                        FieldHeight = userInput;
                    }
                }
                catch (Exception ex)
                {
                    // ex can be logged in logs
                    Console.WriteLine("Invalid input! Please enter a number." + Environment.NewLine);
                }
            }

            return FieldHeight;
        }

        public static List<int> GetFireLocation()
        {
            bool inputEntered = false;
            List<int> userInput = new List<int>();

            while (inputEntered == false)
            {
                try
                {
                    userInput = Console.ReadLine()
                                .Split(',')
                                .Select(e => int.Parse(e))
                                .ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input!" + Environment.NewLine);
                }
            }

            return userInput;
        }

        private static bool ValidateInput(int number)
        {
            if (number <= 0)
            {
                Console.WriteLine("The size must be a number bigger than 0." + Environment.NewLine);

                return false;
            }

            return true;
        }
    }
}
