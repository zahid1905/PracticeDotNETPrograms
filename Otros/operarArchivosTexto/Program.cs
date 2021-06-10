using System;
using System.IO;

namespace operarArchivosTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un archivo, si existe lo sobreescribe
            //StreamWriter escritura = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/operarArchivosTexto/texto.txt");
            //Si archivo existe, escribe en ese mismo a partir de la ultima linea, si no existe lo crea
            //StreamWriter escrituraDos = File.AppendText(@"/home/zahid/Documentos/ProgramasCSharp/operarArchivosTexto/texto.txt");

            StreamReader lectura = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/operarArchivosTexto/texto.txt");
            //Guardar todo a un string
            string contenido = lectura.ReadToEnd();
            //Imprimir el string
            Console.WriteLine(contenido);
            //Cerrar archivo
            lectura.Close();
            //Guardar los datos en un arraglo, separado por saltos de linea
            string[] elementos = contenido.Split('\n');
            //Obneter la ultima posiscion del arreglo
            int ultimo = elementos.Length-2;
            //Abrir el archivo
            StreamWriter escritura = File.AppendText(@"/home/zahid/Documentos/ProgramasCSharp/operarArchivosTexto/texto.txt");
            //Escribe a la ultima linea
            escritura.WriteLine(int.Parse(elementos[ultimo]) + 1);
            //Cierra el archivo
            escritura.Close();

        }
    }
}
