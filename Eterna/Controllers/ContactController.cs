using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Contact> contacts = _context.Contacts.ToList();
            return View(contacts);

        }
    }
}
