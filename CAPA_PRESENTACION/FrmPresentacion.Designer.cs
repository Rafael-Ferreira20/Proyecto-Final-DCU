
namespace CAPA_PRESENTACION
{
    partial class FrmPresentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresentacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBienvenida = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnChoferes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRutas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAutobuses = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnViajes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MovimientoPantalla = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnAyuda = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBienvenida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.bunifuImageButton5);
            this.panel1.Controls.Add(this.BtnBienvenida);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 104);
            this.panel1.TabIndex = 0;
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
            this.BtnBienvenida.TabIndex = 6;
            this.BtnBienvenida.TabStop = false;
            this.BtnBienvenida.Zoom = 10;
            this.BtnBienvenida.Click += new System.EventHandler(this.BtnBienvenida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema Control De Autobuses";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(776, 330);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // BtnChoferes
            // 
            this.BtnChoferes.Activecolor = System.Drawing.Color.Green;
            this.BtnChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnChoferes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnChoferes.BorderRadius = 7;
            this.BtnChoferes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnChoferes.ButtonText = "Registro Choferes";
            this.BtnChoferes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChoferes.DisabledColor = System.Drawing.Color.Gray;
            this.BtnChoferes.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnChoferes.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnChoferes.Iconimage")));
            this.BtnChoferes.Iconimage_right = null;
            this.BtnChoferes.Iconimage_right_Selected = null;
            this.BtnChoferes.Iconimage_Selected = null;
            this.BtnChoferes.IconMarginLeft = 0;
            this.BtnChoferes.IconMarginRight = 0;
            this.BtnChoferes.IconRightVisible = true;
            this.BtnChoferes.IconRightZoom = 0D;
            this.BtnChoferes.IconVisible = true;
            this.BtnChoferes.IconZoom = 90D;
            this.BtnChoferes.IsTab = false;
            this.BtnChoferes.Location = new System.Drawing.Point(28, 138);
            this.BtnChoferes.Name = "BtnChoferes";
            this.BtnChoferes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnChoferes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnChoferes.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnChoferes.selected = false;
            this.BtnChoferes.Size = new System.Drawing.Size(202, 102);
            this.BtnChoferes.TabIndex = 2;
            this.BtnChoferes.Text = "Registro Choferes";
            this.BtnChoferes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnChoferes.Textcolor = System.Drawing.Color.White;
            this.BtnChoferes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChoferes.Click += new System.EventHandler(this.BtnChoferes_Click);
            // 
            // BtnRutas
            // 
            this.BtnRutas.Activecolor = System.Drawing.Color.Green;
            this.BtnRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnRutas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRutas.BorderRadius = 7;
            this.BtnRutas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnRutas.ButtonText = "Registro Rutas";
            this.BtnRutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRutas.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRutas.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRutas.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRutas.Iconimage")));
            this.BtnRutas.Iconimage_right = null;
            this.BtnRutas.Iconimage_right_Selected = null;
            this.BtnRutas.Iconimage_Selected = null;
            this.BtnRutas.IconMarginLeft = 0;
            this.BtnRutas.IconMarginRight = 0;
            this.BtnRutas.IconRightVisible = true;
            this.BtnRutas.IconRightZoom = 0D;
            this.BtnRutas.IconVisible = true;
            this.BtnRutas.IconZoom = 90D;
            this.BtnRutas.IsTab = false;
            this.BtnRutas.Location = new System.Drawing.Point(259, 138);
            this.BtnRutas.Name = "BtnRutas";
            this.BtnRutas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnRutas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnRutas.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnRutas.selected = false;
            this.BtnRutas.Size = new System.Drawing.Size(202, 102);
            this.BtnRutas.TabIndex = 3;
            this.BtnRutas.Text = "Registro Rutas";
            this.BtnRutas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRutas.Textcolor = System.Drawing.Color.White;
            this.BtnRutas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRutas.Click += new System.EventHandler(this.BtnRutas_Click);
            // 
            // BtnAutobuses
            // 
            this.BtnAutobuses.Activecolor = System.Drawing.Color.Green;
            this.BtnAutobuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnAutobuses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAutobuses.BorderRadius = 7;
            this.BtnAutobuses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnAutobuses.ButtonText = " Registro Autobuses";
            this.BtnAutobuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAutobuses.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAutobuses.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAutobuses.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAutobuses.Iconimage")));
            this.BtnAutobuses.Iconimage_right = null;
            this.BtnAutobuses.Iconimage_right_Selected = null;
            this.BtnAutobuses.Iconimage_Selected = null;
            this.BtnAutobuses.IconMarginLeft = 0;
            this.BtnAutobuses.IconMarginRight = 0;
            this.BtnAutobuses.IconRightVisible = true;
            this.BtnAutobuses.IconRightZoom = 0D;
            this.BtnAutobuses.IconVisible = true;
            this.BtnAutobuses.IconZoom = 90D;
            this.BtnAutobuses.IsTab = false;
            this.BtnAutobuses.Location = new System.Drawing.Point(487, 138);
            this.BtnAutobuses.Name = "BtnAutobuses";
            this.BtnAutobuses.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnAutobuses.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnAutobuses.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAutobuses.selected = false;
            this.BtnAutobuses.Size = new System.Drawing.Size(202, 102);
            this.BtnAutobuses.TabIndex = 4;
            this.BtnAutobuses.Text = " Registro Autobuses";
            this.BtnAutobuses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAutobuses.Textcolor = System.Drawing.Color.White;
            this.BtnAutobuses.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutobuses.Click += new System.EventHandler(this.BtnAutobuses_Click);
            // 
            // BtnViajes
            // 
            this.BtnViajes.Activecolor = System.Drawing.Color.Green;
            this.BtnViajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnViajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnViajes.BorderRadius = 7;
            this.BtnViajes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnViajes.ButtonText = "    Registro Viajes";
            this.BtnViajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViajes.DisabledColor = System.Drawing.Color.Gray;
            this.BtnViajes.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnViajes.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnViajes.Iconimage")));
            this.BtnViajes.Iconimage_right = null;
            this.BtnViajes.Iconimage_right_Selected = null;
            this.BtnViajes.Iconimage_Selected = null;
            this.BtnViajes.IconMarginLeft = 0;
            this.BtnViajes.IconMarginRight = 0;
            this.BtnViajes.IconRightVisible = true;
            this.BtnViajes.IconRightZoom = 0D;
            this.BtnViajes.IconVisible = true;
            this.BtnViajes.IconZoom = 90D;
            this.BtnViajes.IsTab = false;
            this.BtnViajes.Location = new System.Drawing.Point(225, 297);
            this.BtnViajes.Name = "BtnViajes";
            this.BtnViajes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnViajes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnViajes.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnViajes.selected = false;
            this.BtnViajes.Size = new System.Drawing.Size(271, 102);
            this.BtnViajes.TabIndex = 5;
            this.BtnViajes.Text = "    Registro Viajes";
            this.BtnViajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnViajes.Textcolor = System.Drawing.Color.White;
            this.BtnViajes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViajes.Click += new System.EventHandler(this.BtnViajes_Click);
            // 
            // MovimientoPantalla
            // 
            this.MovimientoPantalla.Fixed = true;
            this.MovimientoPantalla.Horizontal = true;
            this.MovimientoPantalla.TargetControl = this.label1;
            this.MovimientoPantalla.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(37, 160);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(65, 63);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(269, 160);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(65, 63);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(497, 160);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(65, 63);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 8;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(244, 315);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(65, 63);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton4.TabIndex = 9;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(78)))));
            this.bunifuImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(612, 0);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(89, 101);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton5.TabIndex = 10;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnAyuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnAyuda.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(163)))));
            this.BtnAyuda.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.BtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAyuda.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.White;
            this.BtnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyuda.Image")));
            this.BtnAyuda.ImagePosition = 10;
            this.BtnAyuda.ImageZoom = 50;
            this.BtnAyuda.LabelPosition = 0;
            this.BtnAyuda.LabelText = "Centro de Ayuda";
            this.BtnAyuda.Location = new System.Drawing.Point(15, 346);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(87, 65);
            this.BtnAyuda.TabIndex = 10;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FrmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 426);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.BtnViajes);
            this.Controls.Add(this.BtnAutobuses);
            this.Controls.Add(this.BtnRutas);
            this.Controls.Add(this.BtnChoferes);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPresentacion";
            this.Text = "Sistema Control de Autobuses";
            this.Load += new System.EventHandler(this.FrmPresentacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBienvenida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuFlatButton BtnChoferes;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRutas;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAutobuses;
        private Bunifu.Framework.UI.BunifuFlatButton BtnViajes;
        private Bunifu.Framework.UI.BunifuDragControl MovimientoPantalla;
        private Bunifu.Framework.UI.BunifuImageButton BtnBienvenida;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuTileButton BtnAyuda;
    }
}

