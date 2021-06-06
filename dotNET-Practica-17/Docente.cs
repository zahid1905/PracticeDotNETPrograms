using System;
using System.Collections.Generic;
using System.Text;

namespace Practica17
{
    public class Docente : Persona
    {
        private Estudiante[] estudiantes;

        public Docente(Estudiante[] estudiantes, string nombre, byte edad, string telefono, string correo) : base(nombre, edad, telefono, correo)
        {
            this.estudiantes = estudiantes;
        }
        public Estudiante[] GetEstudiante()
        {
            return this.estudiantes;
        }
        public void SetEstudiantes(Estudiante[] estudiantes)
        {
            this.estudiantes = estudiantes;
        }
    }
}
