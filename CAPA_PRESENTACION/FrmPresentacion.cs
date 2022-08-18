using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FrmPresentacion : Form
    {
        public FrmPresentacion()
        {
            InitializeComponent();
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {

        }

        private void BtnChoferes_Click(object sender, EventArgs e)
        {
            Form frmChoferes = new FrmRegistroChoferes();
            frmChoferes.Show();
            this.Hide();
        }

        private void BtnRutas_Click(object sender, EventArgs e)
        {
            Form frmRutas = new FrmRegistroRutas();
            frmRutas.Show();
            this.Hide();
        }

        private void BtnAutobuses_Click(object sender, EventArgs e)
        {
            Form frmAutobuses = new FrmRegistroAutobuses();
            frmAutobuses.Show();
            this.Hide();
        }

        private void BtnViajes_Click(object sender, EventArgs e)
        {
            Form frmViajes = new FrmRegistroViajes();
            frmViajes.Show();
            this.Hide();
        }

        private void BtnBienvenida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema de control de autobuses", "Saludos");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema de control de autobuses. Para poder realizar un viaje primero debe registrar un chofer, un autobus y una ruta, luego entrar a la ventana de viajes y puede elegir el viaje de su preferencia junto a su chofer, su autobus y su ruta a donde se dirige. ", "Centro De Ayuda");
        }
    }
}
