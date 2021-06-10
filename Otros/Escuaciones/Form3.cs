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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ecuaciones = new Form1();
            ecuaciones.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 integrales = new Form2();
            integrales.Show();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 creditos = new Form4();
            creditos.Show();           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 generador = new Form5();
            generador.Show();
        }
    }
}
