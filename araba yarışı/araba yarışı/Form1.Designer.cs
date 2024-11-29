namespace araba_yarışı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.araba = new System.Windows.Forms.PictureBox();
            this.altaraba1 = new System.Windows.Forms.PictureBox();
            this.ustaraba1 = new System.Windows.Forms.PictureBox();
            this.ortaraba = new System.Windows.Forms.PictureBox();
            this.ustaraba2 = new System.Windows.Forms.PictureBox();
            this.altaraba2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sskor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.araba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altaraba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustaraba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustaraba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altaraba2)).BeginInit();
            this.SuspendLayout();
            // 
            // araba
            // 
            this.araba.Image = ((System.Drawing.Image)(resources.GetObject("araba.Image")));
            this.araba.Location = new System.Drawing.Point(32, 234);
            this.araba.Name = "araba";
            this.araba.Size = new System.Drawing.Size(130, 80);
            this.araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba.TabIndex = 0;
            this.araba.TabStop = false;
            // 
            // altaraba1
            // 
            this.altaraba1.Image = ((System.Drawing.Image)(resources.GetObject("altaraba1.Image")));
            this.altaraba1.Location = new System.Drawing.Point(264, 416);
            this.altaraba1.Name = "altaraba1";
            this.altaraba1.Size = new System.Drawing.Size(130, 80);
            this.altaraba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altaraba1.TabIndex = 1;
            this.altaraba1.TabStop = false;
            // 
            // ustaraba1
            // 
            this.ustaraba1.Image = ((System.Drawing.Image)(resources.GetObject("ustaraba1.Image")));
            this.ustaraba1.Location = new System.Drawing.Point(264, 55);
            this.ustaraba1.Name = "ustaraba1";
            this.ustaraba1.Size = new System.Drawing.Size(130, 80);
            this.ustaraba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustaraba1.TabIndex = 2;
            this.ustaraba1.TabStop = false;
            // 
            // ortaraba
            // 
            this.ortaraba.Image = ((System.Drawing.Image)(resources.GetObject("ortaraba.Image")));
            this.ortaraba.Location = new System.Drawing.Point(575, 234);
            this.ortaraba.Name = "ortaraba";
            this.ortaraba.Size = new System.Drawing.Size(130, 80);
            this.ortaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ortaraba.TabIndex = 3;
            this.ortaraba.TabStop = false;
            // 
            // ustaraba2
            // 
            this.ustaraba2.Image = ((System.Drawing.Image)(resources.GetObject("ustaraba2.Image")));
            this.ustaraba2.Location = new System.Drawing.Point(911, 55);
            this.ustaraba2.Name = "ustaraba2";
            this.ustaraba2.Size = new System.Drawing.Size(130, 80);
            this.ustaraba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustaraba2.TabIndex = 4;
            this.ustaraba2.TabStop = false;
            // 
            // altaraba2
            // 
            this.altaraba2.Image = ((System.Drawing.Image)(resources.GetObject("altaraba2.Image")));
            this.altaraba2.Location = new System.Drawing.Point(911, 416);
            this.altaraba2.Name = "altaraba2";
            this.altaraba2.Size = new System.Drawing.Size(130, 80);
            this.altaraba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altaraba2.TabIndex = 5;
            this.altaraba2.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.oyuntimer);
            // 
            // sskor
            // 
            this.sskor.AutoSize = true;
            this.sskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sskor.Location = new System.Drawing.Point(45, 529);
            this.sskor.Name = "sskor";
            this.sskor.Size = new System.Drawing.Size(89, 32);
            this.sskor.TabIndex = 6;
            this.sskor.Text = "skor :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 570);
            this.Controls.Add(this.sskor);
            this.Controls.Add(this.altaraba2);
            this.Controls.Add(this.ustaraba2);
            this.Controls.Add(this.ortaraba);
            this.Controls.Add(this.ustaraba1);
            this.Controls.Add(this.altaraba1);
            this.Controls.Add(this.araba);
            this.Name = "Form1";
            this.Text = "Araba Yarışı";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.assa);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.yukari);
            ((System.ComponentModel.ISupportInitialize)(this.araba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altaraba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustaraba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustaraba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altaraba2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox araba;
        private System.Windows.Forms.PictureBox altaraba1;
        private System.Windows.Forms.PictureBox ustaraba1;
        private System.Windows.Forms.PictureBox ortaraba;
        private System.Windows.Forms.PictureBox ustaraba2;
        private System.Windows.Forms.PictureBox altaraba2;
 //       private System.Windows.Forms.Label skor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label sskor;
    }
}

