using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test2
{
   public class Log
    {
        public void write(string message )
        {
            string path = @"C:\Users\uwaran\Desktop\Test\StudentData.txt";
            if (!File.Exists(path))
             File.Create(path).Close();
            using (StreamWriter sw = File.AppendText(path))
            {
              sw.WriteLine(message);
            }
            
        }

    }
}
