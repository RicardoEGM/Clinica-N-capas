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
    public class CitaData : ICitas
    {
        public readonly IConfiguration _Configuration;
        public CitaData(IConfiguration configuration)
        {
            this._Configuration = configuration;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Citas> Get()
        {
            try
            {
                string cnString = _Configuration.GetConnectionString("DbContext");
                List<Citas> citas = new List<Citas>();

                using (SqlConnection cn = new SqlConnection(cnString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SPCitasGet", cn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            citas.Add(new Citas
                            {
                                CitaID = dr.GetInt32("CitaID"),
                                DoctoresID = dr.GetInt32("DoctoresID"),
                                PacienteID = dr.GetInt32("PacienteID"),
                                Estado = dr.GetString("Estado"),
                                Ffin = dr.GetDateTime("Ffin"),
                                Finicio = dr.GetDateTime("Finicio"),
                                Diagnóstico = dr.GetString("Diagnóstico"),
                                Activo = dr.GetBoolean("Activo")
                            });
                        }
                    }
                    cn.Close();
                    return citas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Add(Citas citas)
        {

            try
            {
                string cnString = _Configuration.GetConnectionString("DbContext");

                using (SqlConnection cn = new SqlConnection(cnString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand($"SPCitaAdd", cn);
                    cmd.Parameters.Add(new SqlParameter("@doctoresID", citas.DoctoresID));
                    cmd.Parameters.Add(new SqlParameter("@pacienteID", citas.PacienteID));
                    cmd.Parameters.Add(new SqlParameter("@finicio", citas.Finicio));
                    cmd.Parameters.Add(new SqlParameter("@ffin", citas.Ffin));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    cn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Citas GetbyID(int ID)
        {
            try
            {
                string cnString = _Configuration.GetConnectionString("DbContext");
                Citas citas = new Citas();

                using (SqlConnection cn = new SqlConnection(cnString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SPCitaGetBy", cn);
                    cmd.Parameters.Add(new SqlParameter("@citaID", ID));
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            citas = new Citas
                            {
                                CitaID = dr.GetInt32("CitaID"),
                                DoctoresID = dr.GetInt32("DoctoresID"),
                                PacienteID = dr.GetInt32("PacienteID"),
                                Estado = dr.GetString("Estado"),
                                Ffin = dr.GetDateTime("Ffin"),
                                Finicio = dr.GetDateTime("Finicio"),
                                Diagnóstico = dr.GetString("Diagnóstico"),
                                Activo = dr.GetBoolean("Activo")
                            };
                        }
                    }
                    cn.Close();
                    return citas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AddDiagnóstico(int CitaId, string diagnóstico)
        {
            try
            {
                string cnString = _Configuration.GetConnectionString("DbContext");

                using (SqlConnection cn = new SqlConnection(cnString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand($"SPCitaAddDiagnóstico", cn);
                    cmd.Parameters.Add(new SqlParameter("@IdCita", CitaId));
                    cmd.Parameters.Add(new SqlParameter("@diagnóstico", diagnóstico));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    cn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
