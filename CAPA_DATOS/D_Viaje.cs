using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class D_Viaje
    {
        private Acceso acceso = new Acceso();

        public DataTable Listar()
        {
            DataTable tabla = acceso.Leer("SP_LISTAR_VIAJES");
            List<CAPA_ENTIDAD.E_Viaje_Modelo> viajes = new List<CAPA_ENTIDAD.E_Viaje_Modelo>();

            foreach(DataRow registro in tabla.Rows)
            {
                int ID = int.Parse(registro["ID"].ToString());
                int ID_Chofer = int.Parse(registro["ID_C"].ToString());
                int ID_Autobus = int.Parse(registro["ID_A"].ToString());
                int ID_Ruta = int.Parse(registro["ID_R"].ToString());
                string Chofer = registro["CHOFER"].ToString();
                string Cedula = registro["CEDULA"].ToString();
                string Autobus_marca = registro["MARCA"].ToString();
                string modelo_Autobus = registro["MODELO"].ToString();
                string placa_Aut = registro["PLACA"].ToString();
                string Distancia = registro["DISTANCIA"].ToString();
                string Paradas = registro["PARADAS"].ToString();
                CAPA_ENTIDAD.E_Viaje_Modelo viaje = new CAPA_ENTIDAD.E_Viaje_Modelo();
                viajes.Add(viaje);
            }

            return tabla;
        }

        public int Insertar(CAPA_ENTIDAD.E_Viaje viaje)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID_CHOFER", viaje.ID_CHOFER));
            parametros.Add(acceso.CrearParametro("@ID_AUTOBUS", viaje.ID_AUTOBUS));
            parametros.Add(acceso.CrearParametro("@ID_RUTA", viaje.ID_RUTA));

            return acceso.Escribir("SP_INSERTAR_VIAJE", parametros);

        }


        public int Eliminar(CAPA_ENTIDAD.E_Viaje viaje)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", viaje.ID));

            return acceso.Escribir("SP_ELIMINAR_VIAJE", parametros);
        }


    }
}
