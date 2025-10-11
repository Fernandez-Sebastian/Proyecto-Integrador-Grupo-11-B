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
            imgAltaSocio = new PictureBox();
            RegistrarNoSocio = new Button();
            RegistrarSocio = new Button();
            cardDeudores = new GroupBox();
            pbIconDeudores = new PictureBox();
            MostrarDeudaCuotaSocio = new Button();
            cardCuotas = new GroupBox();
            pbIconCuotas = new PictureBox();
            CobrarCuota = new Button();
            SalirSistema = new Button();
            header.SuspendLayout();
            cardRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).BeginInit();
            cardDeudores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIconDeudores).BeginInit();
            cardCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIconCuotas).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(74, 141, 248);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(914, 64);
            header.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(914, 64);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema del Club";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardRegistro
            // 
            cardRegistro.BackColor = Color.FromArgb(232, 239, 249);
            cardRegistro.Controls.Add(imgAltaSocio);
            cardRegistro.Controls.Add(RegistrarNoSocio);
            cardRegistro.Controls.Add(RegistrarSocio);
            cardRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cardRegistro.ForeColor = Color.FromArgb(31, 31, 31);
            cardRegistro.Location = new Point(27, 91);
            cardRegistro.Name = "cardRegistro";
            cardRegistro.Padding = new Padding(18, 16, 18, 21);
            cardRegistro.Size = new Size(251, 347);
            cardRegistro.TabIndex = 1;
            cardRegistro.TabStop = false;
            cardRegistro.Text = "Registro";
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
            RegistrarNoSocio.Location = new Point(24, 264);
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
            // cardDeudores
            // 
            cardDeudores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardDeudores.BackColor = Color.FromArgb(232, 239, 249);
            cardDeudores.Controls.Add(pbIconDeudores);
            cardDeudores.Controls.Add(MostrarDeudaCuotaSocio);
            cardDeudores.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cardDeudores.ForeColor = Color.FromArgb(31, 31, 31);
            cardDeudores.Location = new Point(297, 91);
            cardDeudores.Name = "cardDeudores";
            cardDeudores.Padding = new Padding(18, 16, 18, 21);
            cardDeudores.Size = new Size(286, 347);
            cardDeudores.TabIndex = 2;
            cardDeudores.TabStop = false;
            cardDeudores.Text = "Socios deudores";
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
            // MostrarDeudaCuotaSocio
            // 
            MostrarDeudaCuotaSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MostrarDeudaCuotaSocio.BackColor = Color.White;
            MostrarDeudaCuotaSocio.FlatAppearance.BorderColor = Color.FromArgb(176, 196, 222);
            MostrarDeudaCuotaSocio.FlatStyle = FlatStyle.Flat;
            MostrarDeudaCuotaSocio.Font = new Font("Segoe UI", 9F);
            MostrarDeudaCuotaSocio.ForeColor = Color.FromArgb(31, 31, 31);
            MostrarDeudaCuotaSocio.Location = new Point(23, 264);
            MostrarDeudaCuotaSocio.Name = "MostrarDeudaCuotaSocio";
            MostrarDeudaCuotaSocio.Size = new Size(240, 59);
            MostrarDeudaCuotaSocio.TabIndex = 1;
            MostrarDeudaCuotaSocio.Text = "Listado de deudores";
            MostrarDeudaCuotaSocio.UseVisualStyleBackColor = false;
            MostrarDeudaCuotaSocio.Click += MostrarDeudaCuotaSocio_Click;
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
            // SalirSistema
            // 
            SalirSistema.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SalirSistema.BackColor = Color.FromArgb(176, 196, 222);
            SalirSistema.FlatAppearance.BorderSize = 0;
            SalirSistema.FlatStyle = FlatStyle.Flat;
            SalirSistema.Font = new Font("Segoe UI", 9F);
            SalirSistema.ForeColor = Color.FromArgb(31, 31, 31);
            SalirSistema.Location = new Point(27, 509);
            SalirSistema.Name = "SalirSistema";
            SalirSistema.Size = new Size(251, 59);
            SalirSistema.TabIndex = 4;
            SalirSistema.Text = "Salir";
            SalirSistema.UseVisualStyleBackColor = false;
            SalirSistema.Click += button1_Click;
            // 
            // SistemaClub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 251);
            ClientSize = new Size(914, 600);
            Controls.Add(SalirSistema);
            Controls.Add(cardCuotas);
            Controls.Add(cardDeudores);
            Controls.Add(cardRegistro);
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
            cardDeudores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIconDeudores).EndInit();
            cardCuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIconCuotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label lblTitulo;

        private GroupBox cardRegistro;
        private PictureBox imgAltaSocio;
        private Button RegistrarSocio;
        private Button RegistrarNoSocio;

        private GroupBox cardDeudores;
        private PictureBox pbIconDeudores;
        private Button MostrarDeudaCuotaSocio;

        private GroupBox cardCuotas;
        private PictureBox pbIconCuotas;
        private Button CobrarCuota;

        private Button SalirSistema;
    }
}
