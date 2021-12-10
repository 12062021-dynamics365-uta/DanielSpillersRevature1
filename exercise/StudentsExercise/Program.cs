using System;
using System.Collections.Generic;

namespace StudentsExercise
{
    public class student
    {
        public string name { get; set; }
        public int age { get; set; }
        public int math { get; set; }
        public int science { get; set; }
        public int coding { get; set; }
        public int spanish { get; set; }
        public int theatre { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student()
            {
                name = "daniel",
                age = 15,
                math = 98,
                science = 78,
                coding = 95,
                spanish = 83,
                theatre = 87

            };
            student student2 = new student()
            {
                name = "ady",
                age = 17,
                math = 86,
                science = 87,
                coding = 85,
                spanish = 79,
                theatre = 92

            };
            student student3 = new student()
            {
                name = "hailey",
                age = 18,
                math = 88,
                science = 85,
                coding = 93,
                spanish = 8,
                theatre = 79

            };
            student student4 = new student()
            {
                name = "myles",
                age = 14,
                math = 99,
                science = 99,
                coding = 99,
                spanish = 76,
                theatre = 83

            };
            student student5 = new student()
            {
                name = "justin",
                age = 19,
                math = 78,
                science = 88,
                coding = 63,
                spanish = 80,
                theatre = 80

            };

            List<student> students = new List<student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);

            //students
            Console.WriteLine("Student Data");
            //student 1
            Console.WriteLine("name={0}, age={1}, math={2}, science={3}, coding={4}, spanish={5}, theatre={6}", 
                student1.name, student1.age, student1.math, student1.science, 
                student1.coding, student1.spanish, student1.theatre);
            //student 2
            Console.WriteLine("name={0}, age={1}, math={2}, science={3}, coding={4}, spanish={5}, theatre={6}",
                student2.name, student2.age, student2.math, student2.science,
                student2.coding, student2.spanish, student2.theatre);
            //student 3
            Console.WriteLine("name={0}, age={1}, math={2}, science={3}, coding={4}, spanish={5}, theatre={6}",
                student3.name, student3.age, student3.math, student3.science,
                student3.coding, student3.spanish, student3.theatre);
            //student 4
            Console.WriteLine("name={0}, age={1}, math={2}, science={3}, coding={4}, spanish={5}, theatre={6}",
                student4.name, student4.age, student4.math, student4.science,
                student4.coding, student4.spanish, student4.theatre);
            //student 5
            Console.WriteLine("name={0}, age={1}, math={2}, science={3}, coding={4}, spanish={5}, theatre={6}",
                student5.name, student5.age, student5.math, student5.science,
                student5.coding, student5.spanish, student5.theatre);


            //Boolean value for existing students
            Console.WriteLine(students.Contains(student1));
            Console.WriteLine(students.Contains(student2));
            Console.WriteLine(students.Contains(student3));
            Console.WriteLine(students.Contains(student4));
            Console.WriteLine(students.Contains(student5));


        }
    }
}
