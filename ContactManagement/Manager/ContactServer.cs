using ContactManagement.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagement.Manager
{
    public class ContactServer : IContactManager
    {
        public List<Contact> AddContact(Contact contact)
        {
            using (var context = new ContactManagementEntities())
            {
                var contacts = JsonConvert.DeserializeObject<contact>(JsonConvert.SerializeObject(contact));
                context.contacts.Add(contacts);
                context.SaveChanges();
                return JsonConvert.DeserializeObject<List<Contact>>(JsonConvert.SerializeObject(context.contacts));
            }

        }

        public List<Contact> GetContacts()
        {
            using (var context = new ContactManagementEntities())
            {
                var contacts = from ss in context.contacts
                               orderby ss.Id
                               select ss;
                return JsonConvert.DeserializeObject<List<Contact>>(JsonConvert.SerializeObject(contacts));
            }

        }

        public List<Contact> UpdateContact(Contact contact)
        {
            using (var context = new ContactManagementEntities())
            {
                var contacts = context.contacts.Where(a => a.Id == contact.id).FirstOrDefault();
                contacts.Id = contact.id;
                contacts.Name = contact.Name;
                contacts.PhoneNumber = contact.PhoneNumber;
                context.SaveChanges();
                return JsonConvert.DeserializeObject<List<Contact>>(JsonConvert.SerializeObject(context.contacts));
            }
        }


        public List<Contact> DeleteContact(string contactId)
        {
            using (var context = new ContactManagementEntities())
            {
                context.contacts.RemoveRange(context.contacts.Where(a=>a.Id == contactId));
                context.SaveChanges();
                return JsonConvert.DeserializeObject<List<Contact>>(JsonConvert.SerializeObject(context.contacts));
            }
        }

    }
}