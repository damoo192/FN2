using Microsoft.AspNetCore.Mvc;
using Pro1.Data;
using Pro1.Models;
using Pro1.MyFolder;
using System.Diagnostics;

namespace Pro1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly SimpleDbgegoraphyContext _context;


		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			homeindexviewmodel model = new homeindexviewmodel(
			VisitorCount: Random.Shared.Next(1, 100),
			Categories: _context.Categories.ToList(),
			Products: _context.Products.ToList()
			);
			return View(model);

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