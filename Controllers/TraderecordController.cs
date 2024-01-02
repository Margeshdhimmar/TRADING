using Microsoft.AspNetCore.Mvc;
using MVC_TUTORIAL_5_12_23.Data;
using MVC_TUTORIAL_5_12_23.Models;

namespace MVC_TUTORIAL_5_12_23.Controllers
{
    public class TraderecordController : Controller
    {
        private DataContext _dataContext;

        public TraderecordController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //public JsonResult Index()
        //{
        //    IEnumerable<Traderecord> Traderecords = _dataContext.Traderecords;
        //    return Json(Traderecords);
        //}


        public IActionResult Index()
        {
            return View();
        }
        public JsonResult record()
        {
            IEnumerable<Traderecord> Traderecordsss = _dataContext.Traderecords;
            return Json(Traderecordsss);
        }

    }
}
