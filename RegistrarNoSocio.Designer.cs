using Proyecto_Integrador_Grupo_11_B.Themes;

namespace Proyecto_Integrador_Grupo_11_B
{
    partial class RegistrarNoSocio
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
            groupBox1 = new GroupBox();
            imgAltaSocio = new PictureBox();
            groupBox2 = new GroupBox();
            dtpFechaNacimiento = new DateTimePicker();
            chkAptoMedico = new CheckBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            AptoMedico = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Registrar = new Button();
            VolverMenu = new Button();
            header.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).BeginInit();
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
            header.Size = new Size(800, 48);
            header.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar No Socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(232, 239, 249);
            groupBox1.Controls.Add(imgAltaSocio);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(31, 31, 31);
            groupBox1.Location = new Point(24, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(14);
            groupBox1.Size = new Size(210, 290);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // imgAltaNoSocio
            // 
            imgAltaSocio.BorderStyle = BorderStyle.FixedSingle;
            imgAltaSocio.Image = Properties.Resources.AltaSocio;
            imgAltaSocio.Location = new Point(28, 28);
            imgAltaSocio.Name = "imgAltaSocio";
            imgAltaSocio.Size = new Size(154, 154);
            imgAltaSocio.SizeMode = PictureBoxSizeMode.Zoom;
            imgAltaSocio.TabIndex = 0;
            imgAltaSocio.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(232, 239, 249);
            groupBox2.Controls.Add(dtpFechaNacimiento);
            groupBox2.Controls.Add(chkAptoMedico);
            groupBox2.Controls.Add(txtDni);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(AptoMedico);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(31, 31, 31);
            groupBox2.Location = new Point(250, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(16, 12, 16, 16);
            groupBox2.Size = new Size(526, 290);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 9F);
            dtpFechaNacimiento.Location = new Point(170, 139);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(260, 23);
            dtpFechaNacimiento.TabIndex = 4;
            // 
            // chkAptoMedico
            // 
            chkAptoMedico.AutoSize = true;
            chkAptoMedico.Location = new Point(404, 86);
            chkAptoMedico.Name = "chkAptoMedico";
            chkAptoMedico.Size = new Size(15, 14);
            chkAptoMedico.TabIndex = 3;
            chkAptoMedico.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 9F);
            txtDni.Location = new Point(370, 32);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(110, 23);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.Location = new Point(135, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(135, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 0;
            // 
            // AptoMedico
            // 
            AptoMedico.AutoSize = true;
            AptoMedico.Font = new Font("Segoe UI", 9F);
            AptoMedico.ForeColor = Color.FromArgb(76, 76, 76);
            AptoMedico.Location = new Point(305, 84);
            AptoMedico.Name = "AptoMedico";
            AptoMedico.Size = new Size(76, 15);
            AptoMedico.TabIndex = 10;
            AptoMedico.Text = "Apto médico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(76, 76, 76);
            label5.Location = new Point(24, 142);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(76, 76, 76);
            label4.Location = new Point(305, 35);
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
            label2.Location = new Point(24, 83);
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
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // Registrar
            // 
            Registrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Registrar.BackColor = Color.FromArgb(138, 194, 133);
            Registrar.FlatAppearance.BorderSize = 0;
            Registrar.FlatStyle = FlatStyle.Flat;
            Registrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Registrar.ForeColor = Color.White;
            Registrar.Location = new Point(588, 392);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(188, 44);
            Registrar.TabIndex = 6;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = false;
            Registrar.Click += Registrar_Click;
            // 
            // VolverMenu
            // 
            VolverMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VolverMenu.BackColor = Color.FromArgb(176, 196, 222);
            VolverMenu.FlatAppearance.BorderSize = 0;
            VolverMenu.FlatStyle = FlatStyle.Flat;
            VolverMenu.Font = new Font("Segoe UI", 9F);
            VolverMenu.ForeColor = Color.FromArgb(31, 31, 31);
            VolverMenu.Location = new Point(24, 392);
            VolverMenu.Name = "VolverMenu";
            VolverMenu.Size = new Size(188, 44);
            VolverMenu.TabIndex = 5;
            VolverMenu.Text = "Volver";
            VolverMenu.UseVisualStyleBackColor = false;
            VolverMenu.Click += VolverMenu_Click;
            // 
            // RegistrarNoSocio
            // 
            AcceptButton = Registrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(VolverMenu);
            Controls.Add(Registrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(header);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrarNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar No Socio";
            header.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

            Tema.Aplicar(this);
        }

        #endregion

        private Panel header;
        private Label lblTitulo;
        private GroupBox groupBox1;
        private PictureBox imgAltaSocio;
        private GroupBox groupBox2;
        private DateTimePicker dtpFechaNacimiento;
        private CheckBox chkAptoMedico;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label AptoMedico;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button Registrar;
        private Button VolverMenu;
    }
}
