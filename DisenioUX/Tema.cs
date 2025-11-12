using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto_Integrador_Grupo_11_B
{
    public static class Tema
    {
        public static void Aplicar(Form form)
        {
            if (form == null) return;

            // ====== Configuración base ======
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;

            // activar double buffer por reflexión
            var prop = form.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic);
            prop?.SetValue(form, true, null);

            // ====== Fondo con imagen ======
            try
            {
                var img = Proyecto_Integrador_Grupo_11_B.Properties.Resources
                    .ResourceManager
                    .GetObject("Login_Club") as Image;   // nombre en tu .resx

                if (img != null)
                {
                    form.BackgroundImage = img;
                    form.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    form.BackColor = Color.FromArgb(18, 22, 30);
                }
            }
            catch
            {
                form.BackColor = Color.FromArgb(18, 22, 30);
            }

            // ====== Ventana redondeada ======
            int radio = 25;
            form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, radio, radio));

            // ====== Header ======
            Panel header = form.Controls["header"] as Panel;
            if (header != null)
            {
                header.BackColor = Color.FromArgb(45, 50, 60);
                foreach (var lbl in header.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Color.White;
                    lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                }
                header.MouseDown += (s, e) => DragWindow(form);
            }

            // ====== Tarjeta vidrio ======
            var card = new GlassCard
            {
                Name = "__glassCard",
                BackColor = Color.Transparent,
                Location = new Point(20, (header?.Bottom ?? 0) + 20),
                Size = new Size(
                    form.ClientSize.Width - 40,
                    // 🔴 acá estaba el error: (header?.Bottom ?? ) → le faltaba el 0
                    form.ClientSize.Height - (header?.Bottom ?? 0) - 35
                ),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            form.Controls.Add(card);
            card.BringToFront();

            // ====== mover controles al card ======
            var mover = form.Controls
                .Cast<Control>()
                .Where(c => c != header && c != card)
                .ToList();

            foreach (var ctrl in mover)
            {
                form.Controls.Remove(ctrl);

                // subir solo los groupBox un poco (estaban muy abajo)
                if (ctrl is GroupBox gb)
                {
                    gb.BackColor = Color.Transparent;
                    gb.ForeColor = Color.White;
                    gb.Top = Math.Max(0, gb.Top - 10);
                }

                card.Controls.Add(ctrl);
            }

            // ====== botones estilo ======
            if (card.Controls["Registrar"] is Button btnReg)
            {
                EstiloBoton(btnReg, Color.FromArgb(230, 50, 80), Color.FromArgb(255, 70, 100));
                btnReg.Location = new Point(card.Width - 220, card.Height - 43);
                btnReg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                btnReg.BringToFront();
            }

            if (card.Controls["VolverMenu"] is Button btnVolver)
            {
                EstiloBoton(btnVolver, Color.FromArgb(70, 75, 90), Color.FromArgb(90, 95, 110));
                btnVolver.Location = new Point(40, card.Height - 43);
                btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                btnVolver.BringToFront();
            }

            // ====== labels y textos en blanco ======
            foreach (Label lbl in GetAll<Label>(card))
                lbl.ForeColor = Color.White;

            foreach (TextBox txt in GetAll<TextBox>(card))
            {
                txt.BackColor = Color.FromArgb(55, 60, 70);
                txt.ForeColor = Color.White;
                txt.BorderStyle = BorderStyle.FixedSingle;
            }

            foreach (DateTimePicker dtp in GetAll<DateTimePicker>(card))
            {
                dtp.CalendarMonthBackground = Color.FromArgb(55, 60, 70);
                dtp.CalendarForeColor = Color.White;
                dtp.BackColor = Color.FromArgb(55, 60, 70);
                dtp.ForeColor = Color.White;
            }

            foreach (CheckBox chk in GetAll<CheckBox>(card))
                chk.ForeColor = Color.White;

            // arrastrar también desde el fondo
            form.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    DragWindow(form);
            };
        }

        // ==== tarjeta vidrio que envuelve todo ====
        private class GlassCard : Panel
        {
            public GlassCard()
            {
                this.DoubleBuffered = true;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = this.ClientRectangle;
                rect.Inflate(-1, -1);

                using (GraphicsPath path = RoundedRect(rect, 20))
                {
                    // fondo oscuro translúcido
                    using (SolidBrush sb = new SolidBrush(Color.FromArgb(55, 100, 40, 55)))
                        e.Graphics.FillPath(sb, path);
                }
            }
        }

        // ---------- helpers ----------
        private static void EstiloBoton(Button b, Color baseColor, Color hoverColor)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = baseColor;
            b.ForeColor = Color.White;
            b.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
            b.MouseEnter += (s, e) => b.BackColor = hoverColor;
            b.MouseLeave += (s, e) => b.BackColor = baseColor;
        }

        private static System.Collections.Generic.IEnumerable<T> GetAll<T>(Control root) where T : Control
        {
            foreach (Control c in root.Controls)
            {
                if (c is T t)
                    yield return t;
                foreach (var sub in GetAll<T>(c))
                    yield return sub;
            }
        }

        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private static void DragWindow(Form form)
        {
            ReleaseCapture();
            SendMessage(form.Handle, 0xA1, 0x2, 0);
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
    }
}
