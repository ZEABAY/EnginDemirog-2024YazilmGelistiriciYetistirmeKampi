using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person
                {
                    FirstName = "Engin"
                },
                new Customer{
                    FirstName = "Derin"

                },
                new Student{
                    FirstName = "Salih"

                }
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
    interface IPerson
    {

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person, IPerson
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
