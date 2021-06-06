using System;
using System.Collections.Generic;
using System.Text;

namespace Practica17
{
    public class Estudiante : Persona
    {
        private string[] clases;

        public Estudiante(string[] clases, string nombre, byte edad, string telefono, string correo) : base(nombre, edad, telefono, correo)
        {
            this.clases = clases;            
        }

        public string[] GetClases()
        {
            return this.clases;
        }
        public void SetClases(string[] clases)
        {
            this.clases = clases;
        }
    }
}
