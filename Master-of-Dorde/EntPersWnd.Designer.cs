namespace Master_of_Dorde
{
    partial class EntPersWnd
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BerserkClassBtn = new System.Windows.Forms.PictureBox();
            this.WarriorClassBtn = new System.Windows.Forms.PictureBox();
            this.MageClassBtn = new System.Windows.Forms.PictureBox();
            this.StatImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BerserkClassBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarriorClassBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MageClassBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 54);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BerserkClassBtn
            // 
            this.BerserkClassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BerserkClassBtn.Location = new System.Drawing.Point(12, 124);
            this.BerserkClassBtn.Name = "BerserkClassBtn";
            this.BerserkClassBtn.Size = new System.Drawing.Size(50, 50);
            this.BerserkClassBtn.TabIndex = 3;
            this.BerserkClassBtn.TabStop = false;
            this.BerserkClassBtn.Click += new System.EventHandler(this.BerserkClassBtn_Click);
            this.BerserkClassBtn.MouseEnter += new System.EventHandler(this.BerserkClassBtn_MouseEnter);
            this.BerserkClassBtn.MouseLeave += new System.EventHandler(this.BerserkClassBtn_MouseLeave);
            // 
            // WarriorClassBtn
            // 
            this.WarriorClassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WarriorClassBtn.Location = new System.Drawing.Point(12, 68);
            this.WarriorClassBtn.Name = "WarriorClassBtn";
            this.WarriorClassBtn.Size = new System.Drawing.Size(50, 50);
            this.WarriorClassBtn.TabIndex = 2;
            this.WarriorClassBtn.TabStop = false;
            this.WarriorClassBtn.Click += new System.EventHandler(this.WarriorClassBtn_Click);
            this.WarriorClassBtn.MouseEnter += new System.EventHandler(this.WarriorClassBtn_MouseEnter);
            this.WarriorClassBtn.MouseLeave += new System.EventHandler(this.WarriorClassBtn_MouseLeave);
            // 
            // MageClassBtn
            // 
            this.MageClassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MageClassBtn.Location = new System.Drawing.Point(12, 12);
            this.MageClassBtn.Name = "MageClassBtn";
            this.MageClassBtn.Size = new System.Drawing.Size(50, 50);
            this.MageClassBtn.TabIndex = 1;
            this.MageClassBtn.TabStop = false;
            this.MageClassBtn.Click += new System.EventHandler(this.MageClassBtn_Click);
            this.MageClassBtn.MouseEnter += new System.EventHandler(this.MageClassBtn_MouseEnter);
            this.MageClassBtn.MouseLeave += new System.EventHandler(this.MageClassBtn_MouseLeave);
            // 
            // StatImage
            // 
            this.StatImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatImage.Location = new System.Drawing.Point(71, 12);
            this.StatImage.Name = "StatImage";
            this.StatImage.Size = new System.Drawing.Size(676, 420);
            this.StatImage.TabIndex = 0;
            this.StatImage.TabStop = false;
            // 
            // EntPersWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 444);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BerserkClassBtn);
            this.Controls.Add(this.WarriorClassBtn);
            this.Controls.Add(this.MageClassBtn);
            this.Controls.Add(this.StatImage);
            this.MaximizeBox = false;
            this.Name = "EntPersWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntPersWnd";
            this.Load += new System.EventHandler(this.EntPersWnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BerserkClassBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarriorClassBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MageClassBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StatImage;
        private System.Windows.Forms.PictureBox MageClassBtn;
        private System.Windows.Forms.PictureBox WarriorClassBtn;
        private System.Windows.Forms.PictureBox BerserkClassBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}