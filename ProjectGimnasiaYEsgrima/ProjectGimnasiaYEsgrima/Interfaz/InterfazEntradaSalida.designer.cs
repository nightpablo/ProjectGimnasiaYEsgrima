namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazEntradaSalida
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
            this.vspEntradaSalida = new AForge.Controls.VideoSourcePlayer();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbxSeleccionDipositivos = new System.Windows.Forms.ComboBox();
            this.tmpCapture = new System.Windows.Forms.Timer(this.components);
            this.pnlDatosPersona = new System.Windows.Forms.Panel();
            this.pnlFoto = new System.Windows.Forms.PictureBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.lblTipoDocumentoYNro = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblTituloEntradaSalida = new System.Windows.Forms.Label();
            this.pnlDatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // vspEntradaSalida
            // 
            this.vspEntradaSalida.Location = new System.Drawing.Point(16, 64);
            this.vspEntradaSalida.Name = "vspEntradaSalida";
            this.vspEntradaSalida.Size = new System.Drawing.Size(336, 336);
            this.vspEntradaSalida.TabIndex = 0;
            this.vspEntradaSalida.Text = "videoSourcePlayer1";
            this.vspEntradaSalida.VideoSource = null;
            this.vspEntradaSalida.Click += new System.EventHandler(this.vspEntradaSalida_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.btnIniciar.Location = new System.Drawing.Point(16, 416);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(128, 56);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.btnParar.Location = new System.Drawing.Point(16, 480);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(128, 56);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.btnVolver.Location = new System.Drawing.Point(160, 480);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 56);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbxSeleccionDipositivos
            // 
            this.cbxSeleccionDipositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeleccionDipositivos.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.cbxSeleccionDipositivos.FormattingEnabled = true;
            this.cbxSeleccionDipositivos.Location = new System.Drawing.Point(160, 424);
            this.cbxSeleccionDipositivos.Name = "cbxSeleccionDipositivos";
            this.cbxSeleccionDipositivos.Size = new System.Drawing.Size(160, 38);
            this.cbxSeleccionDipositivos.TabIndex = 4;
            // 
            // tmpCapture
            // 
            this.tmpCapture.Tick += new System.EventHandler(this.tmpCapture_Tick);
            // 
            // pnlDatosPersona
            // 
            this.pnlDatosPersona.Controls.Add(this.pnlFoto);
            this.pnlDatosPersona.Controls.Add(this.lblContador);
            this.pnlDatosPersona.Controls.Add(this.txtFechaIngreso);
            this.pnlDatosPersona.Controls.Add(this.lblFechaIngreso);
            this.pnlDatosPersona.Controls.Add(this.txtTipoDoc);
            this.pnlDatosPersona.Controls.Add(this.lblTipoDocumentoYNro);
            this.pnlDatosPersona.Controls.Add(this.txtNombreApellido);
            this.pnlDatosPersona.Controls.Add(this.lblNombreApellido);
            this.pnlDatosPersona.Location = new System.Drawing.Point(360, 64);
            this.pnlDatosPersona.Name = "pnlDatosPersona";
            this.pnlDatosPersona.Size = new System.Drawing.Size(432, 496);
            this.pnlDatosPersona.TabIndex = 4;
            // 
            // pnlFoto
            // 
            this.pnlFoto.Image = global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil;
            this.pnlFoto.Location = new System.Drawing.Point(200, 280);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(224, 208);
            this.pnlFoto.TabIndex = 4;
            this.pnlFoto.TabStop = false;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblContador.Location = new System.Drawing.Point(64, 352);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(83, 61);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "00";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.txtFechaIngreso.Location = new System.Drawing.Point(16, 232);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(400, 37);
            this.txtFechaIngreso.TabIndex = 1;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(16, 192);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(181, 30);
            this.lblFechaIngreso.TabIndex = 0;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.txtTipoDoc.Location = new System.Drawing.Point(16, 144);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(400, 37);
            this.txtTipoDoc.TabIndex = 1;
            // 
            // lblTipoDocumentoYNro
            // 
            this.lblTipoDocumentoYNro.AutoSize = true;
            this.lblTipoDocumentoYNro.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumentoYNro.Location = new System.Drawing.Point(16, 104);
            this.lblTipoDocumentoYNro.Name = "lblTipoDocumentoYNro";
            this.lblTipoDocumentoYNro.Size = new System.Drawing.Size(306, 30);
            this.lblTipoDocumentoYNro.TabIndex = 0;
            this.lblTipoDocumentoYNro.Text = "Tipo de Documento y Nº";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.txtNombreApellido.Location = new System.Drawing.Point(16, 56);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(400, 37);
            this.txtNombreApellido.TabIndex = 1;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(16, 16);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(236, 30);
            this.lblNombreApellido.TabIndex = 0;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // lblTituloEntradaSalida
            // 
            this.lblTituloEntradaSalida.AutoSize = true;
            this.lblTituloEntradaSalida.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEntradaSalida.Location = new System.Drawing.Point(88, 16);
            this.lblTituloEntradaSalida.Name = "lblTituloEntradaSalida";
            this.lblTituloEntradaSalida.Size = new System.Drawing.Size(186, 30);
            this.lblTituloEntradaSalida.TabIndex = 0;
            this.lblTituloEntradaSalida.Text = "Entrada/Salida";
            // 
            // InterfazEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.pnlDatosPersona);
            this.Controls.Add(this.cbxSeleccionDipositivos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTituloEntradaSalida);
            this.Controls.Add(this.vspEntradaSalida);
            this.Name = "InterfazEntradaSalida";
            this.Text = "InterfazEntradaSalida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfazEntradaSalida_FormClosing);
            this.Load += new System.EventHandler(this.InterfazEntradaSalida_Load);
            this.pnlDatosPersona.ResumeLayout(false);
            this.pnlDatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer vspEntradaSalida;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbxSeleccionDipositivos;
        private System.Windows.Forms.Timer tmpCapture;
        private System.Windows.Forms.Panel pnlDatosPersona;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label lblTipoDocumentoYNro;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblTituloEntradaSalida;
        private System.Windows.Forms.PictureBox pnlFoto;
    }
}