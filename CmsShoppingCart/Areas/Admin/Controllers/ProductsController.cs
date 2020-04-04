using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CmsShoppingCart.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CmsShoppingCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private CmsShoppingCartContext _context;
        public ProductsController(CmsShoppingCartContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}