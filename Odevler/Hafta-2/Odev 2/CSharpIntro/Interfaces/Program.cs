using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
            ProjectManager projectManager = new ProjectManager();

            //customerManager.Add();
            //customerManager.Update();
            //employeeManager.Add();
            //employeeManager.Update();

            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);


            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");

        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated");

        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }
        public void Update(IPersonManager person)
        {
            person.Update();
        }
    }
}