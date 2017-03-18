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
    public partial class Preferencias : Form
    {
        string secsu;

        public Preferencias()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Homescreen home = new Homescreen();
            home.ShowDialog();
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || rdbtnMasc.Checked == false && rdbtnFem.Checked == false)
            {
                if(txtNome.Text == string.Empty)
                {
                    txtNome.BackColor = Color.Red;
                }
                if(rdbtnMasc.Checked == false && rdbtnFem.Checked == false)
                {
                    rdbtnMasc.BackColor = Color.Red;
                    rdbtnFem.BackColor = Color.Red;
                }
            }
            else
            {
                if (txtNome.TextLength > 12)
                {
                    MessageBox.Show("SEU NOME É FEIO");
                }
                else
                {
                    labelAbstrata.LabelNome = txtNome.Text;
                    labelAbstrata.LabelSecsu = secsu;

                    this.Visible = false;
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }
            }
        }

        private void rdbtnMasc_CheckedChanged(object sender, EventArgs e)
        {
            secsu = rdbtnMasc.Text;
            rdbtnMasc.BackColor = Color.White;
            rdbtnFem.BackColor = Color.White;
        }

        private void rdbtnFem_CheckedChanged(object sender, EventArgs e)
        {
            secsu = rdbtnFem.Text;
            rdbtnFem.BackColor = Color.White;
            rdbtnMasc.BackColor = Color.White;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.Empty;
        }
    }
}
