using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;
using System.Collections;
using BIZ.DTOs;
using BIZ.GestionPlanes;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DetPEDAO
    {
        public List<DTODetallesCorrPlan> TraerTodo(DTODetallesCorrPlan unPE)
        {
            List<DTODetallesCorrPlan> resultado = new List<DTODetallesCorrPlan>();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("IdPlanDeEstudio", unPE.IdPlanDeEstudio));
                //resultado = unaConexion.EjecutarTupla<DetallesPlanDeEstudio>("SELECT MateriaConCorrelativas.Nombre, MateriaConCorrelativas.IdMateriaCC FROM MateriaConCorrelativas INNER JOIN DetallesPlanDeEstudio on DetallesPlanDeEstudio.IdMateriaCC = MateriaConCorrelativas.IdMateriaCC AND DetallesPlanDeEstudio.IdPlanDeEstudio = (@IdPlanDeEstudio)", listaParametrosCD);
                resultado = unaConexion.EjecutarTupla<DTODetallesCorrPlan>("SELECT MCC.Nombre, MCC.IdMateriaCC, IdPlanDetalles FROM MateriaConCorrelativas as MCC INNER JOIN DetallesPlanDeEstudio as DPE ON DPE.IdMateriaCC = MCC.IdMateriaCC INNER JOIN PlanDeEstudio as PE ON PE.IdPlanDeEstudio = DPE.IdPlanDeEstudio WHERE PE.IdPlanDeEstudio = (@IdPlanDeEstudio)", listaParametrosCD);
            }
            catch (Exception ex)
            {
                //MsgBox("error al traer correlativas");
                MessageBox.Show("error al traer Detalles PE", ex.ToString());
                //return null;
                //throw;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado;
        }
       
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = ".\\SQLEXPRESS";
            cs.InitialCatalog = "SIUNCA";
            return cs.ConnectionString;
        }

        public List<DetallesPlan> TraerTodoBien(PlanDeEstudio unPE)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "SIUNCA";
            cs.DataSource = ".\\SQLEXPRESS";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = @"SELECT IdPlanDetalles, IdPlanDeEstudio, det.IdMateria, NumeroMateria, Año, mat.Nombre 
                                    FROM DetallesPlanDeEstudio as det inner join Materia as mat on det.IdMateria = mat.IdMateria WHERE det.IdPlanDeEstudio = @IdPlanDeEstudio";
                cmd.Parameters.AddWithValue("IdPlanDeEstudio", unPE.IdPlanDeEstudio);

                reader = cmd.ExecuteReader();

                var listaDetalles = new List<DetallesPlan>();
                while (reader.Read())
                {
                    var unDetalle = new DetallesPlan();
                    //unaTraduccion.IdPalabra_Traduccion = Int32.Parse(reader["username"].ToString());
                    //unDetalle.IdDetallePlan = Int32.Parse(reader["IdPlanDetalles"].ToString());
                    //unDetalle.Materia.IdMateria = Int32.Parse(reader["IdMateria"].ToString());
                    //unDetalle.NumeroMateria = Int32.Parse(reader["NumeroMateria"].ToString());
                    //unDetalle.Año = Int32.Parse(reader["Año"].ToString());
                    //listaDetalles.Add(unDetalle);


                    var IdPlanDetalles = reader.GetInt32(reader.GetOrdinal("IdPlanDetalles"));
                    var IdPlanDeEstudio = reader.GetInt32(reader.GetOrdinal("IdPlanDeEstudio"));
                    var IdMateria = reader.GetInt32(reader.GetOrdinal("IdMateria"));
                    var Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    var NumeroMateria = reader.GetInt32(reader.GetOrdinal("NumeroMateria"));
                    var Año = reader.GetInt32(reader.GetOrdinal("Año"));

                    DetallesPlan c = new DetallesPlan();
                    Materia m = new Materia();


                    c.IdDetallePlan = IdPlanDetalles;
                    c.IdPlanDeEstudio = IdPlanDeEstudio;
                    m.IdMateria = IdMateria;
                    m.Nombre = Nombre;
                    c.Año = Año;
                    c.NumeroMateria = NumeroMateria;

                    c.Materia = m;

                    listaDetalles.Add(c);

                }
                return listaDetalles;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                sql.Close();
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();
            }
        }

    }
}
