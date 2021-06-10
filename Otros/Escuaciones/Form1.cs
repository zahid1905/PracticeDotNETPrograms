using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Escuaciones
{
    public partial class Form1 : Form
    {
        Salida Salida = new Salida();
        public Form1()
        {
            InitializeComponent();
        }        
        //Resolver sistema de 2 ecuaciones o sistema lineal
        private void button1_Click(object sender, EventArgs e)
        {   //Sistema lineal
            if (radio1.Checked == false && radio2.Checked == true)
            {
                //Grado del sistema
                switch (comboBox1.SelectedItem)
                {
                    //Segundo grado
                    case "2":
                        //Division sintetica
                        ultimo1.Text = ultimo.Text;
                        primero1.Text = primero.Text;
                        segundo1.Text = segundo.Text;
                        //Newton-Rapson
                        if (check1.Checked)
                        {
                            string[] resultado = Salida.GeneralSegundo(segundo.Text, primero.Text, ultimo.Text);
                            consola.Text += Environment.NewLine + "X1 = " + resultado[0] +
                                            Environment.NewLine + "X2 = " + resultado[1];
                        }
                        else
                        {
                            float[,] resultado1 = Salida.Segundo(segundo.Text, primero.Text, ultimo.Text);
                            for (int rellenarf = 0; rellenarf <= 99; rellenarf++)
                            {
                                consola.Text += Environment.NewLine +
                                    resultado1[rellenarf, 0].ToString() + "\t" +
                                    resultado1[rellenarf, 1].ToString() + "\t" +
                                    resultado1[rellenarf, 2].ToString() + "\t" +
                                    resultado1[rellenarf, 3].ToString();
                            }
                        }
                            
                        break;
                    //Tercer grado
                    case "3":
                        //Division sintetica
                        ultimo1.Text = ultimo.Text;
                        primero1.Text = primero.Text;
                        segundo1.Text = segundo.Text;
                        tercero1.Text = tercero.Text;
                        //Newton-Rapson
                        float[,] resultado2 = Salida.Tercero(tercero.Text, segundo.Text, primero.Text, ultimo.Text);
                        for (int rellenarf = 0; rellenarf <= 99; rellenarf++)
                        {
                            consola.Text += Environment.NewLine +
                                resultado2[rellenarf, 0].ToString() + "\t" +
                                resultado2[rellenarf, 1].ToString() + "\t" +
                                resultado2[rellenarf, 2].ToString() + "\t" +
                                resultado2[rellenarf, 3].ToString();               
                        }
                        break;
                    //Cuarto grado
                    case "4":
                        //Division sintetica
                        ultimo1.Text = ultimo.Text;
                        primero1.Text = primero.Text;
                        segundo1.Text = segundo.Text;
                        tercero1.Text = tercero.Text;
                        cuarto1.Text = cuarto.Text;
                        //Newton-Rapson
                        float[,] resultado3 = Salida.Cuarto(cuarto.Text, tercero.Text, segundo.Text, primero.Text, ultimo.Text);
                        for (int rellenarf = 0; rellenarf <= 99; rellenarf++)
                        {
                            consola.Text += Environment.NewLine +
                                resultado3[rellenarf, 0].ToString() + "\t" +
                                resultado3[rellenarf, 1].ToString() + "\t" +
                                resultado3[rellenarf, 2].ToString() + "\t" +
                                resultado3[rellenarf, 3].ToString();
                        }
                        break;
                    default:
                        Salida.Invalido();
                        break;                        
                }
            }
            //Sistema de 2 ecuaciones
            if (radio2.Checked == false && radio1.Checked == true)
            {
                float[] resultado1 = Salida.Cramer(x1.Text, x2.Text, y1.Text, y2.Text, c1.Text, c2.Text);
                consola.Text +=
                                Environment.NewLine + "Dp = " + resultado1[0].ToString() +
                                Environment.NewLine + "Dx = " + resultado1[1].ToString() +
                                Environment.NewLine + "Dy = " + resultado1[2].ToString() +
                                Environment.NewLine + "X = " + resultado1[3].ToString() +
                                Environment.NewLine + "Y = " + resultado1[4].ToString();
            }
        }
        //Limpiar
        private void button2_Click(object sender, EventArgs e)
        {            
            cuarto.Text = "";
            tercero.Text = "";
            segundo.Text = "";
            primero.Text = "";
            ultimo.Text = "";
            x1.Text = "";
            x2.Text = "";
            y1.Text = "";
            y2.Text = "";
            c1.Text = "";
            c2.Text = "";
            consola.Text = "";
        }
        //Ingresar sistema de 2 ecuaciones
        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            check1.Enabled = false;
            check1.Checked = false;
            x1.Enabled = true;
            x2.Enabled = true;
            y1.Enabled = true;
            y2.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            cuarto.Enabled = false;
            tercero.Enabled = false;
            segundo.Enabled = false;
            primero.Enabled = false;
            ultimo.Enabled = false;

        }
        //Ingresar sistema lineal
        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            check1.Enabled = true;
            check1.Checked = false;
            x1.Enabled = false;
            x2.Enabled = false;
            y1.Enabled = false;
            y2.Enabled = false;
            c1.Enabled = false;
            c2.Enabled = false;
            cuarto.Enabled = false;
            tercero.Enabled = false;
            segundo.Enabled = true;
            primero.Enabled = true;
            ultimo.Enabled = true;
        }
        //Ingresar grado del sistema lineal 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("2"))
            {
                cuarto.Enabled = false;
                tercero.Enabled = false;
                segundo.Enabled = true;
                primero.Enabled = true;
                ultimo.Enabled = true;

                check1.Enabled = true;
                check1.Checked = false;
            }
            else
            {
                if (comboBox1.SelectedItem.Equals("3"))
                {
                    cuarto.Enabled = false;
                    tercero.Enabled = true;
                    segundo.Enabled = true;
                    primero.Enabled = true;
                    ultimo.Enabled = true;

                    check1.Enabled = false;
                    check1.Checked = false;
                }
                else if (comboBox1.SelectedItem.Equals("4"))
                {
                    cuarto.Enabled = true;
                    tercero.Enabled = true;
                    segundo.Enabled = true;
                    primero.Enabled = true;
                    ultimo.Enabled = true;

                    check1.Enabled = false;
                    check1.Checked = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radio1.Checked == false && radio2.Checked == true)
            {
                //Grado del sistema
                switch (comboBox1.SelectedItem)
                {
                    //Segundo grado
                    case "2":
                        //Division sintetica
                        float[,] resultado2 = Salida.DivisionSegundo(segundo1.Text, primero1.Text, ultimo1.Text, divisor1.Text);
                        segundo2.Text = resultado2[0, 0].ToString();
                        primero2.Text = resultado2[0, 1].ToString();
                        ultimo2.Text = resultado2[0, 2].ToString();

                        segundo3.Text = resultado2[1, 0].ToString();
                        primero3.Text = resultado2[1, 1].ToString();
                        ultimo3.Text = resultado2[1, 2].ToString();
                        break;
                    //Tercer grado
                    case "3":
                        //Division sintetica
                        float[,] resultado3 = Salida.DivisionTercero(tercero1.Text, segundo1.Text, primero1.Text, ultimo1.Text, divisor1.Text);
                        tercero2.Text = resultado3[0, 0].ToString();
                        segundo2.Text = resultado3[0, 1].ToString();
                        primero2.Text = resultado3[0, 2].ToString();
                        ultimo2.Text = resultado3[0, 3].ToString();

                        tercero3.Text = resultado3[1, 0].ToString();
                        segundo3.Text = resultado3[1, 1].ToString();
                        primero3.Text = resultado3[1, 2].ToString();
                        ultimo3.Text = resultado3[1, 3].ToString();
                        break;
                    //Cuarto grado
                    case "4":
                        //Division sintetica
                        float[,] resultado4 = Salida.DivisionCuarto(cuarto1.Text, tercero1.Text, segundo1.Text, primero1.Text, ultimo1.Text, divisor1.Text);
                        cuarto2.Text = resultado4[0, 0].ToString();
                        tercero2.Text = resultado4[0, 1].ToString();
                        segundo2.Text = resultado4[0, 2].ToString();
                        primero2.Text = resultado4[0, 3].ToString();
                        ultimo2.Text = resultado4[0, 4].ToString();

                        cuarto3.Text = resultado4[1, 0].ToString();
                        tercero3.Text = resultado4[1, 1].ToString();
                        segundo3.Text = resultado4[1, 2].ToString();
                        primero3.Text = resultado4[1, 3].ToString();
                        ultimo3.Text = resultado4[1, 4].ToString();
                        break;
                    default:
                        Salida.Invalido();
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radio1.Checked == false && radio2.Checked == true)
            {
                //Grado del sistema
                switch (comboBox1.SelectedItem)
                {
                    //Segundo grado
                    case "2":
                        //Division sintetica
                        float[,] resultado2 = Salida.DivisionSegundo(segundo3.Text, primero3.Text, ultimo3.Text, divisor2.Text);
                        segundo4.Text = resultado2[0, 0].ToString();
                        primero4.Text = resultado2[0, 1].ToString();
                        ultimo4.Text = resultado2[0, 2].ToString();

                        segundo5.Text = resultado2[1, 0].ToString();
                        primero5.Text = resultado2[1, 1].ToString();
                        ultimo5.Text = resultado2[1, 2].ToString();
                        break;
                    //Tercer grado
                    case "3":
                        //Division sintetica
                        float[,] resultado3 = Salida.DivisionTercero(tercero3.Text, segundo3.Text, primero3.Text, ultimo3.Text, divisor2.Text);
                        tercero4.Text = resultado3[0, 0].ToString();
                        segundo4.Text = resultado3[0, 1].ToString();
                        primero4.Text = resultado3[0, 2].ToString();
                        ultimo4.Text = resultado3[0, 3].ToString();

                        tercero5.Text = resultado3[1, 0].ToString();
                        segundo5.Text = resultado3[1, 1].ToString();
                        primero5.Text = resultado3[1, 2].ToString();
                        ultimo5.Text = resultado3[1, 3].ToString();
                        break;
                    //Cuarto grado
                    case "4":
                        //Division sintetica
                        float[,] resultado4 = Salida.DivisionCuarto(cuarto3.Text, tercero3.Text, segundo3.Text, primero3.Text, ultimo3.Text, divisor2.Text);
                        cuarto4.Text = resultado4[0, 0].ToString();
                        tercero4.Text = resultado4[0, 1].ToString();
                        segundo4.Text = resultado4[0, 2].ToString();
                        primero4.Text = resultado4[0, 3].ToString();
                        ultimo4.Text = resultado4[0, 4].ToString();

                        cuarto5.Text = resultado4[1, 0].ToString();
                        tercero5.Text = resultado4[1, 1].ToString();
                        segundo5.Text = resultado4[1, 2].ToString();
                        primero5.Text = resultado4[1, 3].ToString();
                        ultimo5.Text = resultado4[1, 4].ToString();
                        break;
                    default:
                        Salida.Invalido();
                        break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radio1.Checked == false && radio2.Checked == true)
            {
                //Grado del sistema
                switch (comboBox1.SelectedItem)
                {
                    //Segundo grado
                    case "2":
                        //Division sintetica
                        float[,] resultado2 = Salida.DivisionSegundo(segundo5.Text, primero5.Text, ultimo5.Text, divisor3.Text);
                        segundo6.Text = resultado2[0, 0].ToString();
                        primero6.Text = resultado2[0, 1].ToString();
                        ultimo6.Text = resultado2[0, 2].ToString();

                        segundo7.Text = resultado2[1, 0].ToString();
                        primero7.Text = resultado2[1, 1].ToString();
                        ultimo7.Text = resultado2[1, 2].ToString();
                        break;
                    //Tercer grado
                    case "3":
                        //Division sintetica
                        float[,] resultado3 = Salida.DivisionTercero(tercero5.Text, segundo5.Text, primero5.Text, ultimo5.Text, divisor3.Text);
                        tercero6.Text = resultado3[0, 0].ToString();
                        segundo6.Text = resultado3[0, 1].ToString();
                        primero6.Text = resultado3[0, 2].ToString();
                        ultimo6.Text = resultado3[0, 3].ToString();

                        tercero7.Text = resultado3[1, 0].ToString();
                        segundo7.Text = resultado3[1, 1].ToString();
                        primero7.Text = resultado3[1, 2].ToString();
                        ultimo7.Text = resultado3[1, 3].ToString();
                        break;
                    //Cuarto grado
                    case "4":
                        //Division sintetica
                        float[,] resultado4 = Salida.DivisionCuarto(cuarto5.Text, tercero5.Text, segundo5.Text, primero5.Text, ultimo5.Text, divisor3.Text);
                        cuarto6.Text = resultado4[0, 0].ToString();
                        tercero6.Text = resultado4[0, 1].ToString();
                        segundo6.Text = resultado4[0, 2].ToString();
                        primero6.Text = resultado4[0, 3].ToString();
                        ultimo6.Text = resultado4[0, 4].ToString();

                        cuarto7.Text = resultado4[1, 0].ToString();
                        tercero7.Text = resultado4[1, 1].ToString();
                        segundo7.Text = resultado4[1, 2].ToString();
                        primero7.Text = resultado4[1, 3].ToString();
                        ultimo7.Text = resultado4[1, 4].ToString();
                        break;
                    default:
                        Salida.Invalido();
                        break;
                }
            }
        }
    }
}
