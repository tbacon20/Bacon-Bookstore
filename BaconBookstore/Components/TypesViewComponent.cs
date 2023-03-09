using BaconBookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaconBookstore.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }
        public TypesViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["bookType"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }
}
