namespace Assignment_1
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
            this.descriptionBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.cardPicture5 = new System.Windows.Forms.PictureBox();
            this.cardPicture4 = new System.Windows.Forms.PictureBox();
            this.cardPicture3 = new System.Windows.Forms.PictureBox();
            this.cardPicture2 = new System.Windows.Forms.PictureBox();
            this.threeDiamondsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeDiamondsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(169, 235);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(278, 43);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click a card to view its name!";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(253, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cardPicture5
            // 
            this.cardPicture5.Image = global::Assignment_1.Properties.Resources.Jack_Hearts;
            this.cardPicture5.Location = new System.Drawing.Point(447, 127);
            this.cardPicture5.Name = "cardPicture5";
            this.cardPicture5.Size = new System.Drawing.Size(50, 70);
            this.cardPicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cardPicture5.TabIndex = 5;
            this.cardPicture5.TabStop = false;
            this.cardPicture5.Click += new System.EventHandler(this.cardPicture5_Click);
            // 
            // cardPicture4
            // 
            this.cardPicture4.Image = global::Assignment_1.Properties.Resources.Ace_Spades;
            this.cardPicture4.Location = new System.Drawing.Point(354, 127);
            this.cardPicture4.Name = "cardPicture4";
            this.cardPicture4.Size = new System.Drawing.Size(50, 70);
            this.cardPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cardPicture4.TabIndex = 4;
            this.cardPicture4.TabStop = false;
            this.cardPicture4.Click += new System.EventHandler(this.cardPicture4_Click);
            // 
            // cardPicture3
            // 
            this.cardPicture3.Image = global::Assignment_1.Properties.Resources._8_Hearts;
            this.cardPicture3.Location = new System.Drawing.Point(267, 127);
            this.cardPicture3.Name = "cardPicture3";
            this.cardPicture3.Size = new System.Drawing.Size(50, 70);
            this.cardPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cardPicture3.TabIndex = 3;
            this.cardPicture3.TabStop = false;
            this.cardPicture3.Click += new System.EventHandler(this.cardPicture3_Click);
            // 
            // cardPicture2
            // 
            this.cardPicture2.Image = global::Assignment_1.Properties.Resources.King_Clubs;
            this.cardPicture2.Location = new System.Drawing.Point(186, 127);
            this.cardPicture2.Name = "cardPicture2";
            this.cardPicture2.Size = new System.Drawing.Size(50, 70);
            this.cardPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cardPicture2.TabIndex = 2;
            this.cardPicture2.TabStop = false;
            this.cardPicture2.Click += new System.EventHandler(this.cardPicture2_Click);
            // 
            // threeDiamondsPictureBox
            // 
            this.threeDiamondsPictureBox.Image = global::Assignment_1.Properties.Resources._3_Diamonds;
            this.threeDiamondsPictureBox.Location = new System.Drawing.Point(104, 127);
            this.threeDiamondsPictureBox.Name = "threeDiamondsPictureBox";
            this.threeDiamondsPictureBox.Size = new System.Drawing.Size(50, 70);
            this.threeDiamondsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.threeDiamondsPictureBox.TabIndex = 1;
            this.threeDiamondsPictureBox.TabStop = false;
            this.threeDiamondsPictureBox.Click += new System.EventHandler(this.cardPicture1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 359);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardPicture5);
            this.Controls.Add(this.cardPicture4);
            this.Controls.Add(this.cardPicture3);
            this.Controls.Add(this.cardPicture2);
            this.Controls.Add(this.threeDiamondsPictureBox);
            this.Controls.Add(this.descriptionBox);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeDiamondsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionBox;
        private System.Windows.Forms.PictureBox threeDiamondsPictureBox;
        private System.Windows.Forms.PictureBox cardPicture2;
        private System.Windows.Forms.PictureBox cardPicture3;
        private System.Windows.Forms.PictureBox cardPicture4;
        private System.Windows.Forms.PictureBox cardPicture5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
    }
}

