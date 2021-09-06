using Logic.Models;
using System;
using System.Collections.Generic;

namespace Logic.Interfaz.IServices
{
    public interface IPacientesServices : IDisposable
    {
        IEnumerable<Pacientes> List();
    }
}
