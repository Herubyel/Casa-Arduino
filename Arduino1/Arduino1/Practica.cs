using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino1
{
    public partial class Practica : Form
    {
        
        public Practica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Click(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Click(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Click(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Click(button4);
        }

        private void Click(Button btn)
        {
            MessageBox.Show("Has seleccionado el boton " + btn.Name);
        }

    }
}
