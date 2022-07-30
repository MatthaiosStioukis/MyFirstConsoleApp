using System;

namespace MyFirstConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            OperatorExamples();
        }

        private static void OperatorExamples()
        {
            // This statement declares the variable width with type int and assigns the value 3.
            int width = 3;
            // The ++ operator increments a variable (adds 1 to it).
            width++;
            // Declared two more varriables to hold numbers
            // and used the + operator to add and the * operator to multiply.
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);
            // The next two statements declare string variables
            // and use + operator to concatenate them (join them together).
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            // A boolean variable is either true or false
            bool truthValue = true;
            Console.WriteLine(truthValue);
        }
    }
}

