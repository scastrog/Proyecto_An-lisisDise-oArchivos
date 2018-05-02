using Proyecto_Final.UI;
using Proyecto_Final.Clases;
using Proyecto_Final.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final
{
    static class Program
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Conferencistas> listaConferencistas = new List<Conferencistas>();
        public static List<Conferencia> listaConferencias = new List<Conferencia>();
        public static List<Asistencia> listaAsistencias = new List<Asistencia>();
        public static Util utilidades = new Util();
        public static string usuario = "";
        //public static string ruta = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){
            CargarInformacionUsuario();
            CargarInformacionConferencia();
            CargarInformacionConferencistas();
            CargarInformacionAsistencias();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new RegistrarUsuario());
            Application.Run(new Login());
        }

        static void CargarInformacionUsuario()
        {
            String ruta = Directory.GetCurrentDirectory() + "\\RegistraUSR.txt";
            utilidades.LeerArchivo(ruta, listaUsuarios);
        }

        public static void GuadarInformacionUsuario() {

            String ruta = Directory.GetCurrentDirectory() + "\\RegistraUSR.txt";
                utilidades.EscribirArchivo(ruta, listaUsuarios);
        }

        public static void GuadarInformacionConferencia()
        {

            String ruta = Directory.GetCurrentDirectory() + "\\RegistraConferencia.txt";
            utilidades.EscribirArchivo(ruta, listaConferencias);
        }

        public static void CargarInformacionConferencia()
        {
            String ruta = Directory.GetCurrentDirectory() + "\\RegistraConferencia.txt";
            utilidades.LeerArchivoFecha(ruta, listaConferencias);
        }

        public static void GuadarInformacionConferencistas()
        {
            String ruta = Directory.GetCurrentDirectory() + "\\RegistraConferencistas.txt";
            utilidades.EscribirArchivo(ruta, listaConferencistas);
        }

        public static void CargarInformacionConferencistas()
        {
            String ruta = Directory.GetCurrentDirectory() + "\\RegistraConferencistas.txt";
            utilidades.LeerArchivo(ruta, listaConferencistas);
        }

        public static void GuadarInformacionAsistencias()
        {
            String ruta = Directory.GetCurrentDirectory() + "\\RegistraAsistencias.txt";
            utilidades.EscribirArchivo(ruta, listaAsistencias);
        }

        public static void CargarInformacionAsistencias()
        {
            String ruta = Directory.GetCurrentDirectory() + "\\RegistraAsistencias.txt";
            utilidades.LeerArchivo(ruta, listaAsistencias);
        }
    }
}
