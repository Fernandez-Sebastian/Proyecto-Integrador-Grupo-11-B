namespace Proyecto_Integrador_Grupo_11_B
{
    partial class SistemaClub
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
            CobrarCuota = new Button();
            RegistrarNoSocio = new Button();
            RegistrarSocio = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            SalirSistema = new Button();
            MostrarDeudaCuotaSocio = new Button();
            SuspendLayout();
            // 
            // CobrarCuota
            // 
            CobrarCuota.Location = new Point(530, 273);
            CobrarCuota.Name = "CobrarCuota";
            CobrarCuota.Size = new Size(241, 50);
            CobrarCuota.TabIndex = 2;
            CobrarCuota.Text = "Cobrar Cuota Socio";
            CobrarCuota.UseVisualStyleBackColor = true;
            CobrarCuota.Click += CobrarCuota_Click;
            // 
            // RegistrarNoSocio
            // 
            RegistrarNoSocio.Location = new Point(47, 168);
            RegistrarNoSocio.Name = "RegistrarNoSocio";
            RegistrarNoSocio.Size = new Size(128, 99);
            RegistrarNoSocio.TabIndex = 1;
            RegistrarNoSocio.Text = "Registrar No Socio";
            RegistrarNoSocio.UseVisualStyleBackColor = true;
            RegistrarNoSocio.Click += RegistrarNoSocio_Click;
            // 
            // RegistrarSocio
            // 
            RegistrarSocio.Location = new Point(47, 23);
            RegistrarSocio.Name = "RegistrarSocio";
            RegistrarSocio.Size = new Size(128, 99);
            RegistrarSocio.TabIndex = 0;
            RegistrarSocio.Text = "Registrar Socio";
            RegistrarSocio.UseVisualStyleBackColor = true;
            RegistrarSocio.Click += RegistrarSocio_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(276, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(239, 244);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Socios Deudores";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(530, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 244);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cuotas";
            // 
            // SalirSistema
            // 
            SalirSistema.Location = new Point(47, 377);
            SalirSistema.Name = "SalirSistema";
            SalirSistema.Size = new Size(203, 61);
            SalirSistema.TabIndex = 3;
            SalirSistema.Text = "Salir";
            SalirSistema.UseVisualStyleBackColor = true;
            SalirSistema.Click += button1_Click;
            // 
            // MostrarDeudaCuotaSocio
            // 
            MostrarDeudaCuotaSocio.Location = new Point(276, 273);
            MostrarDeudaCuotaSocio.Name = "MostrarDeudaCuotaSocio";
            MostrarDeudaCuotaSocio.Size = new Size(241, 50);
            MostrarDeudaCuotaSocio.TabIndex = 4;
            MostrarDeudaCuotaSocio.Text = "Listado Socios Deudores";
            MostrarDeudaCuotaSocio.UseVisualStyleBackColor = true;
            MostrarDeudaCuotaSocio.Click += MostrarDeudaCuotaSocio_Click;
            // 
            // SistemaClub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MostrarDeudaCuotaSocio);
            Controls.Add(SalirSistema);
            Controls.Add(CobrarCuota);
            Controls.Add(groupBox3);
            Controls.Add(RegistrarNoSocio);
            Controls.Add(groupBox2);
            Controls.Add(RegistrarSocio);
            Name = "SistemaClub";
            Text = "SistemaClub";
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button CobrarCuota;
        private Button RegistrarNoSocio;
        private Button RegistrarSocio;
        private Button SalirSistema;
        private Button MostrarDeudaCuotaSocio;
    }
}