using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactManagement.Models;

namespace ContactManagement.Manager
{
    interface IContactManager
    {
        List<Contact> GetContacts();
        List<Contact> AddContact(Contact contact);
        List<Contact> DeleteContact(string contactId);
        List<Contact> UpdateContact(Contact contact);
        //Contact GetContact(string id);

    }
    public class ContactManagerFile : IContactManager
    {
        ContactFile cf = new ContactFile();
        public List<Contact> AddContact(Contact contact)
        {
            var ContactList = cf.read();
            ContactList.Add(contact);
            cf.write(ContactList);
            return ContactList;
        }

        public List<Contact> GetContacts()
        {
            var data = cf.read();
            return data;
            /*
            var contacts = from con in contactlist
                           orderby con.id ascending
                           select con;
            return contacts.ToList();*/
        }

        public List<Contact> UpdateContact(Contact contact)
        {
            /*var ContactList = cf.read();
            ContactList.Add(contact);*/
           // cf.write(contact);
            return null;

        }

        public List<Contact> DeleteContact(string contactId)
        {
            var ContactList = cf.read();
            //ContactList.Remove(contact);
            cf.write(ContactList);
            return ContactList;
        }

    }
}