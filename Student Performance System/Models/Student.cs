using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Models
{
    public class Student : Person
    {
        private string studentNumber;
        private float averageMark;
        private List<Subject> subjects;

        public Student(string name, int age, string studentNumber, float averageMark) : base(name, age)
        {
            this.studentNumber = studentNumber;
            this.averageMark = averageMark;
            this.subjects = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public string GetStudentNumber() => studentNumber;
        public void SetStudentNumber(string number) => studentNumber = number;


        public float GetAverageMark() => averageMark;
        public void SetAverageMark(float newMark) => averageMark = newMark;

        // Polymorphism: Here we are using one of the two types of Polymorphism in C# =  override base method
        public override void PrintDescription()
        {
            base.PrintDescription(); // calls the Person version
            Console.WriteLine($"Student Number: {studentNumber}, Average Mark: {averageMark}");
        }

    }
}
