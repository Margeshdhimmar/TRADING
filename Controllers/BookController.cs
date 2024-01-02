using Microsoft.AspNetCore.Mvc;
using MVC_TUTORIAL_5_12_23.Data;
using MVC_TUTORIAL_5_12_23.Migrations;
using MVC_TUTORIAL_5_12_23.Models;
using MVC_TUTORIAL_5_12_23.Repository;

namespace MVC_TUTORIAL_5_12_23.Controllers
{
    public class BookController : Controller
    {
        private DataContext _dataContext;

        public BookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Book> book = _dataContext.Books;
            return View(book);
        }
        //*********************** Search **************************
        public ViewResult Onebook(int id)
        {
            var data = _dataContext.Books.Find(id);
            return View(data);
        }
        //****************** ADD ***************************

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _dataContext.Books.Add(book);
                _dataContext.SaveChanges();
            }
            else 
            {
                Console.WriteLine("Null Value");
            }
            return RedirectToAction("Index");
        }

        //********************* Remove *****************************

        [HttpGet]
        public IActionResult Delete(int ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var Book = _dataContext.Books.Find(ID);
            if (Book == null)
            {
                return NotFound();
            }
            _dataContext.Books.Remove(Book);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
