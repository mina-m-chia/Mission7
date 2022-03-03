using System;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;

namespace Mission7.Components
{
    public class ShoppingCartSummaryViewComponent : ViewComponent
    {
        private Basket cart;

        public ShoppingCartSummaryViewComponent(Basket cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }

    }
}
