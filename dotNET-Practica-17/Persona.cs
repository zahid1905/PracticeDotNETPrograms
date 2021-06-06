using System;
using System.Collections.Generic;
using System.Text;

namespace Practica17
{
    public class Persona
    {
        private string nombre;
        private byte edad;
        private string telefono;
        private string correo;
        public Persona(string nombre, byte edad, string telefono, string correo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
            this.correo = correo;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public byte GetEdad()
        {
            return this.edad;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        public string GetCorreo()
        {
            return this.correo;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetEdad(byte edad)
        {
            this.edad = edad;
        }
        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public void SetCorreo(string correo)
        {
            this.correo = correo;
        }
    }
}
