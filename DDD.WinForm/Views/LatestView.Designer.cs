namespace DDD.WinForm.Views
{
    partial class LatestView
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
            this.MeasureViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MeasureViewLabel
            // 
            this.MeasureViewLabel.AutoSize = true;
            this.MeasureViewLabel.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MeasureViewLabel.Location = new System.Drawing.Point(349, 206);
            this.MeasureViewLabel.Name = "MeasureViewLabel";
            this.MeasureViewLabel.Size = new System.Drawing.Size(166, 61);
            this.MeasureViewLabel.TabIndex = 0;
            this.MeasureViewLabel.Text = "label1";
            // 
            // LatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MeasureViewLabel);
            this.Name = "LatestView";
            this.Text = "LatestView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MeasureViewLabel;
    }
}