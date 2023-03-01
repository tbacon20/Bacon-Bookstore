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
        /* This is being replaced by the repository method
        private BookstoreContext _context { get; set; }
        public HomeController (BookstoreContext bookStore) =>  _context = bookStore;
        */
        private IBookstoreRepository repo;
        public HomeController(IBookstoreRepository bookstoreRepository) => repo = bookstoreRepository;

        public IActionResult Index()
        {
            // Getting books for context
            var context = repo.Books.ToList();

            return View(context);
        }

        
    }
}
