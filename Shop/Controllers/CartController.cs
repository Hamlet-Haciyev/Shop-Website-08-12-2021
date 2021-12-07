using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CartController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            VmHome homeRelated = new VmHome
            {
                banner = _appDbContext.Banners.FirstOrDefault(),
                setting = _appDbContext.Settings.FirstOrDefault(),
            };
            return View(homeRelated);
        }
    }
}
