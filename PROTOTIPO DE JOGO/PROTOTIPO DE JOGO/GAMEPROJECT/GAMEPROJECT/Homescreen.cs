using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace GAMEPROJECT
{
    public partial class Homescreen : Form
    {
        public Homescreen()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Preferencias pref = new Preferencias();
            pref.ShowDialog();
            this.SuspendLayout();
            this.Close();
        }

        private void btnComoJogar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            HowTo howto = new HowTo();
            howto.ShowDialog();

            this.Close();
        }

        private void btnCredts_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Credts credts = new Credts();
            credts.ShowDialog();

            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp, resp1;
            resp = MessageBox.Show("Affz, serião que você vai sair ?", "VACILAO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resp == DialogResult.Yes)
            {
                resp1 = MessageBox.Show("Seu lixo");

                if (resp1 == DialogResult.OK)
                {
                    labelAbstrata.LabelNome = null;
                    labelAbstrata.LabelSecsu = null;
                    Application.Exit();
                }
            }
        }

        private void Homescreen_Load(object sender, EventArgs e)
        {
            SoundPlayer backmusic2 = new SoundPlayer("Paul_Gilbert_-_Technical_Difficulties2Loop.wav");
            backmusic2.PlayLooping();
        }

    }
}
