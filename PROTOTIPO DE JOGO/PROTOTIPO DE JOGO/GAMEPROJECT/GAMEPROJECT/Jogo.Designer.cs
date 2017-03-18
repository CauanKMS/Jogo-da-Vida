namespace GAMEPROJECT
{
    partial class Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.btnCasa = new System.Windows.Forms.Button();
            this.btnDolly = new System.Windows.Forms.Button();
            this.btnPrefs = new System.Windows.Forms.Button();
            this.btnMercado = new System.Windows.Forms.Button();
            this.btnEscola = new System.Windows.Forms.Button();
            this.btnMonxtro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCasa
            // 
            this.btnCasa.BackColor = System.Drawing.Color.Chocolate;
            this.btnCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCasa.Location = new System.Drawing.Point(12, 229);
            this.btnCasa.Name = "btnCasa";
            this.btnCasa.Size = new System.Drawing.Size(161, 80);
            this.btnCasa.TabIndex = 0;
            this.btnCasa.Text = "Casa";
            this.btnCasa.UseVisualStyleBackColor = false;
            this.btnCasa.Click += new System.EventHandler(this.btnCasa_Click);
            // 
            // btnDolly
            // 
            this.btnDolly.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDolly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDolly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDolly.Location = new System.Drawing.Point(592, 267);
            this.btnDolly.Name = "btnDolly";
            this.btnDolly.Size = new System.Drawing.Size(161, 80);
            this.btnDolly.TabIndex = 2;
            this.btnDolly.Text = "Dolly";
            this.btnDolly.UseVisualStyleBackColor = false;
            // 
            // btnPrefs
            // 
            this.btnPrefs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrefs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrefs.Location = new System.Drawing.Point(1124, 229);
            this.btnPrefs.Name = "btnPrefs";
            this.btnPrefs.Size = new System.Drawing.Size(161, 80);
            this.btnPrefs.TabIndex = 3;
            this.btnPrefs.Text = "Prefeitura";
            this.btnPrefs.UseVisualStyleBackColor = false;
            // 
            // btnMercado
            // 
            this.btnMercado.BackColor = System.Drawing.Color.Crimson;
            this.btnMercado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMercado.Location = new System.Drawing.Point(305, 485);
            this.btnMercado.Name = "btnMercado";
            this.btnMercado.Size = new System.Drawing.Size(161, 80);
            this.btnMercado.TabIndex = 4;
            this.btnMercado.Text = "Mercado Ipiratinigga";
            this.btnMercado.UseVisualStyleBackColor = false;
            this.btnMercado.Click += new System.EventHandler(this.btnMercado_Click);
            // 
            // btnEscola
            // 
            this.btnEscola.BackColor = System.Drawing.Color.Gold;
            this.btnEscola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscola.Location = new System.Drawing.Point(913, 413);
            this.btnEscola.Name = "btnEscola";
            this.btnEscola.Size = new System.Drawing.Size(161, 80);
            this.btnEscola.TabIndex = 5;
            this.btnEscola.Text = "Escola Garibaldo";
            this.btnEscola.UseVisualStyleBackColor = false;
            this.btnEscola.Click += new System.EventHandler(this.btnEscola_Click);
            // 
            // btnMonxtro
            // 
            this.btnMonxtro.BackColor = System.Drawing.Color.Black;
            this.btnMonxtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonxtro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMonxtro.Location = new System.Drawing.Point(524, 616);
            this.btnMonxtro.Name = "btnMonxtro";
            this.btnMonxtro.Size = new System.Drawing.Size(161, 80);
            this.btnMonxtro.TabIndex = 6;
            this.btnMonxtro.Text = "Academia Monxtro";
            this.btnMonxtro.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(12, 658);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 80);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::GAMEPROJECT.Properties.Resources.PRIMEIRA_TELA;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnMonxtro);
            this.Controls.Add(this.btnEscola);
            this.Controls.Add(this.btnMercado);
            this.Controls.Add(this.btnPrefs);
            this.Controls.Add(this.btnDolly);
            this.Controls.Add(this.btnCasa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCasa;
        private System.Windows.Forms.Button btnDolly;
        private System.Windows.Forms.Button btnPrefs;
        private System.Windows.Forms.Button btnMercado;
        private System.Windows.Forms.Button btnEscola;
        private System.Windows.Forms.Button btnMonxtro;
        private System.Windows.Forms.Button btnVoltar;
    }
}