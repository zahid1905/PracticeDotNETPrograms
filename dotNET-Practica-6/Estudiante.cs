using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6
{
    public class Estudiante : Persona
    {
        private int carnetNumero;
        private int anosDeEstudio;

        public Estudiante(int espediente, int escolaridad, string nombre, string genero) : base(nombre, genero)
        {
            this.carnetNumero = espediente;
            this.anosDeEstudio = escolaridad;
        }

        public int obtenerCarnetNumero()
        {
            return this.carnetNumero;
        }

        public int obtenerAnosDeEstudio()
        {
            return this.anosDeEstudio;
        }

        public void actualizarCarnetNumero(int x)
        {
            this.carnetNumero = x;
        }

        public void actualizarAnosDeEstudio(int x)
        {
            this.anosDeEstudio = x;
        }

        public int solicitarCarnetNumero()
        {
            Console.WriteLine("Ingresa el número del carnet: ");
            int numeroCarnet = int.Parse(Console.ReadLine());
            return numeroCarnet;
        }

        public int solicitarAnosDeEstudio()
        {
            Console.WriteLine("Ingresa los años de estudio: ");
            int anosDeEstudio = int.Parse(Console.ReadLine());
            return anosDeEstudio;
        }
    }
}
