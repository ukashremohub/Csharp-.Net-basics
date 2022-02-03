using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using ContactManagement.Models;
using Newtonsoft.Json;

namespace ContactManagement.Manager
{
    public class ContactFile
    {
        string path = @"C:\Users\uwaran\Desktop\Test\ContactData.txt";
        public void write(List<Contact> contacts)
        {
            //string path = @"C:\Users\uwaran\Desktop\Test\ContactData.txt";
            if (!File.Exists(path))
                File.Create(path).Close();
            /* using (StreamWriter sw = File.AppendText(path) )
             {
                 sw.WriteLine(message);
             }*/
            var content = JsonConvert.SerializeObject(contacts);
            File.WriteAllText(path, content);
        }

        public List<Contact> read()
        {
            //if (File.Exists(path))

            var ContactData = JsonConvert.DeserializeObject<List<Contact>>(File.ReadAllText(path));
            if (ContactData == null)
            {
                return new List<Contact>();
            }
            return ContactData;

        }
    }
}