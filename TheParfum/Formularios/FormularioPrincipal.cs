using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheParfum {
    public partial class FormularioPrincipal : Form {
        public FormularioPrincipal() {
            InitializeComponent();
        }

        private Form FormActivo = null;

        private void AbrirFormNuevo(Form FormHijo) {
            // Cerrar el formulario activo anterior
            if (FormActivo != null) {
                FormActivo.Close();
            }

            // Configurar el nuevo formulario
            FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panel_Contenedor.Controls.Add(FormHijo);
            panel_Contenedor.Tag = FormHijo;
            FormHijo.Show();
        }

        #region Separadores
        private void parrotButton_Vender_MouseHover(object sender, EventArgs e) {
            airSeparator_Vender.BackColor = Color.FromArgb(128, 128, 255);
            airSeparator_Vender.Refresh();
        }

        private void parrotButton_Vender_MouseLeave(object sender, EventArgs e) {
            airSeparator_Vender.BackColor = Color.Black;
        }

        private void parrotButton_Stock_MouseHover(object sender, EventArgs e) {
            airSeparator_Stock.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void parrotButton_Stock_MouseLeave(object sender, EventArgs e) {
            airSeparator_Stock.BackColor = Color.Black;
        }

        private void parrotButton_Caja_MouseHover(object sender, EventArgs e) {
            airSeparator_Caja.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void parrotButton_Caja_MouseLeave(object sender, EventArgs e) {
            airSeparator_Caja.BackColor = Color.Black;
        }

        private void parrotButton_Configuracion_MouseHover(object sender, EventArgs e) {
            airSeparator_Configuracion.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void parrotButton_Configuracion_MouseLeave(object sender, EventArgs e) {
            airSeparator_Configuracion.BackColor = Color.Black;
        }
        #endregion
    }
}
