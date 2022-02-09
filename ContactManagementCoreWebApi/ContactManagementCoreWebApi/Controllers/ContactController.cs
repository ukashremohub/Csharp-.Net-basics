using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagementCoreWebApi.Manager;
using ContactManagementCoreWebApi.Model;

namespace ContactManagementCoreWebApi.Controllers
{
    [ApiController]
    [Route("contact-api")]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager();

        [HttpGet]
        public List<Contact> GET()
        {
            return cm.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Contact GETELEMENTBYID(string id)
        {
            var a = cm.Get();
            var GetContact = a.Find(x => x.id == id);
            return GetContact;
        }

        [HttpPost]
        [Route("add")]
        public List<Contact> ADD(Contact contact)
        {
            return cm.Add(contact);
        }

        [HttpPost]
        [Route("update")]
        public List<Contact> UPDATE(Contact contact)
        {
            return cm.Update(contact);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public List<Contact> DELETE(string id)
        {
            return cm.Delete(id);
        }



    }
}
