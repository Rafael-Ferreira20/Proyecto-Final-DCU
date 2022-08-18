
namespace CAPA_PRESENTACION
{
    partial class FrmRegistroChoferes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroChoferes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicBoxVolver = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MovimientoPantalla = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtBuscarChofer = new System.Windows.Forms.TextBox();
            this.BtnGuardarChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminarChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEditarChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnNuevoChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TablaChoferes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnBienvenida = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnAyuda = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuRange1 = new Bunifu.Framework.UI.BunifuRange();
            this.TxtNombreChofer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtApellidoChofer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtFechaNacimiento = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtCedula = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBienvenida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.BtnAyuda);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.BtnBienvenida);
            this.panel1.Controls.Add(this.PicBoxVolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 109);
            this.panel1.TabIndex = 0;
            // 
            // PicBoxVolver
            // 
            this.PicBoxVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxVolver.Location = new System.Drawing.Point(701, 0);
            this.PicBoxVolver.Name = "PicBoxVolver";
            this.PicBoxVolver.Size = new System.Drawing.Size(100, 97);
            this.PicBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxVolver.TabIndex = 4;
            this.PicBoxVolver.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.label1.Font = new System.Drawing.Font("Oswald", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro De Choferes";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 103);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(804, 349);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // MovimientoPantalla
            // 
            this.MovimientoPantalla.Fixed = true;
            this.MovimientoPantalla.Horizontal = true;
            this.MovimientoPantalla.TargetControl = this.label1;
            this.MovimientoPantalla.Vertical = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(643, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // TxtBuscarChofer
            // 
            this.TxtBuscarChofer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarChofer.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarChofer.Location = new System.Drawing.Point(64, 115);
            this.TxtBuscarChofer.Name = "TxtBuscarChofer";
            this.TxtBuscarChofer.Size = new System.Drawing.Size(570, 29);
            this.TxtBuscarChofer.TabIndex = 5;
            // 
            // BtnGuardarChofer
            // 
            this.BtnGuardarChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardarChofer.BorderRadius = 7;
            this.BtnGuardarChofer.ButtonText = "  GUARDAR";
            this.BtnGuardarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarChofer.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardarChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardarChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardarChofer.Iconimage")));
            this.BtnGuardarChofer.Iconimage_right = null;
            this.BtnGuardarChofer.Iconimage_right_Selected = null;
            this.BtnGuardarChofer.Iconimage_Selected = null;
            this.BtnGuardarChofer.IconMarginLeft = 0;
            this.BtnGuardarChofer.IconMarginRight = 0;
            this.BtnGuardarChofer.IconRightVisible = true;
            this.BtnGuardarChofer.IconRightZoom = 0D;
            this.BtnGuardarChofer.IconVisible = true;
            this.BtnGuardarChofer.IconZoom = 100D;
            this.BtnGuardarChofer.IsTab = false;
            this.BtnGuardarChofer.Location = new System.Drawing.Point(634, 390);
            this.BtnGuardarChofer.Name = "BtnGuardarChofer";
            this.BtnGuardarChofer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarChofer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnGuardarChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardarChofer.selected = false;
            this.BtnGuardarChofer.Size = new System.Drawing.Size(158, 48);
            this.BtnGuardarChofer.TabIndex = 22;
            this.BtnGuardarChofer.Text = "  GUARDAR";
            this.BtnGuardarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarChofer.Textcolor = System.Drawing.Color.White;
            this.BtnGuardarChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarChofer.Click += new System.EventHandler(this.BtnGuardarChofer_Click);
            // 
            // BtnEliminarChofer
            // 
            this.BtnEliminarChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarChofer.BorderRadius = 7;
            this.BtnEliminarChofer.ButtonText = " ELIMINAR";
            this.BtnEliminarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarChofer.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminarChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarChofer.Iconimage")));
            this.BtnEliminarChofer.Iconimage_right = null;
            this.BtnEliminarChofer.Iconimage_right_Selected = null;
            this.BtnEliminarChofer.Iconimage_Selected = null;
            this.BtnEliminarChofer.IconMarginLeft = 0;
            this.BtnEliminarChofer.IconMarginRight = 0;
            this.BtnEliminarChofer.IconRightVisible = true;
            this.BtnEliminarChofer.IconRightZoom = 0D;
            this.BtnEliminarChofer.IconVisible = true;
            this.BtnEliminarChofer.IconZoom = 100D;
            this.BtnEliminarChofer.IsTab = false;
            this.BtnEliminarChofer.Location = new System.Drawing.Point(429, 390);
            this.BtnEliminarChofer.Name = "BtnEliminarChofer";
            this.BtnEliminarChofer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarChofer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEliminarChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminarChofer.selected = false;
            this.BtnEliminarChofer.Size = new System.Drawing.Size(158, 48);
            this.BtnEliminarChofer.TabIndex = 21;
            this.BtnEliminarChofer.Text = " ELIMINAR";
            this.BtnEliminarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarChofer.Textcolor = System.Drawing.Color.White;
            this.BtnEliminarChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarChofer.Click += new System.EventHandler(this.BtnEliminarChofer_Click);
            // 
            // BtnEditarChofer
            // 
            this.BtnEditarChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEditarChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditarChofer.BorderRadius = 7;
            this.BtnEditarChofer.ButtonText = "   EDITAR";
            this.BtnEditarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarChofer.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditarChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditarChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditarChofer.Iconimage")));
            this.BtnEditarChofer.Iconimage_right = null;
            this.BtnEditarChofer.Iconimage_right_Selected = null;
            this.BtnEditarChofer.Iconimage_Selected = null;
            this.BtnEditarChofer.IconMarginLeft = 0;
            this.BtnEditarChofer.IconMarginRight = 0;
            this.BtnEditarChofer.IconRightVisible = true;
            this.BtnEditarChofer.IconRightZoom = 0D;
            this.BtnEditarChofer.IconVisible = true;
            this.BtnEditarChofer.IconZoom = 100D;
            this.BtnEditarChofer.IsTab = false;
            this.BtnEditarChofer.Location = new System.Drawing.Point(215, 390);
            this.BtnEditarChofer.Name = "BtnEditarChofer";
            this.BtnEditarChofer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEditarChofer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnEditarChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditarChofer.selected = false;
            this.BtnEditarChofer.Size = new System.Drawing.Size(158, 48);
            this.BtnEditarChofer.TabIndex = 20;
            this.BtnEditarChofer.Text = "   EDITAR";
            this.BtnEditarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarChofer.Textcolor = System.Drawing.Color.White;
            this.BtnEditarChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarChofer.Click += new System.EventHandler(this.BtnEditarChofer_Click);
            // 
            // BtnNuevoChofer
            // 
            this.BtnNuevoChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnNuevoChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevoChofer.BorderRadius = 7;
            this.BtnNuevoChofer.ButtonText = "   NUEVO";
            this.BtnNuevoChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoChofer.DisabledColor = System.Drawing.Color.Gray;
            this.BtnNuevoChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNuevoChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnNuevoChofer.Iconimage")));
            this.BtnNuevoChofer.Iconimage_right = null;
            this.BtnNuevoChofer.Iconimage_right_Selected = null;
            this.BtnNuevoChofer.Iconimage_Selected = null;
            this.BtnNuevoChofer.IconMarginLeft = 0;
            this.BtnNuevoChofer.IconMarginRight = 0;
            this.BtnNuevoChofer.IconRightVisible = true;
            this.BtnNuevoChofer.IconRightZoom = 0D;
            this.BtnNuevoChofer.IconVisible = true;
            this.BtnNuevoChofer.IconZoom = 100D;
            this.BtnNuevoChofer.IsTab = false;
            this.BtnNuevoChofer.Location = new System.Drawing.Point(12, 390);
            this.BtnNuevoChofer.Name = "BtnNuevoChofer";
            this.BtnNuevoChofer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoChofer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnNuevoChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnNuevoChofer.selected = false;
            this.BtnNuevoChofer.Size = new System.Drawing.Size(158, 48);
            this.BtnNuevoChofer.TabIndex = 19;
            this.BtnNuevoChofer.Text = "   NUEVO";
            this.BtnNuevoChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoChofer.Textcolor = System.Drawing.Color.White;
            this.BtnNuevoChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoChofer.Click += new System.EventHandler(this.BtnNuevoChofer_Click);
            // 
            // TablaChoferes
            // 
            this.TablaChoferes.AllowUserToAddRows = false;
            this.TablaChoferes.AllowUserToDeleteRows = false;
            this.TablaChoferes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaChoferes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaChoferes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TablaChoferes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaChoferes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TablaChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaChoferes.Location = new System.Drawing.Point(12, 159);
            this.TablaChoferes.Name = "TablaChoferes";
            this.TablaChoferes.ReadOnly = true;
            this.TablaChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaChoferes.Size = new System.Drawing.Size(631, 225);
            this.TablaChoferes.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(649, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Apellido :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(649, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nombre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(649, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cedula :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(649, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Fecha Nacimiento :";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImprimir.BorderRadius = 7;
            this.BtnImprimir.ButtonText = "IMPRIMIR";
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
            this.BtnImprimir.Location = new System.Drawing.Point(649, 106);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnImprimir.selected = false;
            this.BtnImprimir.Size = new System.Drawing.Size(143, 47);
            this.BtnImprimir.TabIndex = 51;
            this.BtnImprimir.Text = "IMPRIMIR";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Textcolor = System.Drawing.Color.White;
            this.BtnImprimir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnBienvenida
            // 
            this.BtnBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.BtnBienvenida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBienvenida.Image = ((System.Drawing.Image)(resources.GetObject("BtnBienvenida.Image")));
            this.BtnBienvenida.ImageActive = null;
            this.BtnBienvenida.Location = new System.Drawing.Point(0, 0);
            this.BtnBienvenida.Name = "BtnBienvenida";
            this.BtnBienvenida.Size = new System.Drawing.Size(170, 101);
            this.BtnBienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBienvenida.TabIndex = 79;
            this.BtnBienvenida.TabStop = false;
            this.BtnBienvenida.Zoom = 10;
            this.BtnBienvenida.Click += new System.EventHandler(this.BtnBienvenida_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(701, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(103, 100);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 79;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.BtnAyuda.Location = new System.Drawing.Point(651, 55);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(44, 41);
            this.BtnAyuda.TabIndex = 80;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 107);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(58, 46);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 81;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuRange1
            // 
            this.bunifuRange1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRange1.BackgroudColor = System.Drawing.Color.Black;
            this.bunifuRange1.BorderRadius = 0;
            this.bunifuRange1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuRange1.Location = new System.Drawing.Point(13, 354);
            this.bunifuRange1.MaximumRange = 100;
            this.bunifuRange1.Name = "bunifuRange1";
            this.bunifuRange1.RangeMax = 49;
            this.bunifuRange1.RangeMin = 0;
            this.bunifuRange1.Size = new System.Drawing.Size(628, 30);
            this.bunifuRange1.TabIndex = 81;
            // 
            // TxtNombreChofer
            // 
            this.TxtNombreChofer.BackColor = System.Drawing.Color.White;
            this.TxtNombreChofer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtNombreChofer.BorderColorIdle = System.Drawing.Color.Black;
            this.TxtNombreChofer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtNombreChofer.BorderThickness = 3;
            this.TxtNombreChofer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreChofer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNombreChofer.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreChofer.isPassword = false;
            this.TxtNombreChofer.Location = new System.Drawing.Point(649, 181);
            this.TxtNombreChofer.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreChofer.Name = "TxtNombreChofer";
            this.TxtNombreChofer.Size = new System.Drawing.Size(143, 25);
            this.TxtNombreChofer.TabIndex = 82;
            this.TxtNombreChofer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtApellidoChofer
            // 
            this.TxtApellidoChofer.BackColor = System.Drawing.Color.White;
            this.TxtApellidoChofer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtApellidoChofer.BorderColorIdle = System.Drawing.Color.Black;
            this.TxtApellidoChofer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtApellidoChofer.BorderThickness = 3;
            this.TxtApellidoChofer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApellidoChofer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtApellidoChofer.ForeColor = System.Drawing.Color.Black;
            this.TxtApellidoChofer.isPassword = false;
            this.TxtApellidoChofer.Location = new System.Drawing.Point(649, 233);
            this.TxtApellidoChofer.Margin = new System.Windows.Forms.Padding(4);
            this.TxtApellidoChofer.Name = "TxtApellidoChofer";
            this.TxtApellidoChofer.Size = new System.Drawing.Size(143, 25);
            this.TxtApellidoChofer.TabIndex = 83;
            this.TxtApellidoChofer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtFechaNacimiento
            // 
            this.TxtFechaNacimiento.BackColor = System.Drawing.Color.White;
            this.TxtFechaNacimiento.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtFechaNacimiento.BorderColorIdle = System.Drawing.Color.Black;
            this.TxtFechaNacimiento.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtFechaNacimiento.BorderThickness = 3;
            this.TxtFechaNacimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.TxtFechaNacimiento.isPassword = false;
            this.TxtFechaNacimiento.Location = new System.Drawing.Point(649, 283);
            this.TxtFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFechaNacimiento.Name = "TxtFechaNacimiento";
            this.TxtFechaNacimiento.Size = new System.Drawing.Size(143, 25);
            this.TxtFechaNacimiento.TabIndex = 84;
            this.TxtFechaNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.Color.White;
            this.TxtCedula.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtCedula.BorderColorIdle = System.Drawing.Color.Black;
            this.TxtCedula.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.TxtCedula.BorderThickness = 3;
            this.TxtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCedula.ForeColor = System.Drawing.Color.Black;
            this.TxtCedula.isPassword = false;
            this.TxtCedula.Location = new System.Drawing.Point(648, 332);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(143, 25);
            this.TxtCedula.TabIndex = 85;
            this.TxtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FrmRegistroChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtFechaNacimiento);
            this.Controls.Add(this.TxtApellidoChofer);
            this.Controls.Add(this.TxtNombreChofer);
            this.Controls.Add(this.bunifuRange1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TablaChoferes);
            this.Controls.Add(this.BtnGuardarChofer);
            this.Controls.Add(this.BtnEliminarChofer);
            this.Controls.Add(this.BtnEditarChofer);
            this.Controls.Add(this.BtnNuevoChofer);
            this.Controls.Add(this.TxtBuscarChofer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroChoferes";
            this.Text = "Registro de Choferes";
            this.Load += new System.EventHandler(this.FrmRegistroChoferes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBienvenida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicBoxVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuDragControl MovimientoPantalla;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtBuscarChofer;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardarChofer;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminarChofer;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditarChofer;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNuevoChofer;
        private System.Windows.Forms.DataGridView TablaChoferes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton BtnImprimir;
        private Bunifu.Framework.UI.BunifuImageButton BtnBienvenida;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuTileButton BtnAyuda;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuRange bunifuRange1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtNombreChofer;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtApellidoChofer;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtFechaNacimiento;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtCedula;
    }
}