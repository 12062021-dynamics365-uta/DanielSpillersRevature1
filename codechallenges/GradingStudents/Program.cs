using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++) //For Loop to cycle through the grades
        {
            int studentGrade = grades[i]; //sets the grade into a variable
            if (studentGrade >= 38) //if the students grade is greater than or equal
            {
                var gradeDiff = 5 - (studentGrade % 5); //stores the grades difference into a variable
                if (gradeDiff < 3) //if the grade difference is less than 3
                    grades[i] = studentGrade + gradeDiff; //formula to round each grade up from its indexed position
            }
        }
        return grades; //return the rounded up grade
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //Below code is specific to HackerRank
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

