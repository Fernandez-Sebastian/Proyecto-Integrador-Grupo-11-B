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
            button3 = new Button();
            RegistrarNoSocio = new Button();
            RegistrarSocio = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(47, 318);
            button3.Name = "button3";
            button3.Size = new Size(128, 99);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // RegistrarNoSocio
            // 
            RegistrarNoSocio.Location = new Point(47, 168);
            RegistrarNoSocio.Name = "RegistrarNoSocio";
            RegistrarNoSocio.Size = new Size(128, 99);
            RegistrarNoSocio.TabIndex = 1;
            RegistrarNoSocio.Text = "Registrar No Socio";
            RegistrarNoSocio.UseVisualStyleBackColor = true;
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
            groupBox2.Size = new Size(248, 404);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(530, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(248, 404);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // SistemaClub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(RegistrarNoSocio);
            Controls.Add(groupBox2);
            Controls.Add(RegistrarSocio);
            Name = "SistemaClub";
            Text = "SistemaClub";
            Load += SistemaClub_Load;
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button3;
        private Button RegistrarNoSocio;
        private Button RegistrarSocio;
    }
}