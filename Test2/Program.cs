using System;
using System.Collections.Generic;

namespace Test2
{
    class Program
    {
       
       public static void Main(string[] args)
        {
            StudentList studentList = new StudentList();
            /* studentList.AddStudent(new Student()
             {
                 id = 1,
                 age = 22,
                 marks = 85,
                 name = "ukash"
             });*/
            studentList.AddStudent();
            studentList.GetStudentList();
            Console.WriteLine(studentList.GetStudentByID(1));
            Console.WriteLine(studentList.UpdateElementById(1,"waran",24,66));
            studentList.DeleteById(1);
            studentList.GetStudentList();




           /* List<Student> MyStudents = new List<Student>();            
            MyStudents.Add(new Student()
            {
                id = 1,
                age = 22,
                marks = 85,
                name = "ukash"
            });

            MyStudents.Add(new Student());
            MyStudents[1].id = 2;
            MyStudents[1].age = 21;
            MyStudents[1].marks = 61;
            MyStudents[1].name = "queen";
            
            foreach (Student stu in MyStudents)
            {
                Console.WriteLine(stu);
            }*/

          /*  //get
            Console.WriteLine("Enter id to get values");
            int Get_value =Convert.ToInt32(Console.ReadLine());
            Student get = MyStudents.Find(x => x.id == Get_value);
            Console.WriteLine(get.Get());

            //update
            Console.WriteLine("Enter id to update values");
            int upd_value = Convert.ToInt32(Console.ReadLine());
            Student upd = MyStudents.Find(x => x.id == upd_value);
            upd.name
            foreach (Student stu in MyStudents)
            {
                Console.WriteLine(stu);
            }

            //del
            Console.WriteLine("Enter id to delete");
            int del_value = Convert.ToInt32(Console.ReadLine());
            Student del = MyStudents.Find(x => x.id == del_value);
            MyStudents.Remove(del);
            foreach (Student stu in MyStudents)
            {
                Console.WriteLine(stu);
            }*/
        }

    }
    
}
