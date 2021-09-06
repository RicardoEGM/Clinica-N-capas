using Logic.Interfaz;
using Logic.Interfaz.IServices;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class ServiceCitas : ICitasServices
    {
        private readonly ICitas _ICitas;

        public ServiceCitas(ICitas Icitas)
        {
            this._ICitas = Icitas;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Citas> List()
        {
            return _ICitas.Get();
        }

        public bool Add(Citas cita)
        {
            return _ICitas.Add(cita);
        }

        public Citas GetByID(int ID)
        {
            return _ICitas.GetbyID(ID);
        }

        public bool AddDiagnóstico(int IDCita, string diagnóstico)
        {
            return _ICitas.AddDiagnóstico(IDCita, diagnóstico);
        }
    }
}
