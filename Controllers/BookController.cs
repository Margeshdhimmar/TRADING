using Microsoft.AspNetCore.Mvc;
using MVC_TUTORIAL_5_12_23.Models;
using MVC_TUTORIAL_5_12_23.Repository;

namespace MVC_TUTORIAL_5_12_23.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Getallbooks() 
        { 
            var data = _bookRepository.Getallbook();
            return View(data);
        }

        public ViewResult Onebook(int id)
        {
            var data = _bookRepository.Getbook(id);
            return View(data);
        }

        public List<Book> Searchbook(string name, string auth)
        {
            return _bookRepository.SearchBook(name, auth);
        }

        public IActionResult AddNewBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewBook(Book book)
        { 
            return View(book);
        }


    }
}
