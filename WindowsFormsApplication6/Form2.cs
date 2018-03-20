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
            lbl_Comand.Text = "Comandos: \n AV/FW = Avanza \n RE/RT = Retrocede \n GD/TR = Gira a la derecha \n GI/TL = Gira a la izquierda \n LL/PU = Levantar lapiz \n BL/PD = Bajar Lapiz \n Repite/For = Repite la instrucción n numero de veces";
        }
    }
}
