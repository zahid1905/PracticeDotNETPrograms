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
    public partial class Operaciones : Form
    {
        public Operaciones()
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

        private void Limpiar_Click(object sender, EventArgs e)
        {
            numero1.Clear();
            numero2.Clear();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {   
            if (Opcion1.Checked == true)
            {
                double cifra1 = double.Parse(numero1.Text);
                if (cifra1 % 2 == 0)
                {
                    numero2.Text = "Par";
                }
                else
                {
                    numero2.Text = "Impar";
                }

            }
            else if (Opcion2.Checked == true)
            {
                int i, a = 0;

                double cifra1 = double.Parse(numero1.Text);

                for (i = 1; i < (cifra1 + 1); i++)
                {
                    if (cifra1 % i == 0)
                    {
                        a++;
                    }
                }

                if (a != 2)
                {
                    numero2.Text = "No primo";
                }
                else
                {
                    numero2.Text = "Primo";
                }
            }
        }
    }
}
