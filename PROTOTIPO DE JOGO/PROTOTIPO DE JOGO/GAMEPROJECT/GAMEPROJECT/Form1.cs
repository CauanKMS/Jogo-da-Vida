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
    public partial class Form1 : Form
    {
        int money;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Comidas.Comida = 0;
            Comidas.Bebida = 0;
            money = 10;

            lblNome.Text = labelAbstrata.LabelNome;
            lblSecsu.Text = labelAbstrata.LabelSecsu;

            if (labelAbstrata.LabelNome == "MONXXTRO" && labelAbstrata.LabelSecsu == "Masculino" || labelAbstrata.LabelNome == "MONXXTRO" && labelAbstrata.LabelSecsu == "Feminino")
            {
                lblSecsu.Text = "MÁSCULO";
                lblMF.Text = "MACHO ALPHA";
                lblMasc_Fem.Text = "MASCULINIDADE:";
                lblTrab.Text = "ACADEMIA";
                lblForca.Text = "20/20 - STRONDA";
                lblIntel.Text = "0/20 - Continua burro";
                lblPop.Text = "MONXXTRO";
                lblArmas.Text = "Mão de Ogro";

                Image img = Image.FromFile("Monxxtro.bmp");
                pctVoce.Image = img;
                pctVoce.SizeMode = PictureBoxSizeMode.Zoom;

                #region cores
                groupBox1.ForeColor = Color.Black;
                groupBox2.ForeColor = Color.Black;
                groupBox3.ForeColor = Color.Black;
                groupBox4.ForeColor = Color.Black;
                groupBox5.ForeColor = Color.Black;

                btnVoltar.BackColor = Color.Black;
                btnVoltar.ForeColor = Color.White;
                btnIniciar.BackColor = Color.Black;
                btnIniciar.ForeColor = Color.White;

                lblEnergia.ForeColor = Color.Black;
                lblFome.ForeColor = Color.Black;
                lblForca.ForeColor = Color.Black;
                lblIntel.ForeColor = Color.Black;
                lblMF.ForeColor = Color.Black;
                lblMoney.ForeColor = Color.Black;
                lblNome.ForeColor = Color.Black;
                lblPop.ForeColor = Color.Black;
                lblSecsu.ForeColor = Color.Black;
                lblTrab.ForeColor = Color.Black;
                lblDepre.ForeColor = Color.Black;

                lblMasc_Fem.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                #endregion

            }

            else
            {
                if (labelAbstrata.LabelNome == "DOLLYNHO" && labelAbstrata.LabelSecsu == "Masculino" || labelAbstrata.LabelNome == "DOLLYNHO" && labelAbstrata.LabelSecsu == "Feminino")
                {
                        lblMasc_Fem.Text = "DOLLYNILIDADE:";
                        lblMF.Text = "Seu Amiguinho";
                        lblTrab.Text = "Dolly";
                        lblForca.Text = "0/20 - Dollynho Frango";
                        lblIntel.Text = "0/20 - Dollynho Burro";
                        lblPop.Text = "Famoso";
                        lblArmas.Text = "Acabar Amizade";

                        Image img = Image.FromFile("DOLLYNHO.jpeg");
                        pctVoce.Image = img;
                        pctVoce.SizeMode = PictureBoxSizeMode.Zoom;

                        #region cores
                        groupBox1.ForeColor = Color.Green;
                        groupBox2.ForeColor = Color.Green;
                        groupBox3.ForeColor = Color.Green;
                        groupBox4.ForeColor = Color.Green;
                        groupBox5.ForeColor = Color.Green;

                        btnVoltar.BackColor = Color.Green;
                        btnVoltar.ForeColor = Color.White;
                        btnIniciar.BackColor = Color.Green;
                        btnIniciar.ForeColor = Color.White;

                        lblEnergia.ForeColor = Color.Green;
                        lblFome.ForeColor = Color.Green;
                        lblForca.ForeColor = Color.Green;
                        lblIntel.ForeColor = Color.Green;
                        lblMF.ForeColor = Color.Green;
                        lblMoney.ForeColor = Color.Green;
                        lblNome.ForeColor = Color.Green;
                        lblPop.ForeColor = Color.Green;
                        lblSecsu.ForeColor = Color.Green;
                        lblTrab.ForeColor = Color.Green;
                        lblDepre.ForeColor = Color.Green;

                        lblMasc_Fem.ForeColor = Color.Green;
                        label1.ForeColor = Color.Green;
                        label2.ForeColor = Color.Green;
                        label3.ForeColor = Color.Green;
                        label4.ForeColor = Color.Green;
                        label5.ForeColor = Color.Green;
                        label6.ForeColor = Color.Green;
                        label7.ForeColor = Color.Green;
                        label8.ForeColor = Color.Green;
                        #endregion
                }
                else
                {
                    if (labelAbstrata.LabelSecsu == "Masculino")
                    {
                        lblMasc_Fem.Text = "MASCULINIDADE:";
                        lblMasc_Fem.ForeColor = Color.Blue;
                        lblMF.ForeColor = Color.Blue;
                        lblSecsu.ForeColor = Color.Blue;
                        lblMF.Text = "Lixinho";
                        lblTrab.Text = "Vagabundo";
                        lblForca.Text = "0/20 - Franguinho";
                        lblIntel.Text = "0/20 - Burro";
                        lblPop.Text = "Desconhecido";
                        lblArmas.Text = "Porrada";
                    }
                    if (labelAbstrata.LabelSecsu == "Feminino")
                    {
                        lblMasc_Fem.Text = "FEMINILIDADE:";
                        lblMasc_Fem.ForeColor = Color.Fuchsia;
                        lblMF.ForeColor = Color.Fuchsia;
                        lblSecsu.ForeColor = Color.Fuchsia;
                        lblMF.Text = "Lixinha";
                        lblTrab.Text = "Vagaba";
                        lblForca.Text = "0/20 - Franguinha";
                        lblIntel.Text = "0/20 - Burra";
                        lblPop.Text = "Desconhecida";
                        lblArmas.Text = "Porrada";
                    }
                }
            }

            lblEnergia.Text = "10/10";
            lblFome.Text = "0/20";
            lblDepre.Text = "0/100";
            lblMoney.Text = "$R " + money;

            if (labelAbstrata.LabelNome == "KING")
            {
                MessageBox.Show("VOCÊ É MUITO FODA PARA CONTINUAR", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Visible = false;
                Homescreen home = new Homescreen();
                home.ShowDialog();
                this.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Preferencias pref = new Preferencias();
            pref.ShowDialog();
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Skills.Depre = lblDepre.Text;
            Skills.Energia = lblEnergia.Text;
            Skills.Fome = lblFome.Text;
            Skills.Money = money;
            Skills.Mascfem = lblMF.Text;
            Skills.Pop = lblPop.Text;
            Skills.Trab = lblTrab.Text;
            Skills.Forca = lblForca.Text;
            Skills.Intel = lblIntel.Text;
            Skills.Armas = lblArmas.Text;
            Skills.Mmff = lblMasc_Fem.Text;
            
            this.Visible = false;
            carregamentoIniciodoJogo jogo = new carregamentoIniciodoJogo();
            jogo.ShowDialog();
            this.Close();
        }

        private void lblArmas_Click(object sender, EventArgs e)
        {
            if(lblArmas.Text == "Acabar Amizade")
            {
                MessageBox.Show("PQ VC FEZ ISSO ???? ACABOU AMIGUINHO, NAO SOU MAIS SEU ABIGUINHO, SEU MONXXTRO");

                this.Visible = false;
                Homescreen home = new Homescreen();
                home.ShowDialog();
                this.Close();
            }
        }

    }
}
