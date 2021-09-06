using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Citas
    {
        public Citas()
        {

        }

        public int CitaID { get; set; }
        public int DoctoresID { get; set; }
        public int PacienteID { get; set; }
        public DateTime Finicio { get; set; }
        public DateTime Ffin { get; set; }
        public string Estado { get; set; }
        public string Diagnóstico { get; set; }
        public bool Activo { get; set; }
    }
}
