namespace osdjoadjs
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.Gamenamelabel = new System.Windows.Forms.Label();
            this.Ruleslabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Nametxtbox1 = new System.Windows.Forms.TextBox();
            this.Btnstart = new System.Windows.Forms.Button();
            this.Characterpic1 = new System.Windows.Forms.PictureBox();
            this.Characterpic2 = new System.Windows.Forms.PictureBox();
            this.Nametxtbox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Characterpic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Characterpic2)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelabel.Font = new System.Drawing.Font("Viner Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.ForeColor = System.Drawing.Color.Indigo;
            this.Welcomelabel.Location = new System.Drawing.Point(597, -7);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(306, 76);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Welcome  To";
            // 
            // Gamenamelabel
            // 
            this.Gamenamelabel.AutoSize = true;
            this.Gamenamelabel.BackColor = System.Drawing.Color.Transparent;
            this.Gamenamelabel.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gamenamelabel.ForeColor = System.Drawing.Color.Indigo;
            this.Gamenamelabel.Location = new System.Drawing.Point(595, 53);
            this.Gamenamelabel.Name = "Gamenamelabel";
            this.Gamenamelabel.Size = new System.Drawing.Size(333, 97);
            this.Gamenamelabel.TabIndex = 1;
            this.Gamenamelabel.Text = "Super Sal";
            // 
            // Ruleslabel
            // 
            this.Ruleslabel.AutoSize = true;
            this.Ruleslabel.BackColor = System.Drawing.Color.Transparent;
            this.Ruleslabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ruleslabel.ForeColor = System.Drawing.Color.Indigo;
            this.Ruleslabel.Location = new System.Drawing.Point(76, 150);
            this.Ruleslabel.Name = "Ruleslabel";
            this.Ruleslabel.Size = new System.Drawing.Size(829, 465);
            this.Ruleslabel.TabIndex = 2;
            this.Ruleslabel.Text = resources.GetString("Ruleslabel.Text");
            this.Ruleslabel.Click += new System.EventHandler(this.Ruleslabel_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.BackColor = System.Drawing.Color.Transparent;
            this.Namelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(1013, 167);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(249, 28);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "Please enter your names:";
            // 
            // Nametxtbox1
            // 
            this.Nametxtbox1.Location = new System.Drawing.Point(1139, 246);
            this.Nametxtbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nametxtbox1.Multiline = true;
            this.Nametxtbox1.Name = "Nametxtbox1";
            this.Nametxtbox1.Size = new System.Drawing.Size(153, 32);
            this.Nametxtbox1.TabIndex = 5;
            this.Nametxtbox1.TextChanged += new System.EventHandler(this.Nametxtbox1_TextChanged);
            // 
            // Btnstart
            // 
            this.Btnstart.BackColor = System.Drawing.Color.Cyan;
            this.Btnstart.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnstart.Location = new System.Drawing.Point(1069, 575);
            this.Btnstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnstart.Name = "Btnstart";
            this.Btnstart.Size = new System.Drawing.Size(224, 68);
            this.Btnstart.TabIndex = 11;
            this.Btnstart.Text = "START";
            this.Btnstart.UseVisualStyleBackColor = false;
            this.Btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // Characterpic1
            // 
            this.Characterpic1.Image = global::osdjoadjs.Properties.Resources.Character_4;
            this.Characterpic1.Location = new System.Drawing.Point(1019, 210);
            this.Characterpic1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Characterpic1.Name = "Characterpic1";
            this.Characterpic1.Size = new System.Drawing.Size(100, 123);
            this.Characterpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Characterpic1.TabIndex = 12;
            this.Characterpic1.TabStop = false;
            // 
            // Characterpic2
            // 
            this.Characterpic2.Image = global::osdjoadjs.Properties.Resources.doctor_clipart_3_SAL;
            this.Characterpic2.Location = new System.Drawing.Point(1019, 372);
            this.Characterpic2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Characterpic2.Name = "Characterpic2";
            this.Characterpic2.Size = new System.Drawing.Size(100, 123);
            this.Characterpic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Characterpic2.TabIndex = 13;
            this.Characterpic2.TabStop = false;
            // 
            // Nametxtbox2
            // 
            this.Nametxtbox2.Location = new System.Drawing.Point(1140, 407);
            this.Nametxtbox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nametxtbox2.Multiline = true;
            this.Nametxtbox2.Name = "Nametxtbox2";
            this.Nametxtbox2.Size = new System.Drawing.Size(152, 32);
            this.Nametxtbox2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1135, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1133, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Player 2:";
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::osdjoadjs.Properties.Resources.snakeandladder_bckgrd_2_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nametxtbox2);
            this.Controls.Add(this.Characterpic2);
            this.Controls.Add(this.Characterpic1);
            this.Controls.Add(this.Btnstart);
            this.Controls.Add(this.Nametxtbox1);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Ruleslabel);
            this.Controls.Add(this.Gamenamelabel);
            this.Controls.Add(this.Welcomelabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WelcomeScreen";
            this.Text = "welcomepage";
            ((System.ComponentModel.ISupportInitialize)(this.Characterpic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Characterpic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label Gamenamelabel;
        private System.Windows.Forms.Label Ruleslabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox Nametxtbox1;
        private System.Windows.Forms.Button Btnstart;
        private System.Windows.Forms.PictureBox Characterpic1;
        private System.Windows.Forms.PictureBox Characterpic2;
        private System.Windows.Forms.TextBox Nametxtbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

