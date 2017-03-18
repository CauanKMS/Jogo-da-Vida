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
    public partial class Mercado_Ipiratininga : Form
    {
        int bebidas, comida1, comida2, comidaTotal, money;

        public Mercado_Ipiratininga()
        {
            InitializeComponent();
        }

        private void Mercado_Ipiratininga_Load(object sender, EventArgs e)
        {
            lblMoney.Text = "$R " + Skills.Money.ToString();
            money = Skills.Money;
        }

        private void btnYakute_Click(object sender, EventArgs e)
        {
            if (lblMoney.Text == "$R 0,00")
            {
                MessageBox.Show("Money que é bom, vc não have");
            }
            else
            {
                MessageBox.Show("Vc comprou um Yakute, -1 Money");

                bebidas++;
                Comidas.Bebida = bebidas;

                money--;
                Skills.Money = money;
                lblMoney.Text = "$R " + Skills.Money.ToString();
            }
        }

        private void btnGanso_Click(object sender, EventArgs e)
        {
            if (lblMoney.Text == "$R 0,00")
            {
                MessageBox.Show("Money que é bom, vc não have");
            }
            else
            {
                MessageBox.Show("Vc comprou um Ganso, -3 Money");

                comida1++;
                comidaTotal = comida1 + comida2;
                Comidas.Comida = comidaTotal;

                money = money - 3;
                Skills.Money = money;
                lblMoney.Text = "$R " + Skills.Money.ToString();
            }
        }

        private void btnPao_Click(object sender, EventArgs e)
        {
            if (lblMoney.Text == "$R 0,00")
            {
                MessageBox.Show("Money que é bom, vc não have");
            }
            else
            {
                MessageBox.Show("Vc comprou um Pao, -2 Money");

                comida2++;
                comidaTotal = comida1 + comida2;
                Comidas.Comida = comidaTotal;

                money = money - 2;
                Skills.Money = money;
                lblMoney.Text = "$R " + Skills.Money.ToString();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Jogo jogo = new Jogo();
            jogo.ShowDialog();
            this.Close();
        }
    }
}
