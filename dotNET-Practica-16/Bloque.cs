using System;
using System.Collections.Generic;
using System.Text;

namespace Practica16
{
    public class Bloque
    {
        private string nombre;
        private string textura;
        public Bloque(string nombre, string textura)
        {
            this.nombre = nombre;
            this.textura = textura;
        }
        public string obtenerNombre()
        {
            return this.nombre;
        }
        public string obtenerTextura()
        {
            return this.textura;
        }
        public void actualizarNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void actualizarTextura(string textura)
        {
            this.textura = textura;
        }
        public void romper()
        {
            Console.WriteLine("Bloque roto\nDrop: Nada");
        }
    }
}