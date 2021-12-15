using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSON_Serialization
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
            public double salary
            {
                get;
                set;
            }
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.id = 1;
            emp.name = "Daniel";
            emp.salary = 55000;
            string jsondata = JsonConvert.SerializeObject(emp);
            Console.WriteLine(jsondata);
        }
    }
}
