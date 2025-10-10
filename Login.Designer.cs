namespace Proyecto_Integrador_Grupo_11_B
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
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
            groupBox1.Text = "Login";
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.ForeColor = SystemColors.ControlText;
            txtPass.Location = new Point(229, 125);
            txtPass.Margin = new Padding(3, 5, 3, 5);
            txtPass.MaxLength = 20;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.ShortcutsEnabled = false;
            txtPass.Size = new Size(240, 30);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            txtPass.Enter += TxtPass_Enter;
            txtPass.Leave += TxtPass_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(229, 76);
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
            label2.Location = new Point(62, 135);
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
            label1.Location = new Point(62, 80);
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
            button2.UseVisualStyleBackColor = false;
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
            // Login
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
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            header.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}
