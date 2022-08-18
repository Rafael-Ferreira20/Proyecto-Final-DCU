using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class N_Autobus
    {
        CAPA_DATOS.D_Autobus _Autobus = new CAPA_DATOS.D_Autobus();

        public int Guardar(CAPA_ENTIDAD.E_Autobus autobus)
        {
            int res = 0;
            if (autobus.ID == 0)
            {
                res = _Autobus.Insertar(autobus);
            }
            else
            {
                res = _Autobus.Editar(autobus);
            }
            return res;
        }

        public int Eliminar(CAPA_ENTIDAD.E_Autobus autobus)
        {
            return _Autobus.Eliminar(autobus);
        }


        public List<E_Autobus> Listar()
        {
            return _Autobus.Listar();
        }

       
    }
}
