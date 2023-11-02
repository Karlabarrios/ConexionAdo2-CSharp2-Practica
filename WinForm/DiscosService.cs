using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinForm
{
    class DiscosService
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, TE.Descripcion TipoEdicion From DISCOS D, ESTILOS E, ESTILOS TE Where E.Id = D.IdEstilo and TE.Id = D.IdTipoEdicion";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while(lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.TipoEdicion = new Estilo();
                    aux.TipoEdicion.Descripcion = (string)lector["TipoEdicion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}