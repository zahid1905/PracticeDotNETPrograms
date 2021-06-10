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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            //Abrir una ventana y esconder la anterior
            Calculadora mostrarCalculadora = new Calculadora();
            mostrarCalculadora.Show();
            this.Hide();
        }

        private void Operaciones_Click(object sender, EventArgs e)
        {
            //Abrir una ventana y esconder la anterior
            Operaciones mostrarOperaciones = new Operaciones();
            mostrarOperaciones.Show();
            this.Hide();
        }

        private void Creditos_Click(object sender, EventArgs e)
        {
            //Abrir una ventana y esconder la anterior
            Creditos mostrarCreditos = new Creditos();
            mostrarCreditos.Show();
            this.Hide();
            VariablesGlobales.varGlobal1 =+ 1;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Cerrar una ventana
            this.Close();
        }
    }
}
