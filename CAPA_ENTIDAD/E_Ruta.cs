using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class E_Ruta
    {
        private int _ID;
        private string _NOMBRE;
        private string _DISTANCIA;
        private int _PARADAS;
        private bool _DISPONIBLE;


        public int ID { get => _ID; set => _ID = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string DISTANCIA { get => _DISTANCIA; set => _DISTANCIA = value; }
        public int PARADAS { get => _PARADAS; set => _PARADAS = value; }
        public bool DISPONIBLE { get => _DISPONIBLE; set => _DISPONIBLE = value; }
    }
}
