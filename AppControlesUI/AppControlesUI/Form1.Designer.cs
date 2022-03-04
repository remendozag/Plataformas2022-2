namespace AppControlesUI
{
    partial class FrmControles
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.chkGoogle = new System.Windows.Forms.CheckBox();
            this.chkOpera = new System.Windows.Forms.CheckBox();
            this.chkMicrosoft = new System.Windows.Forms.CheckBox();
            this.lblNavegador = new System.Windows.Forms.Label();
            this.rd800 = new System.Windows.Forms.RadioButton();
            this.rd1024 = new System.Windows.Forms.RadioButton();
            this.rd1280 = new System.Windows.Forms.RadioButton();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.cmbRojo = new System.Windows.Forms.ComboBox();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.cmbVerde = new System.Windows.Forms.ComboBox();
            this.lblAzul = new System.Windows.Forms.Label();
            this.cmbAzul = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnMostrarFechaNac = new System.Windows.Forms.Button();
            this.rtbBiografia = new System.Windows.Forms.RichTextBox();
            this.lblBiografia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Escriba su nombre";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(285, 247);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(88, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // chkGoogle
            // 
            this.chkGoogle.AutoSize = true;
            this.chkGoogle.Location = new System.Drawing.Point(36, 80);
            this.chkGoogle.Name = "chkGoogle";
            this.chkGoogle.Size = new System.Drawing.Size(99, 17);
            this.chkGoogle.TabIndex = 3;
            this.chkGoogle.Text = "Google Chrome";
            this.chkGoogle.UseVisualStyleBackColor = true;
            // 
            // chkOpera
            // 
            this.chkOpera.AutoSize = true;
            this.chkOpera.Location = new System.Drawing.Point(36, 104);
            this.chkOpera.Name = "chkOpera";
            this.chkOpera.Size = new System.Drawing.Size(55, 17);
            this.chkOpera.TabIndex = 4;
            this.chkOpera.Text = "Opera";
            this.chkOpera.UseVisualStyleBackColor = true;
            // 
            // chkMicrosoft
            // 
            this.chkMicrosoft.AutoSize = true;
            this.chkMicrosoft.Location = new System.Drawing.Point(36, 128);
            this.chkMicrosoft.Name = "chkMicrosoft";
            this.chkMicrosoft.Size = new System.Drawing.Size(97, 17);
            this.chkMicrosoft.TabIndex = 5;
            this.chkMicrosoft.Text = "Microsoft Edge";
            this.chkMicrosoft.UseVisualStyleBackColor = true;
            // 
            // lblNavegador
            // 
            this.lblNavegador.AutoSize = true;
            this.lblNavegador.Location = new System.Drawing.Point(36, 48);
            this.lblNavegador.Name = "lblNavegador";
            this.lblNavegador.Size = new System.Drawing.Size(101, 13);
            this.lblNavegador.TabIndex = 6;
            this.lblNavegador.Text = "Navegador favorito:";
            // 
            // rd800
            // 
            this.rd800.AutoSize = true;
            this.rd800.Location = new System.Drawing.Point(172, 80);
            this.rd800.Name = "rd800";
            this.rd800.Size = new System.Drawing.Size(72, 17);
            this.rd800.TabIndex = 7;
            this.rd800.TabStop = true;
            this.rd800.Text = "800 x 600";
            this.rd800.UseVisualStyleBackColor = true;
            // 
            // rd1024
            // 
            this.rd1024.AutoSize = true;
            this.rd1024.Location = new System.Drawing.Point(172, 104);
            this.rd1024.Name = "rd1024";
            this.rd1024.Size = new System.Drawing.Size(78, 17);
            this.rd1024.TabIndex = 8;
            this.rd1024.TabStop = true;
            this.rd1024.Text = "1024 x 768";
            this.rd1024.UseVisualStyleBackColor = true;
            // 
            // rd1280
            // 
            this.rd1280.AutoSize = true;
            this.rd1280.Location = new System.Drawing.Point(172, 128);
            this.rd1280.Name = "rd1280";
            this.rd1280.Size = new System.Drawing.Size(78, 17);
            this.rd1280.TabIndex = 9;
            this.rd1280.TabStop = true;
            this.rd1280.Text = "1280 x 720";
            this.rd1280.UseVisualStyleBackColor = true;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Location = new System.Drawing.Point(172, 48);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(63, 13);
            this.lblResolucion.TabIndex = 10;
            this.lblResolucion.Text = "Resolución:";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(381, 247);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(119, 23);
            this.btnCambiar.TabIndex = 11;
            this.btnCambiar.Text = "Cambiar Resolución";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // cmbRojo
            // 
            this.cmbRojo.FormattingEnabled = true;
            this.cmbRojo.Location = new System.Drawing.Point(94, 156);
            this.cmbRojo.Name = "cmbRojo";
            this.cmbRojo.Size = new System.Drawing.Size(77, 21);
            this.cmbRojo.TabIndex = 12;
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(29, 159);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(32, 13);
            this.lblRojo.TabIndex = 13;
            this.lblRojo.Text = "Rojo:";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(29, 188);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(38, 13);
            this.lblVerde.TabIndex = 14;
            this.lblVerde.Text = "Verde:";
            // 
            // cmbVerde
            // 
            this.cmbVerde.FormattingEnabled = true;
            this.cmbVerde.Location = new System.Drawing.Point(94, 184);
            this.cmbVerde.Name = "cmbVerde";
            this.cmbVerde.Size = new System.Drawing.Size(77, 21);
            this.cmbVerde.TabIndex = 15;
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(29, 213);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(30, 13);
            this.lblAzul.TabIndex = 16;
            this.lblAzul.Text = "Azul:";
            // 
            // cmbAzul
            // 
            this.cmbAzul.FormattingEnabled = true;
            this.cmbAzul.Location = new System.Drawing.Point(94, 213);
            this.cmbAzul.Name = "cmbAzul";
            this.cmbAzul.Size = new System.Drawing.Size(77, 21);
            this.cmbAzul.TabIndex = 17;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(285, 286);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(88, 23);
            this.btnColor.TabIndex = 18;
            this.btnColor.Text = "Cambiar Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // imgFoto
            // 
            this.imgFoto.Image = global::AppControlesUI.Properties.Resources.descarga;
            this.imgFoto.Location = new System.Drawing.Point(256, 15);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(244, 178);
            this.imgFoto.TabIndex = 19;
            this.imgFoto.TabStop = false;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(285, 199);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 20;
            // 
            // btnMostrarFechaNac
            // 
            this.btnMostrarFechaNac.Location = new System.Drawing.Point(381, 286);
            this.btnMostrarFechaNac.Name = "btnMostrarFechaNac";
            this.btnMostrarFechaNac.Size = new System.Drawing.Size(118, 23);
            this.btnMostrarFechaNac.TabIndex = 21;
            this.btnMostrarFechaNac.Text = "Mostrar Fecha";
            this.btnMostrarFechaNac.UseVisualStyleBackColor = true;
            this.btnMostrarFechaNac.Click += new System.EventHandler(this.btnMostrarFechaNac_Click);
            // 
            // rtbBiografia
            // 
            this.rtbBiografia.Location = new System.Drawing.Point(36, 263);
            this.rtbBiografia.Name = "rtbBiografia";
            this.rtbBiografia.Size = new System.Drawing.Size(208, 96);
            this.rtbBiografia.TabIndex = 22;
            this.rtbBiografia.Text = "";
            // 
            // lblBiografia
            // 
            this.lblBiografia.AutoSize = true;
            this.lblBiografia.Location = new System.Drawing.Point(36, 247);
            this.lblBiografia.Name = "lblBiografia";
            this.lblBiografia.Size = new System.Drawing.Size(53, 13);
            this.lblBiografia.TabIndex = 23;
            this.lblBiografia.Text = "Biografía:";
            // 
            // FrmControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 365);
            this.Controls.Add(this.lblBiografia);
            this.Controls.Add(this.rtbBiografia);
            this.Controls.Add(this.btnMostrarFechaNac);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.imgFoto);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cmbAzul);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.cmbVerde);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.cmbRojo);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.rd1280);
            this.Controls.Add(this.rd1024);
            this.Controls.Add(this.rd800);
            this.Controls.Add(this.lblNavegador);
            this.Controls.Add(this.chkMicrosoft);
            this.Controls.Add(this.chkOpera);
            this.Controls.Add(this.chkGoogle);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmControles";
            this.Text = "Controles UI";
            this.Load += new System.EventHandler(this.FrmControles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.CheckBox chkGoogle;
        private System.Windows.Forms.CheckBox chkOpera;
        private System.Windows.Forms.CheckBox chkMicrosoft;
        private System.Windows.Forms.Label lblNavegador;
        private System.Windows.Forms.RadioButton rd800;
        private System.Windows.Forms.RadioButton rd1024;
        private System.Windows.Forms.RadioButton rd1280;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.ComboBox cmbRojo;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.ComboBox cmbVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.ComboBox cmbAzul;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox imgFoto;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnMostrarFechaNac;
        private System.Windows.Forms.RichTextBox rtbBiografia;
        private System.Windows.Forms.Label lblBiografia;
    }
}

