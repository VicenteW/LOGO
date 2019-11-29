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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_Comand.Text = "Comandos: \n AV/FW = Avanza \n GD/TR = Gira a la derecha \n GI/TL = Gira a la izquierda \n VC/GH = Volver a casa \n LL/PU = Levantar lapiz \n BL/PD = Bajar Lapiz \n ET/HT: Esconder tortuga \n MT/ST = Mostrar Tortuga \n CC = Cambiar color: 0 Negro, 1 Azul, 2 Rojo, 3 Verde, 4 Amarillo \n RE = Repetir comandos colocados entre { y }, al usar este comando es necesario dejar las llaves en su propio reglon sin otro comando en el mismo.";
        }
    }
}
