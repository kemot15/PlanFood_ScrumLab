using Microsoft.AspNetCore.Mvc;
using PlanFood.Mvc.Services.Interfaces;

namespace PlanFood.Mvc.Controllers
{
	public class BookController : Controller
	{
		private readonly IBookService _bookService;

		public BookController(IBookService bookService)
		{
			_bookService = bookService;
		}

		public IActionResult Index()
		{
			var books = _bookService.GetAll();
			return View(books);
		}
	}
}