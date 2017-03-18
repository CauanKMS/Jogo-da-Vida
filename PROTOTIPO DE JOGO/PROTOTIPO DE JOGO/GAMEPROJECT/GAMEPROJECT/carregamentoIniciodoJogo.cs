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
    public partial class carregamentoIniciodoJogo : Form
    {
        int valor;

        public carregamentoIniciodoJogo()
        {
            InitializeComponent();
        }

        private void tmrCarregar_Tick(object sender, EventArgs e)
        {
            valor = valor + 1;

            #region reticencias
            if (pgbCarregando.Value == 5)
            {
                pctPonto1.Visible = true;
            }
            if (pgbCarregando.Value == 10)
            {
                pctPonto2.Visible = true;
            }
            if (pgbCarregando.Value == 15)
            {
                pctPonto3.Visible = true;
            }
            if (pgbCarregando.Value == 20)
            {
                pctPonto1.Visible = false;
                pctPonto2.Visible = false;
                pctPonto3.Visible = false;
            }

            if (pgbCarregando.Value == 25)
            {
                pctPonto1.Visible = true;
            }
            if (pgbCarregando.Value == 30)
            {
                pctPonto2.Visible = true;
            }
            if (pgbCarregando.Value == 35)
            {
                pctPonto3.Visible = true;
            }
            if (pgbCarregando.Value == 40)
            {
                pctPonto1.Visible = false;
                pctPonto2.Visible = false;
                pctPonto3.Visible = false;
            }

            if (pgbCarregando.Value == 45)
            {
                pctPonto1.Visible = true;
            }
            if (pgbCarregando.Value == 50)
            {
                pctPonto2.Visible = true;
            }
            if (pgbCarregando.Value == 55)
            {
                pctPonto3.Visible = true;
            }
            if (pgbCarregando.Value == 60)
            {
                pctPonto1.Visible = false;
                pctPonto2.Visible = false;
                pctPonto3.Visible = false;
            }

            if (pgbCarregando.Value == 65)
            {
                pctPonto1.Visible = true;
            }
            if (pgbCarregando.Value == 70)
            {
                pctPonto2.Visible = true;
            }
            if (pgbCarregando.Value == 75)
            {
                pctPonto3.Visible = true;
            }
            if (pgbCarregando.Value == 80)
            {
                pctPonto1.Visible = false;
                pctPonto2.Visible = false;
                pctPonto3.Visible = false;
            }

            if (pgbCarregando.Value == 85)
            {
                pctPonto1.Visible = true;
            }
            if (pgbCarregando.Value == 90)
            {
                pctPonto2.Visible = true;
            }
            if (pgbCarregando.Value == 95)
            {
                pctPonto3.Visible = true;
            }
            if (pgbCarregando.Value == 100)
            {
                pctPonto1.Visible = false;
                pctPonto2.Visible = false;
                pctPonto3.Visible = false;
            }
#endregion

            if (pgbCarregando.Value != 100)
            {
                pgbCarregando.Value = valor;

                if (valor == 100)
                {
                    tmrCarregar.Stop();

                    this.Visible = false;
                    Jogo jogo = new Jogo();
                    jogo.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
