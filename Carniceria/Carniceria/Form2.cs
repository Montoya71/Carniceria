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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Principal = new Form1();
            Principal.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            txtCantidadArrachera.Enabled = false;
            txtCantidadAgujaNorteña.Enabled = false;
            txtCantidadCostillasRes.Enabled = false;
            txtCantidadNewYork.Enabled = false;
            txtCantidadRibEye.Enabled = false;
            txtCantidadSirlon.Enabled = false;
            txtCantidadTomahawk.Enabled = false;
            txtCantidadT_Bone.Enabled = false;
        }
        private void checkArrachera_CheckedChanged(object sender, EventArgs e)
        {
            if (checkArrachera.Checked == true)
            {
                txtCantidadArrachera.Enabled = true;

            }else if (checkArrachera.Checked == false)
            {
                txtCantidadArrachera.Enabled = false;
            }
        }
        public void checkNewYork_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNewYork.Checked == true)
            {
                txtCantidadNewYork.Enabled = true;

            }else if(checkNewYork.Checked == false)
            {
                txtCantidadNewYork.Enabled = false;
            }
        }
        private void checkTomahawk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTomahawk.Checked == true)
            {           
                txtCantidadTomahawk.Enabled = true;

            }else if (checkTomahawk.Checked == false)
            {
                txtCantidadTomahawk.Enabled = false;
            }
        }
        private void checkT_Bone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkT_Bone.Checked == true)
            {
                txtCantidadT_Bone.Enabled = true;

            } else if (checkT_Bone.Checked == false)
            {
                txtCantidadT_Bone.Enabled = false;
            }
        }
        private void checkAgujaNorteña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAgujaNorteña.Checked == true)
            {
                txtCantidadAgujaNorteña.Enabled = true;

            } else if (checkAgujaNorteña.Checked == false)
            {
                txtCantidadAgujaNorteña.Enabled = false;
            }
        }
        private void checkRib_Eye_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRib_Eye.Checked == true)
            {
                txtCantidadRibEye.Enabled = true;

            }else if (checkRib_Eye.Checked == false)
            {
                txtCantidadRibEye.Enabled = false;
            }
        }
        private void checkCostillasRes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCostillasRes.Checked == true)
            {
                txtCantidadCostillasRes.Enabled = true;

            }else if(checkCostillasRes.Checked == false)
            {
                txtCantidadCostillasRes.Enabled = false;
            }
        }
        private void checkSirlon_CheckedChanged(object sender, EventArgs e)
        {
            if(checkSirlon.Checked == true)
            {
                txtCantidadSirlon.Enabled = true;

            }else if(checkSirlon.Checked == false)
            {
                txtCantidadSirlon.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quiere confirmar este pedido ?", "Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    if (checkArrachera.Checked == true)
                    {
                        Res.CantidadArrachera = Convert.ToInt32(txtCantidadArrachera.Text);
                        Res.TotalRes += Res.Arrachera * Res.CantidadArrachera;
                    }
                    if (checkNewYork.Checked == true)
                    {
                        Res.CantidadNewYork = Convert.ToInt32(txtCantidadNewYork.Text);
                        Res.TotalRes += Res.NewYork * Res.CantidadNewYork;
                    }
                    if (checkTomahawk.Checked == true)
                    {
                        Res.CantidadTomahawk = Convert.ToInt32(txtCantidadTomahawk.Text);
                        Res.TotalRes += Res.Tomahawk * Res.CantidadTomahawk;
                    }
                    if (checkT_Bone.Checked == true)
                    {
                        Res.CantidadT_Bone = Convert.ToInt32(txtCantidadT_Bone.Text);
                        Res.TotalRes += Res.T_Bone * Res.CantidadT_Bone;
                    }
                    if (checkAgujaNorteña.Checked == true)
                    {
                        Res.CantidadAgujaNorteña = Convert.ToInt32(txtCantidadAgujaNorteña.Text);
                        Res.TotalRes += Res.AgujaNorteña * Res.CantidadAgujaNorteña;
                    }
                    if (checkRib_Eye.Checked == true)
                    {
                        Res.CantidadRib_Eye = Convert.ToInt32(txtCantidadRibEye.Text);
                        Res.TotalRes += Res.Rib_Eye * Res.CantidadRib_Eye;
                    }
                    if (checkCostillasRes.Checked == true)
                    {
                        Res.CantidadCostillasRes = Convert.ToInt32(txtCantidadCostillasRes.Text);
                        Res.TotalRes += Res.CostillasRes * Res.CantidadCostillasRes;
                    }
                    if (checkSirlon.Checked == true)
                    {
                        Res.CantidadSirlon = Convert.ToInt32(txtCantidadSirlon.Text);
                        Res.TotalRes += Res.Sirlon * Res.CantidadSirlon;
                    }
                    MessageBox.Show("Se agrego correctamente", "Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ingrese un digito entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (r==DialogResult.No)
            {
                return;
            }
        }
    }
}