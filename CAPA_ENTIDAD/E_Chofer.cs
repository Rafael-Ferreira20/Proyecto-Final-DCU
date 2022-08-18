using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class E_Chofer
    {
        private int _ID;
        private string _NOMBRE;
        private string _APELLIDO;
        private string _FECHA_NACIMIENTO;
        private string _CEDULA;
        private bool _DISPONIBLE;


        public int ID { get => _ID; set => _ID = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public string FECHA_NACIMIENTO { get => _FECHA_NACIMIENTO; set => _FECHA_NACIMIENTO = value; }
        public string CEDULA { get => _CEDULA; set => _CEDULA = value; }
        public bool DISPONIBLE { get => _DISPONIBLE; set => _DISPONIBLE = value; }
    }
}
