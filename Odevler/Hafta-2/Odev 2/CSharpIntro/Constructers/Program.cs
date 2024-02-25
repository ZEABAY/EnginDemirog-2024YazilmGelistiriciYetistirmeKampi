using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" }; //default Constructor
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");


            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);



            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Customer()
        {
            Console.WriteLine("Empty Constructor");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Constructor");

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
    }
}
