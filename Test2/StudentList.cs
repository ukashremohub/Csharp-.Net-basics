using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    public class StudentList
    {
        private List<Student> studentlist = new List<Student>();

        /* public List<Student> AddStudent(Student student)
         {
             this.studentlist.Add(student);
             return this.studentlist;
         }*/

        public List<Student> AddStudent()
        {
            this.studentlist.Add(new Student()
            {
                id = 1,
                age = 22,
                marks = 85,
                name = "ukash"
            });
            this.studentlist.Add(new Student()
            {
                id = 2,
                age = 22,
                marks = 61,
                name = "queen"
            });
            return this.studentlist;
        }
        public void GetStudentList()
        {
            foreach (Student stu in studentlist)
            {
                Console.WriteLine(stu);
            }
           // return this.studentlist;
        }

        public Student GetStudentByID(int id)
        {
            return this.studentlist.Find(x => x.id == id);
        }

        public void DeleteById(int id)
        {
            int index = studentlist.FindIndex(x => x.id == id);
            studentlist.RemoveAt(index);
        }

        public Student UpdateElementById(int id, string name, int age, int marks)
        {
            Student delete = studentlist.Find(x => x.id == id);
            delete.name = name;
            delete.age = age;
            delete.marks = marks;
            return delete;
        }
    }
}
