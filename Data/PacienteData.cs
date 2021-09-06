using Logic.Interfaz;
using Logic.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class PacienteData : IPacientes
    {
        public readonly IConfiguration _Configuration;
        public PacienteData(IConfiguration configuration)
        {
            this._Configuration = configuration;
        }

        public bool Add(Pacientes entity)
        {
            throw new NotImplementedException();
        }

        public bool AddDiagnóstico(int IDCita, string diagnóstico)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Pacientes> Get()
        {
            try
            {
                string cnString = _Configuration.GetConnectionString("DbContext");
                List<Pacientes> pacientes = new List<Pacientes>();

                using (SqlConnection cn = new SqlConnection(cnString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SPPacienteGet", cn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            pacientes.Add(new Pacientes
                            {
                                PacientesID = dr.GetInt32("PacientesID"),
                                Nombre = dr.GetString("Nombre"),
                                FCreacion = dr.GetDateTime("FCreacion"),
                                FNacimiento = dr.GetDateTime("FNacimiento"),
                                Activo = dr.GetBoolean("Activo")
                            });
                        }
                    }
                    cn.Close();
                    return pacientes;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pacientes GetbyID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
