// Tema
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Integrador_Grupo_11_B.Themes
{
    public static class Tema
    {
        // ===== Colores =====
        static readonly Color Primary = Color.FromArgb(15, 53, 87);     // header
        static readonly Color Surface = Color.FromArgb(243, 246, 250);  // groupboxes
        static readonly Color FormBg = Color.FromArgb(250, 252, 255);  // fondo form
        static readonly Color TextPrimary = Color.FromArgb(17, 24, 39);
        static readonly Color TextMuted = Color.FromArgb(107, 114, 128);
        static readonly Color Accent = Color.FromArgb(22, 163, 74);      // Registrar
        static readonly Color AccentHover = Color.FromArgb(21, 128, 61);
        static readonly Color Neutral = Color.FromArgb(229, 231, 235);    // Volver
        static readonly Color NeutralHover = Color.FromArgb(209, 213, 219);

        // ===== Tipografia =====
        static readonly Font FontBody = new Font("Segoe UI", 9F, FontStyle.Regular);
        static readonly Font FontLabel = new Font("Segoe UI", 9F, FontStyle.Regular);
        static readonly Font FontButton = new Font("Segoe UI Semibold", 9F, FontStyle.Regular);
        static readonly Font FontGroup = new Font("Segoe UI Semibold", 10F, FontStyle.Regular);
        static readonly Font FontTitle = new Font("Segoe UI", 13F, FontStyle.Bold);

        // ===== API pública =====
        // Sobreescribir diseño
        public static void Aplicar(RegistrarNoSocio f)
        {
            // Fondo y fuente base
            f.BackColor = FormBg;
            f.ForeColor = TextPrimary;
            f.Font = FontBody;

            // Header
            SetPanelColor(f, "header", Primary);
            SetLabelTitulo(f, "lblTitulo");

            // GroupBoxes
            SetGroupBox(f, "groupBox1");
            SetGroupBox(f, "groupBox2", setPadding: true);

            // Labels del form original
            SetMutedLabel(f, "AptoMedico");
            SetMutedLabel(f, "label5");
            SetMutedLabel(f, "label4");
            SetMutedLabel(f, "label2");
            SetMutedLabel(f, "label1");

            // Inputs
            StyleTextBox(Find<TextBox>(f, "txtNombre"));
            StyleTextBox(Find<TextBox>(f, "txtApellido"));
            StyleTextBox(Find<TextBox>(f, "txtDni"));

            var chk = Find<CheckBox>(f, "chkAptoMedico");
            if (chk != null) { chk.ForeColor = TextPrimary; chk.Font = FontBody; }

            var dtp = Find<DateTimePicker>(f, "dtpFechaNacimiento");
            if (dtp != null) { dtp.Font = FontBody; dtp.CalendarMonthBackground = Color.White; }

            // Botones
            StylePrimaryButton(Find<Button>(f, "Registrar"));
            StyleNeutralButton(Find<Button>(f, "VolverMenu"));
        }

        // ===== Helpers específicos =====
        static T Find<T>(Form f, string name) where T : Control
            => f.Controls.Find(name, true).FirstOrDefault() as T;

        static void SetPanelColor(Form f, string name, Color color)
        {
            var p = Find<Panel>(f, name);
            if (p != null && !Skip(p)) p.BackColor = color;
        }

        static void SetLabelTitulo(Form f, string name)
        {
            var lbl = Find<Label>(f, name);
            if (lbl == null || Skip(lbl)) return;
            lbl.ForeColor = Color.White;
            lbl.Font = FontTitle;
        }

        static void SetGroupBox(Form f, string name, bool setPadding = false)
        {
            var gb = Find<GroupBox>(f, name);
            if (gb == null || Skip(gb)) return;
            gb.BackColor = Surface;
            gb.ForeColor = TextPrimary;
            gb.Font = FontGroup;
            if (setPadding) gb.Padding = new Padding(16, 12, 16, 16);
        }

        static void SetMutedLabel(Form f, string name)
        {
            var lbl = Find<Label>(f, name);
            if (lbl == null || Skip(lbl)) return;
            lbl.ForeColor = TextMuted;
            lbl.Font = FontLabel;
        }

        static void StyleTextBox(TextBox tb)
        {
            if (tb == null || Skip(tb)) return;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.BackColor = Color.White;
            tb.ForeColor = TextPrimary;
            tb.Font = FontBody;
        }

        static void StylePrimaryButton(Button b)
        {
            if (b == null || Skip(b)) return;
            b.BackColor = Accent;
            b.ForeColor = Color.White;
            b.Font = FontButton;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = AccentHover;
            b.FlatAppearance.MouseDownBackColor = AccentHover;
            b.Cursor = Cursors.Hand;
        }

        static void StyleNeutralButton(Button b)
        {
            if (b == null || Skip(b)) return;
            b.BackColor = Neutral;
            b.ForeColor = TextPrimary;
            b.Font = FontButton;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = NeutralHover;
            b.FlatAppearance.MouseDownBackColor = NeutralHover;
            b.Cursor = Cursors.Hand;
        }

        // Control del tema con Tag = "no-theme" en el Designer
        static bool Skip(Control c) => (c.Tag as string)?.Equals("no-theme", StringComparison.OrdinalIgnoreCase) == true;
    }
}