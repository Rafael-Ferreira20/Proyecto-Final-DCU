using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class N_Ruta
    {
        CAPA_DATOS.D_Ruta _Ruta = new CAPA_DATOS.D_Ruta();

        public int Guardar(CAPA_ENTIDAD.E_Ruta ruta)
        {
            int res = 0;
            if (ruta.ID == 0)
            {
                res = _Ruta.Insertar(ruta);
            }
            else
            {
                res = _Ruta.Editar(ruta);
            }
            return res;
        }

        public int Eliminar(CAPA_ENTIDAD.E_Ruta ruta)
        {
            return _Ruta.Eliminar(ruta);
        }


        public List<E_Ruta> Listar()
        {
            return _Ruta.Listar();
        }
    }
}
