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

            string[] folders = Directory.GetDirectories(@"C:\"); //muestra carpetas
            foreach (string folder in folders)
            {
                Console.WriteLine("> " + folder);
            }

            string fichero = @"C:\resuelto1.csv"; //leer fichero csv
            StreamReader archivo = new StreamReader(fichero);

            string linea; //si el archivo no tiene encabezado, elimina la siguiente linea
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

            //--------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------

            //Ejemplo para escribir los datos en un fichero
            string[,] dades = new string[2, 2] {{ "Mery", "123" }, { "Montgo", "456" }};
            StreamWriter fitxer = new StreamWriter(@"C:\CSV\dades.csv"); //se crea el fichero
            for (int i = 0; i < dades.GetLength(0); i++)
            {
                //OPCIÓ 1 -------------------------------------------------
                string[] fila = new string[1];
                for (int j = 0; j < dades.GetLength(1); j++)
                {
                    
                    fila[j] = dades[i, j];
                    
                }
                fitxer.WriteLine(string.Join(",", fila));

                //OPCIÓ 2 ----------------------------------------------------
                /*string texto = string.Join(",", fila);
                texto = "";

                for (int j = 0; j < 4; j++)
                {
                    texto += dades[i, j];
                    if (j < 3)
                    {
                        texto += ",";
                    }
                }

                fitxer.WriteLine(texto);*/

                //OPCIÓ 3 -----------------------------------------------------
                /*for (int j = 0; j < 4; j++)
                {
                    fitxer.Write(dades[i, j]);

                    if (j < 3)
                    {
                        fitxer.Write(",");
                    }
                    else
                    {
                        fitxer.Write("\n");
                    }
                } */
            }
            fitxer.Close(); //siempre cerrar
            Console.WriteLine("Les dades s'han escrit al fitxer.");

        }
    }
}
