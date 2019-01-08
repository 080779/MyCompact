using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCompact.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                PersonEntity person = new PersonEntity();
                person.Name = "aa";
                dbc.Persons.Add(person);
                dbc.SaveChanges();
                return View(person.Id);
            }
        }
    }
}