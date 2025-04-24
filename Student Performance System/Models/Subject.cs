using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Models
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public float Marks { get; set; }


        public Subject(string subjectName, string subjectCode, float marks) 
        {
            SubjectCode = subjectCode;
            Marks = marks;
            SubjectName = subjectName;
        }
    }
}
