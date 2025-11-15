namespace Proyecto_Integrador_Grupo_11_B
{
    partial class ImprimirCarnet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            header = new Panel();
            lblTitulo = new Label();
            panelPreviewImprimir = new Panel();
            groupBoxFoto = new GroupBox();
            imgSocio = new PictureBox();
            groupBoxDatos = new GroupBox();
            lblNombreValor = new Label();
            lblApellidoValor = new Label();
            lblDniValor = new Label();
            lblFechaRegValor = new Label();
            lblFechaVtoValor = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblFechaReg = new Label();
            lblFechaVto = new Label();
            picBarcode = new PictureBox();
            VolverButton = new Button();
            ImprimirButton = new Button();
            header.SuspendLayout();
            panelPreviewImprimir.SuspendLayout();
            groupBoxFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgSocio).BeginInit();
            groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBarcode).BeginInit();
            SuspendLayout();
            // 
            // header (DENTRO de panelPreviewImprimir)
            // 
            header.BackColor = Color.FromArgb(74, 141, 248);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(886, 64);
            header.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(886, 64);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Club Deportivo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPreviewImprimir (TODO lo imprimible)
            // 
            panelPreviewImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPreviewImprimir.BackColor = Color.FromArgb(243, 246, 251);
            panelPreviewImprimir.Controls.Add(groupBoxFoto);
            panelPreviewImprimir.Controls.Add(groupBoxDatos);
            panelPreviewImprimir.Controls.Add(header);
            panelPreviewImprimir.Location = new Point(14, 12);
            panelPreviewImprimir.Name = "panelPreviewImprimir";
            panelPreviewImprimir.Size = new Size(886, 440);
            panelPreviewImprimir.TabIndex = 1;
            // 
            // groupBoxFoto
            // 
            groupBoxFoto.BackColor = Color.FromArgb(232, 239, 249);
            groupBoxFoto.Controls.Add(imgSocio);
            groupBoxFoto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxFoto.ForeColor = Color.FromArgb(31, 31, 31);
            groupBoxFoto.Location = new Point(20, 80); // debajo del header
            groupBoxFoto.Name = "groupBoxFoto";
            groupBoxFoto.Padding = new Padding(16, 19, 16, 19);
            groupBoxFoto.Size = new Size(240, 330);
            groupBoxFoto.TabIndex = 0;
            groupBoxFoto.TabStop = false;
            // 
            // imgSocio
            // 
            imgSocio.BorderStyle = BorderStyle.FixedSingle;
            imgSocio.Image = Properties.Resources.Goku;
            imgSocio.Location = new Point(32, 32);
            imgSocio.Name = "imgSocio";
            imgSocio.Size = new Size(176, 230);
            imgSocio.SizeMode = PictureBoxSizeMode.Zoom;
            imgSocio.TabIndex = 0;
            imgSocio.TabStop = false;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDatos.BackColor = Color.FromArgb(232, 239, 249);
            groupBoxDatos.Controls.Add(picBarcode);
            groupBoxDatos.Controls.Add(lblNombreValor);
            groupBoxDatos.Controls.Add(lblApellidoValor);
            groupBoxDatos.Controls.Add(lblDniValor);
            groupBoxDatos.Controls.Add(lblFechaRegValor);
            groupBoxDatos.Controls.Add(lblFechaVtoValor);
            groupBoxDatos.Controls.Add(lblNombre);
            groupBoxDatos.Controls.Add(lblApellido);
            groupBoxDatos.Controls.Add(lblDni);
            groupBoxDatos.Controls.Add(lblFechaReg);
            groupBoxDatos.Controls.Add(lblFechaVto);
            groupBoxDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.FromArgb(31, 31, 31);
            groupBoxDatos.Location = new Point(280, 80);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(18, 16, 18, 21);
            groupBoxDatos.Size = new Size(586, 330);
            groupBoxDatos.TabIndex = 1;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Datos";
            // 
            // Etiquetas (títulos)
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 19);
            lblNombre.Text = "Nombre:";
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(24, 84);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 19);
            lblApellido.Text = "Apellido:";
            lblDni.AutoSize = true;
            lblDni.Location = new Point(24, 120);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 19);
            lblDni.Text = "DNI:";
            lblFechaReg.AutoSize = true;
            lblFechaReg.Location = new Point(24, 156);
            lblFechaReg.Name = "lblFechaReg";
            lblFechaReg.Size = new Size(124, 19);
            lblFechaReg.Text = "Fecha registro:";
            lblFechaVto.AutoSize = true;
            lblFechaVto.Location = new Point(24, 192);
            lblFechaVto.Name = "lblFechaVto";
            lblFechaVto.Size = new Size(162, 19);
            lblFechaVto.Text = "Fecha de vencimiento:";
            // 
            // Valores
            // 
            lblNombreValor.AutoSize = true;
            lblNombreValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblNombreValor.Location = new Point(210, 48);
            lblNombreValor.Name = "lblNombreValor";
            lblNombreValor.Text = "-";
            lblApellidoValor.AutoSize = true;
            lblApellidoValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblApellidoValor.Location = new Point(210, 84);
            lblApellidoValor.Name = "lblApellidoValor";
            lblApellidoValor.Text = "-";
            lblDniValor.AutoSize = true;
            lblDniValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblDniValor.Location = new Point(210, 120);
            lblDniValor.Name = "lblDniValor";
            lblDniValor.Text = "-";
            lblFechaRegValor.AutoSize = true;
            lblFechaRegValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblFechaRegValor.Location = new Point(210, 156);
            lblFechaRegValor.Name = "lblFechaRegValor";
            lblFechaRegValor.Text = "-";
            lblFechaVtoValor.AutoSize = true;
            lblFechaVtoValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblFechaVtoValor.Location = new Point(210, 192);
            lblFechaVtoValor.Name = "lblFechaVtoValor";
            lblFechaVtoValor.Text = "-";
            // 
            // picBarcode
            // 
            picBarcode.BorderStyle = BorderStyle.FixedSingle;
            picBarcode.Location = new Point(24, 236);
            picBarcode.Name = "picBarcode";
            picBarcode.Size = new Size(540, 72);
            picBarcode.SizeMode = PictureBoxSizeMode.Zoom;
            picBarcode.TabIndex = 20;
            picBarcode.TabStop = false;
            // 
            // VolverButton
            // 
            VolverButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VolverButton.BackColor = Color.FromArgb(176, 196, 222);
            VolverButton.FlatAppearance.BorderSize = 0;
            VolverButton.FlatStyle = FlatStyle.Flat;
            VolverButton.Font = new Font("Segoe UI", 9F);
            VolverButton.ForeColor = Color.FromArgb(31, 31, 31);
            VolverButton.Location = new Point(27, 465);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(215, 59);
            VolverButton.TabIndex = 5;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = false;
            VolverButton.Click += VolverButton_Click;
            // 
            // ImprimirButton
            // 
            ImprimirButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ImprimirButton.BackColor = Color.FromArgb(138, 194, 133);
            ImprimirButton.FlatAppearance.BorderSize = 0;
            ImprimirButton.FlatStyle = FlatStyle.Flat;
            ImprimirButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImprimirButton.ForeColor = Color.White;
            ImprimirButton.Location = new Point(685, 465);
            ImprimirButton.Name = "ImprimirButton";
            ImprimirButton.Size = new Size(215, 59);
            ImprimirButton.TabIndex = 6;
            ImprimirButton.Text = "Imprimir";
            ImprimirButton.UseVisualStyleBackColor = false;
            ImprimirButton.Click += ImprimirButton_Click;
            // 
            // ImprimirCarnet (Form)
            // 
            AcceptButton = ImprimirButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 251);
            ClientSize = new Size(914, 540);
            Controls.Add(ImprimirButton);
            Controls.Add(VolverButton);
            Controls.Add(panelPreviewImprimir);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImprimirCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imprimir carnet socio";
            header.ResumeLayout(false);
            panelPreviewImprimir.ResumeLayout(false);
            groupBoxFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgSocio).EndInit();
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBarcode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label lblTitulo;

        private Panel panelPreviewImprimir;
        private GroupBox groupBoxFoto;
        private PictureBox imgSocio;
        private GroupBox groupBoxDatos;

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblFechaReg;
        private Label lblFechaVto;

        private Label lblNombreValor;
        private Label lblApellidoValor;
        private Label lblDniValor;
        private Label lblFechaRegValor;
        private Label lblFechaVtoValor;

        private PictureBox picBarcode;

        private Button ImprimirButton;
        private Button VolverButton;
    }
}
