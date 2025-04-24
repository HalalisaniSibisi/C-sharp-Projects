using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Models
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetName() => name;
        public void SetName(string name) => this.name = name;


        public int GetAge() => age;
        public void SetAge(int age) => this.age = age;

        public virtual void PrintDescription()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");

        }
    }
}

