using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagementCoreWebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagementCoreWebApi.Manager
{
    public class ContactManager
    {
        ContactManagementFile cmf = new ContactManagementFile();
        public List<Contact> Get()
        {
            var ContactManagementList = cmf.read();
            return ContactManagementList;
        }
        public List<Contact> Add(Contact contact)
        {
            var ContactManagementList = cmf.read();
            ContactManagementList.Add(contact);
            cmf.write(ContactManagementList);
            return ContactManagementList;
        }

        public List<Contact> Update(Contact contact)
        {

            var ContactManagementList = cmf.read();
            Contact UpdateContact = ContactManagementList.Find(x => x.id == contact.id);
            UpdateContact.name = contact.name;
            UpdateContact.PhoneNumber = contact.PhoneNumber;
            cmf.write(ContactManagementList);
            return ContactManagementList;
        }

        public List<Contact> Delete(string id)
        {
            var ContactManagementList = cmf.read();
            Contact DeleteContact = ContactManagementList.Find(x => x.id == id);
            ContactManagementList.Remove(DeleteContact);
            cmf.write(ContactManagementList);
            return ContactManagementList;
        }
    }
}
