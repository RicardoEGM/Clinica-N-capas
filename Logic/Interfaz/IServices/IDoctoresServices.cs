using Logic.Models;
using System;
using System.Collections.Generic;

namespace Logic.Interfaz.IServices
{
    public interface IDoctoresServices : IDisposable
    {
        IEnumerable<Doctores> List(); 
    }
}
