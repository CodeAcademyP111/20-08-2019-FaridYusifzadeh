using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polo_TestSite.DAL;
using Polo_TestSite.ViewModels;

namespace Polo_TestSite.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeModels homeModel = new HomeModels()
            {
                Sliders=_context.Sliders,
                Descriptions=_context.Descriptions,
                Welcomes=_context.Welcomes,
                What_Wes=_context.What_Wes
            };
            return View(homeModel);
        }
    }
}