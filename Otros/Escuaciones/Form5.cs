using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuaciones
{
    public partial class Form5 : Form
    {
        Salida Salida = new Salida();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] resultado = Salida.GenerarEcuacuacion(valsx.Text, valsy.Text);
            consola.Text += Environment.NewLine + "Ecuacion cuadratica: " + resultado[0] +
                            Environment.NewLine + "Ecuacion recta: " + resultado[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valsx.Text = "";
            valsy.Text = "";  
        }
    }
}
