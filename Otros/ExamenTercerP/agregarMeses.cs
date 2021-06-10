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
    public partial class agregarMeses : Form
    {
        public agregarMeses()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Variables.meses1 = textBox1.Text;
            this.Close();
        }
    }
}
