namespace osdjoadjs
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
            this.CongratulationLabel = new System.Windows.Forms.Label();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CongratulationLabel
            // 
            this.CongratulationLabel.AutoSize = true;
            this.CongratulationLabel.BackColor = System.Drawing.Color.Transparent;
            this.CongratulationLabel.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongratulationLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CongratulationLabel.Location = new System.Drawing.Point(104, 19);
            this.CongratulationLabel.Name = "CongratulationLabel";
            this.CongratulationLabel.Size = new System.Drawing.Size(585, 63);
            this.CongratulationLabel.TabIndex = 0;
            this.CongratulationLabel.Text = "CONGRATULATION";
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinnerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLabel.Location = new System.Drawing.Point(291, 82);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(185, 50);
            this.WinnerLabel.TabIndex = 1;
            this.WinnerLabel.Text = "PLAYER 1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::osdjoadjs.Properties.Resources.Snake_and_ladder_last_page_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.CongratulationLabel);
            this.Name = "Form2";
            this.Text = "congratulationpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CongratulationLabel;
        private System.Windows.Forms.Label WinnerLabel;
    }
}