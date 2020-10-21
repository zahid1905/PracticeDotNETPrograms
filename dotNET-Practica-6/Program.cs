using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes = new Estudiante[5];
            Docente[] docentes = new Docente[5];
            //Estudiante            
            int expediente = 0, escolaridad = 0;
            //Docente
            string especialidad;
            //Persona
            string nombre, genero;
            //Contadores
            byte contadorEsudiantes = 0, contadorDocentes = 0;
            //Excepciones
            bool retryOpcion = true, retryExpediente = true, retryEscolaridad = true;
            //Estudiante o docente
            byte opcion=0;

            while(contadorEsudiantes < 5 && contadorDocentes < 5)
            {
                //Menu
                do
                {
                    try
                    {
                        Console.WriteLine("Ingresar estudiante (1) o docente (2)");
                        opcion = byte.Parse(Console.ReadLine());
                        retryOpcion = false;                        
                    }
                    catch
                    {
                        Console.WriteLine("Ingrese una opcion valida");
                    }
                } while (retryOpcion);
                //Ingresar estudiante
                if (opcion==1)
                {
                    Console.WriteLine("Nombre del estudiante #" + (contadorEsudiantes + 1));
                    nombre = Console.ReadLine();
                    Console.WriteLine("Genero del estudiante #" + (contadorEsudiantes + 1));
                    genero = Console.ReadLine();
                    retryExpediente = true;
                    retryEscolaridad = true;
                    do 
                    {
                        try
                        {
                            Console.WriteLine("Expediente del estudiante #" + (contadorEsudiantes + 1));
                            expediente = int.Parse(Console.ReadLine());
                            retryExpediente = false;
                        }
                        catch
                        {
                            Console.WriteLine("Ingrese un expediente valido");
                        }                        
                    } while (retryExpediente);
                    do
                    {
                        try
                        {
                            Console.WriteLine("Escolaridad del estudiante #" + (contadorEsudiantes + 1));
                            escolaridad = int.Parse(Console.ReadLine());
                            retryEscolaridad = false;
                        }
                        catch
                        {
                            Console.WriteLine("Ingrese una escolaridad valida");
                        }
                    } while (retryEscolaridad);
                    
                    estudiantes[contadorEsudiantes] = new Estudiante(expediente, escolaridad, nombre, genero);
                    contadorEsudiantes++;
                }
                //Ingresar docente
                else if (opcion==2)
                {
                    Console.WriteLine("Nombre del docente #" + (contadorDocentes + 1));
                    nombre = Console.ReadLine();
                    Console.WriteLine("Genero del docente #" + (contadorDocentes + 1));
                    genero = Console.ReadLine();
                    Console.WriteLine("Especialidad del docente #" + (contadorDocentes + 1));
                    especialidad = Console.ReadLine();
                    docentes[contadorDocentes] = new Docente(especialidad, nombre, genero);
                    contadorDocentes++;
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
            }            
        }
    }
}
