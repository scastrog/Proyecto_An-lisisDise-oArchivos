using ProyectoFinal_Francisco.UI;
using Proyecto_Final;
using Proyecto_Final.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.UI
{
    public partial class MenuPrincipal : Form
    {
        public static string nombreUsuario;
        public MenuPrincipal()
        {
            InitializeComponent();
            lbNomUsuario.Text = nombreUsuario;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Login().Show();
        }
        
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarConferencia().Show();
            this.Hide();
        }

        private void conferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarAsistencias().Show();
            //this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarUsuario().Show();
            this.Hide();
        }

        private void asistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarAsistencias().Show();
            this.Hide();
        }
    }
}
