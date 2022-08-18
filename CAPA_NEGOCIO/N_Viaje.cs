using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CAPA_NEGOCIO
{
    public class N_Viaje
    {
        CAPA_DATOS.D_Viaje _Viaje = new CAPA_DATOS.D_Viaje();

        public int Guardar(CAPA_ENTIDAD.E_Viaje viaje)
        {
            int res = 0;
            if (viaje.ID == 0)
            {
                res = _Viaje.Insertar(viaje);
            }
            
            return res;
        }

        public int Eliminar(CAPA_ENTIDAD.E_Viaje viaje)
        {
            return _Viaje.Eliminar(viaje);
        }


        public DataTable Listar()
        {
            return _Viaje.Listar();
        }
    }
}
