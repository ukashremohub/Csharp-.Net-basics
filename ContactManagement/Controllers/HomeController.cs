using ContactManagement.Manager;
using ContactManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IContactManager cm = new ContactServer();
            var a = cm.GetContacts();
            return View(a);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            IContactManager cm = new ContactServer();
            cm.AddContact(contact);
            return RedirectToAction("Index");
        }

        public ActionResult view(string id)
        {
            IContactManager cm = new ContactServer();
            var a = cm.GetContacts();
            var contact = a.Find(x => x.id == id);
            return View(contact);
        }
        public ActionResult Update(string id)
        {
            IContactManager cm = new ContactServer();
            var a = cm.GetContacts();
            var updateid = a.Find(x => x.id == id);
            return View(updateid);
        }

        [HttpPost]
        public ActionResult Update(Contact contact)
        {
            IContactManager cm = new ContactServer();
            var a = cm.GetContacts();
            Contact updateid = a.Find(x => x.id == contact.id);
            updateid.Name = contact.Name;
            updateid.PhoneNumber = contact.PhoneNumber;
            cm.UpdateContact(updateid);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            IContactManager cm = new ContactServer();
            var a = cm.GetContacts();
            Contact delete = a.Find(x => x.id == id);
            cm.DeleteContact(delete.id);
            return RedirectToAction("Index");
        }

    }
}