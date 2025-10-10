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
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = ColorTranslator.FromHtml("#1F1F1F");
            groupBox1.BackColor = ColorTranslator.FromHtml("#E8EFF9");
            groupBox1.Location = new Point(60, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(16, 12, 16, 16);
            groupBox1.Size = new Size(463, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPass.Location = new Point(200, 98);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(210, 25);
            txtPass.TabIndex = 3;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.UseSystemPasswordChar = true;
            txtPass.ForeColor = SystemColors.ControlText;
            txtPass.Location = new Point(214, 88);
            txtPass.MaxLength = 20;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.ShortcutsEnabled = false;
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            txtPass.Enter += TxtPass_Enter;
            txtPass.Leave += TxtPass_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(200, 57);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 25);
            txtUsuario.TabIndex = 2;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = ColorTranslator.FromHtml("#4C4C4C");
            label2.Location = new Point(54, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = ColorTranslator.FromHtml("#4C4C4C");
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSalir.BackColor = ColorTranslator.FromHtml("#B0C4DE");
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSalir.ForeColor = ColorTranslator.FromHtml("#1F1F1F");
            BtnSalir.Location = new Point(60, 280);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(95, 32);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // button2 (Ingresar)
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = ColorTranslator.FromHtml("#8AC285");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(428, 280);
            button2.Name = "button2";
            button2.Size = new Size(95, 32);
            button2.TabIndex = 5;
            button2.Text = "Ingresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnIngresar_Click;
            // 
            // header
            // 
            header.BackColor = ColorTranslator.FromHtml("#4A8DF8");
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(583, 44);
            header.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(583, 44);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Club Deportivo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = ColorTranslator.FromHtml("#F3F6FB");
            ClientSize = new Size(583, 342);
            Controls.Add(header);
            Controls.Add(button2);
            Controls.Add(BtnSalir);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            AcceptButton = button2;
            CancelButton = BtnSalir;
            Name = "Login";
            Text = "Club Deportivo";
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
