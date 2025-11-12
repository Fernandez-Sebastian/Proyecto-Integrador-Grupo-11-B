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
            buttonLimpiarBusqueda = new Button();
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
            label7 = new Label();
            checkBoxAbonarAnio = new CheckBox();
            labelAbonarAnio = new Label();
            groupBox3 = new GroupBox();
            imgAltaSocio = new PictureBox();
            radioTransferencia = new RadioButton();
            radioEfectivo = new RadioButton();
            radioTarjeta = new RadioButton();
            checkBoxAbonarTodo = new CheckBox();
            labelTodasCuotasAdeudadas = new Label();
            comboBoxCuotas = new ComboBox();
            labelComboCuotas = new Label();
            GroupCantidadDeCuotas = new GroupBox();
            radio3Cuotas = new RadioButton();
            radio6Cuotas = new RadioButton();
            BtnPagarCuota = new Button();
            header.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).BeginInit();
            GroupCantidadDeCuotas.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(0, 0, 64);
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(621, 48);
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
            header.Size = new Size(621, 48);
            header.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(232, 239, 249);
            groupBox2.Controls.Add(buttonLimpiarBusqueda);
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
            groupBox2.Size = new Size(527, 278);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Del Socio";
            // 
            // buttonLimpiarBusqueda
            // 
            buttonLimpiarBusqueda.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLimpiarBusqueda.BackColor = Color.Silver;
            buttonLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            buttonLimpiarBusqueda.FlatStyle = FlatStyle.Flat;
            buttonLimpiarBusqueda.Font = new Font("Segoe UI", 9F);
            buttonLimpiarBusqueda.ForeColor = Color.FromArgb(31, 31, 31);
            buttonLimpiarBusqueda.Location = new Point(37, 223);
            buttonLimpiarBusqueda.Name = "buttonLimpiarBusqueda";
            buttonLimpiarBusqueda.Size = new Size(199, 30);
            buttonLimpiarBusqueda.TabIndex = 15;
            buttonLimpiarBusqueda.Text = "Limpiar Campos";
            buttonLimpiarBusqueda.UseVisualStyleBackColor = false;
            buttonLimpiarBusqueda.Click += buttonLimpiarBusqueda_Click;
            // 
            // txtHabilitado
            // 
            txtHabilitado.BorderStyle = BorderStyle.FixedSingle;
            txtHabilitado.Font = new Font("Segoe UI", 9F);
            txtHabilitado.Location = new Point(363, 150);
            txtHabilitado.Name = "txtHabilitado";
            txtHabilitado.ReadOnly = true;
            txtHabilitado.Size = new Size(129, 23);
            txtHabilitado.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(76, 76, 76);
            label5.Location = new Point(292, 152);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 14;
            label5.Text = "Habilitado:";
            // 
            // textNumeroSocio
            // 
            textNumeroSocio.BorderStyle = BorderStyle.FixedSingle;
            textNumeroSocio.Font = new Font("Segoe UI", 9F);
            textNumeroSocio.Location = new Point(106, 156);
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
            label3.Location = new Point(35, 158);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 12;
            label3.Text = "N° de Socio:";
            label3.Click += label3_Click;
            // 
            // BuscarDeuda
            // 
            BuscarDeuda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BuscarDeuda.BackColor = Color.Green;
            BuscarDeuda.FlatAppearance.BorderSize = 0;
            BuscarDeuda.FlatStyle = FlatStyle.Flat;
            BuscarDeuda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarDeuda.ForeColor = Color.White;
            BuscarDeuda.Location = new Point(292, 223);
            BuscarDeuda.Name = "BuscarDeuda";
            BuscarDeuda.Size = new Size(200, 30);
            BuscarDeuda.TabIndex = 10;
            BuscarDeuda.Text = "Buscar Deuda";
            BuscarDeuda.UseVisualStyleBackColor = false;
            BuscarDeuda.Click += BuscarDeuda_Click;
            // 
            // BuscarSocio
            // 
            BuscarSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BuscarSocio.BackColor = Color.Green;
            BuscarSocio.FlatAppearance.BorderSize = 0;
            BuscarSocio.FlatStyle = FlatStyle.Flat;
            BuscarSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarSocio.ForeColor = Color.White;
            BuscarSocio.Location = new Point(292, 49);
            BuscarSocio.Name = "BuscarSocio";
            BuscarSocio.Size = new Size(200, 31);
            BuscarSocio.TabIndex = 9;
            BuscarSocio.Text = "Buscar Socio";
            BuscarSocio.UseVisualStyleBackColor = false;
            BuscarSocio.Click += BuscarSocio_Click;
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 9F);
            txtDni.Location = new Point(73, 55);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "  Ingrese DNI a buscar";
            txtDni.Size = new Size(163, 19);
            txtDni.TabIndex = 2;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.Location = new Point(363, 109);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(129, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(106, 113);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(130, 21);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(76, 76, 76);
            label4.Location = new Point(37, 55);
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
            label2.Location = new Point(292, 113);
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
            label1.Location = new Point(35, 115);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // VolverMenu
            // 
            VolverMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VolverMenu.BackColor = Color.DarkGray;
            VolverMenu.FlatAppearance.BorderSize = 0;
            VolverMenu.FlatStyle = FlatStyle.Flat;
            VolverMenu.Font = new Font("Segoe UI", 9F);
            VolverMenu.ForeColor = Color.FromArgb(31, 31, 31);
            VolverMenu.Location = new Point(73, 314);
            VolverMenu.Name = "VolverMenu";
            VolverMenu.Size = new Size(127, 27);
            VolverMenu.TabIndex = 10;
            VolverMenu.Text = "Volver";
            VolverMenu.UseVisualStyleBackColor = false;
            VolverMenu.Click += VolverMenu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(232, 239, 249);
            groupBox1.Controls.Add(VolverMenu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(BtnPagarCuota);
            groupBox1.Controls.Add(checkBoxAbonarAnio);
            groupBox1.Controls.Add(labelAbonarAnio);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(checkBoxAbonarTodo);
            groupBox1.Controls.Add(labelTodasCuotasAdeudadas);
            groupBox1.Controls.Add(comboBoxCuotas);
            groupBox1.Controls.Add(labelComboCuotas);
            groupBox1.Controls.Add(GroupCantidadDeCuotas);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(31, 31, 31);
            groupBox1.Location = new Point(22, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(16, 12, 16, 16);
            groupBox1.Size = new Size(564, 360);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos De La Deuda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(314, 136);
            label7.Name = "label7";
            label7.Size = new Size(208, 19);
            label7.TabIndex = 3;
            label7.Text = "Cantidad de Cuotas a abonar:";
            label7.Click += label7_Click;
            // 
            // checkBoxAbonarAnio
            // 
            checkBoxAbonarAnio.AutoSize = true;
            checkBoxAbonarAnio.Location = new Point(234, 33);
            checkBoxAbonarAnio.Name = "checkBoxAbonarAnio";
            checkBoxAbonarAnio.Size = new Size(15, 14);
            checkBoxAbonarAnio.TabIndex = 18;
            checkBoxAbonarAnio.UseVisualStyleBackColor = true;
            checkBoxAbonarAnio.Visible = false;
            // 
            // labelAbonarAnio
            // 
            labelAbonarAnio.AutoSize = true;
            labelAbonarAnio.Font = new Font("Segoe UI", 9F);
            labelAbonarAnio.ForeColor = Color.FromArgb(76, 76, 76);
            labelAbonarAnio.Location = new Point(23, 32);
            labelAbonarAnio.Name = "labelAbonarAnio";
            labelAbonarAnio.Size = new Size(169, 15);
            labelAbonarAnio.TabIndex = 17;
            labelAbonarAnio.Text = "Abonar por adelantado un año";
            labelAbonarAnio.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(imgAltaSocio);
            groupBox3.Controls.Add(radioTransferencia);
            groupBox3.Controls.Add(radioEfectivo);
            groupBox3.Controls.Add(radioTarjeta);
            groupBox3.Location = new Point(15, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(277, 157);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Método de Pago";
            groupBox3.Enter += groupBox3_Enter;
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
            radioTransferencia.CheckedChanged += radioTransferencia_CheckedChanged;
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
            radioEfectivo.CheckedChanged += radioEfectivo_CheckedChanged;
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
            radioTarjeta.CheckedChanged += radioTarjeta_CheckedChanged;
            // 
            // checkBoxAbonarTodo
            // 
            checkBoxAbonarTodo.AutoSize = true;
            checkBoxAbonarTodo.Location = new Point(234, 93);
            checkBoxAbonarTodo.Name = "checkBoxAbonarTodo";
            checkBoxAbonarTodo.Size = new Size(15, 14);
            checkBoxAbonarTodo.TabIndex = 14;
            checkBoxAbonarTodo.UseVisualStyleBackColor = true;
            // 
            // labelTodasCuotasAdeudadas
            // 
            labelTodasCuotasAdeudadas.AutoSize = true;
            labelTodasCuotasAdeudadas.Font = new Font("Segoe UI", 9F);
            labelTodasCuotasAdeudadas.ForeColor = Color.FromArgb(76, 76, 76);
            labelTodasCuotasAdeudadas.Location = new Point(23, 92);
            labelTodasCuotasAdeudadas.Name = "labelTodasCuotasAdeudadas";
            labelTodasCuotasAdeudadas.Size = new Size(193, 15);
            labelTodasCuotasAdeudadas.TabIndex = 13;
            labelTodasCuotasAdeudadas.Text = "Abonar todas las cuotas adeudadas";
            // 
            // comboBoxCuotas
            // 
            comboBoxCuotas.FormattingEnabled = true;
            comboBoxCuotas.Location = new Point(234, 53);
            comboBoxCuotas.Name = "comboBoxCuotas";
            comboBoxCuotas.Size = new Size(315, 25);
            comboBoxCuotas.TabIndex = 12;
            // 
            // labelComboCuotas
            // 
            labelComboCuotas.AutoSize = true;
            labelComboCuotas.Font = new Font("Segoe UI", 9F);
            labelComboCuotas.ForeColor = Color.FromArgb(76, 76, 76);
            labelComboCuotas.Location = new Point(23, 63);
            labelComboCuotas.Name = "labelComboCuotas";
            labelComboCuotas.Size = new Size(129, 15);
            labelComboCuotas.TabIndex = 6;
            labelComboCuotas.Text = "Elige la cuota a abonar:";
            // 
            // GroupCantidadDeCuotas
            // 
            GroupCantidadDeCuotas.Controls.Add(radio3Cuotas);
            GroupCantidadDeCuotas.Controls.Add(radio6Cuotas);
            GroupCantidadDeCuotas.Location = new Point(311, 138);
            GroupCantidadDeCuotas.Name = "GroupCantidadDeCuotas";
            GroupCantidadDeCuotas.Size = new Size(234, 114);
            GroupCantidadDeCuotas.TabIndex = 16;
            GroupCantidadDeCuotas.TabStop = false;
            GroupCantidadDeCuotas.Visible = false;
            // 
            // radio3Cuotas
            // 
            radio3Cuotas.AutoSize = true;
            radio3Cuotas.Location = new Point(28, 42);
            radio3Cuotas.Name = "radio3Cuotas";
            radio3Cuotas.Size = new Size(84, 23);
            radio3Cuotas.TabIndex = 2;
            radio3Cuotas.TabStop = true;
            radio3Cuotas.Text = "3 Cuotas";
            radio3Cuotas.UseVisualStyleBackColor = true;
            // 
            // radio6Cuotas
            // 
            radio6Cuotas.AutoSize = true;
            radio6Cuotas.Location = new Point(28, 71);
            radio6Cuotas.Name = "radio6Cuotas";
            radio6Cuotas.Size = new Size(84, 23);
            radio6Cuotas.TabIndex = 1;
            radio6Cuotas.TabStop = true;
            radio6Cuotas.Text = "6 Cuotas";
            radio6Cuotas.UseVisualStyleBackColor = true;
            // 
            // BtnPagarCuota
            // 
            BtnPagarCuota.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnPagarCuota.BackColor = Color.Green;
            BtnPagarCuota.FlatAppearance.BorderSize = 0;
            BtnPagarCuota.FlatStyle = FlatStyle.Flat;
            BtnPagarCuota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnPagarCuota.ForeColor = Color.White;
            BtnPagarCuota.Location = new Point(329, 302);
            BtnPagarCuota.Name = "BtnPagarCuota";
            BtnPagarCuota.Size = new Size(188, 39);
            BtnPagarCuota.TabIndex = 11;
            BtnPagarCuota.Text = "Pagar Cuota";
            BtnPagarCuota.UseVisualStyleBackColor = false;
            BtnPagarCuota.Visible = false;
            BtnPagarCuota.Click += PagarCuota_Click;
            // 
            // CobrarCuota
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(621, 749);
            Controls.Add(groupBox2);
            Controls.Add(header);
            Controls.Add(groupBox1);
            Name = "CobrarCuota";
            Text = "CobrarCuota";
            Load += CobrarCuota_Load;
            header.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).EndInit();
            GroupCantidadDeCuotas.ResumeLayout(false);
            GroupCantidadDeCuotas.PerformLayout();
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
        private Label labelComboCuotas;
        private ComboBox comboBoxCuotas;
        private Button BtnPagarCuota;
        private CheckBox checkBoxAbonarTodo;
        private Label labelTodasCuotasAdeudadas;
        private GroupBox groupBox3;
        private RadioButton radioTransferencia;
        private RadioButton radioEfectivo;
        private RadioButton radioTarjeta;
        private PictureBox imgAltaSocio;
        private GroupBox GroupCantidadDeCuotas;
        private Label label7;
        private RadioButton radio3Cuotas;
        private RadioButton radio6Cuotas;
        private CheckBox checkBoxAbonarAnio;
        private Label labelAbonarAnio;
        private Button buttonLimpiarBusqueda;
    }
}