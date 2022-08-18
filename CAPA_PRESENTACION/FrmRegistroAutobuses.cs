using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION
{
    public partial class FrmRegistroAutobuses : Form
    {
        private string idAutobus;
        Form frmPresentacion = new FrmPresentacion();
        N_Autobus autobus = new N_Autobus();
        E_Autobus objEntidad = new E_Autobus();
        private bool Editarse = false;

        public FrmRegistroAutobuses()
        {
            InitializeComponent();
        }

        private void FrmRegistroAutobuses_Load(object sender, EventArgs e)
        {
            ListarAutobuses();
        }

        public void ListarAutobuses()
        {
            TablaAutobuses.DataSource = autobus.Listar();
            
        }

        private void LimpiarCaja()
        {
            TxtModelo.Text = "";
            TxtPlaca.Text = "";
            TxtMarca.Text = "";
            TxtColor.Text = "";
            TxtBuscarAutobus.Text = "";
            TxtAno.Text = "";
        }

        private bool Validacion()
        {
            bool vacio = false;
            if (TxtMarca.Text == "")
            {
                MessageBox.Show("Debe introducir una marca.", "Advertencia");
                vacio = true;
            }
            else if (TxtModelo.Text == "")
            {
                MessageBox.Show("Debe introducir un modelo.", "Advertencia");
                vacio = true;
            }
            else if (TxtPlaca.Text == "")
            {
                MessageBox.Show("Debe introducir una placa.", "Advertencia");
                vacio = true;
            }
            else if (TxtColor.Text == "")
            {
                MessageBox.Show("Debe introducir un color.", "Advertencia");
                vacio = true;
            }
            else if (TxtAno.Text == "")
            {
                MessageBox.Show("Debe introducir un año.", "Advertencia");
                vacio = true;
            }

            return vacio;
            
        }



        private void BtnNuevoAutobus_Click(object sender, EventArgs e)
        {
            LimpiarCaja();
            Editarse = false;
        }

        private void BtnEditarAutobus_Click(object sender, EventArgs e)
        {
            if (TablaAutobuses.SelectedRows.Count > 0)
            {
                idAutobus = TablaAutobuses.CurrentRow.Cells[0].Value.ToString();
                TxtMarca.Text = TablaAutobuses.CurrentRow.Cells[1].Value.ToString();
                TxtModelo.Text = TablaAutobuses.CurrentRow.Cells[2].Value.ToString();
                TxtPlaca.Text = TablaAutobuses.CurrentRow.Cells[3].Value.ToString();
                TxtColor.Text = TablaAutobuses.CurrentRow.Cells[4].Value.ToString();
                TxtAno.Text = TablaAutobuses.CurrentRow.Cells[5].Value.ToString();

                Editarse = true;
                
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para poder editar", "Advertencia");
            }
        }

        private void BtnEliminarAutobus_Click(object sender, EventArgs e)
        {
            if (TablaAutobuses.SelectedRows.Count > 0)
            {
                objEntidad.ID = Convert.ToInt32(TablaAutobuses.CurrentRow.Cells[0].Value.ToString());
                
                autobus.Eliminar(objEntidad);

                MessageBox.Show("Se ha eliminado el autobus exitosamente.", "EnHoraBuena");
                ListarAutobuses();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para poder eliminar", "Advertencia");
            }
        }

        private void BtnGuardarAutobus_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (Editarse==false)
                {
                    try
                    {
                        objEntidad = new E_Autobus();
                        objEntidad.MARCA = TxtMarca.Text.ToUpper();
                        objEntidad.MODELO = TxtModelo.Text.ToUpper();
                        objEntidad.PLACA = TxtPlaca.Text.ToUpper();
                        objEntidad.COLOR = TxtPlaca.Text.ToUpper();
                        objEntidad.AÑO = TxtAno.Text.ToUpper();


                        autobus.Guardar(objEntidad);

                        MessageBox.Show("Se ha guardado el autobus exitosamente.", "EnHoraBuena");
                        ListarAutobuses();
                        LimpiarCaja();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No se ha podido guardar el autobus.", "Error");
                    }
                }
                if (Editarse == true)
                {
                    try
                    {
                        objEntidad = new E_Autobus();
                        objEntidad.ID = Convert.ToInt32(idAutobus);
                        objEntidad.MARCA = TxtMarca.Text.ToUpper();
                        objEntidad.MODELO = TxtModelo.Text.ToUpper();
                        objEntidad.PLACA = TxtPlaca.Text.ToUpper();
                        objEntidad.COLOR = TxtPlaca.Text.ToUpper();
                        objEntidad.AÑO = TxtAno.Text.ToUpper();

                        autobus.Guardar(objEntidad);

                        MessageBox.Show("Se ha editado el autobus exitosamente.", "EnHoraBuena");
                        ListarAutobuses();
                        LimpiarCaja();
                        Editarse = false;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No se ha podido editar el autobus.", "Error");
                    }
                }
                              
            }


        }


        private void TxtBuscarAutobus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnBienvenida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de autobuses.", "Saludos");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmPresentacion.Show();
            this.Hide();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de autobuses. 1-Debe llenar cada uno de los campos al momento de insertar un autobus, 2-de igual manera si quiere editar solo cambie lo que necesite cambiar y si elimina un autobus asegurese que no se encuentre en un viaje porque sino el programa podria mostrar una excepcion no controlada (ERROR). 3-Para volver a la pantalla principal y cerrar el programa debe de darle al la flechita de retorno y luego cerrar el programa mediante el sistema.", "Centro De Ayuda");
        }

       
    }
}
