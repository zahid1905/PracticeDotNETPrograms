using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6
{
    public class Docente : Persona
    {
        private string especialidad;

        public Docente(string especialidad, string nombre, string genero) : base(nombre, genero)
        {
            this.especialidad = especialidad;
        }
        public string obtenerEspecialidad()
        {
            return this.especialidad;
        }
        public void actualizarEspecialidad(string especialidad)
        {
            this.especialidad = especialidad;
        }
        public string solicitaEspecialidad()
        {
            Console.WriteLine("Ingresar la especialidad");
            string especialidad = Console.ReadLine();
            return especialidad;
        }

    }
}
