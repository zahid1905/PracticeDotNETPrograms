using System;
using System.Collections.Generic;
using System.Text;

namespace Practica16
{
    public class Bloque_Grava : Bloque
    {
        private string posicion;
        public Bloque_Grava(string posicion, string nombre, string textura) : base(nombre, textura)
        {
            this.posicion = posicion;
        }
        public string obtenerPosicion()
        {
            return this.posicion;
        }
        public void actualizarPosicion(string posicion)
        {
            this.posicion = posicion;
        }
        public void romper()
        {
            var rand = new Random();
            if (rand.NextDouble() < 0.5)
            {
                Console.WriteLine("Bloque: roto\nDrop: Arena");
            }
            else
            {
                Console.WriteLine("Bloque: roto\nDrop: Pedernal");
            }            
        }
        public void gravedad()
        {
            if (posicion.Equals("flotando"))
            {
                Console.WriteLine("Bloque: cae");
            }
            else
            {
                Console.WriteLine("Bloque: hace nada");
            }
        }
    }
}
