namespace GAMEPROJECT
{
    partial class carregamentoIniciodoJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carregamentoIniciodoJogo));
            this.pgbCarregando = new System.Windows.Forms.ProgressBar();
            this.tmrCarregar = new System.Windows.Forms.Timer(this.components);
            this.pctPonto3 = new System.Windows.Forms.PictureBox();
            this.pctPonto2 = new System.Windows.Forms.PictureBox();
            this.pctPonto1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbCarregando
            // 
            this.pgbCarregando.Location = new System.Drawing.Point(304, 638);
            this.pgbCarregando.Name = "pgbCarregando";
            this.pgbCarregando.Size = new System.Drawing.Size(767, 23);
            this.pgbCarregando.TabIndex = 0;
            this.pgbCarregando.Visible = false;
            // 
            // tmrCarregar
            // 
            this.tmrCarregar.Enabled = true;
            this.tmrCarregar.Interval = 50;
            this.tmrCarregar.Tick += new System.EventHandler(this.tmrCarregar_Tick);
            // 
            // pctPonto3
            // 
            this.pctPonto3.Image = global::GAMEPROJECT.Properties.Resources.ponto3;
            this.pctPonto3.Location = new System.Drawing.Point(966, 346);
            this.pctPonto3.Name = "pctPonto3";
            this.pctPonto3.Size = new System.Drawing.Size(62, 50);
            this.pctPonto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctPonto3.TabIndex = 8;
            this.pctPonto3.TabStop = false;
            this.pctPonto3.Visible = false;
            // 
            // pctPonto2
            // 
            this.pctPonto2.Image = global::GAMEPROJECT.Properties.Resources.ponto2;
            this.pctPonto2.Location = new System.Drawing.Point(898, 346);
            this.pctPonto2.Name = "pctPonto2";
            this.pctPonto2.Size = new System.Drawing.Size(62, 50);
            this.pctPonto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctPonto2.TabIndex = 7;
            this.pctPonto2.TabStop = false;
            this.pctPonto2.Visible = false;
            // 
            // pctPonto1
            // 
            this.pctPonto1.Image = global::GAMEPROJECT.Properties.Resources.ponto1;
            this.pctPonto1.Location = new System.Drawing.Point(830, 346);
            this.pctPonto1.Name = "pctPonto1";
            this.pctPonto1.Size = new System.Drawing.Size(62, 50);
            this.pctPonto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctPonto1.TabIndex = 6;
            this.pctPonto1.TabStop = false;
            this.pctPonto1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GAMEPROJECT.Properties.Resources.CARREGANDO2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 788);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // carregamentoIniciodoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 788);
            this.Controls.Add(this.pctPonto3);
            this.Controls.Add(this.pctPonto2);
            this.Controls.Add(this.pctPonto1);
            this.Controls.Add(this.pgbCarregando);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "carregamentoIniciodoJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carregamentoIniciodoJogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPonto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbCarregando;
        private System.Windows.Forms.Timer tmrCarregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctPonto1;
        private System.Windows.Forms.PictureBox pctPonto2;
        private System.Windows.Forms.PictureBox pctPonto3;

    }
}