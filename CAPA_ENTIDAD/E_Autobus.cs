using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class E_Autobus
    {
        private int _ID;
        private string _MARCA;
        private string _MODELO;
        private string _PLACA;
        private string _COLOR;
        private string _AÑO;
        private bool _DISPONIBLE;


        public int ID { get => _ID; set => _ID = value; }
        public string MARCA { get => _MARCA; set => _MARCA = value; }
        public string MODELO { get => _MODELO; set => _MODELO = value; }
        public string PLACA { get => _PLACA; set => _PLACA = value; }
        public string COLOR { get => _COLOR; set => _COLOR = value; }
        public string AÑO { get => _AÑO; set => _AÑO = value; }
        public bool DISPONIBLE { get => _DISPONIBLE; set => _DISPONIBLE = value; }
    }
}
