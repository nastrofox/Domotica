using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classetelecomando
{
    public partial class Form1 : Form
    {
        private telecomando tel;
        public int i = 1;
        public Form1()
        {
            InitializeComponent();
            tel = new telecomando("redmi", "R123Sz", "infrarossi");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tel.aumentacanale();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (i % 2 == 1)
            {
                tel.accendi();
                button1.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button3.Visible = true;
                button2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            else 
            {
                tel.spegni();
                button1.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
                i++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tel.aumentaVolume();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tel.diminuisciVolume();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tel.diminuiscicanale();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{tel.getVolume()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{tel.getCanale()}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{tel.getStato()}");
        }
    }
}
