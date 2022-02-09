using ContactManagement.Manager;
using ContactManagement.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ContactManagement.Controllers
{

    public class HomeController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44358/");
        HttpClient client;
        public HomeController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        [HttpGet]
        public ActionResult Index()
        {
            /*IContactManager cm = new ContactServer();
            var a = cm.GetContacts();
            //var a = cf.read();
            return View(a);*/

            List<Contact> list = new List<Contact>();
            var result = client.GetAsync("contact-api");
            var a = result.Result.Content.ReadAsStringAsync().Result;
            list = JsonConvert.DeserializeObject<List<Contact>>(a);
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
       // [Route("create")]
        public ActionResult Create(Contact contact)
        {
            //IContactManager cm = new ContactServer();
            //cm.AddContact(contact);
            /*            var ContactList = cf.read();
                        ContactList.Add(contact);
                        cf.write(ContactList);*/

            var data = JsonConvert.SerializeObject(contact);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = client.PostAsync(client.BaseAddress + "contact-api/add", content).Result;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult view(string id)
        {
            /* IContactManager cm = new ContactServer();
             var a = cm.GetContacts();
             var contact = a.Find(x => x.id == id);
             return View(contact);*/

            Contact list = new Contact();
            var result = client.GetAsync("contact-api/" + id);
            var a = result.Result.Content.ReadAsStringAsync().Result;
            list = JsonConvert.DeserializeObject<Contact>(a);
            return View(list);
        }
        public ActionResult Update(string id)
        {
            /* IContactManager cm = new ContactServer();
             var a = cm.GetContacts();
             var updateid = a.Find(x => x.id == id);
             return View(updateid);*/

            Contact list = new Contact();
            var result = client.GetAsync("contact-api/" + id);
            var a = result.Result.Content.ReadAsStringAsync().Result;
            list = JsonConvert.DeserializeObject<Contact>(a);
            return View(list);

        }

        [HttpPost]
        public ActionResult Update(Contact contact)
        {
            /*IContactManager cm = new ContactServer();
            var a = cm.GetContacts();
            Contact updateid = a.Find(x => x.id == contact.id);
            updateid.Name = contact.Name;
            updateid.PhoneNumber = contact.PhoneNumber;
            cm.UpdateContact(updateid);
            return RedirectToAction("Index");*/

            var data = JsonConvert.SerializeObject(contact);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = client.PostAsync("contact-api/update", content).Result;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Contact contact)
        {
            /* IContactManager cm = new ContactServer();
             var a = cm.GetContacts();
             Contact delete = a.Find(x => x.id == id);
             cm.DeleteContact(delete.id);
             return RedirectToAction("Index");*/

            var response = client.DeleteAsync("contact-api/delete/" + contact.id).Result;
            return RedirectToAction("Index");
        }

    }
}