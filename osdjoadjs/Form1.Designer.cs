﻿namespace osdjoadjs
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
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.RulesLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.CharacterPic1 = new System.Windows.Forms.PictureBox();
            this.CharacterPic2 = new System.Windows.Forms.PictureBox();
            this.SelectBtn1 = new System.Windows.Forms.Button();
            this.SelectBtn2 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelabel.Font = new System.Drawing.Font("Viner Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcomelabel.Location = new System.Drawing.Point(565, 9);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(306, 76);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Welcome  To";
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameLabel.Location = new System.Drawing.Point(561, 68);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(333, 97);
            this.GameNameLabel.TabIndex = 1;
            this.GameNameLabel.Text = "Super Sal";
            // 
            // RulesLabel
            // 
            this.RulesLabel.AutoSize = true;
            this.RulesLabel.BackColor = System.Drawing.Color.Transparent;
            this.RulesLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesLabel.Location = new System.Drawing.Point(95, 165);
            this.RulesLabel.Name = "RulesLabel";
            this.RulesLabel.Size = new System.Drawing.Size(913, 465);
            this.RulesLabel.TabIndex = 2;
            this.RulesLabel.Text = resources.GetString("RulesLabel.Text");
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(1014, 167);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(240, 28);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Please enter your name:";
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.AutoSize = true;
            this.CharacterLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterLabel.Location = new System.Drawing.Point(1014, 242);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(262, 28);
            this.CharacterLabel.TabIndex = 4;
            this.CharacterLabel.Text = "Please choose a character:";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(1016, 197);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTxtBox.Multiline = true;
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(235, 32);
            this.NameTxtBox.TabIndex = 5;
            // 
            // CharacterPic1
            // 
            this.CharacterPic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterPic1.Image = global::osdjoadjs.Properties.Resources.Character_3_1;
            this.CharacterPic1.Location = new System.Drawing.Point(1014, 286);
            this.CharacterPic1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CharacterPic1.Name = "CharacterPic1";
            this.CharacterPic1.Size = new System.Drawing.Size(116, 158);
            this.CharacterPic1.TabIndex = 6;
            this.CharacterPic1.TabStop = false;
            // 
            // CharacterPic2
            // 
            this.CharacterPic2.BackgroundImage = global::osdjoadjs.Properties.Resources.Character_4_1;
            this.CharacterPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterPic2.Location = new System.Drawing.Point(1146, 286);
            this.CharacterPic2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CharacterPic2.Name = "CharacterPic2";
            this.CharacterPic2.Size = new System.Drawing.Size(118, 158);
            this.CharacterPic2.TabIndex = 7;
            this.CharacterPic2.TabStop = false;
            // 
            // SelectBtn1
            // 
            this.SelectBtn1.BackColor = System.Drawing.Color.Yellow;
            this.SelectBtn1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn1.ForeColor = System.Drawing.Color.Black;
            this.SelectBtn1.Location = new System.Drawing.Point(1014, 457);
            this.SelectBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectBtn1.Name = "SelectBtn1";
            this.SelectBtn1.Size = new System.Drawing.Size(115, 28);
            this.SelectBtn1.TabIndex = 8;
            this.SelectBtn1.Text = "SELECT";
            this.SelectBtn1.UseVisualStyleBackColor = false;
            // 
            // SelectBtn2
            // 
            this.SelectBtn2.BackColor = System.Drawing.Color.Yellow;
            this.SelectBtn2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn2.Location = new System.Drawing.Point(1153, 457);
            this.SelectBtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectBtn2.Name = "SelectBtn2";
            this.SelectBtn2.Size = new System.Drawing.Size(111, 28);
            this.SelectBtn2.TabIndex = 9;
            this.SelectBtn2.Text = "SELECT";
            this.SelectBtn2.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(1111, 489);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(71, 36);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Cyan;
            this.StartBtn.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(1053, 564);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(211, 54);
            this.StartBtn.TabIndex = 11;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::osdjoadjs.Properties.Resources.snakeandladder_bckgrd_2_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 658);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SelectBtn2);
            this.Controls.Add(this.SelectBtn1);
            this.Controls.Add(this.CharacterPic2);
            this.Controls.Add(this.CharacterPic1);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.CharacterLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RulesLabel);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.Welcomelabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "welcomepage";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Label RulesLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.PictureBox CharacterPic1;
        private System.Windows.Forms.PictureBox CharacterPic2;
        private System.Windows.Forms.Button SelectBtn1;
        private System.Windows.Forms.Button SelectBtn2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button StartBtn;
    }
}

