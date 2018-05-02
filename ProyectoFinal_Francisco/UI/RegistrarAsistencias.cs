using Proyecto_Final.Clases;
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
    public partial class RegistrarAsistencias : Form
    {
        public RegistrarAsistencias()
        {
            InitializeComponent();
            cargaTemas();
            cargaUsuarios();
        }

        private void cargaTemas() {
            foreach (Conferencia a in Program.listaConferencias) {
                cbTema.Items.Add(a.tema);
            }
        }

        private void cargaUsuarios() {
            foreach (Usuario a in Program.listaUsuarios)
            {
                cbUsuario.Items.Add(a.nombre);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbUsuario.Text == "" && cbTema.Text == "")
            {
                MessageBox.Show("Campos Incorrectos o vacios");
            }
            else
            {
                if (!consultaAsistencia())
                {
                    if (consultaHoraConferencia()) {
                        Asistencia c1 = new Asistencia
                        {
                            nomUsuario = cbUsuario.Text,
                            temaConferencia = cbTema.Text
                        };
                        Program.listaAsistencias.Add(c1);
                        Program.GuadarInformacionAsistencias();
                        //dgvConferencias.Rows.Clear();
                        //mostrarConferencias();
                        //limpiaText();
                        MessageBox.Show("Asistencia Registrado");
                        if (MenuPrincipal.nombreUsuario == null)
                        {
                            this.Hide();
                            new Login().Show();
                        }
                    }
                    else {
                        MessageBox.Show("Ya hay una conferencia a esa hora.");
                    }
                }
                else {
                    MessageBox.Show("El usuario "+ cbUsuario.Text+" ya está registrado para asistir a la conferencia de "+cbTema.Text);
                }
            }
        }

        private Boolean consultaAsistencia() {
            Boolean val = false;
            foreach (Asistencia a in Program.listaAsistencias) {
                if (a.temaConferencia == cbTema.Text && a.nomUsuario == cbUsuario.Text) {
                    val = true;
                }
            }
            return val;
        }

        private Boolean consultaHoraConferencia() {
            Boolean val = true;
            DateTime hora1, fecha1, hora2, fecha2;
            foreach (Asistencia a in Program.listaAsistencias) {
                if (a.nomUsuario==cbUsuario.Text) {
                    hora1 = consultaHora(a.temaConferencia);
                    fecha1 = consultaFecha(a.temaConferencia);
                    hora2 = consultaHora(cbTema.Text);
                    fecha2 = consultaFecha(cbTema.Text);
                    if (fecha1 == fecha2)
                    {
                        if (hora1 != hora2)
                        {
                            val = true;
                        }
                        else
                        {
                            val = false;
                        }
                    }
                    else {
                        val = true;
                    }
                }
            }
            return val;
        }

        private DateTime consultaHora(String tema) {
            DateTime hora=DateTime.Now;
            foreach (Conferencia c in Program.listaConferencias) {
                if (c.tema == tema) {
                    hora =c.hora;
                }
            }
            return hora;
        }

        private DateTime consultaFecha(String tema)
        {
            DateTime fecha = DateTime.Now;
            foreach (Conferencia c in Program.listaConferencias)
            {
                if (c.tema == tema)
                {
                    fecha = c.fecha;
                }
            }
            return fecha;
        }

        private void RegistrarAsistencias_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }
    }
}
