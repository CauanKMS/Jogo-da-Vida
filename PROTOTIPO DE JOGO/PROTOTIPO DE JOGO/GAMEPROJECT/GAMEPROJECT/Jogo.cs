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
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult resp,resp1;
            resp = MessageBox.Show("Sair? Se sair, perderá seus dados", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resp == DialogResult.Yes)
            {
                if (labelAbstrata.LabelSecsu == "Masculino")
                {
                    resp1 = MessageBox.Show("Rala");

                    if (resp1 == DialogResult.OK)
                    {
                        this.Visible = false;
                        Homescreen home = new Homescreen();
                        home.ShowDialog();
                        this.Close();
                    }
                }

                if (labelAbstrata.LabelSecsu == "Feminino")
                {
                    resp1 = MessageBox.Show("Por aqui, senhorita");

                    if (resp1 == DialogResult.OK)
                    {
                        this.Visible = false;
                        Homescreen home = new Homescreen();
                        home.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Casa casa = new Casa();
            casa.ShowDialog();
            this.Close();
        }

        private void btnMercado_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Mercado_Ipiratininga merca = new Mercado_Ipiratininga();
            merca.ShowDialog();
            this.Close();
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            escolaGaribaldo escola = new escolaGaribaldo();
            escola.ShowDialog();
            this.SuspendLayout();
            this.Close();
        }
    }
}
