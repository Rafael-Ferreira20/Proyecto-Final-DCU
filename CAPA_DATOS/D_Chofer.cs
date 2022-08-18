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
    public class D_Chofer
    {
        private Acceso acceso = new Acceso();


        public List<E_Chofer> Listar()
        {
            DataTable tabla = acceso.Leer("SP_LISTAR_CHOFER");
            List<E_Chofer> chofer = new List<E_Chofer>();

            foreach (DataRow row in tabla.Rows)
            {
                E_Chofer chofer1 = new E_Chofer
                {
                    ID = Convert.ToInt32(row["ID"]),
                    NOMBRE = row["NOMBRE"].ToString(),
                    APELLIDO = row["APELLIDO"].ToString(),
                    FECHA_NACIMIENTO = row["FECHA_NACIMIENTO"].ToString(),
                    CEDULA = row["CEDULA"].ToString(),
                    DISPONIBLE = Convert.ToBoolean(row["DISPONIBLE"])

                };
                chofer.Add(chofer1);
            }

            return chofer;
        }

        public int Insertar(CAPA_ENTIDAD.E_Chofer chofer)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@NOMBRE", chofer.NOMBRE));
            parametros.Add(acceso.CrearParametro("@APELLIDO", chofer.APELLIDO));
            parametros.Add(acceso.CrearParametro("@FECHA_NACIMIENTO", chofer.FECHA_NACIMIENTO));
            parametros.Add(acceso.CrearParametro("@CEDULA", chofer.CEDULA));
            
            return acceso.Escribir("SP_INSERTAR_CHOFER", parametros);
        }

        public int Editar(CAPA_ENTIDAD.E_Chofer chofer)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", chofer.ID));
            parametros.Add(acceso.CrearParametro("@NOMBRE", chofer.NOMBRE));
            parametros.Add(acceso.CrearParametro("@APELLIDO", chofer.APELLIDO));
            parametros.Add(acceso.CrearParametro("@FECHA_NACIMIENTO", chofer.FECHA_NACIMIENTO));
            parametros.Add(acceso.CrearParametro("@CEDULA", chofer.CEDULA));
            
            
            return acceso.Escribir("SP_EDITAR_CHOFER", parametros);
        }

        public int Eliminar(CAPA_ENTIDAD.E_Chofer chofer)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", chofer.ID));

            return acceso.Escribir("SP_ELIMINAR_CHOFERES", parametros);

        }
    }
}
