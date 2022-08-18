
namespace CAPA_PRESENTACION
{
    partial class FrmRegistroRutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroRutas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TablaRutas = new System.Windows.Forms.DataGridView();
            this.BtnGuardarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEditarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnNuevoRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtBuscarRuta = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MovimientoPantalla = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BtnAyuda = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnBienvenida = new Bunifu.Framework.UI.BunifuImageButton();
            this.TxtNombreRuta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuRange1 = new Bunifu.Framework.UI.BunifuRange();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.TxtDistancia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtParadas = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBienvenida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.BtnAyuda);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 112);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.label1.Font = new System.Drawing.Font("Oswald", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 94);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro De Rutas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImprimir.BorderRadius = 7;
            this.BtnImprimir.ButtonText = " IMPRIMIR";
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimir.DisabledColor = System.Drawing.Color.Gray;
            this.BtnImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Iconimage")));
            this.BtnImprimir.Iconimage_right = null;
            this.BtnImprimir.Iconimage_right_Selected = null;
            this.BtnImprimir.Iconimage_Selected = null;
            this.BtnImprimir.IconMarginLeft = 0;
            this.BtnImprimir.IconMarginRight = 0;
            this.BtnImprimir.IconRightVisible = true;
            this.BtnImprimir.IconRightZoom = 0D;
            this.BtnImprimir.IconVisible = true;
            this.BtnImprimir.IconZoom = 100D;
            this.BtnImprimir.IsTab = false;
            this.BtnImprimir.Location = new System.Drawing.Point(649, 109);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnImprimir.selected = false;
            this.BtnImprimir.Size = new System.Drawing.Size(143, 47);
            this.BtnImprimir.TabIndex = 71;
            this.BtnImprimir.Text = " IMPRIMIR";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Textcolor = System.Drawing.Color.White;
            this.BtnImprimir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(649, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "Parada :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(649, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "Distancia :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(649, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nombre :";
            // 
            // TablaRutas
            // 
            this.TablaRutas.AllowUserToAddRows = false;
            this.TablaRutas.AllowUserToDeleteRows = false;
            this.TablaRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaRutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaRutas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TablaRutas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRutas.Location = new System.Drawing.Point(12, 162);
            this.TablaRutas.Name = "TablaRutas";
            this.TablaRutas.ReadOnly = true;
            this.TablaRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaRutas.Size = new System.Drawing.Size(631, 225);
            this.TablaRutas.TabIndex = 59;
            // 
            // BtnGuardarRuta
            // 
            this.BtnGuardarRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardarRuta.BorderRadius = 7;
            this.BtnGuardarRuta.ButtonText = "  GUARDAR";
            this.BtnGuardarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarRuta.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardarRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardarRuta.Iconimage")));
            this.BtnGuardarRuta.Iconimage_right = null;
            this.BtnGuardarRuta.Iconimage_right_Selected = null;
            this.BtnGuardarRuta.Iconimage_Selected = null;
            this.BtnGuardarRuta.IconMarginLeft = 0;
            this.BtnGuardarRuta.IconMarginRight = 0;
            this.BtnGuardarRuta.IconRightVisible = true;
            this.BtnGuardarRuta.IconRightZoom = 0D;
            this.BtnGuardarRuta.IconVisible = true;
            this.BtnGuardarRuta.IconZoom = 100D;
            this.BtnGuardarRuta.IsTab = false;
            this.BtnGuardarRuta.Location = new System.Drawing.Point(634, 393);
            this.BtnGuardarRuta.Name = "BtnGuardarRuta";
            this.BtnGuardarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardarRuta.selected = false;
            this.BtnGuardarRuta.Size = new System.Drawing.Size(158, 48);
            this.BtnGuardarRuta.TabIndex = 58;
            this.BtnGuardarRuta.Text = "  GUARDAR";
            this.BtnGuardarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarRuta.Textcolor = System.Drawing.Color.White;
            this.BtnGuardarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRuta.Click += new System.EventHandler(this.BtnGuardarRuta_Click);
            // 
            // BtnEliminarRuta
            // 
            this.BtnEliminarRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarRuta.BorderRadius = 7;
            this.BtnEliminarRuta.ButtonText = "  ELIMINAR";
            this.BtnEliminarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarRuta.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarRuta.Iconimage")));
            this.BtnEliminarRuta.Iconimage_right = null;
            this.BtnEliminarRuta.Iconimage_right_Selected = null;
            this.BtnEliminarRuta.Iconimage_Selected = null;
            this.BtnEliminarRuta.IconMarginLeft = 0;
            this.BtnEliminarRuta.IconMarginRight = 0;
            this.BtnEliminarRuta.IconRightVisible = true;
            this.BtnEliminarRuta.IconRightZoom = 0D;
            this.BtnEliminarRuta.IconVisible = true;
            this.BtnEliminarRuta.IconZoom = 100D;
            this.BtnEliminarRuta.IsTab = false;
            this.BtnEliminarRuta.Location = new System.Drawing.Point(429, 393);
            this.BtnEliminarRuta.Name = "BtnEliminarRuta";
            this.BtnEliminarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminarRuta.selected = false;
            this.BtnEliminarRuta.Size = new System.Drawing.Size(158, 48);
            this.BtnEliminarRuta.TabIndex = 57;
            this.BtnEliminarRuta.Text = "  ELIMINAR";
            this.BtnEliminarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarRuta.Textcolor = System.Drawing.Color.White;
            this.BtnEliminarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarRuta.Click += new System.EventHandler(this.BtnEliminarRuta_Click);
            // 
            // BtnEditarRuta
            // 
            this.BtnEditarRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEditarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditarRuta.BorderRadius = 7;
            this.BtnEditarRuta.ButtonText = "  EDITAR";
            this.BtnEditarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarRuta.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditarRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditarRuta.Iconimage")));
            this.BtnEditarRuta.Iconimage_right = null;
            this.BtnEditarRuta.Iconimage_right_Selected = null;
            this.BtnEditarRuta.Iconimage_Selected = null;
            this.BtnEditarRuta.IconMarginLeft = 0;
            this.BtnEditarRuta.IconMarginRight = 0;
            this.BtnEditarRuta.IconRightVisible = true;
            this.BtnEditarRuta.IconRightZoom = 0D;
            this.BtnEditarRuta.IconVisible = true;
            this.BtnEditarRuta.IconZoom = 100D;
            this.BtnEditarRuta.IsTab = false;
            this.BtnEditarRuta.Location = new System.Drawing.Point(215, 393);
            this.BtnEditarRuta.Name = "BtnEditarRuta";
            this.BtnEditarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEditarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEditarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditarRuta.selected = false;
            this.BtnEditarRuta.Size = new System.Drawing.Size(158, 48);
            this.BtnEditarRuta.TabIndex = 56;
            this.BtnEditarRuta.Text = "  EDITAR";
            this.BtnEditarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarRuta.Textcolor = System.Drawing.Color.White;
            this.BtnEditarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarRuta.Click += new System.EventHandler(this.BtnEditarRuta_Click);
            // 
            // BtnNuevoRuta
            // 
            this.BtnNuevoRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnNuevoRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevoRuta.BorderRadius = 7;
            this.BtnNuevoRuta.ButtonText = "  NUEVO";
            this.BtnNuevoRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoRuta.DisabledColor = System.Drawing.Color.Gray;
            this.BtnNuevoRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNuevoRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnNuevoRuta.Iconimage")));
            this.BtnNuevoRuta.Iconimage_right = null;
            this.BtnNuevoRuta.Iconimage_right_Selected = null;
            this.BtnNuevoRuta.Iconimage_Selected = null;
            this.BtnNuevoRuta.IconMarginLeft = 0;
            this.BtnNuevoRuta.IconMarginRight = 0;
            this.BtnNuevoRuta.IconRightVisible = true;
            this.BtnNuevoRuta.IconRightZoom = 0D;
            this.BtnNuevoRuta.IconVisible = true;
            this.BtnNuevoRuta.IconZoom = 100D;
            this.BtnNuevoRuta.IsTab = false;
            this.BtnNuevoRuta.Location = new System.Drawing.Point(12, 393);
            this.BtnNuevoRuta.Name = "BtnNuevoRuta";
            this.BtnNuevoRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnNuevoRuta.selected = false;
            this.BtnNuevoRuta.Size = new System.Drawing.Size(158, 48);
            this.BtnNuevoRuta.TabIndex = 55;
            this.BtnNuevoRuta.Text = "  NUEVO";
            this.BtnNuevoRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoRuta.Textcolor = System.Drawing.Color.White;
            this.BtnNuevoRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoRuta.Click += new System.EventHandler(this.BtnNuevoRuta_Click);
            // 
            // TxtBuscarRuta
            // 
            this.TxtBuscarRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarRuta.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarRuta.Location = new System.Drawing.Point(64, 118);
            this.TxtBuscarRuta.Name = "TxtBuscarRuta";
            this.TxtBuscarRuta.Size = new System.Drawing.Size(570, 29);
            this.TxtBuscarRuta.TabIndex = 54;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(643, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(804, 349);
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // MovimientoPantalla
            // 
            this.MovimientoPantalla.Fixed = true;
            this.MovimientoPantalla.Horizontal = true;
            this.MovimientoPantalla.TargetControl = this.label1;
            this.MovimientoPantalla.Vertical = true;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.BtnAyuda.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.BtnAyuda.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.BtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAyuda.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.White;
            this.BtnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyuda.Image")));
            this.BtnAyuda.ImagePosition = 10;
            this.BtnAyuda.ImageZoom = 50;
            this.BtnAyuda.LabelPosition = 0;
            this.BtnAyuda.LabelText = "Centro de Ayuda";
            this.BtnAyuda.Location = new System.Drawing.Point(649, 62);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(44, 41);
            this.BtnAyuda.TabIndex = 85;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(697, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(103, 100);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 83;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // BtnBienvenida
            // 
            this.BtnBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.BtnBienvenida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBienvenida.Image = ((System.Drawing.Image)(resources.GetObject("BtnBienvenida.Image")));
            this.BtnBienvenida.ImageActive = null;
            this.BtnBienvenida.Location = new System.Drawing.Point(0, -1);
            this.BtnBienvenida.Name = "BtnBienvenida";
            this.BtnBienvenida.Size = new System.Drawing.Size(170, 101);
            this.BtnBienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBienvenida.TabIndex = 84;
            this.BtnBienvenida.TabStop = false;
            this.BtnBienvenida.Zoom = 10;
            this.BtnBienvenida.Click += new System.EventHandler(this.BtnBienvenida_Click);
            // 
            // TxtNombreRuta
            // 
            this.TxtNombreRuta.BackColor = System.Drawing.Color.White;
            this.TxtNombreRuta.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtNombreRuta.BorderColorIdle = System.Drawing.Color.Black;
            this.TxtNombreRuta.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtNombreRuta.BorderThickness = 3;
            this.TxtNombreRuta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreRuta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNombreRuta.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreRuta.isPassword = false;
            this.TxtNombreRuta.Location = new System.Drawing.Point(649, 207);
            this.TxtNombreRuta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreRuta.Name = "TxtNombreRuta";
            this.TxtNombreRuta.Size = new System.Drawing.Size(143, 25);
            this.TxtNombreRuta.TabIndex = 88;
            this.TxtNombreRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuRange1
            // 
            this.bunifuRange1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRange1.BackgroudColor = System.Drawing.Color.Black;
            this.bunifuRange1.BorderRadius = 0;
            this.bunifuRange1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuRange1.Location = new System.Drawing.Point(13, 357);
            this.bunifuRange1.MaximumRange = 100;
            this.bunifuRange1.Name = "bunifuRange1";
            this.bunifuRange1.RangeMax = 49;
            this.bunifuRange1.RangeMin = 0;
            this.bunifuRange1.Size = new System.Drawing.Size(629, 30);
            this.bunifuRange1.TabIndex = 86;
            this.bunifuRange1.RangeChanged += new System.EventHandler(this.bunifuRange1_RangeChanged);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 109);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(58, 46);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 87;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // TxtDistancia
            // 
            this.TxtDistancia.BackColor = System.Drawing.Color.White;
            this.TxtDistancia.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtDistancia.BorderColorIdle = System.Drawing.Color.Black;
            this.TxtDistancia.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtDistancia.BorderThickness = 3;
            this.TxtDistancia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDistancia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtDistancia.ForeColor = System.Drawing.Color.Black;
            this.TxtDistancia.isPassword = false;
            this.TxtDistancia.Location = new System.Drawing.Point(649, 283);
            this.TxtDistancia.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDistancia.Name = "TxtDistancia";
            this.TxtDistancia.Size = new System.Drawing.Size(143, 25);
            this.TxtDistancia.TabIndex = 89;
            this.TxtDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtParadas
            // 
            this.TxtParadas.BackColor = System.Drawing.Color.White;
            this.TxtParadas.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtParadas.BorderColorIdle = System.Drawing.Color.Black;
            this.TxtParadas.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtParadas.BorderThickness = 3;
            this.TxtParadas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtParadas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtParadas.ForeColor = System.Drawing.Color.Black;
            this.TxtParadas.isPassword = false;
            this.TxtParadas.Location = new System.Drawing.Point(649, 357);
            this.TxtParadas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtParadas.Name = "TxtParadas";
            this.TxtParadas.Size = new System.Drawing.Size(143, 25);
            this.TxtParadas.TabIndex = 90;
            this.TxtParadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FrmRegistroRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtParadas);
            this.Controls.Add(this.TxtDistancia);
            this.Controls.Add(this.TxtNombreRuta);
            this.Controls.Add(this.bunifuRange1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TablaRutas);
            this.Controls.Add(this.BtnGuardarRuta);
            this.Controls.Add(this.BtnEliminarRuta);
            this.Controls.Add(this.BtnEditarRuta);
            this.Controls.Add(this.BtnNuevoRuta);
            this.Controls.Add(this.TxtBuscarRuta);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroRutas";
            this.Text = "Registro De Rutas";
            this.Load += new System.EventHandler(this.FrmRegistroRutas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBienvenida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnImprimir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TablaRutas;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNuevoRuta;
        private System.Windows.Forms.TextBox TxtBuscarRuta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuDragControl MovimientoPantalla;
        private Bunifu.Framework.UI.BunifuTileButton BtnAyuda;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton BtnBienvenida;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtNombreRuta;
        private Bunifu.Framework.UI.BunifuRange bunifuRange1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtDistancia;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtParadas;
    }
}