using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class FrmRegistroViajes : Form
    {
        N_Viaje viaje = new N_Viaje();
        E_Viaje objEntidad = new E_Viaje();
        N_Autobus autobus = new N_Autobus();
        N_Chofer chofer = new N_Chofer();
        N_Ruta ruta = new N_Ruta();
        Form frmPresentacion = new FrmPresentacion();

        public FrmRegistroViajes()
        {
            InitializeComponent();
        }

        private void BtnNuevoViaje_Click(object sender, EventArgs e)
        {
            LimpiarCaja();
        }

        private void LimpiarCaja()
        {
            CmbChofer.Text = "";
            CmbRuta.Text = "";
            CmbAutobus.Text = "";
            TxtBuscarViaje.Text = "";
        }

        private void ListarViajes()
        {
            TablaViajes.DataSource = viaje.Listar();
        }

        private void ListarAutobus()
        {
            List<E_Autobus> listAutobuses = new List<E_Autobus>();
            listAutobuses = autobus.Listar();

            foreach (E_Autobus autobus in listAutobuses)
            {

                if (autobus.DISPONIBLE)
                {
                    CmbAutobus.Items.Add(autobus.MARCA + " " + autobus.MODELO);

                }

            }




        }

        private void ListarChofer()
        {
            List<E_Chofer> listChoferes = new List<E_Chofer>();
            listChoferes = chofer.Listar();

            foreach (E_Chofer chofer in listChoferes)
            {

                if (chofer.DISPONIBLE)
                {
                    CmbChofer.Items.Add(chofer.NOMBRE + " " + chofer.APELLIDO);

                }

            }
        }

        private void ListarRuta()
        {
            List<E_Ruta> listRutas = new List<E_Ruta>();
            listRutas = ruta.Listar();

            foreach (E_Ruta ruta in listRutas)
            {

                if (ruta.DISPONIBLE)
                {
                    CmbRuta.Items.Add(ruta.NOMBRE);

                }

            }
        }



        private void FrmRegistroViajes_Load(object sender, EventArgs e)
        {
            ListarViajes();
            ListarAutobus();
            ListarChofer();
            ListarRuta();
        }

        private void BtnGuardarViaje_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidad = new E_Viaje();
                List<int> ids = BuscarPropiedades(CmbChofer.SelectedItem.ToString(), CmbAutobus.SelectedItem.ToString(), CmbRuta.SelectedItem.ToString());
                objEntidad.ID_CHOFER = ids[0];
                objEntidad.ID_AUTOBUS = ids[1];
                objEntidad.ID_RUTA = ids[2];


                viaje.Guardar(objEntidad);

                MessageBox.Show("Se ha guardado el viaje exitosamente.", "EnHoraBuena");
                ListarViajes();
                LimpiarCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido guardar el viaje.", "Error");
            }
        }

        private List<int> BuscarPropiedades(string choferr, string autobuss, string rutaa)
        {

            List<E_Chofer> chofers = chofer.Listar();

            List<E_Autobus> autobuses = autobus.Listar();

            List<E_Ruta> rutas = ruta.Listar();

            List<int> retorno = new List<int>();


            foreach (E_Chofer item in chofers)
            {
                string nombre_completo = item.NOMBRE + " " + item.APELLIDO;

                if (nombre_completo == choferr)
                {
                    retorno.Add(item.ID);
                }
            }

            foreach (E_Autobus item in autobuses)
            {
                string auto_completo = item.MARCA + " " + item.MODELO;

                if (auto_completo == autobuss)
                {
                    retorno.Add(item.ID);
                }
            }

            foreach (E_Ruta item in rutas)
            {

                if (item.NOMBRE == rutaa)
                {
                    retorno.Add(item.ID);
                }
            }

            return retorno;
        }

        private void BtnEliminarViaje_Click(object sender, EventArgs e)
        {
            if (TablaViajes.SelectedRows.Count > 0)
            {
                objEntidad.ID = Convert.ToInt32(TablaViajes.CurrentRow.Cells[0].Value.ToString());

                viaje.Eliminar(objEntidad);

                MessageBox.Show("Se ha eliminado el viaje exitosamente", "EnHoraBuena");
                ListarViajes();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para poder eliminar un viaje.", "Advertencia");
            }
        }

        private void BtnBienvenida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de viajes", "Saludos");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmPresentacion.Show();
            this.Hide();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de viajes. 1-Debe llenar cada uno de los campos al momento de insertar un viaje, 2-de igual manera si elimina un viaje asegurese que no se encuentre en proceso porque sino el programa podria mostrar una excepcion no controlada (ERROR). 3-Para volver a la pantalla principal y cerrar el programa debe de darle al la flechita de retorno y luego cerrar el programa mediante el sistema.", "Centro De Ayuda");
        }
    }


}



