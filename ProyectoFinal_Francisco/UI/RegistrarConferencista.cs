using Proyecto_Final.Clases;
using Proyecto_Final.UI;
using Proyecto_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Francisco.UI
{
    public partial class RegistrarAsistencias : Form
    {
        public RegistrarAsistencias()
        {
            InitializeComponent();
            mostrarConferencista();
            btEliminar.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void btAgregaProf_Click(object sender, EventArgs e)
        {
            if (txtNomConferencista.Text == "" && txtApeConferencista.Text == "" && txtCedConferencista.Text == "" && txtCorreoConferencista.Text =="")
            {
                MessageBox.Show("Campos Incorrectos o vacios");
            }
            else
            {
                Conferencistas u1 = new Conferencistas
                {
                    nombre = txtNomConferencista.Text,
                    apellidos = txtApeConferencista.Text,
                    cedula = txtCedConferencista.Text,
                    correo = txtCorreoConferencista.Text
                };
                Program.listaConferencistas.Add(u1);
                Program.GuadarInformacionConferencistas();
                dgvConferencistas.Rows.Clear();
                mostrarConferencista();
                limpiaText();
                MessageBox.Show("Conferencistas Registrado");
                //this.Hide();
            }
        }

        private void limpiaText()
        {
            txtCedConferencista.Text = "";
            txtNomConferencista.Text = "";
            txtApeConferencista.Text = "";
            txtCorreoConferencista.Text = "";
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            limpia_dgvConferencista();
            mostrarConferencista();
            limpiaText();
            btEliminar.Visible = false;
        }

        private void limpia_dgvConferencista()
        {
            foreach (Conferencia u in Program.listaConferencias)
            {
                dgvConferencistas.Rows.Clear();
            }
        }

        private void mostrarConferencista()
        {
            foreach (Conferencistas c in Program.listaConferencistas)
            {
                dgvConferencistas.Rows.Add(c.cedula, c.nombre, c.apellidos, c.correo);
            }
        }

        private void dgvConferencistas_Click(object sender, EventArgs e)
        {
            if (dgvConferencistas.CurrentRow != null)
            {
                txtCedConferencista.Text = dgvConferencistas.CurrentRow.Cells[0].Value.ToString();
                txtNomConferencista.Text = dgvConferencistas.CurrentRow.Cells[1].Value.ToString();
                txtApeConferencista.Text = dgvConferencistas.CurrentRow.Cells[2].Value.ToString();
                txtCorreoConferencista.Text = dgvConferencistas.CurrentRow.Cells[3].Value.ToString();
                foreach (Conferencistas u in Program.listaConferencistas)
                {
                    if (u.cedula == txtCedConferencista.Text)
                    {
                        Program.listaConferencistas.Remove(u);
                        Program.GuadarInformacionConferencistas();
                        btEliminar.Visible = true;
                        break;
                    }
                }
            }
        }
    }
}
