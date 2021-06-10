using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraForm
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }        

        private void Suma_Click(object sender, EventArgs e)
        {
            double cifra1 = double.Parse(numero1.Text);

            double cifra2 = double.Parse(numero2.Text);

            double suma = cifra1 + cifra2;

            numero1.Text = suma.ToString();
            numero2.Clear();
        }        

        private void Resta_Click(object sender, EventArgs e)
        {
            double cifra1 = double.Parse(numero1.Text);

            double cifra2 = double.Parse(numero2.Text);

            double resta = cifra1 - cifra2;

            numero1.Text = resta.ToString();
            numero2.Clear();
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            double cifra1 = double.Parse(numero1.Text);

            double cifra2 = double.Parse(numero2.Text);

            double multiplicacion = cifra1 * cifra2;

            numero1.Text = multiplicacion.ToString();
            numero2.Clear();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double cifra1 = double.Parse(numero1.Text);

            double cifra2 = double.Parse(numero2.Text);

            if (cifra1 != 0 || cifra2 != 0)
            {
                double division = cifra1 / cifra2;

                numero1.Text = division.ToString();
                numero2.Clear();
            }
            else
            {
                numero1.Text = "Operacion no valida";
            }            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            numero1.Clear();
            numero2.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Abrir una ventana y cerrar la anterior
            Menu mostrarMenu = new Menu();
            mostrarMenu.Show();
            this.Close();
        }
    }
}
