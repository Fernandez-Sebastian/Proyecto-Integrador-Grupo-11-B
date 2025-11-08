namespace Proyecto_Integrador_Grupo_11_B
{
    partial class ConfiguracionBD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtPuerto = new TextBox();
            txtServidor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnSalir = new Button();
            button2 = new Button();
            header = new Panel();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(232, 239, 249);
            groupBox1.Controls.Add(txtPuerto);
            groupBox1.Controls.Add(txtServidor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(31, 31, 31);
            groupBox1.Location = new Point(69, 93);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(18, 16, 18, 21);
            groupBox1.Size = new Size(529, 247);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conexión BD";
            // 
            // txtPuerto
            // 
            txtPuerto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPuerto.BorderStyle = BorderStyle.FixedSingle;
            txtPuerto.Font = new Font("Segoe UI", 10F);
            txtPuerto.ForeColor = SystemColors.ControlText;
            txtPuerto.Location = new Point(229, 85);
            txtPuerto.Margin = new Padding(3, 5, 3, 5);
            txtPuerto.MaxLength = 20;
            txtPuerto.Name = "txtPuerto";
            txtPuerto.ShortcutsEnabled = false;
            txtPuerto.Size = new Size(240, 30);
            txtPuerto.TabIndex = 7;
            // 
            // txtServidor
            // 
            txtServidor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtServidor.BorderStyle = BorderStyle.FixedSingle;
            txtServidor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServidor.Location = new Point(229, 35);
            txtServidor.Margin = new Padding(3, 4, 3, 4);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(240, 30);
            txtServidor.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(76, 76, 76);
            label3.Location = new Point(52, 89);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Puerto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(76, 76, 76);
            label4.Location = new Point(52, 39);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 4;
            label4.Text = "Servidor";
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 10F);
            txtPass.ForeColor = SystemColors.ControlText;
            txtPass.Location = new Point(229, 185);
            txtPass.Margin = new Padding(3, 5, 3, 5);
            txtPass.MaxLength = 20;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.ShortcutsEnabled = false;
            txtPass.Size = new Size(240, 30);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(229, 135);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(240, 30);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(76, 76, 76);
            label2.Location = new Point(52, 189);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(76, 76, 76);
            label1.Location = new Point(52, 139);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSalir.BackColor = Color.FromArgb(176, 196, 222);
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI", 9F);
            BtnSalir.ForeColor = Color.FromArgb(31, 31, 31);
            BtnSalir.Location = new Point(69, 373);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(109, 43);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(138, 194, 133);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(489, 373);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(109, 43);
            button2.TabIndex = 5;
            button2.Text = "Ingresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnIngresar_Click;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(74, 141, 248);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(666, 59);
            header.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(666, 59);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Club Deportivo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConfiguracionBD
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 251);
            CancelButton = BtnSalir;
            ClientSize = new Size(666, 456);
            Controls.Add(header);
            Controls.Add(button2);
            Controls.Add(BtnSalir);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfiguracionBD";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ConfiguracionBD_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            header.ResumeLayout(false);
            ResumeLayout(false);

            //Acá puse lo del tab
            txtServidor.TabIndex = 0;
            txtPuerto.TabIndex = 1;
            txtUsuario.TabIndex = 2;
            txtPass.TabIndex = 3;
            button2.TabIndex = 4; 
            BtnSalir.TabIndex = 5;
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtPass;
        private TextBox txtUsuario;
        private Button BtnSalir;
        private Button button2;
        private Panel header;
        private Label lblTitulo;
        private TextBox txtPuerto;
        private TextBox txtServidor;
        private Label label3;
        private Label label4;
    }
}
