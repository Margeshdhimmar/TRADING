using Microsoft.AspNetCore.Mvc;
using MVC_TUTORIAL_5_12_23.Data;
using MVC_TUTORIAL_5_12_23.Models;
using System.Data.SqlClient;

namespace MVC_TUTORIAL_5_12_23.Controllers
{
    public class EmployeeController : Controller
    {
        private DataContext _dataContext;

        public EmployeeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> Employees = _dataContext.Employees;
            return View(Employees);
        }



        //****************   ADD   **********************

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            
            
                _dataContext.Employees.Add(employee);
                _dataContext.SaveChanges();
            
            
            
                Console.WriteLine("Null Value");
            
            return RedirectToAction("Index");
        }

        //****************   Edit   **********************

        public IActionResult Edit()
        {
            IEnumerable<Employee> Employees = _dataContext.Employees;
            return View(Employees);
        }
        [HttpGet]
        public IActionResult Edit(int ID)
        {
            if(ID == null || ID == 0)
            {
                return NotFound();
            }
            var employee = _dataContext.Employees.Find(ID);
            if(employee == null) 
            {
                return NotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _dataContext.Employees.Update(employee);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //******************* Delete ************************

        [HttpGet] 
        public IActionResult Delete(int ID)
        {
            if(ID == null || ID == 0)
            {
                return NotFound();
            }
            var employee = _dataContext.Employees.Find(ID);
            if(employee == null)
            {
                return NotFound();
            }
            _dataContext.Employees.Remove(employee);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
