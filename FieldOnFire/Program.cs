using FieldOnFire.Models;
using FieldOnFire.Services;
using System;
using System.Collections.Generic;

namespace FieldOnFire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the field!");
            int fieldWidth = InputService.GetUserWidthInput();
            int fieldHeight = InputService.GetUserHeightInput();
            Field field = new Field(fieldWidth, fieldHeight);

            // example input 1, 1, 1, 4, 1, 6, 2, 1, 2, 4, 2, 6, 4, 1, 4, 5, 5, 2, 5, 5, 6, 5
            Console.WriteLine(Environment.NewLine + "Please enter the coordinates of the fires in an array format separated by a comma.");
            List<int> fireCoordinates = InputService.GetFireLocation();
            field.CatchFire(fireCoordinates);


            Console.WriteLine("Good!");
        }
    }
}
