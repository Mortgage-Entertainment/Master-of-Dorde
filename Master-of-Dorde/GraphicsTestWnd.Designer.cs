namespace Master_of_Dorde
{
    partial class GraphicsTestWnd
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
            this.BtnImg1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImg1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImg1
            // 
            this.BtnImg1.BackColor = System.Drawing.SystemColors.Window;
            this.BtnImg1.BackgroundImage = global::Master_of_Dorde.Engine.Resources.Btn_Grn_Passive;
            this.BtnImg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImg1.Location = new System.Drawing.Point(12, 12);
            this.BtnImg1.Name = "BtnImg1";
            this.BtnImg1.Size = new System.Drawing.Size(328, 76);
            this.BtnImg1.TabIndex = 9;
            this.BtnImg1.TabStop = false;
            this.BtnImg1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox7_DragEnter);
            this.BtnImg1.MouseEnter += new System.EventHandler(this.pictureBox7_MouseEnter);
            this.BtnImg1.MouseLeave += new System.EventHandler(this.BtnImg1_MouseLeave);
            // 
            // GraphicsTestWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 494);
            this.ControlBox = false;
            this.Controls.Add(this.BtnImg1);
            this.Name = "GraphicsTestWnd";
            this.Text = "GraphicsTestWnd";
            this.Load += new System.EventHandler(this.GraphicsTestWnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnImg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.PictureBox BtnImg1;
    }
}