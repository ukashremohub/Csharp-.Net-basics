using ContactManagementCoreWebApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ContactManagementCoreWebApi.Manager
{
    public class ContactManagementFile
    {
        string path = @"C:\Users\uwaran\Desktop\.vs\Test\ContactManagementData.txt";
        public void write(List<Contact> contacts)
        {
            if (!File.Exists(path))
                File.Create(path).Close();

            var content = JsonConvert.SerializeObject(contacts);
            File.WriteAllText(path,content);
        }

        public List<Contact> read()
        {
            if (!File.Exists(path))
                File.Create(path).Close();

            var ContactData = JsonConvert.DeserializeObject<List<Contact>>(File.ReadAllText(path));
            if(ContactData == null)
            {
                return new List<Contact>();
            }
            return ContactData;
        }

    }
}
