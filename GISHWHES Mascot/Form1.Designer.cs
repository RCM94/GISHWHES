namespace GISHWHES_Mascot
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
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LegBox = new System.Windows.Forms.PictureBox();
            this.HeadBox = new System.Windows.Forms.PictureBox();
            this.BodyBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomizeButton.Location = new System.Drawing.Point(242, 506);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
            this.RandomizeButton.TabIndex = 3;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomButton_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::GISHWHES_Mascot.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 135);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LegBox
            // 
            this.LegBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LegBox.Image = global::GISHWHES_Mascot.Properties.Resources.Bear_Legs2;
            this.LegBox.Location = new System.Drawing.Point(136, 374);
            this.LegBox.Name = "LegBox";
            this.LegBox.Size = new System.Drawing.Size(309, 118);
            this.LegBox.TabIndex = 2;
            this.LegBox.TabStop = false;
            this.LegBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HeadBox
            // 
            this.HeadBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HeadBox.Image = global::GISHWHES_Mascot.Properties.Resources.Dog_Head;
            this.HeadBox.Location = new System.Drawing.Point(352, 195);
            this.HeadBox.Name = "HeadBox";
            this.HeadBox.Size = new System.Drawing.Size(129, 121);
            this.HeadBox.TabIndex = 1;
            this.HeadBox.TabStop = false;
            // 
            // BodyBox
            // 
            this.BodyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BodyBox.Image = global::GISHWHES_Mascot.Properties.Resources.Goat_Body;
            this.BodyBox.Location = new System.Drawing.Point(119, 229);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(326, 182);
            this.BodyBox.TabIndex = 0;
            this.BodyBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.LegBox);
            this.Controls.Add(this.HeadBox);
            this.Controls.Add(this.BodyBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BodyBox;
        private System.Windows.Forms.PictureBox HeadBox;
        private System.Windows.Forms.PictureBox LegBox;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

