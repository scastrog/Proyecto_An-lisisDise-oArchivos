using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Proyecto_Final.Utils
{
    public class Util
    {
        public void LeerArchivo<T>(string ruta, List<T> listaClase) where T: new()
        {
            string linea;
            try
            {
                //if (ruta == null)
                //{
                //    ruta = ConfigurationManager.AppSettings["rutaUsuario" + "RegistraUSR.txt"];
                //}
                //else
                //{
                    StreamReader sr = new StreamReader(ruta);
                    linea = sr.ReadLine();
                    while (linea != null)
                    {
                        var datosLinea = linea.Split(',');
                        T clase = new T { };
                        var propiedades = clase.GetType().GetProperties().ToList();

                    for (int i = 0; i < propiedades.Count; i++)
                    {
                        propiedades.ElementAt(i).SetValue(clase, datosLinea[i]);
                    }

                        listaClase.Add(clase);

                        linea = sr.ReadLine();
                    }
                    sr.Close();
                //}
                //Console.WriteLine("Valor ruta: " + ruta);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error encontrado: " + e.Message);
            }
        }

        public void LeerArchivoFecha<T>(string ruta, List<T> listaClase) where T : new()
        {
            string linea;
            try
            {
                //if (ruta == null)
                //{
                //    ruta = ConfigurationManager.AppSettings["rutaUsuario" + "RegistraUSR.txt"];
                //}
                //else
                //{
                StreamReader sr = new StreamReader(ruta);
                linea = sr.ReadLine();
                //DateTime parsedDate;
                while (linea != null)
                {
                    var datosLinea = linea.Split(',');
                    T clase = new T { };
                    var propiedades = clase.GetType().GetProperties().ToList();

                    for (int i = 0; i < propiedades.Count; i++)
                    {
                        if (i != 1 || i != 3)
                        {
                            propiedades.ElementAt(i).SetValue(clase, datosLinea[i]);
                        }
                    }
                    listaClase.Add(clase);

                    linea = sr.ReadLine();
                }
                sr.Close();
                //}
                //Console.WriteLine("Valor ruta: " + ruta);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error encontrado: " + e.Message);
            }
        }

        public void EscribirArchivo<T>(string ruta, List<T> listaClase)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta);

                foreach (var clase in listaClase)
                {
                    var propiedades = clase.GetType().GetProperties().ToList();
                    sw.WriteLine(string.Join(",", propiedades.Select(x => x.GetValue(clase, null))));
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error encontrado: " + e.Message);
            }
        }
    }
}
