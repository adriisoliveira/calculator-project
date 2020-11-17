using System;

namespace Calculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Write the first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the operation:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the second number:");
            char operation = Console.ReadLine()[1];

            float results;

            switch (operation)
            {
                case '+':
                    results = x + y;
                    break;

                case '-':
                    results = x - y;
                    break;

                case '*':
                    results = x * y;
                    break;

                case '/' :
                    results = x / y;
                    break;
            }

            Console.WriteLine("O resultado é:", );

        }
    }
}
