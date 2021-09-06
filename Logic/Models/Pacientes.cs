using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Pacientes
    {
        public Pacientes()
        {

        }

        public int PacientesID { get; set; }
        public string Nombre { get; set; }
        public DateTime FNacimiento { get; set; }
        public DateTime FCreacion { get; set; }
        public bool Activo { get; set; }
    }
}
