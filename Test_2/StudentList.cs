using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    public class StudentList
    {
        private List<Student> studentlist = new List<Student>();
        Log log = new Log();
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
            foreach (Student stu in studentlist)
            {
                log.write("Student " + stu.name + " is added");
            }
            return this.studentlist;
        }
         
        public List<Student> GetStudentList()
        {
          return this.studentlist;
        }

        public Student GetStudentByID(int id)
        {
            return this.studentlist.Find(x => x.id == id);
        }

        public void DeleteById(int id)
        {
            Student index = studentlist.Find(x => x.id == id);
            studentlist.Remove(index);
            log.write("Student "+ index.name +" Deleted");
        }

        public Student UpdateElementById(int id, string name, int age, int marks)
        {
            Student update = studentlist.Find(x => x.id == id);
            update.name = name;
            update.age = age;
            update.marks = marks;
            log.write("Student "+ update.name +" Updated");
            return update;
        }
    }
}
