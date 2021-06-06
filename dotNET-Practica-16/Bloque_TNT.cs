using System;
using System.Collections.Generic;
using System.Text;

namespace Practica16
{
    public class Bloque_TNT : Bloque
    {
        private string estado;                
        public Bloque_TNT(string estado, string nombre, string textura) : base(nombre, textura)
        {
            this.estado = estado;            
        }
        public string obtenerEstado()
        {
            return this.estado;
        }
        public void actualizarEstado(string estado)
        {
            this.estado = estado;
        }
        public void romper()
        {
            Console.WriteLine("Bloque roto\nDrop: TNT");
        }
        public void explotar()
        {
            if (estado.Equals("encendido"))
            {
                Console.WriteLine("Bloque exploto");
            }
        }
    }
}
