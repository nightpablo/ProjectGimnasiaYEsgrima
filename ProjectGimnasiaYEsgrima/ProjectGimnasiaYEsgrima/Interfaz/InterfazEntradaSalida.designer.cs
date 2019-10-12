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
            this.lblTipo = new System.Windows.Forms.Label();
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
            this.vspEntradaSalida.Location = new System.Drawing.Point(12, 52);
            this.vspEntradaSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vspEntradaSalida.Name = "vspEntradaSalida";
            this.vspEntradaSalida.Size = new System.Drawing.Size(252, 273);
            this.vspEntradaSalida.TabIndex = 0;
            this.vspEntradaSalida.Text = "videoSourcePlayer1";
            this.vspEntradaSalida.VideoSource = null;
            this.vspEntradaSalida.Click += new System.EventHandler(this.vspEntradaSalida_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.btnIniciar.Location = new System.Drawing.Point(12, 338);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(96, 46);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.btnParar.Location = new System.Drawing.Point(12, 390);
            this.btnParar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(96, 46);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.btnVolver.Location = new System.Drawing.Point(120, 390);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 46);
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
            this.cbxSeleccionDipositivos.Location = new System.Drawing.Point(120, 344);
            this.cbxSeleccionDipositivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSeleccionDipositivos.Name = "cbxSeleccionDipositivos";
            this.cbxSeleccionDipositivos.Size = new System.Drawing.Size(121, 30);
            this.cbxSeleccionDipositivos.TabIndex = 4;
            // 
            // tmpCapture
            // 
            this.tmpCapture.Tick += new System.EventHandler(this.tmpCapture_Tick);
            // 
            // pnlDatosPersona
            // 
            this.pnlDatosPersona.Controls.Add(this.lblTipo);
            this.pnlDatosPersona.Controls.Add(this.pnlFoto);
            this.pnlDatosPersona.Controls.Add(this.lblContador);
            this.pnlDatosPersona.Controls.Add(this.txtFechaIngreso);
            this.pnlDatosPersona.Controls.Add(this.lblFechaIngreso);
            this.pnlDatosPersona.Controls.Add(this.txtTipoDoc);
            this.pnlDatosPersona.Controls.Add(this.lblTipoDocumentoYNro);
            this.pnlDatosPersona.Controls.Add(this.txtNombreApellido);
            this.pnlDatosPersona.Controls.Add(this.lblNombreApellido);
            this.pnlDatosPersona.Location = new System.Drawing.Point(270, 52);
            this.pnlDatosPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDatosPersona.Name = "pnlDatosPersona";
            this.pnlDatosPersona.Size = new System.Drawing.Size(324, 403);
            this.pnlDatosPersona.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(6, 228);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(230, 21);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "TipoEmpleadoOCategoria";
            // 
            // pnlFoto
            // 
            this.pnlFoto.Location = new System.Drawing.Point(150, 228);
            this.pnlFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(168, 169);
            this.pnlFoto.TabIndex = 4;
            this.pnlFoto.TabStop = false;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblContador.Location = new System.Drawing.Point(48, 286);
            this.lblContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(66, 49);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "00";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.txtFechaIngreso.Location = new System.Drawing.Point(12, 188);
            this.txtFechaIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(301, 31);
            this.txtFechaIngreso.TabIndex = 1;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(12, 156);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(140, 22);
            this.lblFechaIngreso.TabIndex = 0;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.txtTipoDoc.Location = new System.Drawing.Point(12, 117);
            this.txtTipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(301, 31);
            this.txtTipoDoc.TabIndex = 1;
            // 
            // lblTipoDocumentoYNro
            // 
            this.lblTipoDocumentoYNro.AutoSize = true;
            this.lblTipoDocumentoYNro.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumentoYNro.Location = new System.Drawing.Point(12, 84);
            this.lblTipoDocumentoYNro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDocumentoYNro.Name = "lblTipoDocumentoYNro";
            this.lblTipoDocumentoYNro.Size = new System.Drawing.Size(233, 22);
            this.lblTipoDocumentoYNro.TabIndex = 0;
            this.lblTipoDocumentoYNro.Text = "Tipo de Documento y Nº";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.txtNombreApellido.Location = new System.Drawing.Point(12, 46);
            this.txtNombreApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(301, 31);
            this.txtNombreApellido.TabIndex = 1;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(12, 13);
            this.lblNombreApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(179, 22);
            this.lblNombreApellido.TabIndex = 0;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // lblTituloEntradaSalida
            // 
            this.lblTituloEntradaSalida.AutoSize = true;
            this.lblTituloEntradaSalida.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEntradaSalida.Location = new System.Drawing.Point(66, 13);
            this.lblTituloEntradaSalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloEntradaSalida.Name = "lblTituloEntradaSalida";
            this.lblTituloEntradaSalida.Size = new System.Drawing.Size(146, 22);
            this.lblTituloEntradaSalida.TabIndex = 0;
            this.lblTituloEntradaSalida.Text = "Entrada/Salida";
            // 
            // InterfazEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 462);
            this.Controls.Add(this.pnlDatosPersona);
            this.Controls.Add(this.cbxSeleccionDipositivos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTituloEntradaSalida);
            this.Controls.Add(this.vspEntradaSalida);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InterfazEntradaSalida";
            this.Text = "InterfazEntradaSalida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfazEntradaSalida_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfazEntradaSalida_FormClosing);
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
        private System.Windows.Forms.Label lblTipo;
    }
}