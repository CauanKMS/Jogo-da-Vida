using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAMEPROJECT
{
    public partial class Casa : Form
    {
        Form1 arma = new Form1();
        int energia = 10, fome, depre, forca, intel, money, bebida, comida;
        string pop, trab, mascfem, armas;

        public Casa()
        {
            InitializeComponent();
        }

        private void Casa_Load(object sender, EventArgs e)
        {
            lblEnergia.Text = Skills.Energia;
            lblFome.Text = Skills.Fome;
            lblDepre.Text = Skills.Depre;
            lblPop.Text = Skills.Pop;
            lblForca.Text = Skills.Forca;
            lblIntel.Text = Skills.Intel;
            lblMoney.Text = "$R " + Skills.Money.ToString();
            lblTrab.Text = Skills.Trab;
            lblMF.Text = Skills.Mascfem;
            lblArmas.Text = Skills.Armas;
            lblMasc_Fem.Text = Skills.Mmff;
            bebida = Comidas.bebida;
            comida = Comidas.comida;
            lblBebida.Text = Comidas.Bebida + " Bebidas";
            lblComida.Text = Comidas.Comida + " Comidas";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Jogo jogo = new Jogo();
            jogo.ShowDialog();
            this.Close();
        }

        private void btnCama_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você durmiu mto bem: +4 Fome, +10 Energia");

            if (energia != 10)
            {
                energia = 10;
                lblEnergia.Text = energia.ToString() + "/10";

                Skills.Energia = lblEnergia.Text;
            }

            if (fome != 20)
            {
                fome = fome + 4;
                lblFome.Text = fome.ToString() + "/20";

                Skills.Fome = lblFome.Text;
            }
        }

        private void lblFome_TextChanged(object sender, EventArgs e)
        {
            if (fome == 20)
            {
                MessageBox.Show("Você morreu");

                this.Visible = false;
                Homescreen home = new Homescreen();
                home.ShowDialog();
                this.Close();
            }
        }

        private void lblEnergia_TextChanged(object sender, EventArgs e)
        {
            if (energia == 0)
            {
                MessageBox.Show("Você morreu");

                this.Visible = false;
                Homescreen home = new Homescreen();
                home.ShowDialog();
                this.Close();
            }
        }

        private void btnBeber_Click(object sender, EventArgs e)
        {
            if (Comidas.Bebida == 0)
            {
                MessageBox.Show("Q vc acha q vc vai beber? Agua?");
            }
            else
            {
                MessageBox.Show("Voce mata sua sede com um delicioso yakute, -1 Fome, +1 Energia");

                bebida--;
                Comidas.Bebida = bebida;
                lblBebida.Text = Comidas.Bebida + " Bebidas";

                if (fome != 0)
                {
                    fome = fome - 4;
                    lblFome.Text = fome + "/20";
                    Skills.Fome = lblFome.Text;
                }

                if (energia != 10)
                {
                    energia++;
                    lblEnergia.Text = energia + "/10";
                    Skills.Energia = lblEnergia.Text;
                }
            }
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            if (Comidas.Comida == 0)
            {
                MessageBox.Show("Q vc acha q vc vai comer? Strogonoff?");
            }
            else
            {
                MessageBox.Show("Voce mata sua fome com um delicioso ganso ou talvez um delicioso pão, -4 Fome, +1 Energia");

                comida--;
                Comidas.Comida = comida;
                lblComida.Text = Comidas.Comida + " Comidas";

                if (fome != 0)
                {
                    fome = fome - 4;
                    lblFome.Text = fome + "/20";
                    Skills.Fome = lblFome.Text;
                }

                if (energia != 10)
                {
                    energia++;
                    lblEnergia.Text = energia + "/10";
                    Skills.Energia = lblEnergia.Text;
                }
            }
        }

    }
}
