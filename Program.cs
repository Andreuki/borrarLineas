using System;
using System.IO;
using System.Collections.Generic;
namespace ficheroBorrarLineas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce nombre del fichero: ");
            string fichero = Console.ReadLine();

            StreamReader f = File.OpenText(fichero);
            string[] nuevoF = File.ReadAllLines(fichero);
            List<string> lista = new List<string>(nuevoF);
            string linea;
            do
            {
                linea = f.ReadLine();
                if (linea != null)
                {
                    if (linea == "") {
                        lista.Remove(linea);
                    }
                }
            } while (linea != null);

            File.WriteAllLines("patata.txt", lista.ToArray());
            f.Close();

            //ejemplo iborra 

            //Console.WriteLine("Introduce el nombre del fichero");
            //string nombreEntrada = Console.ReadLine();
            //StreamReader lectura = new StreamReader(nombreEntrada);
            //StreamWriter escritura = new StreamWriter(nombreEntrada + ".sinVacios.txt");
            //string lineas;
            //do
            //{
            //    lineas = lectura.ReadLine();
            //    if (lineas != null && lineas != "")
            //    {
            //        escritura.WriteLine(lineas);
            //    }
            //} while (lineas != null);
            //lectura.Close();
            //escritura.Close();

        }
    }
}

