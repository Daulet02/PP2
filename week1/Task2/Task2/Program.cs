using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;

        public Student()
        {
            name = Console.ReadLine();
            id = Console.ReadLine();
        }
        public Student (string name, string id, int year)
        {
            this.name = name;
            this.id = id;
        }
        public void PrintInfo()
        {
            int year = 0;
            //return name + " " + id + " " + year;
            Console.WriteLine(name + " " + id + " " + (year + 1));
        }
    }
    class Program
    {
        static void Main(string[] args) // i dont know how to do task2
        {
            Student st1 = new Student("Daulet", "18BD110325", 0);
            st1.PrintInfo();
            Console.ReadKey();
        }
    }
}