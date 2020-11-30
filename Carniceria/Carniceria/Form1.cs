using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Res = new Form2();
            Res.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Puerco = new Form3();
            Puerco.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pollo CortePollo = new Pollo();
            CortePollo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          DialogResult r = MessageBox.Show("¿Seguro abandonar?", "Abandonar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( r == DialogResult.Yes)
            {
                this.Close();
            }else if (r == DialogResult.No)
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Tiket = new Form4();
            Tiket.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
