using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6
{
    public class Persona
    {
        private string nombre;
        private string genero;
        public Persona(string nombre, string genero)
        {
            this.nombre = nombre;
            this.genero = genero;
        }
        public string obtenerNombre()
        {
            return this.nombre;
        }
        public string obtenerGenero()
        {
            return this.genero;
        }
        public void actualizarNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void actualizarGenero(string genero)
        {
            this.genero = genero;
        }
        public string solicitaNombre()
        {
            Console.WriteLine("Ingresar el nombre: ");
            string nombre = Console.ReadLine();
            return nombre;
        }
        public string solicitaGenero()
        {
            Console.WriteLine("Ingresar el genero: ");
            string genero = Console.ReadLine();
            return genero;
        }
    }
}
