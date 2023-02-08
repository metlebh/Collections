using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_08._02._2023__2_
{
    public class StudentList 
    {
        private List<Student> students;

        public StudentList()
        {
            students = new List<Student>();
        }

        public static void AddStudent(List<Student> students, Student student)
        {
            if (students.Find(s => s.PIN == student.PIN) == null)
            {
                students.Add(student);
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
        public int CountAStudent()
        {
            return students.Count(s => s.Name.Contains("a") | s.Name.Contains("A"));
        }

        
    }
}
