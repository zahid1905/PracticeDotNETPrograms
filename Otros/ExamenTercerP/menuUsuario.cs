using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTercerP
{
    public partial class menuUsuario : Form
    {
        public menuUsuario()
        {
            InitializeComponent();
        }

        private void Parejas_Click(object sender, EventArgs e)
        {
            ingresarParejas parejas1 = new ingresarParejas();
            parejas1.Show();
        }

        private void Meses_Click(object sender, EventArgs e)
        {
            agregarMeses meses1 = new agregarMeses();
            meses1.Show();
        }
    }
}
