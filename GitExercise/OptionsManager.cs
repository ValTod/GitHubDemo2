using System;

namespace GitExercise
{
    public static class OptionsManager
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
        // Added OptionsList
=======
>>>>>>> 17108263912fec82a1683ffa364715f5f68075b5
>>>>>>> 4b5a739c05f79a7bca7539e741f14503d49696d4
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply"
        };

<<<<<<< HEAD
        public static void Add(double a, double b)    // Added Add method

=======
<<<<<<< HEAD
        public static void Add(double a, double b)      // Added Add method
=======
        public static void Add(double a, double b)
>>>>>>> 17108263912fec82a1683ffa364715f5f68075b5
>>>>>>> 4b5a739c05f79a7bca7539e741f14503d49696d4
        {
            Console.WriteLine($"{a} + {b} = {a + b}");

        }
        public static double Addd(double a, double b)    // Added Add method

        {
            return a + b;
        }

<<<<<<< HEAD
        public static void Multiply(double a, double b)    // Added Multiply method
=======
<<<<<<< HEAD
        public static void Multiply(double a, double b)    // Added Multiply method
=======
        public static void Multiply(double a, double b)
>>>>>>> 17108263912fec82a1683ffa364715f5f68075b5
>>>>>>> 4b5a739c05f79a7bca7539e741f14503d49696d4
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }
        public static double Multiplyy(double a, double b)    // Added Multiply method
        {
           return a * b;
        }

        public static void Subtract(double a, double b)// Added Subtract method

<<<<<<< HEAD
=======
<<<<<<< HEAD
        public static void Subtract(double a, double b) // Added Subtract method
=======
        public static void Subtract(double a, double b)
>>>>>>> 17108263912fec82a1683ffa364715f5f68075b5
>>>>>>> 4b5a739c05f79a7bca7539e741f14503d49696d4
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}
