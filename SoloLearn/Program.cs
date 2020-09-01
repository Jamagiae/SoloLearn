using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
               string yourName;
   Console.WriteLine("What is your name?");

   yourName = Console.ReadLine();
 
   Console.WriteLine("Hello {0}", yourName);
            
            Console.WriteLine("Hello World");
            DataTypes();
        }

        static void DataTypes()
        {
            //VARIABLES
            var name = "Jamagiae";
            var lastname = "Medley";
            var Good_var = "identifier";
            int myAge = 99;
            string firstName = "Bob the builder";
            bool awesome = true;
            char grade = 'f'; // Chars are singles character. requires single quotes, 'A'
            float altitude = 90.265141f; // float requires 'f' at the end
            double bankBalance = -400000000;
            decimal pi = 3.14159265M; // decimal requires an M at the end

            Console.WriteLine($"int = {myAge}.");
            Console.WriteLine($"string = {name}.");
            Console.WriteLine($"bool = {awesome}.");
            Console.WriteLine($"char = {grade}.");
            Console.WriteLine($"float = {altitude}.");
            Console.WriteLine($"double = {bankBalance}.");
            Console.WriteLine($"decimal = {pi}.");

        }
    }
}
