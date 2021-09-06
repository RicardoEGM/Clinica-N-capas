using Logic.Interfaz;
using Logic.Interfaz.IServices;
using Logic.Models;
using System;
using System.Collections.Generic;

namespace Logic.Controller
{
    public class ServiceDoctores : IDoctoresServices
    {
        private readonly IDoctores _IDoctor;
        public ServiceDoctores(IDoctores IDoctor)
        {
            this._IDoctor = IDoctor;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Doctores> List()
        {
            return _IDoctor.Get();
        }
    }
}
