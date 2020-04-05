using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CmsShoppingCart.Infrastructure;
using CmsShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CmsShoppingCart.Controllers
{
    public class PagesController : Controller
    {
        private readonly CmsShoppingCartContext _context;

        public PagesController(CmsShoppingCartContext context)
        {
            _context = context;
        }
        // GET / or /slug
        public async Task<IActionResult> Page(string slug)
        {
            var home = "home";
            if (slug == null)
                return View(await _context.Pages.Where(x => x.Slug == home).FirstOrDefaultAsync());

            Page page = await _context.Pages.Where(x => x.Slug == slug).FirstOrDefaultAsync();

            if (page == null)
                return NotFound();
            return View(page);
        }
    }
}