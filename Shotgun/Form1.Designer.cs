namespace Shotgun
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
            this.cmdBlock = new System.Windows.Forms.Button();
            this.cmdReload = new System.Windows.Forms.Button();
            this.cmdShoot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdShotgun = new System.Windows.Forms.Button();
            this.lblPlayerShots = new System.Windows.Forms.Label();
            this.lblOpponentShots = new System.Windows.Forms.Label();
            this.cmdPlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBlock
            // 
            this.cmdBlock.AutoSize = true;
            this.cmdBlock.Location = new System.Drawing.Point(38, 165);
            this.cmdBlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdBlock.Name = "cmdBlock";
            this.cmdBlock.Size = new System.Drawing.Size(108, 63);
            this.cmdBlock.TabIndex = 0;
            this.cmdBlock.Text = "Block";
            this.cmdBlock.UseVisualStyleBackColor = true;
            this.cmdBlock.Click += new System.EventHandler(this.cmdBlock_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.AutoSize = true;
            this.cmdReload.Location = new System.Drawing.Point(38, 268);
            this.cmdReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(108, 63);
            this.cmdReload.TabIndex = 1;
            this.cmdReload.Text = "Reload";
            this.cmdReload.UseVisualStyleBackColor = true;
            this.cmdReload.Click += new System.EventHandler(this.cmdReload_Click);
            // 
            // cmdShoot
            // 
            this.cmdShoot.AutoSize = true;
            this.cmdShoot.Enabled = false;
            this.cmdShoot.Location = new System.Drawing.Point(38, 369);
            this.cmdShoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdShoot.Name = "cmdShoot";
            this.cmdShoot.Size = new System.Drawing.Size(108, 64);
            this.cmdShoot.TabIndex = 2;
            this.cmdShoot.Text = "Shoot";
            this.cmdShoot.UseVisualStyleBackColor = true;
            this.cmdShoot.Click += new System.EventHandler(this.cmdShoot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(244, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Playershots";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(689, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "AIshots";
            // 
            // cmdShotgun
            // 
            this.cmdShotgun.AutoSize = true;
            this.cmdShotgun.Enabled = false;
            this.cmdShotgun.Location = new System.Drawing.Point(518, 429);
            this.cmdShotgun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdShotgun.Name = "cmdShotgun";
            this.cmdShotgun.Size = new System.Drawing.Size(108, 64);
            this.cmdShotgun.TabIndex = 15;
            this.cmdShotgun.Text = "Shotgun";
            this.cmdShotgun.UseVisualStyleBackColor = true;
            this.cmdShotgun.Click += new System.EventHandler(this.cmdShotgun_Click);
            // 
            // lblPlayerShots
            // 
            this.lblPlayerShots.AutoSize = true;
            this.lblPlayerShots.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerShots.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerShots.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerShots.Location = new System.Drawing.Point(310, 255);
            this.lblPlayerShots.Name = "lblPlayerShots";
            this.lblPlayerShots.Size = new System.Drawing.Size(88, 64);
            this.lblPlayerShots.TabIndex = 16;
            this.lblPlayerShots.Text = "lbl";
            // 
            // lblOpponentShots
            // 
            this.lblOpponentShots.AutoSize = true;
            this.lblOpponentShots.BackColor = System.Drawing.Color.Transparent;
            this.lblOpponentShots.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentShots.ForeColor = System.Drawing.Color.Red;
            this.lblOpponentShots.Location = new System.Drawing.Point(707, 255);
            this.lblOpponentShots.Name = "lblOpponentShots";
            this.lblOpponentShots.Size = new System.Drawing.Size(140, 64);
            this.lblOpponentShots.TabIndex = 17;
            this.lblOpponentShots.Text = "lblAI";
            // 
            // cmdPlayAgain
            // 
            this.cmdPlayAgain.AutoSize = true;
            this.cmdPlayAgain.Location = new System.Drawing.Point(895, 429);
            this.cmdPlayAgain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdPlayAgain.Name = "cmdPlayAgain";
            this.cmdPlayAgain.Size = new System.Drawing.Size(108, 64);
            this.cmdPlayAgain.TabIndex = 18;
            this.cmdPlayAgain.Text = "Play Again";
            this.cmdPlayAgain.UseVisualStyleBackColor = true;
            this.cmdPlayAgain.Click += new System.EventHandler(this.cmdPlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1116, 531);
            this.Controls.Add(this.cmdPlayAgain);
            this.Controls.Add(this.lblOpponentShots);
            this.Controls.Add(this.lblPlayerShots);
            this.Controls.Add(this.cmdShotgun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdShoot);
            this.Controls.Add(this.cmdReload);
            this.Controls.Add(this.cmdBlock);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Shotgun.exe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBlock;
        private System.Windows.Forms.Button cmdReload;
        private System.Windows.Forms.Button cmdShoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdShotgun;
        private System.Windows.Forms.Label lblPlayerShots;
        private System.Windows.Forms.Label lblOpponentShots;
        private System.Windows.Forms.Button cmdPlayAgain;
    }
}

