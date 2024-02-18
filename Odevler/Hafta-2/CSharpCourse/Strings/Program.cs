using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length;
            var result2 = sentence.Clone();

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My na");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3);
            var result10 = sentence.Substring(3, 4);
            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            var result13 = sentence.Replace(" ", "-");
            var result14 = sentence.Remove(2);
            var result15 = sentence.Remove(2, 4);


            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city);

            foreach (char c in city)
            {
                Console.WriteLine(c);

            }

            string city2 = "İstanbul";
            //string result = city + city2;
            //string result = String.Format("{0} {1}", city, city2);


            Console.WriteLine(String.Format("{0} {1}", city, city2));
            //Console.WriteLine(result);
        }
    }
}
