using StudentPerformanceSystem.Models;
using System;
using System.Collections.Generic;
using StudentPerformanceSystem.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();


            // Creating a student - Our first Student to be added to the list
            Student student1 = new Student("Zama", 25, "12345678", 76.8f);

            //student1.PrintDescription(); To test out one of the key principles of OOP, Polymorphism.

            // Creating subjects using methods we created on our Student Class.
            Subject math = new Subject("Mathematics", "MATH101", 85);
            Subject science = new Subject("Science", "SCI101", 90);

            // Here we are adding subjects to the student - in this case Zama our first student
            student1.AddSubject(math);
            student1.AddSubject(science);
            students.Add(student1);


            //Second Student - Naluthabo
            Student student2 = new Student("Naluthabo", 25, "24988987", 88F);
            Subject programming = new Subject("Programming", "ICT2611", 95);
            Subject database = new Subject("Database Systems", "ICT2613", 77);
            Subject webDev = new Subject("Web Development", "CS404", 91);
            student2.AddSubject(programming);
            student2.AddSubject(database);
            student2.AddSubject(webDev);
            students.Add(student2);


            // Third student - Busani
            Student student3 = new Student("Busani", 29, "ST456789", 79.3f);
            Subject biology = new Subject("Biology", "BIO101", 84);
            Subject chemistry = new Subject("Chemistry", "CHEM201", 78);
            student3.AddSubject(biology);
            student3.AddSubject(chemistry);
            student3.AddSubject(math); 
            students.Add(student3);
            

            // Fourth student - Mphikeleli
            Student student4 = new Student("Mphikeleli", 19, "ST123456", 68.7f);
            Subject history = new Subject("History", "HIST101", 72);
            Subject literature = new Subject("Literature", "LIT202", 85);
            student4.AddSubject(history);
            student4.AddSubject(literature);
            students.Add(student4);

            // The method - ReportGenerator ready to be used to generate the report.
            ReportGenerator reportGenerator = new ReportGenerator();

            // Example to generate a report for a single student, in this Naluthabo[index number 1]
            reportGenerator.GenerateStudentReport(students[1]);

            Console.WriteLine(); 

            // Example to generate reports for all student in the list if any. I commented it out to not get printed out on the console.
            //reportGenerator.GenerateClassReport(students);


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();



        }
    }
}
