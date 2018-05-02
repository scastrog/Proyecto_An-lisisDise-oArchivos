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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            foreach ( var user in Program.listaUsuarios)
            {
                if (user.usuario == usuario && user.contraseña == contraseña)
                {
                    // Abre VentanaMenu
                    Program.usuario = user.usuario;
                    MessageBox.Show("Bienvenido");
                    this.Hide();
                    new MenuPrincipal().Show();
                    MenuPrincipal.nombreUsuario = user.usuario;
                    return;
                }
                          
            }

            MessageBox.Show("Contraseña Incorrecta!");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrarUsuario().Show();
        }

        //private void Login_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Program.GuadarInformacionUsuario();
        //}

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
