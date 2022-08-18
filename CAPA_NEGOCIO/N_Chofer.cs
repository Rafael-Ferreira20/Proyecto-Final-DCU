using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class N_Chofer
    {
        CAPA_DATOS.D_Chofer _Chofer = new CAPA_DATOS.D_Chofer();

        public int Guardar(CAPA_ENTIDAD.E_Chofer chofer)
        {
            int res = 0;
            if (chofer.ID == 0)
            {
                res = _Chofer.Insertar(chofer);
            }
            {
                res = _Chofer.Editar(chofer);
            }
            return res;
        }

        public int Eliminar(CAPA_ENTIDAD.E_Chofer chofer)
        {
            return _Chofer.Eliminar(chofer);
        }


        public List<E_Chofer> Listar()
        {
            return _Chofer.Listar();
        }
    }
}
