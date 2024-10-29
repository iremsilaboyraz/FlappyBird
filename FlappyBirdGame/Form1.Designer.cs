namespace FlappyBirdGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.score = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.birdy = new System.Windows.Forms.PictureBox();
            this.zaman = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdy)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(96, 28);
            this.score.TabIndex = 4;
            this.score.Text = "skor:0";
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdGame.Properties.Resources.g;
            this.ground.Location = new System.Drawing.Point(2, 419);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(809, 201);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 7;
            this.ground.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pipe2
            // 
            this.pipe2.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipe2.Location = new System.Drawing.Point(552, 260);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(79, 188);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 5;
            this.pipe2.TabStop = false;
            // 
            // pipe1
            // 
            this.pipe1.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipe1.Location = new System.Drawing.Point(337, -34);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(81, 178);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 2;
            this.pipe1.TabStop = false;
            // 
            // birdy
            // 
            this.birdy.Image = global::FlappyBirdGame.Properties.Resources.pngwing_com;
            this.birdy.Location = new System.Drawing.Point(176, 232);
            this.birdy.Name = "birdy";
            this.birdy.Size = new System.Drawing.Size(59, 54);
            this.birdy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdy.TabIndex = 0;
            this.birdy.TabStop = false;
            // 
            // zaman
            // 
            this.zaman.Enabled = true;
            this.zaman.Interval = 20;
            this.zaman.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.birdy);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.pipe1);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox birdy;
        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer zaman;
    }
}

