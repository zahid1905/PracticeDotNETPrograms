using System;
using System.IO;

namespace examen_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            string repetir = "no";
            do
            {
                Console.Clear();
                Console.WriteLine("**** Registrar producto ****");

                Console.WriteLine("Ingrese numero de producto");
                string numeroProducto = Console.ReadLine();     

                Console.WriteLine("Ingrese peso de producto");
                double pesoProducto = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese altura de producto");
                double alturaProducto = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese ancho de producto");
                double anchoProducto = double.Parse(Console.ReadLine());

                byte calidad = 0;
                byte desperdicio = 1;
                byte producto = 0;

                //Evaluar producto 1
                if (numeroProducto[0].Equals('0') | numeroProducto[0].Equals('1'))
                {
                    if (alturaProducto <= 10 && anchoProducto <= 5)
                    {
                        calidad = 1;
                        desperdicio = 0;
                    }
                    producto = 1;

                }

                //Evaluar producto 2
                else if (numeroProducto[0].Equals('2') | numeroProducto[0].Equals('5'))
                {
                    if (alturaProducto <= 45 && anchoProducto <= 23)
                    {
                        calidad = 1;
                        desperdicio = 0;
                    }
                    producto = 2;

                }
                
                //Evaluar producto 3
                else if (numeroProducto[0].Equals('7') | numeroProducto[0].Equals('3'))
                {
                    if (alturaProducto >= 4 && anchoProducto >= 15)
                    {
                        calidad = 1;
                        desperdicio = 0;
                    }
                    producto = 3;

                }

                //Grabar archivos de productos
                if (producto != 0)
                {
                    StreamWriter escritura = File.AppendText(@"/home/zahid/Documentos/ProgramasCSharp/examen_p2/archivos/producto" + producto + ".txt");
                    escritura.WriteLine(numeroProducto);
                    escritura.WriteLine(pesoProducto);
                    escritura.WriteLine(alturaProducto);
                    escritura.WriteLine(anchoProducto);
                    escritura.WriteLine(calidad);
                    escritura.Close();
                }

                //Grabar archivo calidad
                if(File.Exists(@"/home/zahid/Documentos/ProgramasCSharp/examen_p2/archivos/calidad.txt"))
                {
                    StreamReader lectura = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/examen_p2/archivos/calidad.txt");
                    string contenidoProductos = lectura.ReadToEnd();
                    lectura.Close();

                    string[] elementosProductos = contenidoProductos.Split('\n');

                    StreamWriter escritura = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/examen_p2/archivos/calidad.txt");
                    //Cantidad productos
                    escritura.WriteLine(int.Parse(elementosProductos[0].Trim())+1);
                    //Cantidad productos calidad 1
                    escritura.WriteLine(int.Parse(elementosProductos[1].Trim())+calidad);
                    if (calidad == 0)
                    {
                        calidad = 1;
                    }
                    else
                    {
                        calidad = 0;
                    }
                    //Cantidad productos calidad 0
                    escritura.WriteLine(int.Parse(elementosProductos[2].Trim())+calidad);
                    //Cantidad productos desperdicio
                    escritura.WriteLine(int.Parse(elementosProductos[3].Trim())+calidad);
                    escritura.Close();
                }
                else
                {
                    StreamWriter escritura = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/examen_p2/archivos/calidad.txt");
                    //Cantidad productos
                    escritura.WriteLine("1");
                    //Cantidad productos calidad 1
                    escritura.WriteLine(calidad);
                    if (calidad == 0)
                    {
                        calidad = 1;
                    }
                    else
                    {
                        calidad = 0;
                    }
                    //Cantidad productos calidad 0
                    escritura.WriteLine(calidad);
                    //Cantidad productos desperdicio
                    escritura.WriteLine(desperdicio);
                    escritura.Close();
                }
                
                Console.WriteLine("Añadir otro producto:\nsi o no");
                repetir = Console.ReadLine();
            }
            while (repetir == "si");
        }
    }
}
