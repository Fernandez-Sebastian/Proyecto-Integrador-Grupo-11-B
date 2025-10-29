namespace Proyecto_Integrador_Grupo_11_B
{
    partial class CobrarCuota
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
            lblTitulo = new Label();
            header = new Panel();
            groupBox2 = new GroupBox();
            txtHabilitado = new TextBox();
            label5 = new Label();
            textNumeroSocio = new TextBox();
            label3 = new Label();
            BuscarDeuda = new Button();
            BuscarSocio = new Button();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            VolverMenu = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            imgAltaSocio = new PictureBox();
            radioTransferencia = new RadioButton();
            radioEfectivo = new RadioButton();
            radioTarjeta = new RadioButton();
            checkBoxAbonarTodo = new CheckBox();
            label6 = new Label();
            comboBoxCuotas = new ComboBox();
            PagarCuota = new Button();
            button1 = new Button();
            button2 = new Button();
            label12 = new Label();
            header.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(622, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cobrar Cuota";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(74, 141, 248);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(3, 2, 3, 2);
            header.Name = "header";
            header.Size = new Size(622, 48);
            header.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(232, 239, 249);
            groupBox2.Controls.Add(txtHabilitado);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textNumeroSocio);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(BuscarDeuda);
            groupBox2.Controls.Add(BuscarSocio);
            groupBox2.Controls.Add(txtDni);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(31, 31, 31);
            groupBox2.Location = new Point(22, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(16, 12, 16, 16);
            groupBox2.Size = new Size(588, 313);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Del Socio";
            // 
            // txtHabilitado
            // 
            txtHabilitado.BorderStyle = BorderStyle.FixedSingle;
            txtHabilitado.Font = new Font("Segoe UI", 9F);
            txtHabilitado.Location = new Point(382, 144);
            txtHabilitado.Name = "txtHabilitado";
            txtHabilitado.ReadOnly = true;
            txtHabilitado.Size = new Size(130, 23);
            txtHabilitado.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(76, 76, 76);
            label5.Location = new Point(289, 138);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 14;
            label5.Text = "Habilitado:";
            // 
            // textNumeroSocio
            // 
            textNumeroSocio.BorderStyle = BorderStyle.FixedSingle;
            textNumeroSocio.Font = new Font("Segoe UI", 9F);
            textNumeroSocio.Location = new Point(119, 144);
            textNumeroSocio.Name = "textNumeroSocio";
            textNumeroSocio.ReadOnly = true;
            textNumeroSocio.Size = new Size(130, 23);
            textNumeroSocio.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(76, 76, 76);
            label3.Location = new Point(11, 144);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 12;
            label3.Text = "Número de Socio:";
            // 
            // BuscarDeuda
            // 
            BuscarDeuda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BuscarDeuda.BackColor = Color.FromArgb(138, 194, 133);
            BuscarDeuda.FlatAppearance.BorderSize = 0;
            BuscarDeuda.FlatStyle = FlatStyle.Flat;
            BuscarDeuda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarDeuda.ForeColor = Color.White;
            BuscarDeuda.Location = new Point(181, 254);
            BuscarDeuda.Name = "BuscarDeuda";
            BuscarDeuda.Size = new Size(188, 40);
            BuscarDeuda.TabIndex = 10;
            BuscarDeuda.Text = "Buscar Deuda";
            BuscarDeuda.UseVisualStyleBackColor = false;
            BuscarDeuda.Click += BuscarDeuda_Click;
            // 
            // BuscarSocio
            // 
            BuscarSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BuscarSocio.BackColor = Color.FromArgb(138, 194, 133);
            BuscarSocio.FlatAppearance.BorderSize = 0;
            BuscarSocio.FlatStyle = FlatStyle.Flat;
            BuscarSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarSocio.ForeColor = Color.White;
            BuscarSocio.Location = new Point(324, 26);
            BuscarSocio.Name = "BuscarSocio";
            BuscarSocio.Size = new Size(188, 40);
            BuscarSocio.TabIndex = 9;
            BuscarSocio.Text = "Buscar Socio";
            BuscarSocio.UseVisualStyleBackColor = false;
            BuscarSocio.Click += BuscarSocio_Click;
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 9F);
            txtDni.Location = new Point(119, 37);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "    Ingrese DNI a buscar";
            txtDni.Size = new Size(152, 23);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.Location = new Point(382, 101);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(130, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(119, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(76, 76, 76);
            label4.Location = new Point(83, 45);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(76, 76, 76);
            label2.Location = new Point(289, 99);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(76, 76, 76);
            label1.Location = new Point(59, 101);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // VolverMenu
            // 
            VolverMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VolverMenu.BackColor = Color.FromArgb(176, 196, 222);
            VolverMenu.FlatAppearance.BorderSize = 0;
            VolverMenu.FlatStyle = FlatStyle.Flat;
            VolverMenu.Font = new Font("Segoe UI", 9F);
            VolverMenu.ForeColor = Color.FromArgb(31, 31, 31);
            VolverMenu.Location = new Point(22, 763);
            VolverMenu.Name = "VolverMenu";
            VolverMenu.Size = new Size(188, 44);
            VolverMenu.TabIndex = 10;
            VolverMenu.Text = "Volver";
            VolverMenu.UseVisualStyleBackColor = false;
            VolverMenu.Click += VolverMenu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(232, 239, 249);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(checkBoxAbonarTodo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBoxCuotas);
            groupBox1.Controls.Add(PagarCuota);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label12);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(31, 31, 31);
            groupBox1.Location = new Point(22, 417);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(16, 12, 16, 16);
            groupBox1.Size = new Size(588, 327);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos De La Deuda";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(imgAltaSocio);
            groupBox3.Controls.Add(radioTransferencia);
            groupBox3.Controls.Add(radioEfectivo);
            groupBox3.Controls.Add(radioTarjeta);
            groupBox3.Location = new Point(15, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(277, 170);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Método de Pago";
            // 
            // imgAltaSocio
            // 
            imgAltaSocio.BorderStyle = BorderStyle.FixedSingle;
            imgAltaSocio.Image = Properties.Resources.pago;
            imgAltaSocio.Location = new Point(6, 49);
            imgAltaSocio.Name = "imgAltaSocio";
            imgAltaSocio.Size = new Size(93, 98);
            imgAltaSocio.SizeMode = PictureBoxSizeMode.Zoom;
            imgAltaSocio.TabIndex = 15;
            imgAltaSocio.TabStop = false;
            // 
            // radioTransferencia
            // 
            radioTransferencia.AutoSize = true;
            radioTransferencia.Location = new Point(128, 124);
            radioTransferencia.Name = "radioTransferencia";
            radioTransferencia.Size = new Size(116, 23);
            radioTransferencia.TabIndex = 2;
            radioTransferencia.TabStop = true;
            radioTransferencia.Text = "Transferencia";
            radioTransferencia.UseVisualStyleBackColor = true;
            // 
            // radioEfectivo
            // 
            radioEfectivo.AutoSize = true;
            radioEfectivo.Location = new Point(128, 42);
            radioEfectivo.Name = "radioEfectivo";
            radioEfectivo.Size = new Size(80, 23);
            radioEfectivo.TabIndex = 1;
            radioEfectivo.TabStop = true;
            radioEfectivo.Text = "Efectivo";
            radioEfectivo.UseVisualStyleBackColor = true;
            // 
            // radioTarjeta
            // 
            radioTarjeta.AutoSize = true;
            radioTarjeta.Location = new Point(128, 81);
            radioTarjeta.Name = "radioTarjeta";
            radioTarjeta.Size = new Size(73, 23);
            radioTarjeta.TabIndex = 0;
            radioTarjeta.TabStop = true;
            radioTarjeta.Text = "Tarjeta";
            radioTarjeta.UseVisualStyleBackColor = true;
            // 
            // checkBoxAbonarTodo
            // 
            checkBoxAbonarTodo.AutoSize = true;
            checkBoxAbonarTodo.Location = new Point(230, 73);
            checkBoxAbonarTodo.Name = "checkBoxAbonarTodo";
            checkBoxAbonarTodo.Size = new Size(15, 14);
            checkBoxAbonarTodo.TabIndex = 14;
            checkBoxAbonarTodo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.FromArgb(76, 76, 76);
            label6.Location = new Point(19, 72);
            label6.Name = "label6";
            label6.Size = new Size(193, 15);
            label6.TabIndex = 13;
            label6.Text = "Abonar todas las cuotas adeudadas";
            // 
            // comboBoxCuotas
            // 
            comboBoxCuotas.FormattingEnabled = true;
            comboBoxCuotas.Location = new Point(230, 33);
            comboBoxCuotas.Name = "comboBoxCuotas";
            comboBoxCuotas.Size = new Size(262, 25);
            comboBoxCuotas.TabIndex = 12;
            // 
            // PagarCuota
            // 
            PagarCuota.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PagarCuota.BackColor = Color.FromArgb(138, 194, 133);
            PagarCuota.FlatAppearance.BorderSize = 0;
            PagarCuota.FlatStyle = FlatStyle.Flat;
            PagarCuota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PagarCuota.ForeColor = Color.White;
            PagarCuota.Location = new Point(357, 262);
            PagarCuota.Name = "PagarCuota";
            PagarCuota.Size = new Size(188, 40);
            PagarCuota.TabIndex = 11;
            PagarCuota.Text = "Pagar Cuota";
            PagarCuota.UseVisualStyleBackColor = false;
            PagarCuota.Visible = false;
            PagarCuota.Click += PagarCuota_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(138, 194, 133);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(494, 468);
            button1.Name = "button1";
            button1.Size = new Size(188, 40);
            button1.TabIndex = 10;
            button1.Text = "Buscar Deuda";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(138, 194, 133);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(668, 240);
            button2.Name = "button2";
            button2.Size = new Size(188, 40);
            button2.TabIndex = 9;
            button2.Text = "Buscar Socio";
            button2.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.ForeColor = Color.FromArgb(76, 76, 76);
            label12.Location = new Point(19, 43);
            label12.Name = "label12";
            label12.Size = new Size(129, 15);
            label12.TabIndex = 6;
            label12.Text = "Elige la cuota a abonar:";
            // 
            // CobrarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 819);
            Controls.Add(groupBox1);
            Controls.Add(VolverMenu);
            Controls.Add(groupBox2);
            Controls.Add(header);
            Name = "CobrarCuota";
            Text = "CobrarCuota";
            header.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel header;
        private GroupBox groupBox2;
        private Button BuscarSocio;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtHabilitado;
        private Label label5;
        private TextBox textNumeroSocio;
        private Label label3;
        private Button BuscarDeuda;
        private Button VolverMenu;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Label label12;
        private ComboBox comboBoxCuotas;
        private Button PagarCuota;
        private CheckBox checkBoxAbonarTodo;
        private Label label6;
        private GroupBox groupBox3;
        private RadioButton radioTransferencia;
        private RadioButton radioEfectivo;
        private RadioButton radioTarjeta;
        private PictureBox imgAltaSocio;
    }
}