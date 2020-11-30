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
    public partial class Pollo : Form
    {
        public Pollo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Principal = new Form1();
            Principal.Show();
        }
        private void Pollo_Load(object sender, EventArgs e)
        {
            txtCantidadAlitas.Enabled = false;
            txtCantidadFajita.Enabled = false;
            txtCantidadMilanesa.Enabled = false;
            txtCantidadMuslo.Enabled = false;
            txtCantidadNuggets.Enabled = false;
            txtCantidadPechuga.Enabled = false;
            txtCantidadPierna.Enabled = false;
            txtCantidadRestazo.Enabled = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPechuga.Checked == true)
            {
                txtCantidadPechuga.Enabled = true;

            }else if (checkPechuga.Checked == false)
            {
                txtCantidadPechuga.Enabled = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPierna.Checked == true)
            {
                txtCantidadPierna.Enabled = true;

            }else if (checkPierna.Checked == false)
            {
                txtCantidadPierna.Enabled = false;
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNuggets.Checked == true)
            {
                txtCantidadNuggets.Enabled = true;

            }else if (checkNuggets.Checked == false)
            {
                txtCantidadNuggets.Enabled = false;
            }
        }
        private void checkRetazo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRetazo.Checked == true)
            {
                txtCantidadRestazo.Enabled = true;

            }else if (checkRetazo.Checked == false)
            {
                txtCantidadRestazo.Enabled = false;
            }
        }
        private void checkAlitas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAlitas.Checked == true)
            {
                txtCantidadAlitas.Enabled = true;

            }else if (checkAlitas.Checked == false)
            {
                txtCantidadAlitas.Enabled = false;
            }
        }
        private void checkMolanesa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMolanesa.Checked == true)
            {
                txtCantidadMilanesa.Enabled = true;

            }else if(checkMolanesa.Checked == false)
            {
                txtCantidadMilanesa.Enabled = false;
            }
        }
        private void checkMuslo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMuslo.Checked == true)
            {
                txtCantidadMuslo.Enabled = true;

            }else if (checkMuslo.Checked == false)
            {
                txtCantidadMuslo.Enabled = false;
            }
        }
        private void checkFajita_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFajita.Checked == true)
            {
                txtCantidadFajita.Enabled = true;

            }else if (checkFajita.Checked == false)
            {
                txtCantidadFajita.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quiere confirmar este pedido?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    if (checkPechuga.Checked == true)
                    {
                        Pollo2.CantidadPechuga = Convert.ToInt32(txtCantidadPechuga.Text);
                        Pollo2.TotalPollo += Pollo2.Pechuga * Pollo2.CantidadPechuga;
                    }
                    if (checkPierna.Checked == true)
                    {
                        Pollo2.CantidadPierna = Convert.ToInt32(txtCantidadPierna.Text);
                        Pollo2.TotalPollo += Pollo2.Pierna * Pollo2.CantidadPierna;
                    }
                    if (checkRetazo.Checked == true)
                    {
                        Pollo2.CantidadRatazo = Convert.ToInt32(txtCantidadRestazo.Text);
                        Pollo2.TotalPollo += Pollo2.Ratazo * Pollo2.CantidadRatazo;
                    }
                    if (checkAlitas.Checked == true)
                    {
                        Pollo2.CantidadAlitas = Convert.ToInt32(txtCantidadAlitas.Text);
                        Pollo2.TotalPollo += Pollo2.Alitas * Pollo2.CantidadAlitas;
                    }
                    if (checkMolanesa.Checked == true)
                    {
                        Pollo2.CantidadMilanesa = Convert.ToInt32(txtCantidadMilanesa.Text);
                        Pollo2.TotalPollo += Pollo2.Milanesa * Pollo2.CantidadMilanesa;
                    }
                    if (checkMuslo.Checked == true)
                    {
                        Pollo2.CantidadMuslo = Convert.ToInt32(txtCantidadMuslo.Text);
                        Pollo2.TotalPollo += Pollo2.Muslo * Pollo2.CantidadMuslo;
                    }
                    if (checkNuggets.Checked == true)
                    {
                        Pollo2.CantidadNuggets = Convert.ToInt32(txtCantidadNuggets.Text);
                        Pollo2.TotalPollo += Pollo2.Nuggets * Pollo2.CantidadNuggets;
                    }
                    if (checkFajita.Checked == true)
                    {
                        Pollo2.CantidadFajitas = Convert.ToInt32(txtCantidadFajita.Text);
                        Pollo2.TotalPollo += Pollo2.Fajitas * Pollo2.CantidadFajitas;
                    }
                    MessageBox.Show("Se agregado correctamente", "Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ingrese un digito entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (r == DialogResult.No)
            {
                return;
            }
        }
    }
}