using Logic.Models;
using System;
using System.Collections.Generic;

namespace Logic.Interfaz.IServices
{
    public interface ICitasServices : IDisposable
    {
        IEnumerable<Citas> List();
        Citas GetByID(int ID);
        bool Add(Citas cita);
        bool AddDiagnóstico(int IDCita,string diagnóstico);
    }
}
