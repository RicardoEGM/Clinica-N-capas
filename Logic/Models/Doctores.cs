using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Doctores
    {
        public int DoctorID { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public bool Activo { get; set; }
    }
}
