using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);

            int numero2 = int.Parse(textBox2.Text);

            int suma = numero1 + numero2;

            textBox3.Text = suma.ToString();
        }
    }
}
