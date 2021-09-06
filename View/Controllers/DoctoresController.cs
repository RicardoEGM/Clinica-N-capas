using Logic.Interfaz.IServices;
using Microsoft.AspNetCore.Mvc;

namespace View.Controllers
{
    public class DoctoresController : Controller
    {
        private readonly IDoctoresServices _doctoresServices;
        public DoctoresController(IDoctoresServices doctoresServices)
        {
            this._doctoresServices = doctoresServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetListDoctores()
        {
            var data = _doctoresServices.List();
            return Json(data);
        }
    }
}
