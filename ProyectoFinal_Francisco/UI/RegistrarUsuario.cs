using Proyecto_Final.Clases;
using System;
using System.Windows.Forms;
using Proyecto_Final.UI;

namespace Proyecto_Final
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
            mostrarUsuarios();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != txtConfimar.Text)
            {
                MessageBox.Show("Contraseñas Diferentes ");
            }
            else
            {
                Usuario u1 = new Usuario
                {
                    usuario = txtUsuario.Text,
                    contraseña = txtContraseña.Text,
                    nombre = txtNombre.Text,
                    apellidos = txtApellidos.Text
                };
                Program.listaUsuarios.Add(u1);
                Program.GuadarInformacionUsuario();
                dgvUsuarios.Rows.Clear();
                mostrarUsuarios();
                limpiaText();
                MessageBox.Show("Usuario Registrado");
                if (MenuPrincipal.nombreUsuario==null) {
                    this.Hide();
                    new Login().Show();
                }
            }
        }

        private void limpiaText() {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtUsuario.Text = "";
            txtConfimar.Text = "";
            txtContraseña.Text = "";
        }

        private void mostrarUsuarios()
        {
            foreach (Usuario u in Program.listaUsuarios) {
                dgvUsuarios.Rows.Add(u.usuario, u.nombre, u.apellidos);
            }
        }

        private void RegistrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }
        
        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                txtNombre.Text= dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtApellidos.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                foreach (Usuario u in Program.listaUsuarios) {
                    if (u.nombre == txtNombre.Text)
                    {
                        Program.listaUsuarios.Remove(u);
                        Program.GuadarInformacionUsuario();
                        break;
                    }
                }
                //mostrarUsuarios();
            }
        }
    }
}
