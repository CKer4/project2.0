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
            this.Congratslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Congratslabel
            // 
            this.Congratslabel.BackColor = System.Drawing.Color.YellowGreen;
            this.Congratslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Congratslabel.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Congratslabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.Congratslabel.Location = new System.Drawing.Point(217, 286);
            this.Congratslabel.Name = "Congratslabel";
            this.Congratslabel.Size = new System.Drawing.Size(623, 77);
            this.Congratslabel.TabIndex = 0;
            this.Congratslabel.Text = "CONGRATULATIONS";
            this.Congratslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::osdjoadjs.Properties.Resources.Snake_and_ladder_last_page_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 552);
            this.Controls.Add(this.Congratslabel);
            this.Name = "Form2";
            this.Text = "congratulationpage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Congratslabel;
    }
}