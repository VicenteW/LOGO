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

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int Disy;
        int Disx;
        int tempx;
        int tempy;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            instrucciontxt.Text = "De click en el espacio vacio para mostrar la tortuga";
            
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
                    sw.Write(temporal + " /n ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            int posy = 325;
            int posx = 400;
            int grados = 0;
            for (int i = 0; i < Codigotxt.Lines.Count(); i++)
            {
                
                    string instruccion = null;
                    string numero = null;
                    bool inst = false;
                    int num = 0;
                    string LineaAct = Codigotxt.Lines[i].ToUpper();
                    char[] LineaChar = LineaAct.ToCharArray();
                    for (int j = 0; j < LineaChar.Length; j++)
                    {
                        if (LineaChar[j] != ' ' && inst == true)
                        {
                            numero = numero + LineaChar[j];
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
                        if (grados == 0)
                        {
                            int temp = posy;
                            posy = posy - num;
                            papel.DrawLine(lapiz, posx, temp, posx, posy);
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
                                papel.DrawLine(lapiz, tempx, tempy, posx, posy);
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
                                    papel.DrawLine(lapiz, tempx, tempy, posx, posy);
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
                                        papel.DrawLine(lapiz, tempx, tempy, posx, posy);
                                    }
                                    else
                                    {
                                        if(grados <= 360)
                                        {
                                            tempx = posx;
                                            tempy = posy;
                                            int gradosut = grados - 270;
                                            CalcularGrados(gradosut, num);

                                            posx = posx - Disx;
                                            posy = posy - Disy;
                                            papel.DrawLine(lapiz, tempx, tempy, posx, posy);
                                        }
                                    }
                                }
                            }
                        }
                           

                            break;

                        case "GD":
                        case "TR":
                            grados = grados + num;
                            if (grados >= 360)
                            {
                                int sobrante = grados - 360;
                                grados = sobrante;
                            }


                            break;

                        case "GI":
                        case "TL":

                        grados = grados - num;
                        if(grados < 0)
                        {
                            int sobrante = grados + 360;
                            grados = sobrante;
                        }

                        break;

                        default:
                            MessageBox.Show("NO SE RECONOCE LA INSTRUCCIÓN");
                            break;
                    }  
            }//Cierre de la ejecucion del codigo

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
            Pen lapiz = new Pen(Color.Black);
            papel.DrawLine(lapiz, 395, 325, 405, 325);
            papel.DrawLine(lapiz, 405, 325, 400, 315);
            papel.DrawLine(lapiz, 400, 315, 395, 325);

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