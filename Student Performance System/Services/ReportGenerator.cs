using StudentPerformanceSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Services
{
    public class ReportGenerator
    {
        // Creating a Method to generate a console report for a single student
        public void GenerateStudentReport(Student student)
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"STUDENT REPORT: {student.GetName()}");
            Console.WriteLine("====================================");
            Console.WriteLine($"Student Number: {student.GetStudentNumber()}");
            Console.WriteLine($"Age: {student.GetAge()}");
            Console.WriteLine($"Average Mark: {student.GetAverageMark()}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("End of Report");
            Console.WriteLine("====================================");
        }

        // Creating a Method to generate a report for multiple students
        public void GenerateClassReport(List<Student> students)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("CLASS PERFORMANCE REPORT");
            Console.WriteLine("====================================");

            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.GetName()} | " +
                                 $"Student Number: {student.GetStudentNumber()} | " +
                                 $"Average: {student.GetAverageMark()}");
            }

            // To calculate the class average if there are students
            if (students.Count > 0)
            {
                float totalMarks = 0;
                foreach (Student student in students)
                {
                    totalMarks += student.GetAverageMark();
                }
                float classAverage = totalMarks / students.Count;

                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Class Average: {classAverage:F2}");
            }

            Console.WriteLine("====================================");
        }

        
    }
}
