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
            txtFechaPagoCuota = new TextBox();
            label6 = new Label();
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
            header.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox2.Controls.Add(txtFechaPagoCuota);
            groupBox2.Controls.Add(label6);
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
            groupBox2.Location = new Point(22, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(16, 12, 16, 16);
            groupBox2.Size = new Size(588, 313);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Del Socio";
            // 
            // txtFechaPagoCuota
            // 
            txtFechaPagoCuota.BorderStyle = BorderStyle.FixedSingle;
            txtFechaPagoCuota.Font = new Font("Segoe UI", 9F);
            txtFechaPagoCuota.Location = new Point(119, 215);
            txtFechaPagoCuota.Name = "txtFechaPagoCuota";
            txtFechaPagoCuota.ReadOnly = true;
            txtFechaPagoCuota.Size = new Size(130, 23);
            txtFechaPagoCuota.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.FromArgb(76, 76, 76);
            label6.Location = new Point(11, 215);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 16;
            label6.Text = "Fecha Pago Cuota";
            // 
            // txtHabilitado
            // 
            txtHabilitado.BorderStyle = BorderStyle.FixedSingle;
            txtHabilitado.Font = new Font("Segoe UI", 9F);
            txtHabilitado.Location = new Point(349, 215);
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
            label5.Location = new Point(278, 215);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 14;
            label5.Text = "Habilitado:";
            // 
            // textNumeroSocio
            // 
            textNumeroSocio.BorderStyle = BorderStyle.FixedSingle;
            textNumeroSocio.Font = new Font("Segoe UI", 9F);
            textNumeroSocio.Location = new Point(119, 172);
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
            label3.Location = new Point(11, 172);
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
            BuscarDeuda.Location = new Point(119, 254);
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
            BuscarSocio.Location = new Point(293, 26);
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
            txtDni.Location = new Point(49, 37);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "    Ingrese DNI a buscar";
            txtDni.Size = new Size(152, 23);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.Location = new Point(349, 129);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(130, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(119, 127);
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
            label4.Location = new Point(13, 39);
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
            label2.Location = new Point(289, 127);
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
            label1.Location = new Point(59, 129);
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
            // CobrarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 819);
            Controls.Add(VolverMenu);
            Controls.Add(groupBox2);
            Controls.Add(header);
            Name = "CobrarCuota";
            Text = "CobrarCuota";
            header.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private TextBox txtFechaPagoCuota;
        private Label label6;
    }
}