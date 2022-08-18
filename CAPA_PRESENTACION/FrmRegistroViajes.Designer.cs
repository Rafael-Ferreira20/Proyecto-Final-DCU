
namespace CAPA_PRESENTACION
{
    partial class FrmRegistroViajes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroViajes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TablaViajes = new System.Windows.Forms.DataGridView();
            this.BtnGuardarViaje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminarViaje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnNuevoViaje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtBuscarViaje = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbChofer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbAutobus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbRuta = new System.Windows.Forms.ComboBox();
            this.MovimientoPantalla = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BtnBienvenida = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnAyuda = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuRange1 = new Bunifu.Framework.UI.BunifuRange();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBienvenida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.BtnBienvenida);
            this.panel1.Controls.Add(this.BtnAyuda);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 106);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.label1.Font = new System.Drawing.Font("Oswald", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 89);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registro De Viajes";
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
            this.BtnImprimir.Location = new System.Drawing.Point(645, 106);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnImprimir.selected = false;
            this.BtnImprimir.Size = new System.Drawing.Size(143, 46);
            this.BtnImprimir.TabIndex = 81;
            this.BtnImprimir.Text = " IMPRIMIR";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Textcolor = System.Drawing.Color.White;
            this.BtnImprimir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TablaViajes
            // 
            this.TablaViajes.AllowUserToAddRows = false;
            this.TablaViajes.AllowUserToDeleteRows = false;
            this.TablaViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaViajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaViajes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TablaViajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaViajes.Location = new System.Drawing.Point(8, 156);
            this.TablaViajes.Name = "TablaViajes";
            this.TablaViajes.ReadOnly = true;
            this.TablaViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaViajes.Size = new System.Drawing.Size(631, 227);
            this.TablaViajes.TabIndex = 80;
            // 
            // BtnGuardarViaje
            // 
            this.BtnGuardarViaje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarViaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardarViaje.BorderRadius = 7;
            this.BtnGuardarViaje.ButtonText = "  GUARDAR";
            this.BtnGuardarViaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarViaje.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardarViaje.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardarViaje.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardarViaje.Iconimage")));
            this.BtnGuardarViaje.Iconimage_right = null;
            this.BtnGuardarViaje.Iconimage_right_Selected = null;
            this.BtnGuardarViaje.Iconimage_Selected = null;
            this.BtnGuardarViaje.IconMarginLeft = 0;
            this.BtnGuardarViaje.IconMarginRight = 0;
            this.BtnGuardarViaje.IconRightVisible = true;
            this.BtnGuardarViaje.IconRightZoom = 0D;
            this.BtnGuardarViaje.IconVisible = true;
            this.BtnGuardarViaje.IconZoom = 100D;
            this.BtnGuardarViaje.IsTab = false;
            this.BtnGuardarViaje.Location = new System.Drawing.Point(630, 387);
            this.BtnGuardarViaje.Name = "BtnGuardarViaje";
            this.BtnGuardarViaje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarViaje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarViaje.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardarViaje.selected = false;
            this.BtnGuardarViaje.Size = new System.Drawing.Size(158, 50);
            this.BtnGuardarViaje.TabIndex = 79;
            this.BtnGuardarViaje.Text = "  GUARDAR";
            this.BtnGuardarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarViaje.Textcolor = System.Drawing.Color.White;
            this.BtnGuardarViaje.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarViaje.Click += new System.EventHandler(this.BtnGuardarViaje_Click);
            // 
            // BtnEliminarViaje
            // 
            this.BtnEliminarViaje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarViaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarViaje.BorderRadius = 7;
            this.BtnEliminarViaje.ButtonText = "  ELIMINAR";
            this.BtnEliminarViaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarViaje.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminarViaje.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarViaje.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarViaje.Iconimage")));
            this.BtnEliminarViaje.Iconimage_right = null;
            this.BtnEliminarViaje.Iconimage_right_Selected = null;
            this.BtnEliminarViaje.Iconimage_Selected = null;
            this.BtnEliminarViaje.IconMarginLeft = 0;
            this.BtnEliminarViaje.IconMarginRight = 0;
            this.BtnEliminarViaje.IconRightVisible = true;
            this.BtnEliminarViaje.IconRightZoom = 0D;
            this.BtnEliminarViaje.IconVisible = true;
            this.BtnEliminarViaje.IconZoom = 100D;
            this.BtnEliminarViaje.IsTab = false;
            this.BtnEliminarViaje.Location = new System.Drawing.Point(320, 388);
            this.BtnEliminarViaje.Name = "BtnEliminarViaje";
            this.BtnEliminarViaje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarViaje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarViaje.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminarViaje.selected = false;
            this.BtnEliminarViaje.Size = new System.Drawing.Size(158, 50);
            this.BtnEliminarViaje.TabIndex = 78;
            this.BtnEliminarViaje.Text = "  ELIMINAR";
            this.BtnEliminarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarViaje.Textcolor = System.Drawing.Color.White;
            this.BtnEliminarViaje.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarViaje.Click += new System.EventHandler(this.BtnEliminarViaje_Click);
            // 
            // BtnNuevoViaje
            // 
            this.BtnNuevoViaje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnNuevoViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoViaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevoViaje.BorderRadius = 7;
            this.BtnNuevoViaje.ButtonText = "  NUEVO";
            this.BtnNuevoViaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoViaje.DisabledColor = System.Drawing.Color.Gray;
            this.BtnNuevoViaje.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNuevoViaje.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnNuevoViaje.Iconimage")));
            this.BtnNuevoViaje.Iconimage_right = null;
            this.BtnNuevoViaje.Iconimage_right_Selected = null;
            this.BtnNuevoViaje.Iconimage_Selected = null;
            this.BtnNuevoViaje.IconMarginLeft = 0;
            this.BtnNuevoViaje.IconMarginRight = 0;
            this.BtnNuevoViaje.IconRightVisible = true;
            this.BtnNuevoViaje.IconRightZoom = 0D;
            this.BtnNuevoViaje.IconVisible = true;
            this.BtnNuevoViaje.IconZoom = 100D;
            this.BtnNuevoViaje.IsTab = false;
            this.BtnNuevoViaje.Location = new System.Drawing.Point(8, 387);
            this.BtnNuevoViaje.Name = "BtnNuevoViaje";
            this.BtnNuevoViaje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoViaje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoViaje.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnNuevoViaje.selected = false;
            this.BtnNuevoViaje.Size = new System.Drawing.Size(158, 50);
            this.BtnNuevoViaje.TabIndex = 76;
            this.BtnNuevoViaje.Text = "  NUEVO";
            this.BtnNuevoViaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoViaje.Textcolor = System.Drawing.Color.White;
            this.BtnNuevoViaje.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoViaje.Click += new System.EventHandler(this.BtnNuevoViaje_Click);
            // 
            // TxtBuscarViaje
            // 
            this.TxtBuscarViaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarViaje.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarViaje.Location = new System.Drawing.Point(60, 112);
            this.TxtBuscarViaje.Name = "TxtBuscarViaje";
            this.TxtBuscarViaje.Size = new System.Drawing.Size(570, 29);
            this.TxtBuscarViaje.TabIndex = 75;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-4, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(643, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-4, 102);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(804, 349);
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(645, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Chofer :";
            // 
            // CmbChofer
            // 
            this.CmbChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbChofer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbChofer.FormattingEnabled = true;
            this.CmbChofer.Location = new System.Drawing.Point(645, 197);
            this.CmbChofer.Name = "CmbChofer";
            this.CmbChofer.Size = new System.Drawing.Size(143, 21);
            this.CmbChofer.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(645, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "Autobus :";
            // 
            // CmbAutobus
            // 
            this.CmbAutobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbAutobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAutobus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbAutobus.FormattingEnabled = true;
            this.CmbAutobus.Location = new System.Drawing.Point(645, 270);
            this.CmbAutobus.Name = "CmbAutobus";
            this.CmbAutobus.Size = new System.Drawing.Size(143, 21);
            this.CmbAutobus.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(645, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 87;
            this.label4.Text = "Ruta :";
            // 
            // CmbRuta
            // 
            this.CmbRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbRuta.FormattingEnabled = true;
            this.CmbRuta.Location = new System.Drawing.Point(645, 338);
            this.CmbRuta.Name = "CmbRuta";
            this.CmbRuta.Size = new System.Drawing.Size(143, 21);
            this.CmbRuta.TabIndex = 88;
            // 
            // MovimientoPantalla
            // 
            this.MovimientoPantalla.Fixed = true;
            this.MovimientoPantalla.Horizontal = true;
            this.MovimientoPantalla.TargetControl = this.label1;
            this.MovimientoPantalla.Vertical = true;
            // 
            // BtnBienvenida
            // 
            this.BtnBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.BtnBienvenida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBienvenida.Image = ((System.Drawing.Image)(resources.GetObject("BtnBienvenida.Image")));
            this.BtnBienvenida.ImageActive = null;
            this.BtnBienvenida.Location = new System.Drawing.Point(0, -1);
            this.BtnBienvenida.Name = "BtnBienvenida";
            this.BtnBienvenida.Size = new System.Drawing.Size(173, 101);
            this.BtnBienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBienvenida.TabIndex = 91;
            this.BtnBienvenida.TabStop = false;
            this.BtnBienvenida.Zoom = 10;
            this.BtnBienvenida.Click += new System.EventHandler(this.BtnBienvenida_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 106);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(58, 46);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 94;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
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
            this.BtnAyuda.Location = new System.Drawing.Point(648, 59);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(44, 41);
            this.BtnAyuda.TabIndex = 92;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(697, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(103, 100);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 90;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuRange1
            // 
            this.bunifuRange1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRange1.BackgroudColor = System.Drawing.Color.Black;
            this.bunifuRange1.BorderRadius = 0;
            this.bunifuRange1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuRange1.Location = new System.Drawing.Point(10, 353);
            this.bunifuRange1.MaximumRange = 100;
            this.bunifuRange1.Name = "bunifuRange1";
            this.bunifuRange1.RangeMax = 49;
            this.bunifuRange1.RangeMin = 0;
            this.bunifuRange1.Size = new System.Drawing.Size(629, 30);
            this.bunifuRange1.TabIndex = 93;
            // 
            // FrmRegistroViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuRange1);
            this.Controls.Add(this.CmbRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbAutobus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbChofer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.TablaViajes);
            this.Controls.Add(this.BtnGuardarViaje);
            this.Controls.Add(this.BtnEliminarViaje);
            this.Controls.Add(this.BtnNuevoViaje);
            this.Controls.Add(this.TxtBuscarViaje);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroViajes";
            this.Text = "Registro De Viajes";
            this.Load += new System.EventHandler(this.FrmRegistroViajes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaViajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBienvenida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnImprimir;
        private System.Windows.Forms.DataGridView TablaViajes;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardarViaje;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminarViaje;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNuevoViaje;
        private System.Windows.Forms.TextBox TxtBuscarViaje;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbChofer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbAutobus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbRuta;
        private Bunifu.Framework.UI.BunifuDragControl MovimientoPantalla;
        private Bunifu.Framework.UI.BunifuImageButton BtnBienvenida;
        private Bunifu.Framework.UI.BunifuTileButton BtnAyuda;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuRange bunifuRange1;
    }
}