namespace DrawApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxRed = new System.Windows.Forms.PictureBox();
            this.picBoxYellow = new System.Windows.Forms.PictureBox();
            this.picBoxGreen = new System.Windows.Forms.PictureBox();
            this.picBoxBlue = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 473);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picBoxBlue);
            this.panel2.Controls.Add(this.picBoxGreen);
            this.panel2.Controls.Add(this.picBoxYellow);
            this.panel2.Controls.Add(this.picBoxRed);
            this.panel2.Location = new System.Drawing.Point(655, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 32);
            this.panel2.TabIndex = 0;
            // 
            // picBoxRed
            // 
            this.picBoxRed.BackColor = System.Drawing.Color.Red;
            this.picBoxRed.Location = new System.Drawing.Point(3, 3);
            this.picBoxRed.Name = "picBoxRed";
            this.picBoxRed.Size = new System.Drawing.Size(27, 26);
            this.picBoxRed.TabIndex = 0;
            this.picBoxRed.TabStop = false;
            this.picBoxRed.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBoxYellow
            // 
            this.picBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.picBoxYellow.Location = new System.Drawing.Point(36, 3);
            this.picBoxYellow.Name = "picBoxYellow";
            this.picBoxYellow.Size = new System.Drawing.Size(27, 26);
            this.picBoxYellow.TabIndex = 1;
            this.picBoxYellow.TabStop = false;
            this.picBoxYellow.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBoxGreen
            // 
            this.picBoxGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picBoxGreen.Location = new System.Drawing.Point(69, 3);
            this.picBoxGreen.Name = "picBoxGreen";
            this.picBoxGreen.Size = new System.Drawing.Size(27, 26);
            this.picBoxGreen.TabIndex = 1;
            this.picBoxGreen.TabStop = false;
            this.picBoxGreen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBoxBlue
            // 
            this.picBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.picBoxBlue.Location = new System.Drawing.Point(102, 3);
            this.picBoxBlue.Name = "picBoxBlue";
            this.picBoxBlue.Size = new System.Drawing.Size(27, 26);
            this.picBoxBlue.TabIndex = 2;
            this.picBoxBlue.TabStop = false;
            this.picBoxBlue.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxBlue;
        private System.Windows.Forms.PictureBox picBoxGreen;
        private System.Windows.Forms.PictureBox picBoxYellow;
        private System.Windows.Forms.PictureBox picBoxRed;
    }
}

