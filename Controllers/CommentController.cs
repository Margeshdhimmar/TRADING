using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MVC_TUTORIAL_5_12_23.Data;
using MVC_TUTORIAL_5_12_23.Models;

namespace MVC_TUTORIAL_5_12_23.Controllers
{
    public class CommentController : Controller
    {
        private DataContext _dataContext;

        public CommentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Comment> comments = _dataContext.Comments;
            return View(comments);
        }
        //***************** ADD *************************
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            if(ModelState.IsValid)
            {
                _dataContext.Comments.Add(comment);
                _dataContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //*****************  EDIT ************************
        public IActionResult Edit()
        {
            IEnumerable<Comment> comments = _dataContext.Comments;
            return View(comments);
        }
        [HttpGet]
        public IActionResult Edit(int ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var comment = _dataContext.Comments.Find(ID);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }
        [HttpPost]
        public IActionResult Edit(Comment comment)
        {
            _dataContext.Comments.Update(comment);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }

        //****************  Delete ************************

        [HttpGet]
        public IActionResult Delete(int ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var Comment = _dataContext.Comments.Find(ID);
            if (Comment == null)
            {
                return NotFound();
            }
            _dataContext.Comments.Remove(Comment);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
