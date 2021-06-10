using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Escuaciones
{
    class Salida
    {
        public float[,] Segundo(string sA, string sB, string sC)
        {
            float A = float.Parse(sA);
            float B = float.Parse(sB);
            float C = float.Parse(sC);

            float[] x = new float[100];
            float[] fx = new float[100];
            float[] fpx = new float[100];
            float[] xfxfpx = new float[100];

            byte filaTabla = 0;
            byte nuevaX = 1;

            x[filaTabla] = 0;

            while (filaTabla < 99)
            {
                fx[filaTabla] = (A * x[filaTabla] * x[filaTabla]) + (B * x[filaTabla]) + (C);
                fpx[filaTabla] = (A * 2 * x[filaTabla]) + (B);
                xfxfpx[filaTabla] = x[filaTabla] - (fx[filaTabla] / fpx[filaTabla]);
                if (filaTabla < 99)
                {
                    if (xfxfpx[filaTabla] == x[filaTabla])
                    {
                        x[filaTabla + 1] = nuevaX;
                        nuevaX++;
                    }
                    else
                    {
                        x[filaTabla + 1] = xfxfpx[filaTabla];
                    }
                }
                filaTabla++;
            }

            float[,] res = new float[100, 4];
            for (int rellenarf = 0; rellenarf <= 99; rellenarf++)
            {
                res[rellenarf, 0] = x[rellenarf];
                res[rellenarf, 1] = fx[rellenarf];
                res[rellenarf, 2] = fpx[rellenarf];
                res[rellenarf, 3] = xfxfpx[rellenarf];
            }

            return res;
        }
        public string[] GeneralSegundo(string sA, string sB, string sC)
        {
            float A = float.Parse(sA);
            float B = float.Parse(sB);
            float C = float.Parse(sC);

            string[] res = new string[2];

            if (((B * B) - 4 * A * C) >= 0)
            {
                //X1
                res[0] = (((-1 * B) + Math.Sqrt((B * B) - 4 * A * C)) / (2 * A)).ToString();
                //X2
                res[1] = (((-1 * B) - Math.Sqrt((B * B) - 4 * A * C)) / (2 * A)).ToString();
            }
            else
            {
                //X1
                res[0] = ((-1 * B) / (2 * A)).ToString() + " + " + (Math.Sqrt(-1 * ((B * B) - 4 * A * C)) / (2 * A)).ToString() + " i";
                //X2
                res[1] = ((-1 * B) / (2 * A)).ToString() + " - " + (Math.Sqrt(-1 * ((B * B) - 4 * A * C)) / (2 * A)).ToString() + " i";
            }

            return res;
        }
        public float[,] Tercero(string sA, string sB, string sC, string sD)
        {
            float A = float.Parse(sA);
            float B = float.Parse(sB);
            float C = float.Parse(sC);
            float D = float.Parse(sD);

            float[] x = new float[100];
            float[] fx = new float[100];
            float[] fpx = new float[100];
            float[] xfxfpx = new float[100];

            byte raiz = 0;
            byte filaTabla = 0;
            byte nuevaX = 1;

            x[filaTabla] = 0;

            while (filaTabla < 99)
            {
                fx[filaTabla] = (A * x[filaTabla] * x[filaTabla] * x[filaTabla]) + (B * x[filaTabla] * x[filaTabla]) + (C * x[filaTabla]) + (D);
                fpx[filaTabla] = (A * 3 * x[filaTabla] * x[filaTabla]) + (B * 2 * x[filaTabla]) + (C);
                xfxfpx[filaTabla] = x[filaTabla] - (fx[filaTabla] / fpx[filaTabla]);
                if (filaTabla < 99)
                {
                    if (xfxfpx[filaTabla] == x[filaTabla])
                    {
                        x[filaTabla + 1] = nuevaX;
                        nuevaX++;
                        raiz++;
                    }
                    else
                    {
                        x[filaTabla + 1] = xfxfpx[filaTabla];
                    }
                }
                filaTabla++;
            }

            float[,] res = new float[100, 4];
            for (int rellenarf = 0; rellenarf <= 99; rellenarf++)
            {
                res[rellenarf, 0] = x[rellenarf];
                res[rellenarf, 1] = fx[rellenarf];
                res[rellenarf, 2] = fpx[rellenarf];
                res[rellenarf, 3] = xfxfpx[rellenarf];
            }

            return res;
        }
        public float[,] Cuarto(string sA, string sB, string sC, string sD, string sE)
        {
            float A = float.Parse(sA);
            float B = float.Parse(sB);
            float C = float.Parse(sC);
            float D = float.Parse(sD);
            float E = float.Parse(sE);

            float[] x = new float[100];
            float[] fx = new float[100];
            float[] fpx = new float[100];
            float[] xfxfpx = new float[100];

            byte filaTabla = 0;
            byte nuevaX = 1;

            x[filaTabla] = 0;

            while (filaTabla < 99)
            {
                fx[filaTabla] = (A * x[filaTabla] * x[filaTabla] * x[filaTabla] * x[filaTabla]) + (B * x[filaTabla] * x[filaTabla] * x[filaTabla]) + (C * x[filaTabla] * x[filaTabla]) + (D * x[filaTabla]) + (E);
                fpx[filaTabla] = (A * 4 * x[filaTabla] * x[filaTabla] * x[filaTabla]) + (B * 3 * x[filaTabla] * x[filaTabla]) + (C * 2 * x[filaTabla]) + (D);
                xfxfpx[filaTabla] = x[filaTabla] - (fx[filaTabla] / fpx[filaTabla]);
                if (filaTabla < 99)
                {
                    if (xfxfpx[filaTabla] == x[filaTabla])
                    {
                        x[filaTabla + 1] = nuevaX;
                        nuevaX++;
                    }
                    else
                    {
                        x[filaTabla + 1] = xfxfpx[filaTabla];
                    }
                }
                filaTabla++;
            }

            float[,] res = new float[100, 4];
            for (int rellenarf = 0; rellenarf <= 99; rellenarf++)
            {
                res[rellenarf, 0] = x[rellenarf];
                res[rellenarf, 1] = fx[rellenarf];
                res[rellenarf, 2] = fpx[rellenarf];
                res[rellenarf, 3] = xfxfpx[rellenarf];
            }

            return res;
        }
        public float[,] DivisionSegundo(string sA, string sB, string sC, string sDiv)
        {
            float A = float.Parse(sA);
            float B = float.Parse(sB);
            float C = float.Parse(sC);

            float Div = float.Parse(sDiv);

            float[,] res = new float[2, 3];

            res[0, 0] = 0;
            res[1, 0] = A;

            res[0, 1] = res[1, 0] * Div;
            res[1, 1] = B + res[0, 1];

            res[0, 2] = res[1, 1] * Div;
            res[1, 2] = C + res[0, 2];

            return res;
        }
        public float[,] DivisionTercero(string sA, string sB, string sC, string sD, string sDiv)
        {
            float A = float.Parse(sA);
            float B = float.Parse(sB);
            float C = float.Parse(sC);
            float D = float.Parse(sD);

            float Div = float.Parse(sDiv);

            float[,] res = new float[2, 4];

            res[0, 0] = 0;
            res[1, 0] = A;

            res[0, 1] = res[1, 0] * Div;
            res[1, 1] = B + res[0, 1];

            res[0, 2] = res[1, 1] * Div;
            res[1, 2] = C + res[0, 2];

            res[0, 3] = res[1, 2] * Div;
            res[1, 3] = D + res[0, 3];

            return res;
        }
        public float[,] DivisionCuarto(string sA, string sB, string sC, string sD, string sE, string sDiv)
        {
            float A = float.Parse(sA);
            float B = float.Parse(sB);
            float C = float.Parse(sC);
            float D = float.Parse(sD);
            float E = float.Parse(sE);

            float Div = float.Parse(sDiv);

            float[,] res = new float[2, 5];

            res[0, 0] = 0;
            res[1, 0] = A;

            res[0, 1] = res[1, 0] * Div;
            res[1, 1] = B + res[0, 1];

            res[0, 2] = res[1, 1] * Div;
            res[1, 2] = C + res[0, 2];

            res[0, 3] = res[1, 2] * Div;
            res[1, 3] = D + res[0, 3];

            res[0, 4] = res[1, 3] * Div;
            res[1, 4] = E + res[0, 4];

            return res;
        }
        public float[] Cramer(string x1s, string x2s, string y1s, string y2s, string c1s, string c2s)
        {
            float x1 = float.Parse(x1s);
            float x2 = float.Parse(x2s);
            float y1 = float.Parse(y1s);
            float y2 = float.Parse(y2s);
            float c1 = float.Parse(c1s);
            float c2 = float.Parse(c2s);

            float Dp = (x1 * y2) - (y1 * x2);
            float Dx = (c1 * y2) - (y1 * c2);
            float Dy = (x1 * c2) - (c1 * x2);
            float x = Dx / Dp;
            float y = Dy / Dp;

            float[] res = { Dp, Dx, Dy, x, y };

            return res;
        }
        public void Invalido()
        {
            Console.WriteLine("Valor invalido");
        }
        public string[] Integral(string sA, string sB, string sC, string sD, string sE, string sLS, string sLI, string sNT)
        {
            float A;
            if (sA.Equals("")) { A = 0; } else { A = float.Parse(sA); }
            float B;
            if (sB.Equals("")) { B = 0; } else { B = float.Parse(sB); }
            float C;
            if (sC.Equals("")) { C = 0; } else { C = float.Parse(sC); }
            float D;
            if (sD.Equals("")) { D = 0; } else { D = float.Parse(sD); }
            float E;
            if (sE.Equals("")) { E = 0; } else { E = float.Parse(sE); }
            float LS;
            if (sLS.Equals("")) { LS = 0; } else { LS = float.Parse(sLS); }
            float LI;
            if (sLI.Equals("")) { LI = 0; } else { LI = float.Parse(sLI); }
            float NT;
            if (sNT.Equals("")) { NT = 0; } else { NT = float.Parse(sNT); }

            float[] res = new float[5];

            string[] res1 = new string[3];

            //Integral
            res[0] = A / 5;
            res[1] = B / 4;
            res[2] = C / 3;
            res[3] = D / 2;
            res[4] = E;
            res1[0] = res[0] + "x^5+" + res[1] + "x^4+" + res[2] + "x^3+" + res[3] + "x^2+" + res[4] + "x+c";

            //Area
            double area1 = 0;
            double area2 = 0;

            if (NT != 0)
            {
                float h = (LS - LI) / NT;
                double x1, x2, bM, bm;
                float N = 0;
                while (N < NT)
                {
                    x1 = LI + (N * h);
                    x2 = x1 + h;
                    bM = A * Math.Pow(x1, 4) + B * Math.Pow(x1, 3) + C * Math.Pow(x1, 2) + D * x1 + E;
                    bm = A * Math.Pow(x2, 4) + B * Math.Pow(x2, 3) + C * Math.Pow(x2, 2) + D * x2 + E;
                    area1 += ((bM + bm) / 2) * h;
                    N++;
                }
            }
            area2 = (res[0] * Math.Pow(LS, 5) + res[1] * Math.Pow(LS, 4) + res[2] * Math.Pow(LS, 3) + res[3] * Math.Pow(LS, 2) + res[4] * LS) - (res[0] * Math.Pow(LI, 5) + res[1] * Math.Pow(LI, 4) + res[2] * Math.Pow(LI, 3) + res[3] * Math.Pow(LI, 2) + res[4] * LI);

            res1[1] = area1.ToString();
            res1[2] = area2.ToString();

            return res1;
        }
        public string[] DobleIntegral(string sA1, string sB1, string sC1, string sA2, string sB2, string sC2)
        {
            //Ecuacion 1
            float[] e1 = new float[3];
            if (sA1.Equals("")) { e1[0] = 0; } else { e1[0] = float.Parse(sA1); }
            if (sB1.Equals("")) { e1[1] = 0; } else { e1[1] = float.Parse(sB1); }
            if (sC1.Equals("")) { e1[2] = 0; } else { e1[2] = float.Parse(sC1); }

            //Ecuacion 2
            float[] e2 = new float[3];
            if (sA2.Equals("")) { e2[0] = 0; } else { e2[0] = float.Parse(sA2); }
            if (sB2.Equals("")) { e2[1] = 0; } else { e2[1] = float.Parse(sB2); }
            if (sC2.Equals("")) { e2[2] = 0; } else { e2[2] = float.Parse(sC2); }

            //Punto de equilibrio
            float[] e3 = new float[3];
            for (int cont = 0; cont < 3; cont++)
            {
                e3[cont] = e1[cont] - e2[cont];
            }
            double raiz1 = (((-1 * e3[1]) + Math.Sqrt((e3[1] * e3[1]) - 4 * e3[0] * e3[2])) / (2 * e3[0]));
            double raiz2 = (((-1 * e3[1]) - Math.Sqrt((e3[1] * e3[1]) - 4 * e3[0] * e3[2])) / (2 * e3[0]));
            double PuntoE = raiz1;
            if (raiz1 > 0) { PuntoE = raiz1; } else { PuntoE = raiz2; }

            //Monto de inversion
            float[] res = new float[5];
            res[0] = -e3[0] / 3;
            res[1] = -e3[1] / 2;
            res[2] = -e3[2];
            double MontoI = (res[0] * Math.Pow(PuntoE, 3) + res[1] * Math.Pow(PuntoE, 2) + res[2] * PuntoE) - (res[0] * Math.Pow(0, 3) + res[1] * Math.Pow(0, 2) + res[2] * 0);

            //Periodo de retorno
            res[0] *= -1;
            res[1] *= -1;
            res[2] *= -1;
            double area12 = (((-1 * res[1]) + Math.Sqrt((res[1] * res[1]) - 4 * res[0] * res[2])) / (2 * res[0]));
            double area22 = (((-1 * res[1]) + Math.Sqrt((res[1] * res[1]) - 4 * res[0] * res[2])) / (2 * res[0]));
            double PeriodoR;
            if (area12 > 0) { PeriodoR = area12; } else { PeriodoR = area22; }

            string[] res1 = new string[3];
            res1[0] = PuntoE.ToString();
            res1[1] = MontoI.ToString();
            res1[2] = PeriodoR.ToString();

            return res1;
        }
        public string[] GenerarEcuacuacion(string sX, string sY)
        {
            string[] sEX = sX.Split(',');
            string[] sEY = sY.Split(',');
            double[] x = new double[sEX.Length];
            double[] y = new double[sEY.Length];
            for (int cont = 0; cont < sEX.Length; cont++)
            {
                x[cont] = double.Parse(sEX[cont]);
                y[cont] = double.Parse(sEY[cont]);
            }
            //Suma X, Y, X2, XY
            double sumax = 0, sumay = 0, sumax2 = 0, sumaxy = 0, sumax2y = 0, sumax3 = 0, sumax4 = 0, n = x.Length;
            for (int cont = 0; cont < x.Length -1; cont++)
            {
                sumax += x[cont];
                sumay += y[cont];
                sumax2 += Math.Pow(x[cont], 2);
                sumaxy += x[cont] * y[cont];
                sumax2y += Math.Pow(x[cont], 2) * y[cont];
                sumax3 += Math.Pow(x[cont], 3);
                sumax4 += Math.Pow(x[cont], 4);
            }
            //a1 = n,b1 = sumax,c1 = sumax2, res1 = sumay
            //a2 = sumax,b2 = sumax2,c2 = sumax3,res2 = sumaxy
            //a3 = sumax2,b3 = sumax3,c3 =sumax4,res3 = sumax2y
            double detg = n * ((sumax2 * sumax4) - (sumax3 * sumax3)) - sumax * ((sumax * sumax4) - (sumax2 * sumax3)) + sumax2 * ((sumax * sumax3) - (sumax2 * sumax2));
            double detx = sumay * ((sumax2 * sumax4) - (sumax3 - sumax3)) - sumax * ((sumaxy * sumax4) - (sumax2y * sumax3)) + sumax2 * ((sumaxy * sumax3) - (sumax2y * sumax2));
            double dety = n * ((sumaxy * sumax4) - (sumax2y * sumax3)) - sumay * ((sumax * sumax4) - (sumax2 * sumax3)) + sumax2 * ((sumax * sumax2y) - (sumax2 * sumaxy));
            double detz = n * ((sumax2 * sumax2y) - (sumax3 * sumaxy)) - sumax * ((sumax * sumax2y) - (sumax2 * sumaxy)) + sumay * ((sumax * sumax3) - (sumax2 * sumax2));

            double a1 = detx / detg;
            double b1 = dety / detg;
            double c1 = detz / detg;

            double a2 = ((sumax2 * sumay) - (sumax * sumaxy)) / ((n * sumax2) - Math.Pow(sumax, 2));
            double b2 = ((n * sumaxy) - (sumax * sumay)) / ((n * sumax2) - Math.Pow(sumax, 2));

            string[] res = new string[2];
            res[0] = a1 + "x^2+" + b1 + "x+" + c1;
            res[1] = a2 + "x+" + b2;
            return res;
        }
    }
}