namespace Proyecto_Integrador_Grupo_11_B
{
    partial class SistemaClub
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
            header = new Panel();
            lblTitulo = new Label();
            cardRegistro = new GroupBox();
            carnetSocioButton = new Button();
            imgAltaSocio = new PictureBox();
            RegistrarNoSocio = new Button();
            RegistrarSocio = new Button();
            cardVencimientos = new GroupBox();
            pbIconDeudores = new PictureBox();
            MostrarVencimientoCuotaSocio = new Button();
            cardCuotas = new GroupBox();
            pbIconCuotas = new PictureBox();
            CobrarCuota = new Button();
            cardActividad = new GroupBox();
            pbIconActividad = new PictureBox();
            CobrarActividad = new Button();
            SalirSistema = new Button();
            alertaVencimientosLabel = new Label();
            cardAlertaVencimientos = new GroupBox();
            actualizarButton = new Button();
            actualizarToolTip = new ToolTip();
            header.SuspendLayout();
            cardRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).BeginInit();
            cardVencimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIconDeudores).BeginInit();
            cardCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIconCuotas).BeginInit();
            cardActividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIconActividad).BeginInit();
            cardAlertaVencimientos.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(74, 141, 248);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1218, 64);
            header.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1218, 64);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema del Club";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardRegistro
            // 
            cardRegistro.BackColor = Color.FromArgb(232, 239, 249);
            cardRegistro.Controls.Add(carnetSocioButton);
            cardRegistro.Controls.Add(imgAltaSocio);
            cardRegistro.Controls.Add(RegistrarNoSocio);
            cardRegistro.Controls.Add(RegistrarSocio);
            cardRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cardRegistro.ForeColor = Color.FromArgb(31, 31, 31);
            cardRegistro.Location = new Point(27, 91);
            cardRegistro.Name = "cardRegistro";
            cardRegistro.Padding = new Padding(18, 16, 18, 21);
            cardRegistro.Size = new Size(251, 400);
            cardRegistro.TabIndex = 1;
            cardRegistro.TabStop = false;
            cardRegistro.Text = "Registro";
            // 
            // carnetSocioButton
            // 
            carnetSocioButton.BackColor = Color.FromArgb(138, 194, 133);
            carnetSocioButton.FlatAppearance.BorderSize = 0;
            carnetSocioButton.FlatStyle = FlatStyle.Flat;
            carnetSocioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            carnetSocioButton.ForeColor = Color.White;
            carnetSocioButton.Location = new Point(24, 262);
            carnetSocioButton.Name = "carnetSocioButton";
            carnetSocioButton.Size = new Size(206, 59);
            carnetSocioButton.TabIndex = 3;
            carnetSocioButton.Text = "Carnet socio";
            carnetSocioButton.UseVisualStyleBackColor = false;
            carnetSocioButton.Click += CarnetSocioButton_Click;
            // 
            // imgAltaSocio
            // 
            imgAltaSocio.BorderStyle = BorderStyle.FixedSingle;
            imgAltaSocio.Image = Properties.Resources.AltaSocio;
            imgAltaSocio.Location = new Point(46, 41);
            imgAltaSocio.Name = "imgAltaSocio";
            imgAltaSocio.Size = new Size(165, 148);
            imgAltaSocio.SizeMode = PictureBoxSizeMode.Zoom;
            imgAltaSocio.TabIndex = 2;
            imgAltaSocio.TabStop = false;
            // 
            // RegistrarNoSocio
            // 
            RegistrarNoSocio.BackColor = Color.FromArgb(138, 194, 133);
            RegistrarNoSocio.FlatAppearance.BorderSize = 0;
            RegistrarNoSocio.FlatStyle = FlatStyle.Flat;
            RegistrarNoSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegistrarNoSocio.ForeColor = Color.White;
            RegistrarNoSocio.Location = new Point(24, 327);
            RegistrarNoSocio.Name = "RegistrarNoSocio";
            RegistrarNoSocio.Size = new Size(206, 59);
            RegistrarNoSocio.TabIndex = 1;
            RegistrarNoSocio.Text = "Registrar no socio";
            RegistrarNoSocio.UseVisualStyleBackColor = false;
            RegistrarNoSocio.Click += RegistrarNoSocio_Click;
            // 
            // RegistrarSocio
            // 
            RegistrarSocio.BackColor = Color.FromArgb(138, 194, 133);
            RegistrarSocio.FlatAppearance.BorderSize = 0;
            RegistrarSocio.FlatStyle = FlatStyle.Flat;
            RegistrarSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegistrarSocio.ForeColor = Color.White;
            RegistrarSocio.Location = new Point(24, 197);
            RegistrarSocio.Name = "RegistrarSocio";
            RegistrarSocio.Size = new Size(206, 59);
            RegistrarSocio.TabIndex = 0;
            RegistrarSocio.Text = "Registrar socio";
            RegistrarSocio.UseVisualStyleBackColor = false;
            RegistrarSocio.Click += RegistrarSocio_Click;
            // 
            // cardVencimientos
            // 
            cardVencimientos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardVencimientos.BackColor = Color.FromArgb(232, 239, 249);
            cardVencimientos.Controls.Add(pbIconDeudores);
            cardVencimientos.Controls.Add(MostrarVencimientoCuotaSocio);
            cardVencimientos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cardVencimientos.ForeColor = Color.FromArgb(31, 31, 31);
            cardVencimientos.Location = new Point(297, 91);
            cardVencimientos.Name = "cardVencimientos";
            cardVencimientos.Padding = new Padding(18, 16, 18, 21);
            cardVencimientos.Size = new Size(286, 347);
            cardVencimientos.TabIndex = 2;
            cardVencimientos.TabStop = false;
            cardVencimientos.Text = "Listar vencimientos";
            // 
            // pbIconDeudores
            // 
            pbIconDeudores.Anchor = AnchorStyles.Top;
            pbIconDeudores.Image = Properties.Resources.lista_verde;
            pbIconDeudores.Location = new Point(51, 69);
            pbIconDeudores.Name = "pbIconDeudores";
            pbIconDeudores.Size = new Size(176, 148);
            pbIconDeudores.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconDeudores.TabIndex = 2;
            pbIconDeudores.TabStop = false;
            // 
            // MostrarVencimientoCuotaSocio
            // 
            MostrarVencimientoCuotaSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MostrarVencimientoCuotaSocio.BackColor = Color.White;
            MostrarVencimientoCuotaSocio.FlatAppearance.BorderColor = Color.FromArgb(176, 196, 222);
            MostrarVencimientoCuotaSocio.FlatStyle = FlatStyle.Flat;
            MostrarVencimientoCuotaSocio.Font = new Font("Segoe UI", 9F);
            MostrarVencimientoCuotaSocio.ForeColor = Color.FromArgb(31, 31, 31);
            MostrarVencimientoCuotaSocio.Location = new Point(23, 264);
            MostrarVencimientoCuotaSocio.Name = "MostrarVencimientoCuotaSocio";
            MostrarVencimientoCuotaSocio.Size = new Size(240, 59);
            MostrarVencimientoCuotaSocio.TabIndex = 1;
            MostrarVencimientoCuotaSocio.Text = "Ver vencimientos";
            MostrarVencimientoCuotaSocio.UseVisualStyleBackColor = false;
            MostrarVencimientoCuotaSocio.Click += MostrarVencimientosCuotaSocio_Click;
            // 
            // cardCuotas
            // 
            cardCuotas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cardCuotas.BackColor = Color.FromArgb(232, 239, 249);
            cardCuotas.Controls.Add(pbIconCuotas);
            cardCuotas.Controls.Add(CobrarCuota);
            cardCuotas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cardCuotas.ForeColor = Color.FromArgb(31, 31, 31);
            cardCuotas.Location = new Point(592, 91);
            cardCuotas.Name = "cardCuotas";
            cardCuotas.Padding = new Padding(18, 16, 18, 21);
            cardCuotas.Size = new Size(295, 347);
            cardCuotas.TabIndex = 3;
            cardCuotas.TabStop = false;
            cardCuotas.Text = "Cuotas";
            // 
            // pbIconCuotas
            // 
            pbIconCuotas.Anchor = AnchorStyles.Top;
            pbIconCuotas.Image = Properties.Resources.pago;
            pbIconCuotas.Location = new Point(66, 69);
            pbIconCuotas.Name = "pbIconCuotas";
            pbIconCuotas.Size = new Size(147, 148);
            pbIconCuotas.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconCuotas.TabIndex = 2;
            pbIconCuotas.TabStop = false;
            // 
            // CobrarCuota
            // 
            CobrarCuota.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CobrarCuota.BackColor = Color.White;
            CobrarCuota.FlatAppearance.BorderColor = Color.FromArgb(176, 196, 222);
            CobrarCuota.FlatStyle = FlatStyle.Flat;
            CobrarCuota.Font = new Font("Segoe UI", 9F);
            CobrarCuota.ForeColor = Color.FromArgb(31, 31, 31);
            CobrarCuota.Location = new Point(23, 264);
            CobrarCuota.Name = "CobrarCuota";
            CobrarCuota.Size = new Size(249, 59);
            CobrarCuota.TabIndex = 1;
            CobrarCuota.Text = "Cobrar cuota";
            CobrarCuota.UseVisualStyleBackColor = false;
            CobrarCuota.Click += CobrarCuota_Click;
            // 
            // cardActividad
            // 
            cardActividad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cardActividad.BackColor = Color.FromArgb(232, 239, 249);
            cardActividad.Controls.Add(pbIconActividad);
            cardActividad.Controls.Add(CobrarActividad);
            cardActividad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cardActividad.ForeColor = Color.FromArgb(31, 31, 31);
            cardActividad.Location = new Point(896, 91);
            cardActividad.Name = "cardActividad";
            cardActividad.Padding = new Padding(18, 16, 18, 21);
            cardActividad.Size = new Size(295, 347);
            cardActividad.TabIndex = 4;
            cardActividad.TabStop = false;
            cardActividad.Text = "Actividad";
            // 
            // pbIconActividad
            // 
            pbIconActividad.Anchor = AnchorStyles.Top;
            pbIconActividad.Image = Properties.Resources.actividad;
            pbIconActividad.Location = new Point(73, 69);
            pbIconActividad.Name = "pbIconActividad";
            pbIconActividad.Size = new Size(147, 148);
            pbIconActividad.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconActividad.TabIndex = 2;
            pbIconActividad.TabStop = false;
            // 
            // CobrarActividad
            // 
            CobrarActividad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CobrarActividad.BackColor = Color.White;
            CobrarActividad.FlatAppearance.BorderColor = Color.FromArgb(176, 196, 222);
            CobrarActividad.FlatStyle = FlatStyle.Flat;
            CobrarActividad.Font = new Font("Segoe UI", 9F);
            CobrarActividad.ForeColor = Color.FromArgb(31, 31, 31);
            CobrarActividad.Location = new Point(23, 264);
            CobrarActividad.Name = "CobrarActividad";
            CobrarActividad.Size = new Size(249, 59);
            CobrarActividad.TabIndex = 1;
            CobrarActividad.Text = "Cobrar actividad";
            CobrarActividad.UseVisualStyleBackColor = false;
            CobrarActividad.Click += CobrarActividad_Click;
            // 
            // SalirSistema
            // 
            SalirSistema.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SalirSistema.BackColor = Color.FromArgb(176, 196, 222);
            SalirSistema.FlatAppearance.BorderSize = 0;
            SalirSistema.FlatStyle = FlatStyle.Flat;
            SalirSistema.Font = new Font("Segoe UI", 9F);
            SalirSistema.ForeColor = Color.FromArgb(31, 31, 31);
            SalirSistema.Location = new Point(27, 510);
            SalirSistema.Name = "SalirSistema";
            SalirSistema.Size = new Size(251, 59);
            SalirSistema.TabIndex = 5;
            SalirSistema.Text = "Salir";
            SalirSistema.UseVisualStyleBackColor = false;
            SalirSistema.Click += SalirSistema_Click;
            // 
            // alertaVencimientosLabel
            // 
            alertaVencimientosLabel.AutoSize = true;
            alertaVencimientosLabel.Location = new Point(51, 16);
            alertaVencimientosLabel.Name = "alertaVencimientosLabel";
            alertaVencimientosLabel.Size = new Size(205, 23);
            alertaVencimientosLabel.TabIndex = 6;
            alertaVencimientosLabel.Text = "alertaVencimientosLabel";
            // 
            // cardAlertaVencimientos
            // 
            cardAlertaVencimientos.BackColor = Color.FromArgb(232, 239, 249);
            cardAlertaVencimientos.Controls.Add(alertaVencimientosLabel);
            cardAlertaVencimientos.Controls.Add(actualizarButton);
            cardAlertaVencimientos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cardAlertaVencimientos.ForeColor = Color.FromArgb(31, 31, 31);
            cardAlertaVencimientos.Location = new Point(297, 444);
            cardAlertaVencimientos.Name = "cardAlertaVencimientos";
            cardAlertaVencimientos.Padding = new Padding(18, 16, 18, 21);
            cardAlertaVencimientos.Size = new Size(894, 47);
            cardAlertaVencimientos.TabIndex = 7;
            cardAlertaVencimientos.TabStop = false;
            // 
            // actualizarButton
            // 
            actualizarButton.FlatAppearance.BorderSize = 0;
            actualizarButton.FlatStyle = FlatStyle.Flat;
            actualizarButton.Font = new Font("Segoe UI Emoji", 14F);
            actualizarButton.Location = new Point(5, 7);
            actualizarButton.Name = "actualizarButton";
            actualizarButton.Size = new Size(40, 40);
            actualizarButton.TabIndex = 7;
            actualizarButton.Text = "🔄"; //icono de actualizar
            actualizarButton.BackColor = Color.FromArgb(232, 239, 249);
            actualizarButton.Click += ActualizarButton_Click;
            actualizarButton.ForeColor = Color.FromArgb(74, 141, 248);
            actualizarToolTip.SetToolTip(actualizarButton, "Actualizar: ver si existen vencimientos al día de hoy.");
            // 
            // SistemaClub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 251);
            ClientSize = new Size(1218, 600);
            Controls.Add(cardAlertaVencimientos);
            Controls.Add(SalirSistema);
            Controls.Add(cardCuotas);
            Controls.Add(cardVencimientos);
            Controls.Add(cardRegistro);
            Controls.Add(cardActividad);
            Controls.Add(header);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SistemaClub";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema del Club";
            header.ResumeLayout(false);
            cardRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).EndInit();
            cardVencimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIconDeudores).EndInit();
            cardCuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIconCuotas).EndInit();
            cardActividad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIconActividad).EndInit();
            cardAlertaVencimientos.ResumeLayout(false);
            cardAlertaVencimientos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label lblTitulo;

        private GroupBox cardRegistro;
        private PictureBox imgAltaSocio;
        private Button RegistrarSocio;
        private Button RegistrarNoSocio;

        private GroupBox cardVencimientos;
        private PictureBox pbIconDeudores;
        private Button MostrarVencimientoCuotaSocio;

        private GroupBox cardCuotas;
        private PictureBox pbIconCuotas;
        private Button CobrarCuota;

        private GroupBox cardActividad;
        private PictureBox pbIconActividad;
        private Button CobrarActividad;

        private Button SalirSistema;
        private Label alertaVencimientosLabel;
        private Button carnetSocioButton;
        private GroupBox cardAlertaVencimientos;
        private Button actualizarButton;
        private ToolTip actualizarToolTip;
    }
}
