using System;
using System.IO;

namespace proyectoP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proyecto inventarios
            string respuesta = null;
            do
            {
                Console.Clear();
                //Menu
                Console.WriteLine("Menu\nOpciones:\n1-Iniciar sesion\n2-Registrar usuario");
                byte opcion = byte.Parse(Console.ReadLine());
                switch (opcion)
                {
                    //Iniciar sesion
                    case 1:
                    {
                        Console.Clear();
                        
                        Console.WriteLine("Inicio de sesion");

                        Console.WriteLine("Ingresa tu username");
                        string username = Console.ReadLine();

                        Console.WriteLine("Ingresa tu password");
                        string password = Console.ReadLine();

                        StreamReader lectura = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/users.txt");
                        string contenido = lectura.ReadToEnd();
                        lectura.Close();
                        string [] elementos = contenido.Split('\n');

                        for (int x = 1; x < elementos.Length; x=x+5)
                        {
                            if (elementos[x].Trim().Equals(username))
                            {
                                if (elementos[x+1].Trim().Equals(password))
                                {
                                    Console.WriteLine("Bienvenido");

                                    //Menu usuario
                                    Console.Clear();                                    
                                    Console.WriteLine("Menu\nOpciones:\n1-Usuarios\n2-Productos");
                                    byte opcion2 = byte.Parse(Console.ReadLine());

                                    switch (opcion2)
                                    {
                                        //Menu usuarios
                                        case 1:
                                        {
                                            Console.Clear();                                    
                                            Console.WriteLine("Menu\nOpciones:\n1-Cambio de password\n2-Cambio de tipo");
                                            byte opcion3 = byte.Parse(Console.ReadLine());
                                            switch(opcion3)
                                            {
                                                //Cabiar password
                                                case 1:
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

                                                    break;
                                                }
                                                //Cambiar tipo
                                                case 2:
                                                {
                                                    Console.Clear();
                                                    
                                                    Console.WriteLine("Cambio de tipo");

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
                                                            Console.WriteLine("Ingresa nuevo tipo");
                                                            elementosCambios[z+2] = Console.ReadLine();

                                                            Console.WriteLine("Cambio de tipo exitoso");

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

                                                    break;
                                                }
                                                //Otro
                                                default:
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Opcion invalida");
                                                    break;
                                                }
                                            }

                                            break;
                                        }
                                        //Menu productos
                                        case 2:
                                        {
                                            Console.Clear();                             
                                            Console.WriteLine("Menu\nOpciones:\n1-Alta productos\n2-Baja productos\n3-Cambio productos");
                                            byte opcion3 = byte.Parse(Console.ReadLine());
                                            switch(opcion3)
                                            {
                                                //Alta productos
                                                case 1:
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Registro producto");

                                                    Console.WriteLine("Ingresa nombre del producto");
                                                    string nombreProducto = Console.ReadLine();

                                                    Console.WriteLine("Ingresa descripcion del producto");
                                                    string descripcionProducto = Console.ReadLine();

                                                    Console.WriteLine("Ingresa cantidad del producto");
                                                    string cantidadProducto = Console.ReadLine();

                                                    Console.WriteLine("Ingresa precio del producto");
                                                    string precioProducto = Console.ReadLine();

                                                    Console.WriteLine("Ingresa localizacion del producto");
                                                    string localizacionProducto = Console.ReadLine();                                            

                                                    //Si existe el archivo productos.txt lo abre y continua a partir del anterior
                                                    if(File.Exists(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/productos.txt"))
                                                    {
                                                        StreamReader lecturaProductos = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/productos.txt");
                                                        string contenidoProductos = lecturaProductos.ReadToEnd();
                                                        lecturaProductos.Close();
                                                        string [] elementosProductos = contenidoProductos.Split('\n');

                                                        int tamanoProductos = elementosProductos.Length;

                                                        int ultimoProductos = int.Parse(elementosProductos[tamanoProductos-9]) + 1;

                                                        StreamWriter escrituraProductos = File.AppendText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/productos.txt");
                                                        escrituraProductos.WriteLine(ultimoProductos);
                                                        escrituraProductos.WriteLine(nombreProducto);
                                                        escrituraProductos.WriteLine(descripcionProducto);
                                                        escrituraProductos.WriteLine(cantidadProducto);
                                                        escrituraProductos.WriteLine(precioProducto);
                                                        escrituraProductos.WriteLine(localizacionProducto);
                                                        DateTime fechaProducto = DateTime.Now;
                                                        escrituraProductos.WriteLine(fechaProducto);
                                                        escrituraProductos.WriteLine("1");
                                                        escrituraProductos.Close();

                                                        Console.WriteLine("Registro exitoso. Regrese al menu principal para manejar los registros");

                                                    }
                                                    //Si no existe el archivo users.txt lo crea y añade el primer producto
                                                    else
                                                    {
                                                        StreamWriter escrituraProductos = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/productos.txt");

                                                        escrituraProductos.WriteLine("1");
                                                        escrituraProductos.WriteLine(nombreProducto);
                                                        escrituraProductos.WriteLine(descripcionProducto);
                                                        escrituraProductos.WriteLine(cantidadProducto);
                                                        escrituraProductos.WriteLine(precioProducto);
                                                        escrituraProductos.WriteLine(localizacionProducto);
                                                        DateTime fechaProducto = DateTime.Now;
                                                        escrituraProductos.WriteLine(fechaProducto);
                                                        escrituraProductos.WriteLine("1");
                                                        escrituraProductos.Close();

                                                        Console.WriteLine("Registro exitoso. Regrese al menu principal para manejar los registros");
                                                    }

                                                    break;
                                                }
                                                //Baja productos
                                                case 2:
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Baja de productos");

                                                    Console.WriteLine("Ingresa nombre del producto");
                                                    string busqueda = Console.ReadLine();
                                                    
                                                    StreamReader lecturaCambios = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/productos.txt");
                                                    string contenidoCambios = lecturaCambios.ReadToEnd();
                                                    lecturaCambios.Close();
                                                    string[] elementosCambios = contenidoCambios.Split('\n');

                                                    byte control = 0;

                                                    for (int z = 1; z < elementosCambios.Length; z=z+8)
                                                    {
                                                        if (elementosCambios[z].Trim().Equals(busqueda))
                                                        {
                                                            elementosCambios[z+6] = "0";

                                                            Console.WriteLine("Producto eliminado");

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
                                                        Console.WriteLine("Producto no existe");
                                                    }

                                                    StreamWriter escrituraCambios = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/productos.txt");
                                                    for (int z = 0; z < elementosCambios.Length - 1; z++)
                                                    {
                                                        escrituraCambios.WriteLine(elementosCambios[z]);
                                                    }
                                                    escrituraCambios.Close();

                                                    break;
                                                }
                                                //Cambio productos
                                                case 3:
                                                {
                                                    Console.Clear();
                                                    
                                                    Console.WriteLine("Cambio de productos");

                                                    Console.WriteLine("Ingresa nombre del producto");
                                                    string busqueda = Console.ReadLine();
                                                    
                                                    StreamReader lecturaCambios = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/productos.txt");
                                                    string contenidoCambios = lecturaCambios.ReadToEnd();
                                                    lecturaCambios.Close();
                                                    string[] elementosCambios = contenidoCambios.Split('\n');

                                                    byte control = 0;

                                                    for (int z = 1; z < elementosCambios.Length; z=z+8)
                                                    {
                                                        if (elementosCambios[z].Trim().Equals(busqueda))
                                                        {    
                                                            Console.WriteLine("Deja en blanco los atributos que no se requieran modificar");

                                                            Console.WriteLine("Ingresa nuevo nombre del producto");
                                                            string nombreProducto = Console.ReadLine();
                                                            if (!String.IsNullOrEmpty(nombreProducto))
                                                            {
                                                                elementosCambios[z] = nombreProducto;
                                                            }

                                                            Console.WriteLine("Ingresa nueva descripcion del producto");
                                                            string descripcionProducto = Console.ReadLine();
                                                            if (!String.IsNullOrEmpty(descripcionProducto))
                                                            {
                                                                elementosCambios[z+1] = descripcionProducto;
                                                            }

                                                            Console.WriteLine("Ingresa nueva cantidad del producto");
                                                            string cantidadProducto = Console.ReadLine();
                                                            if (!String.IsNullOrEmpty(cantidadProducto))
                                                            {
                                                                elementosCambios[z+2] = cantidadProducto;
                                                            }

                                                            Console.WriteLine("Ingresa nuevo precio del producto");
                                                            string precioProducto = Console.ReadLine();
                                                            if (!String.IsNullOrEmpty(precioProducto))
                                                            {
                                                                elementosCambios[z+3] = precioProducto;
                                                            }

                                                            Console.WriteLine("Ingresa nueva localizacion del producto");
                                                            string localizacionProducto = Console.ReadLine();
                                                            if (!String.IsNullOrEmpty(localizacionProducto))
                                                            {
                                                                elementosCambios[z+4] = localizacionProducto;
                                                            }

                                                            DateTime fechaProducto = DateTime.Now;
                                                            elementosCambios[z+5] = fechaProducto.ToString();

                                                            Console.WriteLine("Producto cambiado");

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
                                                        Console.WriteLine("Producto no existe");
                                                    }

                                                    StreamWriter escrituraCambios = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/productos.txt");
                                                    for (int z = 0; z < elementosCambios.Length - 1; z++)
                                                    {
                                                        escrituraCambios.WriteLine(elementosCambios[z]);
                                                    }
                                                    escrituraCambios.Close();

                                                    break;
                                                }
                                                //Otro
                                                default:
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Opcion invalida");
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                        default:
                                        {
                                            break;
                                        }
                                    }

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Username o password incorrectos");
                                }
                            }
                            
                        }
                        break;
                    }
                    //Registrar usuario
                    case 2:
                    {
                        Console.Clear();

                        Console.WriteLine("Registro usuario");

                        Console.WriteLine("Ingresa nuevo username");
                        string username = Console.ReadLine();

                        Console.WriteLine("Ingresa tu password");
                        string password = Console.ReadLine();

                        //Si existe el archivo users.txt lo abre y continua a partir del anterior
                        if(File.Exists(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/users.txt"))
                        {
                            StreamReader lectura = File.OpenText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/users.txt");
                            string contenido = lectura.ReadToEnd();
                            lectura.Close();
                            string [] elementos = contenido.Split('\n');

                            int tamano = elementos.Length;

                            int ultimo = int.Parse(elementos[tamano-6]) + 1;

                            StreamWriter escritura = File.AppendText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/users.txt");
                            escritura.WriteLine(ultimo);
                            escritura.WriteLine(username);
                            escritura.WriteLine(password);
                            escritura.WriteLine("2");
                            escritura.WriteLine("1");
                            escritura.Close();

                            Console.WriteLine("Registro exitoso. Regrese al menu principal para iniciar sesion");

                        }
                        //Si no existe el archivo users.txt lo crea y añade el primer usuario
                        else
                        {
                            StreamWriter escritura = File.CreateText(@"/home/zahid/Documentos/ProgramasCSharp/proyectoP2/registros/users.txt");

                            escritura.WriteLine("1");
                            escritura.WriteLine(username);
                            escritura.WriteLine(password);
                            escritura.WriteLine("2");
                            escritura.WriteLine("1");
                            escritura.Close();

                            Console.WriteLine("Registro exitoso. Regrese al menu principal para iniciar sesion");
                        }

                        break;
                    }
                    //Otro
                    default:
                    {
                        Console.Clear();

                        Console.WriteLine("Opcion invalida");
                        break;
                    }
                }
                Console.WriteLine("Regresar al menu principal: si/no");
                respuesta = Console.ReadLine();
            }
            while(respuesta == "si");
        }
    }
}
