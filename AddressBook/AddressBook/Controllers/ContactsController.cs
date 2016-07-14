using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataContext;
using DataContext.Entities;
using AddressBook.Factories;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class ContactsController : Controller
    {
        private AddressBookContext _ctx;
        private ViewModelFactory _factory;
        public ContactsController()
        {
            if(_ctx == null)
            {
                _ctx = new AddressBookContext();
            }
            if(_factory == null)
            {
                _factory = new ViewModelFactory();
            }
        }
        // GET: Contacts
        public ActionResult Index()
        {
            IEnumerable<Contact> query = _ctx.Contacts;
            var results = query.OrderBy(i => i.FirstName).ToList().Select(i => _factory.Create(i));
            if(query.Count() > 0)
            {
                return View(results);
            }

            

            

            return View();
        }

        public ActionResult ViewContact(int id)
        {
            var contact = _ctx.Contacts.Where(i => i.Id == id).SingleOrDefault();
            var result = _factory.Create(contact);
            return View(result);
        }

        public ActionResult CreateContact()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateContact(ContactsViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}