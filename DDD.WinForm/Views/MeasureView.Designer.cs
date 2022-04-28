namespace DDD.WinForm.Views
{
    partial class MeasureView
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
            this.MeasureValueLabel = new System.Windows.Forms.Label();
            this.MeasureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeasureValueLabel
            // 
            this.MeasureValueLabel.AutoSize = true;
            this.MeasureValueLabel.Location = new System.Drawing.Point(370, 89);
            this.MeasureValueLabel.Name = "MeasureValueLabel";
            this.MeasureValueLabel.Size = new System.Drawing.Size(41, 15);
            this.MeasureValueLabel.TabIndex = 0;
            this.MeasureValueLabel.Text = "label1";
            // 
            // MeasureButton
            // 
            this.MeasureButton.Location = new System.Drawing.Point(375, 213);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(75, 23);
            this.MeasureButton.TabIndex = 1;
            this.MeasureButton.Text = "Measure";
            this.MeasureButton.UseVisualStyleBackColor = true;
            // 
            // MeasureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MeasureButton);
            this.Controls.Add(this.MeasureValueLabel);
            this.Name = "MeasureView";
            this.Text = "MeasureView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MeasureValueLabel;
        private Button MeasureButton;
    }
}