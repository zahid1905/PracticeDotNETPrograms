using System;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calculadora = new Calculadora("Normal", 10, false);

            double suma = Calculadora.sumar(5, 10);
            double resta = Calculadora.restar(5, 10);
            double multiplicacion = Calculadora.multiplicar(5, 10);
            double division = Calculadora.dividir(5, 10);

            Calculadora.imprimir("+", suma);
            Calculadora.imprimir("-", resta);
            Calculadora.imprimir("*", multiplicacion);
            Calculadora.imprimir("/", division);
        }
    }
}
