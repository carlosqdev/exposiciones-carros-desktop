using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;
using Data;

namespace Logic
{
    public class Comentarios
    {
        public void InsertarMensaje(Comentario mensaje, out string error)
        {
            using (var cn = new SqlConnection(Conection.CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("InsertarMensaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 80).Value = mensaje.Nombre;
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 140).Value = mensaje.Mensaje;
                
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    error = "Comentario enviado correctamente";
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }

            }

        }

        public List<Comentario> ListaDeComentarios(out string error)
        {
            using (var cn = new SqlConnection(Conection.CadenaConexion))
            {
                List<Comentario> mensajes = new List<Comentario>();
                error = "";

                SqlCommand cmd = new SqlCommand("MostrarMensajes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 0;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                    error = "Mensajes obtenidos correctamente.";
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Comentario comentario_db = new Comentario()
                            {
                                Nombre = dr["Nombre"].ToString(),
                                Mensaje = dr["Mensaje"].ToString()
                            };
                            mensajes.Add(comentario_db);
                        }
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
                return mensajes;
            }
        }
    }
}
