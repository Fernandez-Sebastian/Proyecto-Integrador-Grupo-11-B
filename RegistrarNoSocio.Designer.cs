using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador_Grupo_11_B
{
    partial class RegistrarNoSocio
    {
        private System.ComponentModel.IContainer components = null;

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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(803, 48);
            header.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(803, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar No Socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(imgAltaSocio);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(24, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(14);
            groupBox1.Size = new Size(210, 217);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagen";
            // 
            // imgAltaSocio
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
            groupBox2.Location = new Point(250, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(16, 12, 16, 16);
            groupBox2.Size = new Size(529, 217);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaNacimiento.Location = new Point(170, 139);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(263, 25);
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
            txtDni.Location = new Point(370, 32);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(110, 25);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(135, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 25);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(135, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 25);
            txtNombre.TabIndex = 0;
            // 
            // AptoMedico
            // 
            AptoMedico.AutoSize = true;
            AptoMedico.Location = new Point(305, 84);
            AptoMedico.Name = "AptoMedico";
            AptoMedico.Size = new Size(96, 19);
            AptoMedico.TabIndex = 10;
            AptoMedico.Text = "Apto médico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 142);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 9;
            label5.Text = "Fecha nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 35);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 8;
            label4.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // Registrar
            // 
            Registrar.Location = new Point(588, 329);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(188, 44);
            Registrar.TabIndex = 6;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // VolverMenu
            // 
            VolverMenu.Location = new Point(24, 329);
            VolverMenu.Name = "VolverMenu";
            VolverMenu.Size = new Size(188, 44);
            VolverMenu.TabIndex = 5;
            VolverMenu.Text = "Volver";
            VolverMenu.UseVisualStyleBackColor = true;
            VolverMenu.Click += VolverMenu_Click;
            // 
            // RegistrarNoSocio
            // 
            AcceptButton = Registrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 409);
            Controls.Add(VolverMenu);
            Controls.Add(Registrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(header);
            Name = "RegistrarNoSocio";
            Text = "Registrar No Socio";
            header.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgAltaSocio).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
