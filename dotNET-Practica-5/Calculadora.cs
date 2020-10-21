using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class Calculadora
    {
        private string tipoCalculadora;
        private int cantidadTeclas;
        private bool necesitaBaterias;

        //Constructor
        public Calculadora(string tipoCalculadora, int cantidadTeclas, bool necesitaBaterias)
        {
            this.tipoCalculadora = tipoCalculadora;
            this.cantidadTeclas = cantidadTeclas;
            this.necesitaBaterias = necesitaBaterias;
        }
        public double sumar(double x, double y)
        {
            return (x + y);
        }

        public double restar(double x, double y)
        {
            return (x - y);
        }

        public double multiplicar(double x, double y)
        {
            return (x * y);
        }

        public double dividir(double x, double y)
        {
            return (x / y);
        }

        public void imprimir(string signo, double resultado)
        {
            switch (signo)
            {
                case "+":                    
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;
                case "-":
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;
                case "*":
                    Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                    break;
                case "/":
                    Console.WriteLine("El resultado de la division es: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operacion desconocida");
                    break;
            }
        }     
    }
}
