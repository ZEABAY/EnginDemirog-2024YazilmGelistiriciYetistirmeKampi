using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TypesIntro();

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            // Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            Employee employee = new Employee();

            //Person person3 = customer;


            //Console.WriteLine(person3.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);



            Console.ReadLine();
        }

        private static void TypesIntro()
        {
            //int, decimal, float, enum, boolean -> value types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            Console.WriteLine("Sayi 1 : " + sayi1);

            //array, class, interface ... -> reference types

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayilar1[] : " + sayilar1[0]);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("Eklendi");
        }
    }
}
