using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

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
                    throw new Exception("[Conexion] No Se Encontró La Cadena De Conexión 'CadenaSQL' o está vacía.");

                cadenaConexion = cs.ConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception("[Conexion] Error Al Inicializar La Conexión: " + ex.Message);
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
                    return (true, "[Conexion] Conexión Exitosa A La Base De Datos.");
                }
            }
            catch (SqlException ex)
            {
                return (false, $"[Conexion] Error SQL {ex.Number}: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"[Conexion] Error general: {ex.Message}");
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
