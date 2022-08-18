using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class FrmRegistroRutas : Form
    {
        private string idRuta;
        Form frmPresentacion = new FrmPresentacion();
        N_Ruta ruta = new N_Ruta();
        E_Ruta objEntidad = new E_Ruta();
        private bool Editarse = false;

        public FrmRegistroRutas()
        {
            InitializeComponent();
        }

        private void LimpiarCaja()
        {
            TxtNombreRuta.Text = "";
            TxtDistancia.Text = "";
            TxtParadas.Text = "";
        }

        private bool Validacion()
        {
            bool vacio = false;
            if (TxtNombreRuta.Text == "")
            {
                MessageBox.Show("Debe llenar el campo nombre de ruta.", "Advertencia");
                vacio= true;
            }
            else if (TxtDistancia.Text == "")
            {
                MessageBox.Show("Debe llenar el campo distancia.", "Advertencia");
                vacio = true;
            }
            else if (TxtParadas.Text == "")
            {
                MessageBox.Show("Debe llenar el campo paradas.", "Advertencia");
                vacio = true;
            }

            return vacio;
        }

        public void ListarRutas()
        {
            TablaRutas.DataSource = ruta.Listar();
        }

        private void BtnNuevoRuta_Click(object sender, EventArgs e)
        {
            LimpiarCaja();
            Editarse = false;
        }

        private void BtnEditarRuta_Click(object sender, EventArgs e)
        {
            if (TablaRutas.SelectedRows.Count > 0)
            {
                idRuta = TablaRutas.CurrentRow.Cells[0].Value.ToString();
                TxtNombreRuta.Text = TablaRutas.CurrentRow.Cells[1].Value.ToString();
                TxtDistancia.Text = TablaRutas.CurrentRow.Cells[2].Value.ToString();
                TxtParadas.Text = TablaRutas.CurrentRow.Cells[3].Value.ToString();

                Editarse = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para poder editar.", "Advertencia");
            }
        }

        private void FrmRegistroRutas_Load(object sender, EventArgs e)
        {
            ListarRutas();
        }

        private void BtnEliminarRuta_Click(object sender, EventArgs e)
        {
            if (TablaRutas.SelectedRows.Count > 0)
            {
                objEntidad.ID = Convert.ToInt32(TablaRutas.CurrentRow.Cells[0].Value.ToString());

                ruta.Eliminar(objEntidad);

                MessageBox.Show("Se ha eliminado la ruta exitosamente.", "EnHoraBuena");
                ListarRutas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila pra poder eliminar.", "Advertencia");
            }
        }

        private void BtnGuardarRuta_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (Editarse == false)
                {
                    try
                    {
                        objEntidad = new E_Ruta();
                        objEntidad.NOMBRE = TxtNombreRuta.Text.ToUpper();
                        objEntidad.DISTANCIA = TxtDistancia.Text.ToUpper();
                        objEntidad.PARADAS = Convert.ToInt32(TxtParadas.Text.ToUpper());

                        ruta.Guardar(objEntidad);

                        MessageBox.Show("Se ha guardado la ruta exitosamente.", "EnHoraBuena");
                        ListarRutas();
                        LimpiarCaja();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No se ha podido guardar la ruta.", "Error");
                    }
                }

                if (Editarse == true)
                {
                    try
                    {
                        objEntidad = new E_Ruta();
                        objEntidad.ID = Convert.ToInt32(idRuta);
                        objEntidad.NOMBRE = TxtNombreRuta.Text.ToUpper();
                        objEntidad.DISTANCIA = TxtDistancia.Text.ToUpper();
                        objEntidad.PARADAS = Convert.ToInt32(TxtParadas.Text.ToUpper());

                        ruta.Guardar(objEntidad);

                        MessageBox.Show("Se ha editado la ruta exitosamente.", "EnHoraBuena");
                        ListarRutas();
                        LimpiarCaja();
                        Editarse = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido editar la ruta.", "Error");
                    }
                }
            }
        }

        private void BtnBienvenida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de rutas", "Saludos");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmPresentacion.Show();
            this.Hide();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de rutas. 1-Debe llenar cada uno de los campos al momento de insertar una ruta, 2-de igual manera si quiere editar solo cambie lo que necesite cambiar y si elimina una ruta asegurese que no se encuentre en proceso porque sino el programa podria mostrar una excepcion no controlada (ERROR). 3-Para volver a la pantalla principal y cerrar el programa debe de darle al la flechita de retorno y luego cerrar el programa mediante el sistema.", "Centro De Ayuda");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {

        }
    }
}
