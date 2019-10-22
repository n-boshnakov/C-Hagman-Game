namespace HangmanProject
{
    partial class frmTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.lblGrade = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSplatter = new System.Windows.Forms.PictureBox();
            this.lblGradeChange = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplatter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblGrade.Font = new System.Drawing.Font("Edwardian Script ITC", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrade.Location = new System.Drawing.Point(47, 50);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(66, 51);
            this.lblGrade.TabIndex = 13;
            this.lblGrade.Text = "7th";
            this.lblGrade.Click += new System.EventHandler(this.lblGrade_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::HangmanProject.Properties.Resources.stickman;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(49, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pbSplatter
            // 
            this.pbSplatter.BackColor = System.Drawing.Color.Transparent;
            this.pbSplatter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSplatter.Image = global::HangmanProject.Properties.Resources.splatter;
            this.pbSplatter.InitialImage = null;
            this.pbSplatter.Location = new System.Drawing.Point(417, 20);
            this.pbSplatter.Name = "pbSplatter";
            this.pbSplatter.Size = new System.Drawing.Size(203, 193);
            this.pbSplatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplatter.TabIndex = 11;
            this.pbSplatter.TabStop = false;
            this.pbSplatter.Click += new System.EventHandler(this.pbSplatter_Click);
            // 
            // lblGradeChange
            // 
            this.lblGradeChange.AutoSize = true;
            this.lblGradeChange.BackColor = System.Drawing.Color.Transparent;
            this.lblGradeChange.Font = new System.Drawing.Font("Edwardian Script ITC", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeChange.Location = new System.Drawing.Point(12, 9);
            this.lblGradeChange.Name = "lblGradeChange";
            this.lblGradeChange.Size = new System.Drawing.Size(112, 51);
            this.lblGradeChange.TabIndex = 10;
            this.lblGradeChange.Text = "Grade";
            this.lblGradeChange.Click += new System.EventHandler(this.lblGradeChange_Click);
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.BackColor = System.Drawing.Color.Transparent;
            this.lblBegin.Font = new System.Drawing.Font("Edwardian Script ITC", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegin.Location = new System.Drawing.Point(331, 216);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(205, 57);
            this.lblBegin.TabIndex = 9;
            this.lblBegin.Text = "New Game";
            this.lblBegin.Click += new System.EventHandler(this.lblBegin_Click_1);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Edwardian Script ITC", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(70, 216);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(102, 57);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Edwardian Script ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(181, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 71);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Hangman";
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangmanProject.Properties.Resources.BGZoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 472);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbSplatter);
            this.Controls.Add(this.lblGradeChange);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplatter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbSplatter;
        private System.Windows.Forms.Label lblGradeChange;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGrade;
    }
}

