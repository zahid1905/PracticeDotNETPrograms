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
    public partial class Form2 : Form
    {
        Salida Salida = new Salida();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string[] resultado = Salida.DobleIntegral(segundo.Text, primero.Text, ultimo.Text, segundo2.Text, primero2.Text, ultimo2.Text);
                consola.Text += Environment.NewLine + "Punto de equilibrio: " + resultado[0] +
                                Environment.NewLine + "Monto de inversion: " + resultado[1] +
                                Environment.NewLine + "Periodo de retorno: " + resultado[2];
            }
            else
            {
                string[] resultado = Salida.Integral(cuarto.Text, tercero.Text, segundo.Text, primero.Text, ultimo.Text, sup.Text, inf.Text, trapecios.Text);
                consola.Text += Environment.NewLine + "Integral: " + resultado[0] +
                                Environment.NewLine + "Area bajo la curva por suma de trapecios: " + resultado[1] +
                                Environment.NewLine + "Area bajo la curva por integral: " + resultado[2];
            }
            
        }                                

        private void button2_Click(object sender, EventArgs e)
        {
            cuarto.Text = "";
            tercero.Text = "";
            segundo.Text = "";
            primero.Text = "";
            ultimo.Text = "";
            sup.Text = "0";
            inf.Text = "0";
            trapecios.Text = "0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (segundo2.Enabled == true)
            {
                segundo2.Enabled = false;
                primero2.Enabled = false;
                cuarto.Enabled = true;
                tercero.Enabled = true;
                ultimo2.Enabled = false;
                sup.Enabled = true;
                inf.Enabled = true;
                trapecios.Enabled = true;
            }
            else
            {
                cuarto.Enabled = false;
                tercero.Enabled = false;
                segundo2.Enabled = true;
                primero2.Enabled = true;
                ultimo2.Enabled = true;
                sup.Enabled = false;
                inf.Enabled = false;
                trapecios.Enabled = false;
            }
        }
    }
}
