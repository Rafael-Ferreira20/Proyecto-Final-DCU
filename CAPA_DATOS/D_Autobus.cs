using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
    public class D_Autobus
    {
        private Acceso acceso = new Acceso();


        public List<E_Autobus> Listar()
        {
            DataTable tabla = acceso.Leer("SP_LISTAR_AUTOBUSES");
            List<E_Autobus> autobus = new List<E_Autobus>();

            foreach (DataRow row in tabla.Rows)
            {
                E_Autobus autobus1 = new E_Autobus()
                {
                    ID = Convert.ToInt32(row["ID"]),
                    MARCA = row["MARCA"].ToString(),
                    MODELO = row["MODELO"].ToString(),
                    PLACA = row["PLACA"].ToString(),
                    COLOR = row["COLOR"].ToString(),
                    AÑO = row["AÑO"].ToString(),
                    DISPONIBLE = Convert.ToBoolean(row["DISPONIBLE"])

                };
                autobus.Add(autobus1);
            }

            return autobus;
        }

        public int Insertar(CAPA_ENTIDAD.E_Autobus autobus)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@MARCA", autobus.MARCA));
            parametros.Add(acceso.CrearParametro("@MODELO", autobus.MODELO));
            parametros.Add(acceso.CrearParametro("@PLACA", autobus.PLACA));
            parametros.Add(acceso.CrearParametro("@COLOR", autobus.COLOR));
            parametros.Add(acceso.CrearParametro("@AÑO", autobus.AÑO));

            return acceso.Escribir("SP_INSERTAR_AUTOBUS", parametros);
        }

        public int Editar(CAPA_ENTIDAD.E_Autobus autobus)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", autobus.ID));
            parametros.Add(acceso.CrearParametro("@MARCA", autobus.MARCA));
            parametros.Add(acceso.CrearParametro("@MODELO", autobus.MODELO));
            parametros.Add(acceso.CrearParametro("@PLACA", autobus.PLACA));
            parametros.Add(acceso.CrearParametro("@COLOR", autobus.COLOR));
            parametros.Add(acceso.CrearParametro("@AÑO", autobus.AÑO));

            return acceso.Escribir("SP_EDITAR_AUTOBUS", parametros);
        }

        public int Eliminar(CAPA_ENTIDAD.E_Autobus autobus)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", autobus.ID));

            return acceso.Escribir("SP_ELIMINAR_AUTOBUS", parametros);

        }
        
       

        
    }
}
