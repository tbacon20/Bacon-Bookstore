using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaconBookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaconBookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket cart;
        public CartSummaryViewComponent(Basket cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
