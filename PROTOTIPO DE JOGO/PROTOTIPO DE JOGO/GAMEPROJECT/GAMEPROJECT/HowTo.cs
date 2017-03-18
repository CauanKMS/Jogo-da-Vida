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
    public partial class HowTo : Form
    {
        public HowTo()
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
    }
}
