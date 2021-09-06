using Logic.Interfaz;
using Logic.Interfaz.IServices;
using Logic.Models;
using System;
using System.Collections.Generic;

namespace Logic.Services
{
    public class ServicePacientes : IPacientesServices
    {
        private readonly IPacientes _IPacientes;
        public ServicePacientes(IPacientes IPacientes)
        {
            this._IPacientes = IPacientes;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Pacientes> List()
        {

            return _IPacientes.Get();
        }
    }
}
