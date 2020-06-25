namespace VisualCar_
{
    partial class Game
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.margineSinistro = new System.Windows.Forms.PictureBox();
            this.margineDestro = new System.Windows.Forms.PictureBox();
            this.striscia1 = new System.Windows.Forms.PictureBox();
            this.striscia2 = new System.Windows.Forms.PictureBox();
            this.striscia3 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ostacolo1 = new System.Windows.Forms.PictureBox();
            this.ostacolo3 = new System.Windows.Forms.PictureBox();
            this.ostacolo5 = new System.Windows.Forms.PictureBox();
            this.ostacolo2 = new System.Windows.Forms.PictureBox();
            this.ostacolo4 = new System.Windows.Forms.PictureBox();
            this.macchina = new System.Windows.Forms.PictureBox();
            this.fineGioco = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.margineSinistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margineDestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.striscia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.striscia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.striscia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            this.SuspendLayout();
            // 
            // margineSinistro
            // 
            this.margineSinistro.BackColor = System.Drawing.Color.GreenYellow;
            this.margineSinistro.Location = new System.Drawing.Point(0, -1);
            this.margineSinistro.Name = "margineSinistro";
            this.margineSinistro.Size = new System.Drawing.Size(108, 754);
            this.margineSinistro.TabIndex = 0;
            this.margineSinistro.TabStop = false;
            // 
            // margineDestro
            // 
            this.margineDestro.BackColor = System.Drawing.Color.GreenYellow;
            this.margineDestro.Location = new System.Drawing.Point(674, -1);
            this.margineDestro.Name = "margineDestro";
            this.margineDestro.Size = new System.Drawing.Size(108, 754);
            this.margineDestro.TabIndex = 1;
            this.margineDestro.TabStop = false;
            // 
            // striscia1
            // 
            this.striscia1.BackColor = System.Drawing.Color.White;
            this.striscia1.Location = new System.Drawing.Point(382, -20);
            this.striscia1.Name = "striscia1";
            this.striscia1.Size = new System.Drawing.Size(26, 244);
            this.striscia1.TabIndex = 2;
            this.striscia1.TabStop = false;
            // 
            // striscia2
            // 
            this.striscia2.BackColor = System.Drawing.Color.White;
            this.striscia2.Location = new System.Drawing.Point(382, 257);
            this.striscia2.Name = "striscia2";
            this.striscia2.Size = new System.Drawing.Size(26, 225);
            this.striscia2.TabIndex = 3;
            this.striscia2.TabStop = false;
            // 
            // striscia3
            // 
            this.striscia3.BackColor = System.Drawing.Color.White;
            this.striscia3.Location = new System.Drawing.Point(382, 516);
            this.striscia3.Name = "striscia3";
            this.striscia3.Size = new System.Drawing.Size(26, 280);
            this.striscia3.TabIndex = 4;
            this.striscia3.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvento);
            // 
            // ostacolo1
            // 
            this.ostacolo1.BackColor = System.Drawing.Color.Transparent;
            this.ostacolo1.Image = ((System.Drawing.Image)(resources.GetObject("ostacolo1.Image")));
            this.ostacolo1.Location = new System.Drawing.Point(133, 121);
            this.ostacolo1.Name = "ostacolo1";
            this.ostacolo1.Size = new System.Drawing.Size(78, 72);
            this.ostacolo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ostacolo1.TabIndex = 6;
            this.ostacolo1.TabStop = false;
            // 
            // ostacolo3
            // 
            this.ostacolo3.BackColor = System.Drawing.Color.Transparent;
            this.ostacolo3.Image = ((System.Drawing.Image)(resources.GetObject("ostacolo3.Image")));
            this.ostacolo3.Location = new System.Drawing.Point(430, 491);
            this.ostacolo3.Name = "ostacolo3";
            this.ostacolo3.Size = new System.Drawing.Size(78, 72);
            this.ostacolo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ostacolo3.TabIndex = 7;
            this.ostacolo3.TabStop = false;
            // 
            // ostacolo5
            // 
            this.ostacolo5.BackColor = System.Drawing.Color.Transparent;
            this.ostacolo5.Image = ((System.Drawing.Image)(resources.GetObject("ostacolo5.Image")));
            this.ostacolo5.Location = new System.Drawing.Point(439, 121);
            this.ostacolo5.Name = "ostacolo5";
            this.ostacolo5.Size = new System.Drawing.Size(78, 72);
            this.ostacolo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ostacolo5.TabIndex = 8;
            this.ostacolo5.TabStop = false;
            // 
            // ostacolo2
            // 
            this.ostacolo2.BackColor = System.Drawing.Color.Transparent;
            this.ostacolo2.Image = ((System.Drawing.Image)(resources.GetObject("ostacolo2.Image")));
            this.ostacolo2.Location = new System.Drawing.Point(270, 424);
            this.ostacolo2.Name = "ostacolo2";
            this.ostacolo2.Size = new System.Drawing.Size(78, 72);
            this.ostacolo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ostacolo2.TabIndex = 9;
            this.ostacolo2.TabStop = false;
            // 
            // ostacolo4
            // 
            this.ostacolo4.BackColor = System.Drawing.Color.Transparent;
            this.ostacolo4.Image = ((System.Drawing.Image)(resources.GetObject("ostacolo4.Image")));
            this.ostacolo4.Location = new System.Drawing.Point(547, 313);
            this.ostacolo4.Name = "ostacolo4";
            this.ostacolo4.Size = new System.Drawing.Size(78, 72);
            this.ostacolo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ostacolo4.TabIndex = 10;
            this.ostacolo4.TabStop = false;
            // 
            // macchina
            // 
            this.macchina.BackColor = System.Drawing.Color.Transparent;
            this.macchina.Image = ((System.Drawing.Image)(resources.GetObject("macchina.Image")));
            this.macchina.Location = new System.Drawing.Point(172, 491);
            this.macchina.Name = "macchina";
            this.macchina.Size = new System.Drawing.Size(39, 94);
            this.macchina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.macchina.TabIndex = 11;
            this.macchina.TabStop = false;
            // 
            // fineGioco
            // 
            this.fineGioco.AutoSize = true;
            this.fineGioco.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineGioco.ForeColor = System.Drawing.Color.Transparent;
            this.fineGioco.Location = new System.Drawing.Point(310, 286);
            this.fineGioco.Name = "fineGioco";
            this.fineGioco.Size = new System.Drawing.Size(172, 38);
            this.fineGioco.TabIndex = 12;
            this.fineGioco.Text = "Game Over!";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(172, 343);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(39, 42);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 13;
            this.coin1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(369, 230);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(39, 42);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 14;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(439, 371);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(39, 42);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 15;
            this.coin3.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.score.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(114, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(86, 19);
            this.score.TabIndex = 16;
            this.score.Text = "punteggio: ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.score);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.fineGioco);
            this.Controls.Add(this.macchina);
            this.Controls.Add(this.ostacolo4);
            this.Controls.Add(this.ostacolo2);
            this.Controls.Add(this.ostacolo5);
            this.Controls.Add(this.ostacolo3);
            this.Controls.Add(this.ostacolo1);
            this.Controls.Add(this.striscia3);
            this.Controls.Add(this.striscia2);
            this.Controls.Add(this.striscia1);
            this.Controls.Add(this.margineDestro);
            this.Controls.Add(this.margineSinistro);
            this.Name = "Game";
            this.Text = "VisualCar!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tastiPremuti);
            ((System.ComponentModel.ISupportInitialize)(this.margineSinistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margineDestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.striscia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.striscia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.striscia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox margineSinistro;
        private System.Windows.Forms.PictureBox margineDestro;
        private System.Windows.Forms.PictureBox striscia1;
        private System.Windows.Forms.PictureBox striscia2;
        private System.Windows.Forms.PictureBox striscia3;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ostacolo1;
        private System.Windows.Forms.PictureBox ostacolo3;
        private System.Windows.Forms.PictureBox ostacolo5;
        private System.Windows.Forms.PictureBox ostacolo2;
        private System.Windows.Forms.PictureBox ostacolo4;
        private System.Windows.Forms.PictureBox macchina;
        private System.Windows.Forms.Label fineGioco;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.Label score;
    }
}

