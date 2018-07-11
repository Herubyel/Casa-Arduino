using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino1
{
    public partial class Form2 : Form
    {
        SerialPort sp;
        arduino arduinoConf = new arduino(9600);
        int contador = 1;

        public Form2()
        {
            InitializeComponent();
            sp = arduinoConf.GetSerialPort();
            sp.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LedVerde(button1);

        }

        private void LedVerde(Button BTN)
        {
            if (contador == 1)
            {

                sp.Write(1 + "");
                BTN.Text = "Cerrar PE";
                contador++;
            }
            else
            {

                sp.Write(2 + "");
                BTN.Text = "Abrir PE";
                contador = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LedVerde(button2);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LedRojo(button3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LedVerde(button12);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LedVerde(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LedVerde(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            LedRojo(button6);
            
        }

        private void LedRojo(Button BTN)
        {
            if (contador == 1)
            {

                sp.Write(3 + "");
                BTN.Text = "Apagar FE";
                contador++;
            }
            else
            {

                sp.Write(4 + "");
                BTN.Text = "Prender FE";
                contador = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LedRojo(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LedRojo(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LedRojo(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LedRojo(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LedRojo(button11);
        }
    }
}
