using System;

namespace GitExercise
{
    public static class OptionsManager
    {
<<<<<<< HEAD
        // Added OptionsList
=======
>>>>>>> 17108263912fec82a1683ffa364715f5f68075b5
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply"
        };

<<<<<<< HEAD
        public static void Add(double a, double b)      // Added Add method
=======
        public static void Add(double a, double b)
>>>>>>> 17108263912fec82a1683ffa364715f5f68075b5
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

<<<<<<< HEAD
        public static void Multiply(double a, double b)    // Added Multiply method
=======
        public static void Multiply(double a, double b)
>>>>>>> 17108263912fec82a1683ffa364715f5f68075b5
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

<<<<<<< HEAD
        public static void Subtract(double a, double b) // Added Subtract method
=======
        public static void Subtract(double a, double b)
>>>>>>> 17108263912fec82a1683ffa364715f5f68075b5
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}
