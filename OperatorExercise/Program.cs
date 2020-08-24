using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b; // % = modulus (the remainder after division) // 

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}"); // $ = string interpolation //

            //Allow user to input the radius
            Console.WriteLine("What is the radius of your circle? Do not include units of measure, only whole numbers, please.");

            double realRadius;
            var radius = double.TryParse(Console.ReadLine(), out realRadius);

            //Calculate area of the circle
            var areaOfCircle = CalculateArea(realRadius);

            Console.WriteLine($"The area of a circle with radius of {realRadius} is {areaOfCircle}");

        }

        public static double CalculateArea(double r) // r = radius, changin r to radius will yield the same result
        {
            return Math.PI * (r * r); // Math. is a class //
        }
    }
}
