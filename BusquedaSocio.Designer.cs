namespace Proyecto_Integrador_Grupo_11_B
{
    partial class BusquedaSocio
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
            dniSocioLabel = new Label();
            dniSocioText = new TextBox();
            resultadoLabel = new Label();
            cardDatos = new GroupBox();
            buscarButton = new Button();
            imprimirCarnetButton = new Button();
            VolverMenu = new Button();
            header.SuspendLayout();
            cardDatos.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(74, 141, 248);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(689, 64);
            header.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(689, 64);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema del Club";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dniSocioLabel
            // 
            dniSocioLabel.AutoSize = true;
            dniSocioLabel.Location = new Point(35, 57);
            dniSocioLabel.Name = "dniSocioLabel";
            dniSocioLabel.Size = new Size(51, 23);
            dniSocioLabel.TabIndex = 1;
            dniSocioLabel.Text = "DNI: ";
            // 
            // dniSocioText
            // 
            dniSocioText.Location = new Point(102, 53);
            dniSocioText.Name = "dniSocioText";
            dniSocioText.Size = new Size(243, 30);
            dniSocioText.TabIndex = 2;
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Location = new Point(29, 241);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(119, 20);
            resultadoLabel.TabIndex = 4;
            resultadoLabel.Text = string.Empty;
            resultadoLabel.Font = new Font(resultadoLabel.Font, FontStyle.Bold);
            // 
            // cardDatos
            // 
            cardDatos.BackColor = Color.FromArgb(232, 239, 249);
            cardDatos.Controls.Add(dniSocioLabel);
            cardDatos.Controls.Add(dniSocioText);
            cardDatos.Controls.Add(buscarButton);
            cardDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cardDatos.ForeColor = Color.FromArgb(31, 31, 31);
            cardDatos.Location = new Point(29, 85);
            cardDatos.Name = "cardDatos";
            cardDatos.Padding = new Padding(18, 16, 18, 21);
            cardDatos.Size = new Size(628, 136);
            cardDatos.TabIndex = 5;
            cardDatos.TabStop = false;
            cardDatos.Text = "Socio";
            // 
            // buscarButton
            // 
            buscarButton.Location = new Point(376, 54);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(191, 29);
            buscarButton.TabIndex = 3;
            buscarButton.Text = "Buscar socio";
            buscarButton.UseVisualStyleBackColor = true;
            buscarButton.Click += BuscarButton_Click;
            // 
            // imprimirCarnetButton
            // 
            imprimirCarnetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            imprimirCarnetButton.BackColor = Color.FromArgb(138, 194, 133);
            imprimirCarnetButton.FlatAppearance.BorderSize = 0;
            imprimirCarnetButton.FlatStyle = FlatStyle.Flat;
            imprimirCarnetButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            imprimirCarnetButton.ForeColor = Color.White;
            imprimirCarnetButton.Location = new Point(442, 282);
            imprimirCarnetButton.Margin = new Padding(3, 4, 3, 4);
            imprimirCarnetButton.Name = "imprimirCarnetButton";
            imprimirCarnetButton.Size = new Size(215, 59);
            imprimirCarnetButton.TabIndex = 7;
            imprimirCarnetButton.Text = "Imprimir Carnet";
            imprimirCarnetButton.UseVisualStyleBackColor = false;
            imprimirCarnetButton.Enabled = false;
            imprimirCarnetButton.Click += ImprimirCarnetButton_Click;
            // 
            // VolverMenu
            // 
            VolverMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VolverMenu.BackColor = Color.FromArgb(176, 196, 222);
            VolverMenu.FlatAppearance.BorderSize = 0;
            VolverMenu.FlatStyle = FlatStyle.Flat;
            VolverMenu.Font = new Font("Segoe UI", 9F);
            VolverMenu.ForeColor = Color.FromArgb(31, 31, 31);
            VolverMenu.Location = new Point(29, 282);
            VolverMenu.Margin = new Padding(3, 4, 3, 4);
            VolverMenu.Name = "VolverMenu";
            VolverMenu.Size = new Size(215, 59);
            VolverMenu.TabIndex = 8;
            VolverMenu.Text = "Volver";
            VolverMenu.UseVisualStyleBackColor = false;
            VolverMenu.Click += VolverMenu_Click;
            // 
            // BusquedaSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 354);
            Controls.Add(VolverMenu);
            Controls.Add(imprimirCarnetButton);
            Controls.Add(cardDatos);
            Controls.Add(resultadoLabel);
            Controls.Add(header);
            Name = "BusquedaSocio";
            header.ResumeLayout(false);
            cardDatos.ResumeLayout(false);
            cardDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private Label lblTitulo;
        private Label dniSocioLabel;
        private TextBox dniSocioText;
        private Label resultadoLabel;
        private GroupBox cardDatos;
        private Button imprimirCarnetButton;
        private Button VolverMenu;
        private Button buscarButton;
    }
}