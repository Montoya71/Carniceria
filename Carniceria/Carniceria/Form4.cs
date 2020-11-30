using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Carniceria
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Principal = new Form1();
            Principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Seccion de Res
            int Total;
            if (Res.CantidadArrachera != 0)
            {
                Total = Res.CantidadArrachera * Res.Arrachera;
                txtTiket.Text += Res.CantidadArrachera + " Kilos de Arrachera...............$" + Total + "  ";
            }
            if (Res.CantidadNewYork != 0)
            {
                Total = Res.CantidadNewYork * Res.NewYork;
                txtTiket.Text += Res.CantidadNewYork + " Kilos de New York..............$" + Total + " ";
            }
            if (Res.CantidadTomahawk != 0)
            {
                Total = Res.CantidadTomahawk * Res.Tomahawk;
                txtTiket.Text += Res.CantidadTomahawk + " Kilos de Tomahawk..............$" + Total + "  ";
            }
            if (Res.CantidadT_Bone != 0)
            {
                Total = Res.CantidadT_Bone * Res.T_Bone;
                txtTiket.Text += Res.CantidadT_Bone + " Kilos de T-Bone...................$" + Total + "  ";
            }
            if (Res.CantidadAgujaNorteña != 0)
            {
                Total = Res.CantidadAgujaNorteña * Res.AgujaNorteña;
                txtTiket.Text += Res.CantidadAgujaNorteña + " Kilos de Aguja Norteña........$" + Total + " ";
            }
            if (Res.CantidadRib_Eye != 0)
            {
                Total = Res.CantidadRib_Eye * Res.Rib_Eye;
                txtTiket.Text += Res.CantidadRib_Eye + " Kilos de Rib Eye................$" + Total + "  ";
            }
            if (Res.CantidadCostillasRes != 0)
            {
                Total = Res.CantidadCostillasRes * Res.CostillasRes;
                txtTiket.Text += Res.CantidadCostillasRes + " Kilos de Costillas de Res........$" + Total + " ";
            }
            if (Res.CantidadSirlon != 0)
            {
                Total = Res.CantidadSirlon * Res.Sirlon;
                txtTiket.Text += Res.CantidadSirlon + " kilos de Top Sirlon................$" + Total + " ";
            }

            //Seccion de Puerco

            if (Puerco.CantidadCostillas != 0)
            {
                Total = Puerco.CantidadCostillas * Puerco.Costillas;
                txtTiket.Text += Puerco.CantidadCostillas + " Kilos de Costillas de Puerco..$" + Total + "  ";
            }
            if (Puerco.CantidadSirlon != 0)
            {
                Total = Puerco.CantidadSirlon * Puerco.Sirlon;
                txtTiket.Text += Puerco.CantidadSirlon + " Kilos de Sirlon de Puerco......$" + Total + " ";
            }
            if (Puerco.CantidadChamorro != 0)
            {
                Total = Puerco.CantidadChamorro * Puerco.Chamorro;
                txtTiket.Text += Puerco.CantidadChamorro + " Kilos de Chamorro................$" + Total + "  ";
            }
            if (Puerco.CantidadCueritos != 0)
            {
                Total = Puerco.CantidadCueritos * Puerco.Cueritos;
                txtTiket.Text += Puerco.CantidadCueritos + " Kilos de Cueritos...................$" + Total + "  ";
            }
            if (Puerco.CantidadCabeza != 0)
            {
                Total = Puerco.CantidadCabeza * Puerco.Cabeza;
                txtTiket.Text += Puerco.CantidadCabeza + " Kilos de Cabeza de lomo.......$" + Total + " ";
            }
            if (Puerco.CantidadManitas != 0)
            {
                Total = Puerco.CantidadManitas * Puerco.Manitas;
                txtTiket.Text += Puerco.CantidadManitas + " Kilos de Manitas...................$" + Total + "  ";
            }
            if (Puerco.CantidadEspaldilla != 0)
            {
                Total = Puerco.CantidadEspaldilla * Puerco.Espaldilla;
                txtTiket.Text += Puerco.CantidadEspaldilla + " Kilos de Espaldilla................$" + Total + " ";
            }
            if (Puerco.CantidadChicharrones != 0)
            {
                Total = Puerco.CantidadChicharrones * Puerco.Chicharrones;
                txtTiket.Text += Puerco.CantidadChicharrones + " Kilos de Chicharrones...........$" + Total + "  ";
            }

            //Seccion de Pollo

            if (Pollo2.CantidadPechuga != 0)
            {
                Total= Pollo2.CantidadPechuga * Pollo2.Pechuga;
                txtTiket.Text += Pollo2.CantidadPechuga + " Kilos de Pechuga.................$" + Total + "  ";
            }
            if (Pollo2.CantidadPierna != 0)
            {
                Total = Pollo2.CantidadPierna * Pollo2.Pierna;
                txtTiket.Text += Pollo2.CantidadPierna + " Kilos de Pierna.......................$" + Total + " ";
            }
            if (Pollo2.CantidadRatazo != 0)
            {
                Total = Pollo2.CantidadRatazo * Pollo2.Ratazo;
                txtTiket.Text += Pollo2.CantidadRatazo + " Kilos de Retazo......................$" + Total + "  ";
            }
            if (Pollo2.CantidadAlitas != 0)
            {
                Total = Pollo2.CantidadAlitas * Pollo2.Alitas;
                txtTiket.Text += Pollo2.CantidadAlitas + " Kilos de Alitas......................$" + Total + "  ";
            }
            if (Pollo2.CantidadMilanesa != 0)
            {
                Total = Pollo2.CantidadMilanesa * Pollo2.Milanesa;
                txtTiket.Text += Pollo2.CantidadMilanesa + " Kilos de Milanesa.................$" + Total + " ";
            }
            if (Pollo2.CantidadMuslo != 0)
            {
                Total = Pollo2.CantidadMuslo * Pollo2.Muslo;
                txtTiket.Text += Pollo2.CantidadMuslo + " Kilos de Muslo.......................$" + Total + "  ";
            }
            if (Pollo2.CantidadNuggets != 0)
            {
                Total = Pollo2.CantidadNuggets * Pollo2.Nuggets;
                txtTiket.Text += Pollo2.CantidadNuggets + " Kilos de Nuggets...................$" + Total + " ";
            }
            if (Pollo2.CantidadFajitas != 0)
            {
                Total = Pollo2.CantidadFajitas * Pollo2.Fajitas;
                txtTiket.Text += Pollo2.CantidadFajitas + " Kilos de Fajitas......................$" + Total + "  ";
            }

            int TotalCarniceria;
            TotalCarniceria = Res.TotalRes + Pollo2.TotalPollo + Puerco.TotalPuerco;
            lblTotal.Text = Convert.ToString(TotalCarniceria);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\emman\Desktop\Tiket2.Txt", true);
            try
            {
                int Total;
                escribir.WriteLine("------------------Tiket-----------------");

                //Res
                if (Res.CantidadArrachera != 0)
                {
                    Total = Res.CantidadArrachera * Res.Arrachera;
                    escribir.WriteLine(Res.CantidadArrachera + " Kilos de Arrachera................$" + Total + "  ");
                }
                if (Res.CantidadNewYork != 0)
                {
                    Total = Res.CantidadNewYork * Res.NewYork;
                    escribir.WriteLine(Res.CantidadNewYork + " Kilos de New York.................$" + Total + " ");
                }
                if (Res.CantidadTomahawk != 0)
                {
                    Total = Res.CantidadTomahawk * Res.Tomahawk;
                    escribir.WriteLine(Res.CantidadTomahawk + " Kilos de Tomahawk.................$" + Total + "  ");
                }
                if (Res.CantidadT_Bone != 0)
                {
                    Total = Res.CantidadT_Bone * Res.T_Bone;
                    escribir.WriteLine(Res.CantidadT_Bone + " Kilos de T-Bone...................$" + Total + "  ");
                }
                if (Res.CantidadAgujaNorteña != 0)
                {
                    Total = Res.CantidadAgujaNorteña * Res.AgujaNorteña;
                    escribir.WriteLine(Res.CantidadAgujaNorteña + " Kilos de Aguja Norteña............$" + Total + " ");
                }
                if (Res.CantidadRib_Eye != 0)
                {
                    Total = Res.CantidadRib_Eye * Res.Rib_Eye;
                    escribir.WriteLine(Res.CantidadRib_Eye + " Kilos de Rib Eye.................$" + Total + "  ");
                }
                if (Res.CantidadCostillasRes != 0)
                {
                    Total = Res.CantidadCostillasRes * Res.CostillasRes;
                    escribir.WriteLine(Res.CantidadCostillasRes + " Kilos de Costillas de Res.........$" + Total + " ");
                }
                if (Res.CantidadSirlon != 0)
                {
                    Total = Res.CantidadSirlon * Res.Sirlon;
                    escribir.WriteLine(Res.CantidadSirlon + " kilos de Top Sirlon...............$" + Total + " ");
                }

                //Puerco 
                if (Puerco.CantidadCostillas != 0)
                {
                    Total = Puerco.CantidadCostillas * Puerco.Costillas;
                    escribir.WriteLine(Puerco.CantidadCostillas + " Kilos de Costillas de Puerco......$" + Total + "  ");
                }
                if (Puerco.CantidadSirlon != 0)
                {
                    Total = Puerco.CantidadSirlon * Puerco.Sirlon;
                    escribir.WriteLine(Puerco.CantidadSirlon + " Kilos de Sirlon de Puerco....,,,..$" + Total + " ");
                }
                if (Puerco.CantidadChamorro != 0)
                {
                    Total = Puerco.CantidadChamorro * Puerco.Chamorro;
                    escribir.WriteLine(Puerco.CantidadChamorro + " Kilos de Chamorro.................$" + Total + "  ");
                }
                if (Puerco.CantidadCueritos != 0)
                {
                    Total = Puerco.CantidadCueritos * Puerco.Cueritos;
                    escribir.WriteLine(Puerco.CantidadCueritos + " Kilos de Cueritos.................$" + Total + "  ");
                }
                if (Puerco.CantidadCabeza != 0)
                {
                    Total = Puerco.CantidadCabeza * Puerco.Cabeza;
                    escribir.WriteLine(Puerco.CantidadCabeza + " Kilos de Cabeza de lomo...........$" + Total + " ");
                }
                if (Puerco.CantidadManitas != 0)
                {
                    Total = Puerco.CantidadManitas * Puerco.Manitas;
                    escribir.WriteLine(Puerco.CantidadManitas + " Kilos de Manitas..................$" + Total + "  ");
                }
                if (Puerco.CantidadEspaldilla != 0)
                {
                    Total = Puerco.CantidadEspaldilla * Puerco.Espaldilla;
                    escribir.WriteLine(Puerco.CantidadEspaldilla + " Kilos de Espaldilla...............$" + Total + " ");
                }
                if (Puerco.CantidadChicharrones != 0)
                {
                    Total = Puerco.CantidadChicharrones * Puerco.Chicharrones;
                    escribir.WriteLine(Puerco.CantidadChicharrones + " Kilos de Chicharrones.............$" + Total + "  ");
                }

                //Pollo

                if (Pollo2.CantidadPechuga != 0)
                {
                    Total = Pollo2.CantidadPechuga * Pollo2.Pechuga;
                    escribir.WriteLine(Pollo2.CantidadPechuga + " Kilos de Pechuga..................$" + Total + "  ");
                }
                if (Pollo2.CantidadPierna != 0)
                {
                    Total = Pollo2.CantidadPierna * Pollo2.Pierna;
                    escribir.WriteLine(Pollo2.CantidadPierna + " Kilos de Pierna...................$" + Total + " ");
                }
                if (Pollo2.CantidadRatazo != 0)
                {
                    Total = Pollo2.CantidadRatazo * Pollo2.Ratazo;
                    escribir.WriteLine(Pollo2.CantidadRatazo + " Kilos de Retazo...................$" + Total + "  ");
                }
                if (Pollo2.CantidadAlitas != 0)
                {
                    Total = Pollo2.CantidadAlitas * Pollo2.Alitas;
                    escribir.WriteLine(Pollo2.CantidadAlitas + " Kilos de Alitas...................$" + Total + "  ");
                }
                if (Pollo2.CantidadMilanesa != 0)
                {
                    Total = Pollo2.CantidadMilanesa * Pollo2.Milanesa;
                    escribir.WriteLine(Pollo2.CantidadMilanesa + " Kilos de Milanesa.................$" + Total + " ");
                }
                if (Pollo2.CantidadMuslo != 0)
                {
                    Total = Pollo2.CantidadMuslo * Pollo2.Muslo;
                    escribir.WriteLine(Pollo2.CantidadMuslo + " Kilos de Muslo....................$" + Total + "  ");
                }
                if (Pollo2.CantidadNuggets != 0)
                {
                    Total = Pollo2.CantidadNuggets * Pollo2.Nuggets;
                    escribir.WriteLine(Pollo2.CantidadNuggets + " Kilos de Nuggets..................$" + Total + " ");
                }
                if (Pollo2.CantidadFajitas != 0)
                {
                    Total = Pollo2.CantidadFajitas * Pollo2.Fajitas;
                    escribir.WriteLine(Pollo2.CantidadFajitas + " Kilos de Fajitas..................$" + Total + "  ");
                }

                int TotalCarniceria2;
                TotalCarniceria2 = Res.TotalRes + Pollo2.TotalPollo + Puerco.TotalPuerco;
                lblTotal.Text = Convert.ToString(TotalCarniceria2);
                escribir.WriteLine("Total...............................$" + TotalCarniceria2);
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error", "Tiket", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            escribir.Close();
        }
    }
}