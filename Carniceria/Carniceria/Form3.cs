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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Principal = new Form1();
            Principal.Show();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quiere confirmar este pedido?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    if (checkCostillasPuerco.Checked == true)
                    {
                        Puerco.CantidadCostillas = Convert.ToInt32(txtCantidadCostillas.Text);
                        Puerco.TotalPuerco += Puerco.Costillas * Puerco.CantidadCostillas;
                    }
                    if (checkSirlon.Checked == true)
                    {
                        Puerco.CantidadSirlon = Convert.ToInt32(txtCantidadSirlon.Text);
                        Puerco.TotalPuerco += Puerco.Sirlon * Puerco.CantidadSirlon;
                    }
                    if (checkChamorro.Checked == true)
                    {
                        Puerco.CantidadChamorro = Convert.ToInt32(txtCantidadChamorro.Text);
                        Puerco.TotalPuerco += Puerco.Chamorro * Puerco.CantidadChamorro;
                    }
                    if (checkCueritos.Checked == true)
                    {
                        Puerco.CantidadCueritos = Convert.ToInt32(txtCantidadCueritos.Text);
                        Puerco.TotalPuerco += Puerco.Cueritos * Puerco.CantidadCueritos;
                    }
                    if (checkCabezaLomo.Checked == true)
                    {
                        Puerco.CantidadCabeza = Convert.ToInt32(txtCantidadCabeza.Text);
                        Puerco.TotalPuerco += Puerco.Cabeza * Puerco.CantidadCabeza;
                    }
                    if (checkManitas.Checked == true)
                    {
                        Puerco.CantidadManitas = Convert.ToInt32(txtCantidadManitas.Text);
                        Res.TotalRes += Puerco.Manitas * Puerco.CantidadManitas;
                    }
                    if (checkEspaldilla.Checked == true)
                    {
                        Puerco.CantidadEspaldilla = Convert.ToInt32(txtCantidadEspaldilla.Text);
                        Puerco.TotalPuerco += Puerco.Espaldilla * Puerco.CantidadEspaldilla;
                    }
                    if (checkChicharrones.Checked == true)
                    {
                        Puerco.CantidadChicharrones = Convert.ToInt32(txtCantidadChicharron.Text);
                        Puerco.TotalPuerco += Puerco.Chicharrones * Puerco.CantidadChicharrones;
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
        private void Form3_Load(object sender, EventArgs e)
        {
            txtCantidadCabeza.Enabled = false;
            txtCantidadChamorro.Enabled = false;
            txtCantidadChicharron.Enabled = false;
            txtCantidadCostillas.Enabled = false;
            txtCantidadCueritos.Enabled = false;
            txtCantidadEspaldilla.Enabled = false;
            txtCantidadManitas.Enabled = false;
            txtCantidadSirlon.Enabled = false;
        }
        private void checkCabezaLomo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCabezaLomo.Checked == true)
            {
                txtCantidadCabeza.Enabled = true;

            }else if (checkCabezaLomo.Checked == true)
            {
                txtCantidadCabeza.Enabled = false; 
            }
        }
        private void checkCostillasPuerco_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCostillasPuerco.Checked == true)
            {
                txtCantidadCostillas.Enabled = true;

            }else if (checkCostillasPuerco.Checked == false)
            {
                txtCantidadCostillas.Enabled = false;
            }
        }
        private void checkSirlon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSirlon.Checked == true)
            {
               txtCantidadSirlon.Enabled = true;

            }else if (checkSirlon.Checked == false)
            {
                txtCantidadSirlon.Enabled = false;
            }
        }
        private void checkChamorro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChamorro.Checked == true)
            {
                txtCantidadChamorro.Enabled = true;

            }else if (checkChamorro.Checked == false)
            {
                txtCantidadChamorro.Enabled = false;
            }
        }
        private void checkCueritos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCueritos.Checked == true)
            {
                 txtCantidadCueritos.Enabled = true;

            }else if (checkCueritos.Checked == false)
            {
                txtCantidadCueritos.Enabled = false;
            }
        }
        private void checkManitas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkManitas.Checked == true)
            {
                txtCantidadManitas.Enabled = true;

            }else if (checkManitas.Checked == false)
            {
                txtCantidadManitas.Enabled = false;
            }
        }
        private void checkEspaldilla_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEspaldilla.Checked == true)
            {
                txtCantidadEspaldilla.Enabled = true;

            }else if (checkEspaldilla.Checked == false)
            {
                txtCantidadEspaldilla.Enabled = false;
            }
        }
        private void checkChicharrones_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChicharrones.Checked == true)
            {
                txtCantidadChicharron.Enabled = true;

            }else if (checkChicharrones.Checked == false)
            {
                txtCantidadChicharron.Enabled = false;
            }
        }
    }
}