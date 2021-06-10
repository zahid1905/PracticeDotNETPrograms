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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void Creditos_Click(object sender, EventArgs e)
        {
            menuCreditos creditos = new menuCreditos();
            creditos.Show();
            this.Hide();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            if (entradaUsuario.Text.Equals("Administrador"))
            {
                if (entradaContrasena.Text.Equals("C0ntr4s3ñ4"))
                {
                    Variables.usuario1 = entradaUsuario.Text;                    

                    menuUsuario usuario = new menuUsuario();
                    usuario.Show();
                    this.Hide();
                }
                else
                {
                    label1.Text = "Contrasena incorrecta";
                    entradaUsuario.Clear();
                    entradaContrasena.Clear();
                }
            }
            else
            {
                label1.Text = "Usuario incorrecto";
                entradaUsuario.Clear();
                entradaContrasena.Clear();
            }
        }
    }
}
