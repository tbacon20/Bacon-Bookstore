using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaconBookstore.Models
{
    public class EFBookStoreRepository : IBookstoreRepository
    {
        private BookstoreContext _context { get; set; }
        public EFBookStoreRepository(BookstoreContext bookstoreContext) => _context = bookstoreContext;
        public IQueryable<Book> Books => _context.Books;
    }
}
