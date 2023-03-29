using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListarArchivosyCarpetas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"C:\DAW\MPO2 BDD"); //muestra archivos
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            string[] folders = Directory.GetDirectories(@"C:\");
            foreach (string folder in folders)
            {
                Console.WriteLine("> " + folder); //muestra carpetas
            }
            //leer fichero csv
            string fichero = @"C:\resuelto1.csv";
            StreamReader archivo = new StreamReader(fichero);

            string linea;
            //si el archivo no tiene encabezado, elimina la siguiente linea
            archivo.ReadLine(); //leer la primera linea pero descartarla porque es el encabezado
            while ((linea = archivo.ReadLine()) != null)
            {
                string[] fila = linea.Split(',');
                for (int i = 0; i < fila.Length; i++)
                {
                    Console.Write(fila[i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
