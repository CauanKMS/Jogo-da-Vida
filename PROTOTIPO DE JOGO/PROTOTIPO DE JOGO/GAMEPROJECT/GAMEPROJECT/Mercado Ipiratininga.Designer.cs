namespace GAMEPROJECT
{
    partial class Mercado_Ipiratininga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mercado_Ipiratininga));
            this.btnYakute = new System.Windows.Forms.Button();
            this.btnGanso = new System.Windows.Forms.Button();
            this.btnPao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYakute
            // 
            this.btnYakute.BackColor = System.Drawing.Color.PeachPuff;
            this.btnYakute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYakute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYakute.Location = new System.Drawing.Point(245, 484);
            this.btnYakute.Name = "btnYakute";
            this.btnYakute.Size = new System.Drawing.Size(161, 80);
            this.btnYakute.TabIndex = 1;
            this.btnYakute.Text = "Yakute - $R 1";
            this.btnYakute.UseVisualStyleBackColor = false;
            this.btnYakute.Click += new System.EventHandler(this.btnYakute_Click);
            // 
            // btnGanso
            // 
            this.btnGanso.BackColor = System.Drawing.Color.Peru;
            this.btnGanso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGanso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGanso.Location = new System.Drawing.Point(663, 484);
            this.btnGanso.Name = "btnGanso";
            this.btnGanso.Size = new System.Drawing.Size(161, 80);
            this.btnGanso.TabIndex = 2;
            this.btnGanso.Text = "Ganso - $R 3";
            this.btnGanso.UseVisualStyleBackColor = false;
            this.btnGanso.Click += new System.EventHandler(this.btnGanso_Click);
            // 
            // btnPao
            // 
            this.btnPao.BackColor = System.Drawing.Color.Tan;
            this.btnPao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPao.Location = new System.Drawing.Point(1064, 484);
            this.btnPao.Name = "btnPao";
            this.btnPao.Size = new System.Drawing.Size(161, 80);
            this.btnPao.TabIndex = 3;
            this.btnPao.Text = "Pão - $R 2";
            this.btnPao.UseVisualStyleBackColor = false;
            this.btnPao.Click += new System.EventHandler(this.btnPao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Money:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(747, 654);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(70, 26);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "label2";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(12, 676);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 80);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GAMEPROJECT.Properties.Resources.Merca;
            this.pictureBox2.Location = new System.Drawing.Point(360, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(727, 89);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAMEPROJECT.Properties.Resources.Ipiratenigga;
            this.pictureBox1.Location = new System.Drawing.Point(419, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mercado_Ipiratininga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1366, 750);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPao);
            this.Controls.Add(this.btnGanso);
            this.Controls.Add(this.btnYakute);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Mercado_Ipiratininga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercadinho Ipiratininga";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mercado_Ipiratininga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYakute;
        private System.Windows.Forms.Button btnGanso;
        private System.Windows.Forms.Button btnPao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}