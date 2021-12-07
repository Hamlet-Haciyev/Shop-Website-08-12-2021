using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CheckoutController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            VmHome homeRelated = new VmHome
            {
                banner = _appDbContext.Banners.FirstOrDefault(),
                setting = _appDbContext.Settings.FirstOrDefault(),
                Social = _appDbContext.Socials.Include(o => o.Social_Images).ToList()
            };
            return View(homeRelated);
        }
    }
}
