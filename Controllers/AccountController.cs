using Microsoft.AspNetCore.Mvc;
using MVC_TUTORIAL_5_12_23.Data;
using MVC_TUTORIAL_5_12_23.Models;
using Microsoft.AspNetCore.Http;

namespace MVC_TUTORIAL_5_12_23.Controllers
{
    public class AccountController : Controller
    {
        private DataContext _dataContext;

        public AccountController(DataContext dataContext)
        {
            _dataContext   = dataContext;
        }

        
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Usersession") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("Usersession").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }
            
            return View();
        }

        
        public IActionResult Login()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Login(SignInModel User)
        {
            var myUser = _dataContext.NewUser.Where(x => x.Email == User.Email && x.Password == User.Password).FirstOrDefault();
            if(myUser != null)
            {
                HttpContext.Session.SetString("Usersession", myUser.Email);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.Message = "LOGIN FAILED..";
            }
            return View();
        }

        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            if(ModelState.IsValid)
            {
                _dataContext.NewUser.Add(register);
                _dataContext.SaveChanges();
            }
          
            return RedirectToAction("Login");
        }

    }
}
