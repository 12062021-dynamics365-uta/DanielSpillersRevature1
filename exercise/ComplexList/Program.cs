using System;
using System.Collections.Generic;

namespace ComplexList
{
    public class employee
    {
        public int id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public double salary
        {
            get;
            set;
        }
    }
        
        

    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee()
            {
                id = 101,
                name = "daniel",
                Gender = "male",
                salary = 55000
            };
            employee emp2 = new employee()
            {
                id = 102,
                name = "anthony",
                Gender = "male",
                salary = 120000
            };
            employee emp3 = new employee()
            {
                id = 103,
                name = "spillers",
                Gender = "male",
                salary = 240000
            };
            employee emp4 = new employee()
            {
                id = 104,
                name = "adriana",
                Gender = "female",
                salary = 480000
            };


            List<employee> em = new List<employee>();
            em.Add(emp);
            em.Add(emp2);


            Console.WriteLine("retrieving the first employee data");
            Console.WriteLine("id={0}, name={1}, gender={2}, Salary={3}", emp.id,emp.name,emp.Gender,emp.salary);
            Console.WriteLine("id={0}, name={1}, gender={2}, Salary={3}", emp2.id, emp2.name, emp2.Gender, emp2.salary);
            em.Add(emp3);
            em.Add(emp4);


            //boolean value that checks if it exists
            Console.WriteLine(em.Contains(emp));


            //OR
            if (em.Contains(emp))
            {
                Console.WriteLine("Emp is available");
            }
            else
            {
                Console.WriteLine("Emp is not available");
            }


            //checking for indidivudal letter in string
            if (em.Exists(x=> x.name.StartsWith("d")))
            {
                Console.WriteLine("It starts with d");
            }
            else
            {
                Console.WriteLine("It does not start with the letter d.");
            }
        }
    }

}