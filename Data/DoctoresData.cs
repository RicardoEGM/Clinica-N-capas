using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Interfaz;
using Logic.Models;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class DoctoresData : IDoctores
    {
        public readonly IConfiguration _Configuration;
        public DoctoresData(IConfiguration configuration)
        {
            this._Configuration = configuration;
        }

        public bool Add(Doctores entity)
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

        public IEnumerable<Doctores> Get()
        {
            try
            {
                string cnString = _Configuration.GetConnectionString("DbContext");
                List<Doctores> doctores = new List<Doctores>();

                using (SqlConnection cn = new SqlConnection(cnString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SPGetDoctores", cn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            doctores.Add(new Doctores
                            {
                                DoctorID = dr.GetInt32("DoctorID"),
                                Nombre = dr.GetString("Nombre"),
                                Especialidad = dr.GetString("Especialidad"),
                                Activo = dr.GetBoolean("Activo")
                            });
                        }
                    }
                    cn.Close();
                    return doctores;
                }
                return doctores;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Doctores GetbyID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
