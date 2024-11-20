using BooksLibrary.Business.Abstract;
using BooksLibrary.WEBUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BooksLibrary.WEBUI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IBooksService _booksService;
		public HomeController(ILogger<HomeController> logger, IBooksService booksService)
		{
			_logger = logger;
			_booksService = booksService;
		}

		public IActionResult Index()
		{
            var values = _booksService.TGetAll();
            return View(values);
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
