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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(95, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // txtPass
            // 
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
            txtUsuario.Location = new Point(214, 49);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 96);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 52);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(114, 258);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 1;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(393, 258);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Ingresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 342);
            Controls.Add(button2);
            Controls.Add(BtnSalir);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Club Deportivo";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}
