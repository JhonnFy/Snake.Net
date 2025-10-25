using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private readonly string cadenaConexion;

        public Conexion()
        {
            try
            {
                var cs = ConfigurationManager.ConnectionStrings["CadenaSQL"];
                if (cs == null || string.IsNullOrEmpty(cs.ConnectionString))
                    throw new Exception("No se encontró la cadena de conexión 'CadenaSQL' o está vacía.");

                cadenaConexion = cs.ConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al inicializar la conexión: " + ex.Message);
            }
        }

        // Devuelve el estado y mensaje
        public (bool estado, string mensaje) ProbarConexion()
        {
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    return (true, "Conexión exitosa a la base de datos.");
                }
            }
            catch (SqlException ex)
            {
                return (false, $"Error SQL {ex.Number}: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error general: {ex.Message}");
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
