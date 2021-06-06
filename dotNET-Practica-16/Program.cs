using System;

namespace Practica16
{
    class Program
    {
        static void Main(string[] args)
        {
            Bloque_TNT bloque_TNT_1 = new Bloque_TNT("desactivado", "TNT", "bloque_tnt.png");
            Console.WriteLine("\n" + bloque_TNT_1.obtenerNombre());
            Console.WriteLine(bloque_TNT_1.obtenerTextura());
            bloque_TNT_1.romper();

            Bloque_TNT bloque_TNT_2 = new Bloque_TNT("encendido", "TNT", "bloque_tnt.png");
            Console.WriteLine("\n" + bloque_TNT_2.obtenerNombre());
            Console.WriteLine(bloque_TNT_2.obtenerTextura());
            bloque_TNT_2.explotar();

            Bloque_Grava bloque_Grava_1 = new Bloque_Grava("flotando", "Grava", "bloque_grava.png");
            Console.WriteLine("\n" + bloque_Grava_1.obtenerNombre());
            Console.WriteLine(bloque_Grava_1.obtenerTextura());
            bloque_Grava_1.gravedad();
            bloque_Grava_1.romper();

            Bloque_Grava bloque_Grava_2 = new Bloque_Grava("suelo", "Grava", "bloque_grava.png");
            Console.WriteLine("\n" + bloque_Grava_2.obtenerNombre());
            Console.WriteLine(bloque_Grava_2.obtenerTextura());
            bloque_Grava_2.gravedad();
            bloque_Grava_2.romper();
        }
    }
}
