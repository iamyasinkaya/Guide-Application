using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GuideApp.Web.Models;
using GuideApp.Web.Data;

namespace GuideApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GuideAppContext _context;

        public HomeController(ILogger<HomeController> logger, GuideAppContext context)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.ContactInformation.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
