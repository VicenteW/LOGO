using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int Disy;
        int Disx;
        int tempx;
        int tempy;
        int posy = 325;
        int posx = 400;
        int ouy = 0;
        int oux = 0;
        int grados = 0;
        int num = 0;
        int color = 0;
        int i;
        bool tortuga = false;
        bool LapizArriba = false;
        bool TortugaEscondida = false;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            instrucciontxt.Text = "De click en el espacio vacio para mostrar la cuadricula";
            
        }

        private void btn_comand_Click(object sender, EventArgs e)
        {
            Form2 Comando = new Form2();
            Comando.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Savecod_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName+".txt");
                for(int i = 0; i < Codigotxt.Lines.Count(); i++)
                {
                    string temporal = Codigotxt.Lines[i];
                    sw.WriteLine(temporal);
                }
                sw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void borrar_todo()
        {
            Graphics fondo;
            fondo = pictureBox1.CreateGraphics();
            fondo.Clear(Color.White);
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            borrar_todo();
            posy = 325;
            posx = 400;
            grados = 0;
            color = 0;
            for (i = 0; i < Codigotxt.Lines.Count(); i++)
            {
                
                string instruccion = null;
                string numero = null;
                bool inst = false;
                TortugaEscondida = false;
                string LineaAct = Codigotxt.Lines[i].ToUpper();
                if (LineaAct != "") { 
                char[] LineaChar = LineaAct.ToCharArray();
                for (int j = 0; j < LineaChar.Length; j++)
                {
                    if (LineaChar[j] != ' ' && inst == true)
                    {
                            if (LineaChar[j] != '1' && LineaChar[j] != '2' && LineaChar[j] != '3' && LineaChar[j] != '4' && LineaChar[j] != '5' && LineaChar[j] != '6' && LineaChar[j] != '7' && LineaChar[j] != '8' && LineaChar[j] != '9' && LineaChar[j] != '0')
                            {
                                MessageBox.Show("Este no es un numero valido para el comando => "+ LineaChar[j]);
                            }else
                            {
                                numero = numero + LineaChar[j];
                            }
                            /*if(LineaChar[j+1] != '1' && LineaChar[j+1] != '2' && LineaChar[j+1] != '3' && LineaChar[j+1] != '4' && LineaChar[j+1] != '5' && LineaChar[j+1] != '6' && LineaChar[j+1] != '7' && LineaChar[j+1] != '8' && LineaChar[j+1] != '9' && LineaChar[j+1] != '0')
                            {
                                break;
                            }*/
                    }

                    if (LineaChar[j] != ' ' && inst == false)
                    {
                        instruccion = instruccion + LineaChar[j];
                    }
                    else
                    {
                        inst = true;
                    }

                }//Cierre de analisis de una instrucción, de un solo renglon.
                if (numero != null)
                {
                    num = Int32.Parse(numero);
                }
                switch (instruccion)//Interpretacion de instrucciones
                {
                    case "AV":
                    case "FW":

                        AvanzarTurtuga(grados, posy, posx, num, out ouy, out oux);
                        posy = ouy;
                        posx = oux;

                        break;

                    case "GD":
                    case "TR":

                        GirarDerecha();

                        break;

                    case "GI":
                    case "TL":

                        GirarIzquierda();

                        break;

                    case "RE":
                            int ciclos = num;
                            int cont = 0;
                            int cont2 = 0;
                            if (Codigotxt.Lines[i + 1] == "{")
                            {
                                for (int n = 0; n < ciclos; n++)
                                {
                                    while (Codigotxt.Lines[i] != "}") {
                                        i++;
                                        cont++;
                                        Repetir();
                                    }
                                    i = i - cont;
                                    cont2 = cont;
                                    cont = 0;

                                }
                            i = i + cont2;

                            }else
                            {
                                MessageBox.Show("No se indicó el comienzo del ciclo");
                            }
                        break;

                    case "VC":
                    case "GH":

                        GoHome();

                        break;

                    case "LL":
                    case "PU":
                        LapizArriba = true;
                        break;

                    case "BL":
                    case "PD":
                        LapizArriba = false;
                            break;

                    case "ET":
                    case "HT":
                        TortugaEscondida = true;
                        break;

                    case "MT":
                    case "ST":
                        TortugaEscondida = false;
                        break;

                    case "CC":
                            CambiarColor();
                        break;

                    default:
                            if (instruccion == "{" || instruccion == "}")
                            {

                            }
                            else
                            {
                                MessageBox.Show("NO SE RECONOCE LA INSTRUCCIÓN");
                            }
                        break;
                }
            }
            }//Cierre de la ejecucion del codigo
            if (TortugaEscondida == false)
            {
                DibujarTortuga();
            }
        }

        public void CalcularGrados(int grados, int num)
        {
            //Calcular Y
            double rad = 0;
            rad = grados * 0.0174533;
            double sen = Math.Sin(rad);
            double Dy = sen * num;
            //Redondeo:
            Dy = Math.Round(Dy);
            Disy = Convert.ToInt32(Dy);

            //Calcular X
            double cos = Math.Cos(rad);
            double Dx = cos * num;
            Dx = Math.Round(Dx);
            //Redondeo:
            Disx = Convert.ToInt32(Dx);

            //Regresar valores
        }

        public void Repetir()
        {
            string instruccion = null;
            string numero = null;
            bool inst = false;
            TortugaEscondida = false;
            string LineaAct = Codigotxt.Lines[i].ToUpper();
            if (LineaAct != "")
            {
                char[] LineaChar = LineaAct.ToCharArray();
                for (int j = 0; j < LineaChar.Length; j++)
                {
                    if (LineaChar[j] != ' ' && inst == true)
                    {
                        if (LineaChar[j] != '1' && LineaChar[j] != '2' && LineaChar[j] != '3' && LineaChar[j] != '4' && LineaChar[j] != '5' && LineaChar[j] != '6' && LineaChar[j] != '7' && LineaChar[j] != '8' && LineaChar[j] != '9' && LineaChar[j] != '0')
                        {
                            MessageBox.Show("Este no es un numero valido para el comando => " + LineaChar[j]);
                        }
                        else
                        {
                            numero = numero + LineaChar[j];
                        }
                        /*if(LineaChar[j+1] != '1' && LineaChar[j+1] != '2' && LineaChar[j+1] != '3' && LineaChar[j+1] != '4' && LineaChar[j+1] != '5' && LineaChar[j+1] != '6' && LineaChar[j+1] != '7' && LineaChar[j+1] != '8' && LineaChar[j+1] != '9' && LineaChar[j+1] != '0')
                        {
                            break;
                        }*/
                    }

                    if (LineaChar[j] != ' ' && inst == false)
                    {
                        instruccion = instruccion + LineaChar[j];
                    }
                    else
                    {
                        inst = true;
                    }

                }//Cierre de analisis de una instrucción, de un solo renglon.
                if (numero != null)
                {
                    num = Int32.Parse(numero);
                }
                switch (instruccion)//Interpretacion de instrucciones
                {
                    case "AV":
                    case "FW":

                        AvanzarTurtuga(grados, posy, posx, num, out ouy, out oux);
                        posy = ouy;
                        posx = oux;

                        break;

                    case "GD":
                    case "TR":

                        GirarDerecha();

                        break;

                    case "GI":
                    case "TL":

                        GirarIzquierda();

                        break;


                    case "VC":
                    case "GH":

                        GoHome();

                        break;

                    case "LL":
                    case "PU":
                        LapizArriba = true;
                        break;

                    case "BL":
                    case "PD":
                        LapizArriba = false;
                        break;

                    case "ET":
                    case "HT":
                        TortugaEscondida = true;
                        break;

                    case "MT":
                    case "ST":
                        TortugaEscondida = false;
                        break;

                    case "CC":
                        CambiarColor();
                        break;

                    default:
                        if (instruccion == "{" || instruccion == "}")
                        {

                        }
                        else
                        {
                            MessageBox.Show("NO SE RECONOCE LA INSTRUCCIÓN: " + instruccion);
                        }
                        break;
                }
            }
        }
        public void CambiarColor()
        {
            if (num <= 4)
            {
                color = num;
            }
            else
            {
                color = 0;
            }
        }

        public void GoHome()
        {
            posy = 325;
            posx = 400;
            grados = 0;
        }

        public void DibujarTortuga()
        {
            tortuga = true;
            num = 10;
            AvanzarTurtuga(grados, posy, posx, num, out ouy, out oux);
            posy = ouy;
            posx = oux;
            grados = grados - 135;
            GirarIzquierda();
            AvanzarTurtuga(grados, posy, posx, num, out ouy, out oux);
            grados = grados + 270;
            GirarDerecha();
            AvanzarTurtuga(grados, posy, posx, num, out ouy, out oux);
            tortuga = false;
        }

        public int GirarDerecha()
        {
            grados = grados + num;
            if (grados >= 360)
            {
                int sobrante = grados - 360;
                grados = sobrante;
            }
            return grados;
        }

        public int GirarIzquierda()
        {
            grados = grados - num;
            if (grados < 0)
            {
                int sobrante = grados + 360;
                grados = sobrante;
            }
            return grados;
        }

        public void AvanzarTurtuga (int grados, int posy, int posx, int num, out int ouy, out int oux)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            if (color == 0) { lapiz = new Pen(Color.Black); }
            if (color == 1) { lapiz = new Pen(Color.Blue); }
            if (color == 2) { lapiz = new Pen(Color.Red); }
            if (color == 3) { lapiz = new Pen(Color.Green); }
            if (color == 4) { lapiz = new Pen(Color.Yellow); }
            Pen ColorTortuga = new Pen(Color.Green);
            ouy = 0;
            oux = 0;
            if (grados == 0)
            {
                int temp = posy;
                posy = posy - num;
                if (tortuga == false)
                {
                    if (LapizArriba == false)
                    {
                        papel.DrawLine(lapiz, posx, temp, posx, posy);
                    }
                }else
                {
                        papel.DrawLine(ColorTortuga, posx, temp, posx, posy);
                }
            }
            else
            {
                if (grados <= 90)
                {
                    tempx = posx;
                    tempy = posy;
                    int gradosut = 90 - grados;
                    CalcularGrados(gradosut, num);

                    posx = posx + Disx;
                    posy = posy - Disy;
                    
                    if (tortuga == false)
                    {
                        if (LapizArriba == false)
                        {
                            papel.DrawLine(lapiz, tempx, tempy, posx, posy);
                        }
                    }
                    else
                    {
                            papel.DrawLine(ColorTortuga, tempx, tempy, posx, posy);
                    }
                }
                else
                {
                    if (grados <= 180)
                    {
                        tempx = posx;
                        tempy = posy;
                        int gradosut = grados - 90;
                        CalcularGrados(gradosut, num);

                        posx = posx + Disx;
                        posy = posy + Disy;
                        if (tortuga == false)
                        {
                            if (LapizArriba == false)
                            {
                                papel.DrawLine(lapiz, tempx, tempy, posx, posy);
                            }
                        }
                        else
                        {
                            papel.DrawLine(ColorTortuga, tempx, tempy, posx, posy);
                        }
                    }
                    else
                    {
                        if (grados <= 270)
                        {
                            tempx = posx;
                            tempy = posy;
                            int gradosut = 270 - grados;
                            CalcularGrados(gradosut, num);

                            posx = posx - Disx;
                            posy = posy + Disy;
                            if (tortuga == false)
                            {
                                if (LapizArriba == false)
                                {
                                    papel.DrawLine(lapiz, tempx, tempy, posx, posy);
                                }
                            }
                            else
                            {
                                papel.DrawLine(ColorTortuga, tempx, tempy, posx, posy);
                            }
                        }
                        else
                        {
                            if (grados <= 360)
                            {
                                tempx = posx;
                                tempy = posy;
                                int gradosut = grados - 270;
                                CalcularGrados(gradosut, num);

                                posx = posx - Disx;
                                posy = posy - Disy;
                                if(tortuga == false)
                                {
                                    if (LapizArriba == false)
                                    {
                                        papel.DrawLine(lapiz, tempx, tempy, posx, posy);
                                    }
                                }
                                else
                                {
                                    papel.DrawLine(ColorTortuga, tempx, tempy, posx, posy);
                                }
                            }
                        }
                    }
                }
            }
            ouy = posy;
            oux = posx;
            
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            
                pictureBox1.Image = null;
                MessageBox.Show("Pagina borrada");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int midy = 325;
            int midx = 400;
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);
            papel.DrawLine(lapiz, 0, midy, 800, midy);
            papel.DrawLine(lapiz, midx, 0, midx, 800);
            
        }

        private void btn_Cleartxt_Click(object sender, EventArgs e)
        {
            Codigotxt.Text = null;
        }

        private void Codigotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cargarcod_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                Codigotxt.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}