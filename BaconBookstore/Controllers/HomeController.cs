using BaconBookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaconBookstore.Controllers
{
    public class HomeController : Controller
    {
        private BookstoreContext _context { get; set; }

        public HomeController (BookstoreContext bookStore) =>  _context = bookStore;

        public IActionResult Index()
        {
            // Getting books for context
            var context = _context.Books.ToList();

            return View(context);
        }

        
    }
}
