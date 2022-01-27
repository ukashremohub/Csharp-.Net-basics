using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
   public class Student
    {
        public int id;
        public string name;
        public int age;
        public int marks;

        public override String ToString()
        {
            return id + " " + name + " " + age + " " + marks;
        }

      /* public string Get()
        {
            return id + " " + name + " " + age + " " + marks;
        }*/

        public string update(string name)
        {
            return this.name = name;
        }

    }
}
