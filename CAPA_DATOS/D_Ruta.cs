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
    public class D_Ruta
    {
        private Acceso acceso = new Acceso();


        public List<E_Ruta> Listar()
        {
            DataTable tabla = acceso.Leer("SP_LISTAR_RUTAS");
            List<E_Ruta> e_Rutas = new List<E_Ruta>();

            foreach(DataRow row in tabla.Rows)
            {
                E_Ruta e_Ruta = new E_Ruta {
                    ID = Convert.ToInt32(row["ID"]),
                    NOMBRE = row["NOMBRE"].ToString(),
                    DISTANCIA = row["DISTANCIA"].ToString(),
                    PARADAS = Convert.ToInt32(row["PARADAS"]),
                    DISPONIBLE = Convert.ToBoolean(row["DISPONIBLE"])

                };
                e_Rutas.Add(e_Ruta);
            }

            return e_Rutas;
        }

        public int Insertar(CAPA_ENTIDAD.E_Ruta ruta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@NOMBRE", ruta.NOMBRE));
            parametros.Add(acceso.CrearParametro("@DISTANCIA", ruta.DISTANCIA));
            parametros.Add(acceso.CrearParametro("@PARADAS", ruta.PARADAS));

            return acceso.Escribir("SP_INSERTAR_RUTA", parametros);
        }

        public int Editar(CAPA_ENTIDAD.E_Ruta ruta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", ruta.ID));
            parametros.Add(acceso.CrearParametro("@NOMBRE", ruta.NOMBRE));
            parametros.Add(acceso.CrearParametro("@DISTANCIA", ruta.DISTANCIA));
            parametros.Add(acceso.CrearParametro("@PARADAS", ruta.PARADAS));


            return acceso.Escribir("SP_EDITAR_RUTA", parametros);
        }

        public int Eliminar(CAPA_ENTIDAD.E_Ruta ruta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", ruta.ID));

            return acceso.Escribir("SP_ELIMINAR_RUTA", parametros);

        }
    }
}
