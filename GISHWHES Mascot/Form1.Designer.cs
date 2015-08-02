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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LegBox = new System.Windows.Forms.PictureBox();
            this.HeadBox = new System.Windows.Forms.PictureBox();
            this.BodyBox = new System.Windows.Forms.PictureBox();
            this.RandomizeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LegBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LegBox
            // 
            this.LegBox.Image = ((System.Drawing.Image)(resources.GetObject("LegBox.Image")));
            this.LegBox.Location = new System.Drawing.Point(232, 306);
            this.LegBox.Name = "LegBox";
            this.LegBox.Size = new System.Drawing.Size(457, 147);
            this.LegBox.TabIndex = 2;
            this.LegBox.TabStop = false;
            this.LegBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HeadBox
            // 
            this.HeadBox.Image = global::GISHWHES_Mascot.Properties.Resources.Dog_Head;
            this.HeadBox.Location = new System.Drawing.Point(455, 122);
            this.HeadBox.Name = "HeadBox";
            this.HeadBox.Size = new System.Drawing.Size(166, 126);
            this.HeadBox.TabIndex = 1;
            this.HeadBox.TabStop = false;
            // 
            // BodyBox
            // 
            this.BodyBox.Image = global::GISHWHES_Mascot.Properties.Resources.Bear_Body;
            this.BodyBox.Location = new System.Drawing.Point(222, 161);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(399, 182);
            this.BodyBox.TabIndex = 0;
            this.BodyBox.TabStop = false;
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Location = new System.Drawing.Point(427, 608);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
            this.RandomizeButton.TabIndex = 3;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 643);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.LegBox);
            this.Controls.Add(this.HeadBox);
            this.Controls.Add(this.BodyBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

