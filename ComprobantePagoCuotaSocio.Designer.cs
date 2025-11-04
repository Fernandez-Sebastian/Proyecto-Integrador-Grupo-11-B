namespace Proyecto_Integrador_Grupo_11_B
{
    partial class ComprobantePagoCuotaSocio
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
            panelComprobanteCompleto = new Panel();
            VolverMenu = new Button();
            Imprimir = new Button();
            imgAltaSocio = new PictureBox();
            label3 = new Label();
            label7 = new Label();
            LblApellido = new Label();
            label9 = new Label();
            LblNombre = new Label();
            label2 = new Label();
            LblNroSocio = new Label();
            label20 = new Label();
            LblDni = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            LblFechaPago = new Label();
            label10 = new Label();
            LblCuotaAbonada = new Label();
            label12 = new Label();
            LblMontoTotal = new Label();
            label14 = new Label();
            LblMetodoPago = new Label();
            label16 = new Label();
            LblCuotaTarjeta = new Label();
            label21 = new Label();
            groupBox2 = new GroupBox();
            header.SuspendLayout();
            panelComprobanteCompleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(74, 141, 248);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(884, 48);
            header.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(884, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Comprobante De Pago";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelComprobanteCompleto
            // 
            panelComprobanteCompleto.Controls.Add(VolverMenu);
            panelComprobanteCompleto.Controls.Add(Imprimir);
            panelComprobanteCompleto.Location = new Point(0, 0);
            panelComprobanteCompleto.Name = "panelComprobanteCompleto";
            panelComprobanteCompleto.Size = new Size(883, 616);
            panelComprobanteCompleto.TabIndex = 12;
            // 
            // VolverMenu
            // 
            VolverMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VolverMenu.BackColor = Color.FromArgb(176, 196, 222);
            VolverMenu.FlatAppearance.BorderSize = 0;
            VolverMenu.FlatStyle = FlatStyle.Flat;
            VolverMenu.Font = new Font("Segoe UI", 9F);
            VolverMenu.ForeColor = Color.FromArgb(31, 31, 31);
            VolverMenu.Location = new Point(24, 563);
            VolverMenu.Name = "VolverMenu";
            VolverMenu.Size = new Size(188, 44);
            VolverMenu.TabIndex = 10;
            VolverMenu.Text = "Volver";
            VolverMenu.UseVisualStyleBackColor = false;
            VolverMenu.Click += VolverMenu_Click;
            // 
            // Imprimir
            // 
            Imprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Imprimir.BackColor = Color.FromArgb(138, 194, 133);
            Imprimir.FlatAppearance.BorderSize = 0;
            Imprimir.FlatStyle = FlatStyle.Flat;
            Imprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Imprimir.ForeColor = Color.White;
            Imprimir.Location = new Point(672, 563);
            Imprimir.Name = "Imprimir";
            Imprimir.Size = new Size(188, 44);
            Imprimir.TabIndex = 11;
            Imprimir.Text = "Imprimir";
            Imprimir.UseVisualStyleBackColor = false;
            Imprimir.Click += Imprimir_Click;
            // 
            // imgAltaSocio
            // 
            imgAltaSocio.BorderStyle = BorderStyle.FixedSingle;
            imgAltaSocio.Image = Properties.Resources.AltaSocio;
            imgAltaSocio.Location = new Point(194, 13);
            imgAltaSocio.Name = "imgAltaSocio";
            imgAltaSocio.Size = new Size(154, 154);
            imgAltaSocio.SizeMode = PictureBoxSizeMode.Zoom;
            imgAltaSocio.TabIndex = 0;
            imgAltaSocio.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 54);
            label3.MaximumSize = new Size(200, 200);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 1;
            label3.Text = "Club Deportivo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 9.75F);
            label7.Location = new Point(464, 73);
            label7.MaximumSize = new Size(200, 200);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 4;
            label7.Text = "Apellido:";
            // 
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.Location = new Point(566, 73);
            LblApellido.MaximumSize = new Size(200, 200);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(0, 19);
            LblApellido.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Symbol", 9.75F);
            label9.Location = new Point(465, 108);
            label9.MaximumSize = new Size(200, 200);
            label9.Name = "label9";
            label9.Size = new Size(60, 17);
            label9.TabIndex = 6;
            label9.Text = "Nombre:";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Location = new Point(566, 108);
            LblNombre.MaximumSize = new Size(200, 200);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(0, 19);
            LblNombre.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9.75F);
            label2.Location = new Point(404, 32);
            label2.MaximumSize = new Size(200, 200);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 8;
            label2.Text = "Número de Socio:";
            // 
            // LblNroSocio
            // 
            LblNroSocio.AutoSize = true;
            LblNroSocio.Location = new Point(566, 32);
            LblNroSocio.MaximumSize = new Size(200, 200);
            LblNroSocio.Name = "LblNroSocio";
            LblNroSocio.Size = new Size(0, 19);
            LblNroSocio.TabIndex = 9;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Symbol", 9.75F);
            label20.Location = new Point(496, 139);
            label20.MaximumSize = new Size(200, 200);
            label20.Name = "label20";
            label20.Size = new Size(33, 17);
            label20.TabIndex = 10;
            label20.Text = "DNI:";
            // 
            // LblDni
            // 
            LblDni.AutoSize = true;
            LblDni.Location = new Point(566, 139);
            LblDni.MaximumSize = new Size(200, 200);
            LblDni.Name = "LblDni";
            LblDni.Size = new Size(0, 19);
            LblDni.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(232, 239, 249);
            groupBox1.Controls.Add(LblDni);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(LblNroSocio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LblNombre);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(LblApellido);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(imgAltaSocio);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(31, 31, 31);
            groupBox1.Location = new Point(0, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(14);
            groupBox1.Size = new Size(884, 183);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 9.75F);
            label5.Location = new Point(147, 48);
            label5.MaximumSize = new Size(200, 200);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 2;
            label5.Text = "Fecha Pago:";
            // 
            // LblFechaPago
            // 
            LblFechaPago.AutoSize = true;
            LblFechaPago.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            LblFechaPago.Location = new Point(267, 48);
            LblFechaPago.MaximumSize = new Size(200, 200);
            LblFechaPago.Name = "LblFechaPago";
            LblFechaPago.Size = new Size(0, 17);
            LblFechaPago.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Symbol", 9.75F);
            label10.Location = new Point(50, 97);
            label10.MaximumSize = new Size(200, 200);
            label10.Name = "label10";
            label10.Size = new Size(165, 17);
            label10.TabIndex = 4;
            label10.Text = "Cantidad  Cuotas Pagadas:";
            // 
            // LblCuotaAbonada
            // 
            LblCuotaAbonada.AllowDrop = true;
            LblCuotaAbonada.AutoSize = true;
            LblCuotaAbonada.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            LblCuotaAbonada.Location = new Point(267, 97);
            LblCuotaAbonada.MaximumSize = new Size(200, 200);
            LblCuotaAbonada.Name = "LblCuotaAbonada";
            LblCuotaAbonada.Size = new Size(0, 17);
            LblCuotaAbonada.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Symbol", 9.75F);
            label12.Location = new Point(143, 152);
            label12.MaximumSize = new Size(200, 200);
            label12.Name = "label12";
            label12.Size = new Size(83, 17);
            label12.TabIndex = 6;
            label12.Text = "Monto Total:";
            // 
            // LblMontoTotal
            // 
            LblMontoTotal.AutoSize = true;
            LblMontoTotal.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            LblMontoTotal.Location = new Point(267, 152);
            LblMontoTotal.MaximumSize = new Size(200, 200);
            LblMontoTotal.Name = "LblMontoTotal";
            LblMontoTotal.Size = new Size(0, 17);
            LblMontoTotal.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Symbol", 9.75F);
            label14.Location = new Point(484, 48);
            label14.MaximumSize = new Size(200, 200);
            label14.Name = "label14";
            label14.Size = new Size(111, 17);
            label14.TabIndex = 8;
            label14.Text = "Método de Pago:";
            // 
            // LblMetodoPago
            // 
            LblMetodoPago.AutoSize = true;
            LblMetodoPago.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            LblMetodoPago.Location = new Point(640, 48);
            LblMetodoPago.MaximumSize = new Size(200, 200);
            LblMetodoPago.Name = "LblMetodoPago";
            LblMetodoPago.Size = new Size(0, 17);
            LblMetodoPago.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Symbol", 9.75F);
            label16.Location = new Point(471, 97);
            label16.MaximumSize = new Size(200, 200);
            label16.Name = "label16";
            label16.Size = new Size(124, 17);
            label16.TabIndex = 10;
            label16.Text = "Pago financiado en ";
            // 
            // LblCuotaTarjeta
            // 
            LblCuotaTarjeta.AutoSize = true;
            LblCuotaTarjeta.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            LblCuotaTarjeta.Location = new Point(613, 97);
            LblCuotaTarjeta.MaximumSize = new Size(200, 200);
            LblCuotaTarjeta.Name = "LblCuotaTarjeta";
            LblCuotaTarjeta.Size = new Size(0, 17);
            LblCuotaTarjeta.TabIndex = 11;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Symbol", 9.75F);
            label21.Location = new Point(628, 97);
            label21.MaximumSize = new Size(200, 200);
            label21.Name = "label21";
            label21.Size = new Size(48, 17);
            label21.TabIndex = 14;
            label21.Text = "Cuotas";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(232, 239, 249);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(LblCuotaTarjeta);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(LblMetodoPago);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(LblMontoTotal);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(LblCuotaAbonada);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(LblFechaPago);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(31, 31, 31);
            groupBox2.Location = new Point(0, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(16, 12, 16, 16);
            groupBox2.Size = new Size(884, 317);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "e";
            // 
            // ComprobantePagoCuotaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 614);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(header);
            Controls.Add(panelComprobanteCompleto);
            Name = "ComprobantePagoCuotaSocio";
            Text = "ComprobantePagoCuotaSocio";
            Load += ComprobantePagoCuotaSocio_Load_1;
            header.ResumeLayout(false);
            panelComprobanteCompleto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel header;
        private Panel panelComprobanteCompleto;
        private Label lblTitulo;
        private Button VolverMenu;
        private Button Imprimir;
        private PictureBox imgAltaSocio;
        private Label label3;
        private Label label7;
        private Label LblApellido;
        private Label label9;
        private Label LblNombre;
        private Label label2;
        private Label LblNroSocio;
        private Label label20;
        private Label LblDni;
        private GroupBox groupBox1;
        private Label label5;
        private Label LblFechaPago;
        private Label label10;
        private Label LblCuotaAbonada;
        private Label label12;
        private Label LblMontoTotal;
        private Label label14;
        private Label LblMetodoPago;
        private Label label16;
        private Label LblCuotaTarjeta;
        private Label label21;
        private GroupBox groupBox2;
    }
}