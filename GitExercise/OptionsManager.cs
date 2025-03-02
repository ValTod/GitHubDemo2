using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        // Added OptionsList
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply"
        };

        public static void Add(double a, double b)      // Added Add method
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)    // Added Multiply method
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b) // Added Subtract method
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}
