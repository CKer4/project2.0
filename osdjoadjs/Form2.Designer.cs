﻿namespace osdjoadjs
{
    partial class Form2
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
            this.Congratslabel = new System.Windows.Forms.Label();
            this.Winnerlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Congratslabel
            // 
            this.Congratslabel.AutoSize = true;
            this.Congratslabel.BackColor = System.Drawing.Color.Transparent;
            this.Congratslabel.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Congratslabel.ForeColor = System.Drawing.Color.DarkRed;
            this.Congratslabel.Location = new System.Drawing.Point(214, 20);
            this.Congratslabel.Name = "Congratslabel";
            this.Congratslabel.Size = new System.Drawing.Size(626, 63);
            this.Congratslabel.TabIndex = 0;
            this.Congratslabel.Text = "CONGRATULATIONS";
            // 
            // Winnerlabel
            // 
            this.Winnerlabel.AutoSize = true;
            this.Winnerlabel.BackColor = System.Drawing.Color.Transparent;
            this.Winnerlabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winnerlabel.Location = new System.Drawing.Point(399, 89);
            this.Winnerlabel.Name = "Winnerlabel";
            this.Winnerlabel.Size = new System.Drawing.Size(185, 50);
            this.Winnerlabel.TabIndex = 1;
            this.Winnerlabel.Text = "PLAYER 1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::osdjoadjs.Properties.Resources.Snake_and_ladder_last_page_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 552);
            this.Controls.Add(this.Winnerlabel);
            this.Controls.Add(this.Congratslabel);
            this.Name = "Form2";
            this.Text = "congratulationpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Congratslabel;
        private System.Windows.Forms.Label Winnerlabel;
    }
}