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
    public partial class Form1 : Form
    {
        SerialPort sp;
        arduino ardSP = new arduino(9600);
        int contador = 1, intervalo = 0;
        public Form1()
        {
            InitializeComponent();
            sp = new SerialPort();
            sp = ardSP.GetSerialPort();
            sp.Open();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            PrenderLED();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Close();
            Application.Exit();
        }


        private void PrenderLED()
        {
            intervalo = ((contador / 10) + 1) * 1000;

            timer1.Interval = intervalo;

            label3.Text = (intervalo / 1000) + "";
            label4.Text = contador + "";

            sp.Write(contador + "");

            if (contador < 100)
            {
                contador++;
            }

            else
            {
                contador = 1;
            }
        }

    }
}


