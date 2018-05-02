using Proyecto_Final.Clases;
using Proyecto_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.UI
{
    public partial class RegistrarConferencia : Form
    {
        string path = Directory.GetCurrentDirectory();
        public RegistrarConferencia()
        {
            InitializeComponent();
            mostrarConferencias();
            btEliminar.Visible = false;
            //dtpHora.CustomFormat = "hh:mm tt";
            //dtpFecha.Value.ToString("yyyy/MM/dd");
            dtpHora.Value = DateTime.Now;
            dtpFecha.Value = DateTime.Now;
        }
        
        private void btAgregaAlum_Click_1(object sender, EventArgs e)
        {
            if (txtTema.Text == "" && dtpHora.Text == "" && txtLugar.Text == "" && dtpFecha.Text == "")
            {
                MessageBox.Show("Campos Incorrectos o vacios");
            }
            else
            {
                Conferencia c1 = new Conferencia
                {
                    tema = txtTema.Text,
                    hora = dtpHora.Value,
                    lugar = txtLugar.Text,
                    fecha = dtpFecha.Value

                };
                Program.listaConferencias.Add(c1);
                Program.GuadarInformacionConferencia();
                dgvConferencias.Rows.Clear();
                mostrarConferencias();
                limpiaText();
                MessageBox.Show("Conferencia Registrado");
                if (MenuPrincipal.nombreUsuario == null)
                {
                    this.Hide();
                    new Login().Show();
                }
                //MessageBox.Show("Conferencia Registrado");
                //this.Hide();
            }
        }

        private void limpiaText()
        {
            txtTema.Text = "";
            dtpHora.Text = "";
            txtLugar.Text = "";
            dtpFecha.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void mostrarConferencias()
        {            
            foreach (Conferencia c in Program.listaConferencias)
            {
                dgvConferencias.Rows.Add(c.tema, c.hora, c.lugar, c.fecha);
            }
        }

        private void dgvConferencias_Click(object sender, EventArgs e)
        {
            if (dgvConferencias.CurrentRow != null)
            {
                txtTema.Text = dgvConferencias.CurrentRow.Cells[0].Value.ToString();
                dtpHora.Value.ToString(dgvConferencias.CurrentRow.Cells[1].Value.ToString());
                txtLugar.Text = dgvConferencias.CurrentRow.Cells[2].Value.ToString();
                dtpFecha.Value.ToString(dgvConferencias.CurrentRow.Cells[3].Value.ToString());
                foreach (Conferencia u in Program.listaConferencias)
                {
                    if (u.tema == txtTema.Text)
                    {
                        Program.listaConferencias.Remove(u);
                        Program.GuadarInformacionConferencia();
                        btEliminar.Visible = true;
                        break;
                    }
                }
                //mostrarUsuarios();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            limpia_dgvConferencia();
            mostrarConferencias();
            limpiaText();
            btEliminar.Visible=false;
        }

        private void limpia_dgvConferencia() {
            foreach (Conferencia u in Program.listaConferencias)
            {
                dgvConferencias.Rows.Clear();
            }
        }

        private void RegistrarConferencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

    }
}
