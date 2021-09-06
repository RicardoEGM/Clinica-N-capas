using Logic.Interfaz.IServices;
using Logic.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace View.Controllers
{
    public class CitaController : Controller
    {
        private readonly ICitasServices _citasServices;
        public CitaController(ICitasServices citasServices)
        {
            this._citasServices = citasServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetCitas()
        {
            var data = _citasServices.List().ToList();
            return Json(data);
        }
        public JsonResult GetCitasbyID(int ID)
        {
            var data = _citasServices.GetByID(ID);
            return Json(data);
        }

        public JsonResult AddCita(Citas citas)
        {
            var result = _citasServices.Add(citas);

            return Json(result);
        }

        public JsonResult AddDiagnóstico(int ID, string diagnóstico)
        {
            var result = _citasServices.AddDiagnóstico(ID, diagnóstico);

            return Json(result);
        }
    }
}
