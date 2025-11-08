namespace Proyecto_Integrador_Grupo_11_B
{
    partial class ListarVencimientos
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            header = new Panel();
            lblTitulo = new Label();
            gbParamFecha = new GroupBox();
            ListarVencimientosBtn = new Button();
            dtFechaSeleccionada = new DateTimePicker();
            rbFechaSeleccionada = new RadioButton();
            rbFechaActual = new RadioButton();
            dataGridViewSociosDeudores = new DataGridView();
            NombreSocioColumn = new DataGridViewTextBoxColumn();
            ApellidoSocioColumn = new DataGridViewTextBoxColumn();
            DniSocioColumn = new DataGridViewTextBoxColumn();
            CuotasVencidasSocioColumn = new DataGridViewTextBoxColumn();
            FechaVencimientoSocioColumn = new DataGridViewTextBoxColumn();
            MontoDeudaSocioColumn = new DataGridViewTextBoxColumn();
            conexionBindingSource = new BindingSource(components);
            header.SuspendLayout();
            gbParamFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSociosDeudores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(74, 141, 248);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(942, 64);
            header.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(942, 64);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listar Deudores";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbParamFecha
            // 
            gbParamFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbParamFecha.BackColor = Color.FromArgb(232, 239, 249);
            gbParamFecha.Controls.Add(ListarVencimientosBtn);
            gbParamFecha.Controls.Add(dtFechaSeleccionada);
            gbParamFecha.Controls.Add(rbFechaSeleccionada);
            gbParamFecha.Controls.Add(rbFechaActual);
            gbParamFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbParamFecha.ForeColor = Color.FromArgb(31, 31, 31);
            gbParamFecha.Location = new Point(24, 84);
            gbParamFecha.Name = "gbParamFecha";
            gbParamFecha.Padding = new Padding(18, 16, 18, 16);
            gbParamFecha.Size = new Size(894, 124);
            gbParamFecha.TabIndex = 1;
            gbParamFecha.TabStop = false;
            gbParamFecha.Text = "Listar por";
            // 
            // ListarVencimientosBtn
            // 
            ListarVencimientosBtn.Anchor = AnchorStyles.Top;
            ListarVencimientosBtn.BackColor = Color.FromArgb(176, 196, 222);
            ListarVencimientosBtn.FlatAppearance.BorderSize = 0;
            ListarVencimientosBtn.FlatStyle = FlatStyle.Flat;
            ListarVencimientosBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ListarVencimientosBtn.ForeColor = Color.FromArgb(31, 31, 31);
            ListarVencimientosBtn.Location = new Point(670, 59);
            ListarVencimientosBtn.Name = "ListarVencimientosBtn";
            ListarVencimientosBtn.Size = new Size(203, 43);
            ListarVencimientosBtn.TabIndex = 3;
            ListarVencimientosBtn.Text = "Listar vencimientos";
            ListarVencimientosBtn.UseVisualStyleBackColor = false;
            ListarVencimientosBtn.Click += ListarVencimientos_Click;
            // 
            // dtFechaSeleccionada
            // 
            dtFechaSeleccionada.CalendarForeColor = Color.FromArgb(31, 31, 31);
            dtFechaSeleccionada.CalendarMonthBackground = Color.White;
            dtFechaSeleccionada.CalendarTitleBackColor = Color.FromArgb(176, 196, 222);
            dtFechaSeleccionada.CalendarTitleForeColor = Color.FromArgb(31, 31, 31);
            dtFechaSeleccionada.CustomFormat = "dd/MM/yyyy";
            dtFechaSeleccionada.Font = new Font("Segoe UI", 9F);
            dtFechaSeleccionada.Format = DateTimePickerFormat.Custom;
            dtFechaSeleccionada.Location = new Point(224, 75);
            dtFechaSeleccionada.Name = "dtFechaSeleccionada";
            dtFechaSeleccionada.Size = new Size(200, 27);
            dtFechaSeleccionada.TabIndex = 1;
            // 
            // rbFechaSeleccionada
            // 
            rbFechaSeleccionada.AutoSize = true;
            rbFechaSeleccionada.Font = new Font("Segoe UI", 9F);
            rbFechaSeleccionada.Location = new Point(21, 78);
            rbFechaSeleccionada.Name = "rbFechaSeleccionada";
            rbFechaSeleccionada.Size = new Size(158, 24);
            rbFechaSeleccionada.TabIndex = 2;
            rbFechaSeleccionada.TabStop = true;
            rbFechaSeleccionada.Text = "Fecha seleccionada";
            rbFechaSeleccionada.UseVisualStyleBackColor = true;
            // 
            // rbFechaActual
            // 
            rbFechaActual.AutoSize = true;
            rbFechaActual.Font = new Font("Segoe UI", 9F);
            rbFechaActual.Location = new Point(21, 39);
            rbFechaActual.Name = "rbFechaActual";
            rbFechaActual.Size = new Size(112, 24);
            rbFechaActual.TabIndex = 0;
            rbFechaActual.TabStop = true;
            rbFechaActual.Text = "Fecha actual";
            rbFechaActual.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSociosDeudores
            // 
            dataGridViewSociosDeudores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSociosDeudores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSociosDeudores.BackgroundColor = Color.FromArgb(232, 239, 249);
            dataGridViewSociosDeudores.BorderStyle = BorderStyle.None;
            dataGridViewSociosDeudores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSociosDeudores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSociosDeudores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSociosDeudores.ColumnHeadersHeight = 36;
            dataGridViewSociosDeudores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewSociosDeudores.Columns.AddRange(new DataGridViewColumn[] { NombreSocioColumn, ApellidoSocioColumn, DniSocioColumn, CuotasVencidasSocioColumn, FechaVencimientoSocioColumn, MontoDeudaSocioColumn });
            dataGridViewSociosDeudores.EnableHeadersVisualStyles = false;
            dataGridViewSociosDeudores.GridColor = Color.FromArgb(208, 218, 235);
            dataGridViewSociosDeudores.Location = new Point(24, 224);
            dataGridViewSociosDeudores.MultiSelect = false;
            dataGridViewSociosDeudores.Name = "dataGridViewSociosDeudores";
            dataGridViewSociosDeudores.RowHeadersVisible = false;
            dataGridViewSociosDeudores.RowHeadersWidth = 51;
            dataGridViewSociosDeudores.RowTemplate.Height = 28;
            dataGridViewSociosDeudores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSociosDeudores.Size = new Size(894, 309);
            dataGridViewSociosDeudores.TabIndex = 2;
            // 
            // NombreSocioColumn
            // 
            NombreSocioColumn.HeaderText = "Nombre";
            NombreSocioColumn.MinimumWidth = 70;
            NombreSocioColumn.Name = "NombreSocioColumn";
            // 
            // ApellidoSocioColumn
            // 
            ApellidoSocioColumn.HeaderText = "Apellido";
            ApellidoSocioColumn.MinimumWidth = 70;
            ApellidoSocioColumn.Name = "ApellidoSocioColumn";
            // 
            // DniSocioColumn
            // 
            DniSocioColumn.HeaderText = "DNI";
            DniSocioColumn.MinimumWidth = 70;
            DniSocioColumn.Name = "DniSocioColumn";
            // 
            // CuotasVencidasSocioColumn
            // 
            CuotasVencidasSocioColumn.HeaderText = "Cuotas vencidas";
            CuotasVencidasSocioColumn.MinimumWidth = 90;
            CuotasVencidasSocioColumn.Name = "CuotasVencidasSocioColumn";
            // 
            // FechaVencimientoSocioColumn
            // 
            FechaVencimientoSocioColumn.HeaderText = "Fecha vencimiento";
            FechaVencimientoSocioColumn.MinimumWidth = 90;
            FechaVencimientoSocioColumn.Name = "FechaVencimientoSocioColumn";
            // 
            // MontoDeudaSocioColumn
            // 
            MontoDeudaSocioColumn.HeaderText = "Deuda";
            MontoDeudaSocioColumn.MinimumWidth = 90;
            MontoDeudaSocioColumn.Name = "MontoDeudaSocioColumn";
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // ListarVencimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 251);
            ClientSize = new Size(942, 563);
            Controls.Add(dataGridViewSociosDeudores);
            Controls.Add(gbParamFecha);
            Controls.Add(header);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarVencimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Deudores";
            header.ResumeLayout(false);
            gbParamFecha.ResumeLayout(false);
            gbParamFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSociosDeudores).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label lblTitulo;

        private GroupBox gbParamFecha;
        private RadioButton rbFechaActual;
        private RadioButton rbFechaSeleccionada;
        private DateTimePicker dtFechaSeleccionada;
        private Button ListarVencimientosBtn;

        private DataGridView dataGridViewSociosDeudores;
        private DataGridViewTextBoxColumn NombreSocioColumn;
        private DataGridViewTextBoxColumn ApellidoSocioColumn;
        private DataGridViewTextBoxColumn DniSocioColumn;
        private DataGridViewTextBoxColumn CuotasVencidasSocioColumn;
        private DataGridViewTextBoxColumn FechaVencimientoSocioColumn;
        private DataGridViewTextBoxColumn MontoDeudaSocioColumn;

        private BindingSource conexionBindingSource;
    }
}
