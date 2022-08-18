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
    public partial class FrmRegistroChoferes : Form
    {
        private string idChofer;
        Form frmPresentacion = new FrmPresentacion();
        N_Chofer chofer = new N_Chofer();
        E_Chofer objEntidad = new E_Chofer();
        private bool Editarse = false;

        public FrmRegistroChoferes()
        {
            InitializeComponent();
        }

        private void LimpiarCaja()
        {
            TxtNombreChofer.Text = "";
            TxtApellidoChofer.Text = "";
            TxtFechaNacimiento.Text = "";
            TxtCedula.Text = "";
        }

        private bool Validacion()
        {
            bool vacio = false;
            if (TxtNombreChofer.Text == "")
            {
                MessageBox.Show("Debe llenar el campo nombre.", "Advertencia");
                vacio = true;
            }
            else if (TxtApellidoChofer.Text == "")
            {
                MessageBox.Show("Debe llenar el campo apellido.", "Advertencia");
                vacio = true;
            }
            else if (TxtFechaNacimiento.Text == "")
            {
                MessageBox.Show("Debe llenar el campo fecha de nacimiento.", "Advertencia");
                vacio = true;
            }
            else if (TxtCedula.Text == "")
            {
                MessageBox.Show("Debe llenar el campo cedula.", "Advertencia");
                vacio = true;
            }

            return vacio;
        }

        public void ListarChoferes()
        {
            TablaChoferes.DataSource = chofer.Listar();
        }

        private void BtnNuevoChofer_Click(object sender, EventArgs e)
        {
            LimpiarCaja();
            Editarse = false;
        }

        private void BtnEditarChofer_Click(object sender, EventArgs e)
        {
            if (TablaChoferes.SelectedRows.Count > 0)
            {
                idChofer = TablaChoferes.CurrentRow.Cells[0].Value.ToString();
                TxtNombreChofer.Text = TablaChoferes.CurrentRow.Cells[1].Value.ToString();
                TxtApellidoChofer.Text = TablaChoferes.CurrentRow.Cells[2].Value.ToString();
                TxtFechaNacimiento.Text = TablaChoferes.CurrentRow.Cells[3].Value.ToString();
                TxtCedula.Text = TablaChoferes.CurrentRow.Cells[4].Value.ToString();

                Editarse = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para poder editar", "Advertencia");
            }
        }

        private void BtnEliminarChofer_Click(object sender, EventArgs e)
        {
            if (TablaChoferes.SelectedRows.Count > 0)
            {
                objEntidad.ID = Convert.ToInt32(TablaChoferes.CurrentRow.Cells[0].Value.ToString());

                chofer.Eliminar(objEntidad);

                MessageBox.Show("Se ha eliminado el chofer exitosamente", "EnHoraBuena");
                ListarChoferes();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para poder eliminar", "Advertencia");
            }
        }

        private void FrmRegistroChoferes_Load(object sender, EventArgs e)
        {
            ListarChoferes();
        }

        private void BtnGuardarChofer_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (Editarse == false)
                {
                    try
                    {

                        objEntidad = new E_Chofer();
                        objEntidad.NOMBRE = TxtNombreChofer.Text.ToUpper();
                        objEntidad.APELLIDO = TxtApellidoChofer.Text.ToUpper();
                        objEntidad.FECHA_NACIMIENTO = TxtFechaNacimiento.Text.ToUpper();
                        objEntidad.CEDULA = TxtCedula.Text.ToUpper();

                        chofer.Guardar(objEntidad);

                        MessageBox.Show("Se ha guardado el chofer exitosamente.", "EnHoraBuena");
                        ListarChoferes();
                        LimpiarCaja();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No se ha podido guardar el chofer.", "Error");
                    }
                }

                if (Editarse == true)
                {
                    try
                    {
                        objEntidad = new E_Chofer();
                        objEntidad.ID = Convert.ToInt32(idChofer);
                        objEntidad.NOMBRE = TxtNombreChofer.Text.ToUpper();
                        objEntidad.APELLIDO = TxtApellidoChofer.Text.ToUpper();
                        objEntidad.FECHA_NACIMIENTO = TxtFechaNacimiento.Text.ToUpper();
                        objEntidad.CEDULA = TxtCedula.Text.ToUpper();

                        chofer.Guardar(objEntidad);

                        MessageBox.Show("Se ha editado el chofer exitosamente.", "EnHoraBuena");
                        ListarChoferes();
                        LimpiarCaja();
                        Editarse = false;

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No se ha podido editar el chofer.", "Error");
                    }
                }
            }
        }

        private void BtnBienvenida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de choferes", "Saludos");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmPresentacion.Show();
            this.Hide();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de choferes. 1-Debe llenar cada uno de los campos al momento de insertar un chofer, 2-de igual manera si quiere editar solo cambie lo que necesite cambiar y si elimina un chofer asegurese que no se encuentre en un viaje porque sino el programa podria mostrar una excepcion no controlada (ERROR). 3-Para volver a la pantalla principal y cerrar el programa debe de darle al la flechita de retorno y luego cerrar el programa mediante el sistema.", "Centro De Ayuda");
        }
    }
}
