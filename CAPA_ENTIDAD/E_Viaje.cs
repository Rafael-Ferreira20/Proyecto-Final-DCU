using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class E_Viaje
    {
        private int _ID;
        private int _ID_CHOFER;
        private int _ID_AUTOBUS;
        private int _ID_RUTA;


        public int ID { get => _ID; set => _ID = value; }
        public int ID_CHOFER { get => _ID_CHOFER; set => _ID_CHOFER = value; }
        public int ID_AUTOBUS { get => _ID_AUTOBUS; set => _ID_AUTOBUS = value; }
        public int ID_RUTA { get => _ID_RUTA; set => _ID_RUTA = value; }
    }
}
