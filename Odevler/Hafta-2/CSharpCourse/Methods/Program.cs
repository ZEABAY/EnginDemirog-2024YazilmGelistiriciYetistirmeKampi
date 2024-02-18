using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();

            //var result = Add2(2, 2);
            //Console.WriteLine(result);

            //Console.WriteLine(Add2(2, 5));


            //Console.WriteLine(Add3(2));
            //Console.WriteLine(Add3(2, 4));

            int a = 2;
            int b = 3;

            Console.WriteLine("a is " + a);
            Console.WriteLine("b is " + b);
            int c = Add4(ref a, b);
            Console.WriteLine("a+b is " + c);

            Console.WriteLine("\nafter Add4");
            Console.WriteLine("a is " + a);
            Console.WriteLine("b is " + b);

            Console.WriteLine(Add6(1, 2, 4, 5, 6, 7));


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add4(ref int number1, int number2)
        {
            var result = number1 + number2;
            number1 = 222;

            return result;
        }
        static int Add5(out int number1, int number2)
        {
            number1 = 22;

            return number1 + number2;
        }


        static int Multiply(int number1, int number2)
        {
            var result = number1 * number2;
            return result;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            var result = number1 * number2 * number3;
            return result;
        }

        static int Add6(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}