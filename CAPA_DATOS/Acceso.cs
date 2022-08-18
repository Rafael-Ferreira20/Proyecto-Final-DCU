using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    internal class Acceso
    {
        private SqlConnection conexion;

        private void AbrirConexion()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-3GF3IGG;Initial Catalog=SISTEMA_CONTROL_AUTOBUSES; integrated security=true");
            conexion.Open();
        }

        private void CerrarConexion()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }

        private SqlCommand CrearComando(string nombre, List<SqlParameter> parametros)
        {
            parametros = new List<SqlParameter>(parametros);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = nombre;
            comando.CommandType = CommandType.StoredProcedure;
            if (parametros.Count > 0)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }
            return comando;
        }

        private SqlCommand CrearComando(string nombre)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = nombre;
            comando.CommandType = CommandType.StoredProcedure;

            return comando;
        }

        public DataTable Leer(string nombre)
        {
            AbrirConexion();

            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = CrearComando(nombre);

            adaptador.Fill(tabla);

            adaptador = null;
            CerrarConexion();

            return tabla;
        }

        public int Escribir(string nombre, List<SqlParameter> parametros)
        {
            int filasAfectadas = 0;
            AbrirConexion();

            SqlCommand comando = CrearComando(nombre, parametros);

            try
            {
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                filasAfectadas = -1;
                
            }

            CerrarConexion();
            return filasAfectadas;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.String;
            return parametro;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Int32;
            return parametro;
        }


    }
}
