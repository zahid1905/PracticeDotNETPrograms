using System;
using System.IO;


namespace editar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Cambio de password");

            Console.WriteLine("Ingresa username");
            string busqueda = Console.ReadLine();
                                                    
            StreamReader lecturaCambios = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/users.txt");
            string contenidoCambios = lecturaCambios.ReadToEnd();                                        
            lecturaCambios.Close();
            string[] elementosCambios = contenidoCambios.Split('\n');

            byte control = 0;
            
            for (int z = 1; z < elementosCambios.Length; z=z+5)
            {
                if (elementosCambios[z].Trim().Equals(busqueda))
                {
                    Console.WriteLine("Ingresa nuevo password");
                    elementosCambios[z+1] = Console.ReadLine();

                    Console.WriteLine("Cambio de password exitoso");

                    control = 1;

                    break;
                }
                else
                {
                    control = 0;
                }
            }
            if (control == 0)
            {
                Console.WriteLine("Username no existe");
            }

            StreamWriter escrituraCambios = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/users.txt");
            for (int z = 0; z < elementosCambios.Length - 1; z++)
            {
                escrituraCambios.WriteLine(elementosCambios[z]);
            }
            escrituraCambios.Close();
                                 
        }
    }
}
