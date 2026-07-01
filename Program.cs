// A console Application which displays students results
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studfname, studlname, studDepartment, StudProgram, courseOfStudy;
            double midsemester, finalexam,classtest,totalmarks;

            // Prompt the user to enter student details
            Console.WriteLine("Enter Student First Name: ");
            studfname= Console.ReadLine();
            Console.WriteLine("Enter Student Last Name: ");
            studlname= Console.ReadLine();
            Console.WriteLine("Enter student Department");
            studDepartment= Console.ReadLine();
            Console.WriteLine("Enter student Program of study");
            StudProgram= Console.ReadLine();
            Console.WriteLine("Enter student Course of study");
            courseOfStudy= Console.ReadLine();

            //Enter marks for midsemester, final exam, and class test
            Console.WriteLine("Enter student Class Test marks: ");
            classtest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter student Midsemester marks: ");
            midsemester = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter student Final Exam marks: ");
            finalexam = Convert.ToDouble(Console.ReadLine());
          


        }
    }
}
