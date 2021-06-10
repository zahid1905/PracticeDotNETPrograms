using System;
using System.IO;

namespace lineasProduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetir = 0;
            do {
                Console.Clear();

                Console.WriteLine("**** Registrar Producto ****");

                Console.WriteLine("Ingrese el numero de producto");
                string numeroProducto = Console.ReadLine();

                Console.WriteLine("Ingrese el peso de producto");
                double pesoProducto = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Ingrese el alto de producto");
                double altoProducto = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Ingrese el ancho de producto");
                double anchoProducto = double.Parse(Console.ReadLine());

                byte calidad = 0;
                byte producto = 0;
                byte desperdicio = 0;

                //Comienza con 0 o 1 -> producto 1
                if (numeroProducto[0] == '0' | numeroProducto[0] == '1'){
                    if (altoProducto <= 10 && anchoProducto <= 5){
                        calidad = 1;                        
                    }
                    producto = 1;
                }
                //Comienza con 2 o 5 -> producto 2
                else if (numeroProducto[0] == '2' | numeroProducto[0] == '5'){
                    if (altoProducto <= 45 && anchoProducto <= 23){
                        calidad = 1;
                    }
                    producto = 2;
                }
                //Comienza con 7 o 3 -> producto 3
                else if (numeroProducto[0] == '7' | numeroProducto[0] == '3'){
                    if (altoProducto >= 4 && anchoProducto >= 15){
                        calidad = 1;
                    }
                    producto = 3;
                }
                //Cualquier otro es desperdicio
                else{
                    desperdicio = 1;
                    calidad = 0;           
                }

                //Grabar al archivo respectivo
                StreamWriter escritura;
                if (producto != 0){
                    if (!File.Exists(@"/home/zahid/Documentos/ProgramasCSharp/lineasProduccion/archivos/producto" +  producto + ".txt")){
                        escritura = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/lineasProduccion/archivos/producto" +  producto + ".txt");
                    }                    
                    escritura = File.AppendText(@"/home/zahid/Documentos/ProgramasCSharp/lineasProduccion/archivos/producto" +  producto + ".txt");                                        
                    escritura.WriteLine(numeroProducto);
                    escritura.WriteLine(pesoProducto);
                    escritura.WriteLine(altoProducto);
                    escritura.WriteLine(anchoProducto);
                    escritura.WriteLine(calidad);
                    escritura.Close();
                }                
                
                //Grabar al cuarto archivo
                if (File.Exists(@"/home/zahid/Documentos/ProgramasCSharp/lineasProduccion/archivos/productos.txt")){
                    StreamReader lecturaProductos = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/lineasProduccion/archivos/productos.txt");
                    string contenidoProductos = lecturaProductos.ReadToEnd();
                    lecturaProductos.Close();

                    string [] elementosProductos = contenidoProductos.Split('\n');

                    int tamanoProductos = elementosProductos.Length;

                    StreamWriter escrituraProductos = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/lineasProduccion/archivos/productos.txt");

                    escrituraProductos.WriteLine(int.Parse(elementosProductos[tamanoProductos-5].Trim()) + 1);
                    escrituraProductos.WriteLine(int.Parse(elementosProductos[tamanoProductos-4].Trim()) + calidad);
                    if (calidad == 0){
                        calidad = 1;
                    }
                    else
                    {
                        calidad = 0;
                    }
                    escrituraProductos.WriteLine(int.Parse(elementosProductos[tamanoProductos-3].Trim()) + calidad);
                    escrituraProductos.WriteLine(int.Parse(elementosProductos[tamanoProductos-2].Trim()) + desperdicio);

                    escrituraProductos.Close();
                }
                else{
                    StreamWriter escrituraProductos = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/lineasProduccion/archivos/productos.txt");

                    escrituraProductos.WriteLine("1");
                    escrituraProductos.WriteLine(calidad);
                    if (calidad == 0){
                        calidad = 1;
                    }
                    else
                    {
                        calidad = 0;
                    }
                    escrituraProductos.WriteLine(calidad);
                    escrituraProductos.WriteLine(desperdicio);

                    escrituraProductos.Close();
                }

                Console.WriteLine("Añadir mas productos:\n0-Si\n1-No");
                repetir = int.Parse(Console.ReadLine());

            }
            while (repetir == 0);
        }
    }
}
