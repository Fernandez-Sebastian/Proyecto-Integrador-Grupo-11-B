namespace Proyecto_Integrador_Grupo_11_B
{
    partial class RegistrarSocio
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
            groupBox1 = new GroupBox();
            imgAltaSocio = new PictureBox();
            groupBox2 = new GroupBox();
            dtpFechaNacimiento = new DateTimePicker();
            chkAptoMedico = new CheckBox();
            ImprimirCarnet = new Button();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(imgAltaSocio);
            groupBox1.Location = new Point(31, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // imgAltaSocio
            // 
            imgAltaSocio.Image = Properties.Resources.AltaSocio;
            imgAltaSocio.Location = new Point(28, 22);
            imgAltaSocio.Name = "imgAltaSocio";
            imgAltaSocio.Size = new Size(154, 146);
            imgAltaSocio.SizeMode = PictureBoxSizeMode.Zoom;
            imgAltaSocio.TabIndex = 0;
            imgAltaSocio.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpFechaNacimiento);
            groupBox2.Controls.Add(chkAptoMedico);
            groupBox2.Controls.Add(ImprimirCarnet);
            groupBox2.Controls.Add(txtDni);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(AptoMedico);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(245, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(148, 137);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(241, 23);
            dtpFechaNacimiento.TabIndex = 14;
            // 
            // chkAptoMedico
            // 
            chkAptoMedico.AutoSize = true;
            chkAptoMedico.Location = new Point(387, 82);
            chkAptoMedico.Name = "chkAptoMedico";
            chkAptoMedico.Size = new Size(15, 14);
            chkAptoMedico.TabIndex = 0;
            chkAptoMedico.UseVisualStyleBackColor = true;
            // 
            // ImprimirCarnet
            // 
            ImprimirCarnet.Location = new Point(24, 205);
            ImprimirCarnet.Name = "ImprimirCarnet";
            ImprimirCarnet.Size = new Size(182, 49);
            ImprimirCarnet.TabIndex = 4;
            ImprimirCarnet.Text = "Imprimir Carnet";
            ImprimirCarnet.UseVisualStyleBackColor = true;
            ImprimirCarnet.Click += ImprimirCarnet_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(369, 28);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(109, 23);
            txtDni.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(135, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(109, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(109, 23);
            txtNombre.TabIndex = 6;
            // 
            // AptoMedico
            // 
            AptoMedico.AutoSize = true;
            AptoMedico.Location = new Point(305, 81);
            AptoMedico.Name = "AptoMedico";
            AptoMedico.Size = new Size(76, 15);
            AptoMedico.TabIndex = 5;
            AptoMedico.Text = "Apto Médico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 145);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 36);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Registrar
            // 
            Registrar.Location = new Point(573, 389);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(182, 49);
            Registrar.TabIndex = 2;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // VolverMenu
            // 
            VolverMenu.Location = new Point(31, 389);
            VolverMenu.Name = "VolverMenu";
            VolverMenu.Size = new Size(182, 49);
            VolverMenu.TabIndex = 3;
            VolverMenu.Text = "Volver";
            VolverMenu.UseVisualStyleBackColor = true;
            VolverMenu.Click += VolverMenu_Click;
            // 
            // RegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VolverMenu);
            Controls.Add(Registrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegistrarSocio";
            Text = "Registrar Socio";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
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
        private Button ImprimirCarnet;
        private CheckBox chkAptoMedico;
        private PictureBox imgAltaSocio;
        private DateTimePicker dtpFechaNacimiento;
    }
}