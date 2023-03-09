using BaconBookstore.Models;
using BaconBookstore.Models.ViewModels;
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

        public IActionResult Index(string bookType, int pageNum = 1)
        {
            // page CANNOT be used as a variable name (it's a reserved word)
            int pageSize = 10;

            var bookViewModelContext = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == bookType || bookType == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = (bookType == null 
                    ? repo.Books.Count() 
                    : repo.Books.Where(x => x.Category == bookType).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };


            // Getting books for context and skipping to the current pag

            return View(bookViewModelContext);
        }

        
    }
}
