﻿using System;
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
    public partial class menuCreditos : Form
    {
        public menuCreditos()
        {
            InitializeComponent();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            menuPrincipal principal = new menuPrincipal();
            principal.Show();
            this.Close();
        }
    }
}
