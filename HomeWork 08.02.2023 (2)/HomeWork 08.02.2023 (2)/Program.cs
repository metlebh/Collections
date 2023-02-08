using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_08._02._2023__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student
            {
                Name = "Metleb",
                Surname = "Huseynov",
                PIN = 12345
            };
            AddStudents(students, student1);

            Student student2 = new Student
            {
                Name = "Omer",
                Surname = "Imanli",
                PIN = 12347
            };
            AddStudents(students, student2);

            foreach (var NewList in students)  
            {
                Console.WriteLine(NewList.GetDetails());
            }









        }
        public static void AddStudents(List<Student> students, Student student)
        {
            var studentDublicate = students.Any(s => s.PIN == student.PIN);

            if (!studentDublicate)
            {
                students.Add(student);
            }
        }
    }
}


