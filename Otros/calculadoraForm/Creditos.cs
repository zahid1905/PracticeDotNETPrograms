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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Abrir una ventana y cerrar la anterior
            Menu mostrarMenu = new Menu();
            mostrarMenu.Show();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Text = VariablesGlobales.varGlobal1.ToString();
        }
    }
}
