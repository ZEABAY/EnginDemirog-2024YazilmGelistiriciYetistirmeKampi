using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int number = 100;

            ////DoWhile(number);
            ////While(number);
            ////ForLoop();

            //string[] students = { "Engin", "Derin", "Salih" };


            ////foreach - readonly 
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}


            Console.WriteLine(IsPrimeNumber(3) ? "This is a prime number" : "This is not a prime number");


            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }

            return result;
        }

        private static void DoWhile(int number)
        {
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void While(int number)
        {
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
