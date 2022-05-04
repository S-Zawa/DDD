﻿namespace DDD.WinForm.Views
{
    partial class MenuView
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
            this.MeasureButton = new System.Windows.Forms.Button();
            this.LatestButton = new System.Windows.Forms.Button();
            this.ListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeasureButton
            // 
            this.MeasureButton.Location = new System.Drawing.Point(334, 66);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(75, 23);
            this.MeasureButton.TabIndex = 0;
            this.MeasureButton.Text = "Measure";
            this.MeasureButton.UseVisualStyleBackColor = true;
            this.MeasureButton.Click += new System.EventHandler(this.MeasureButton_Click);
            // 
            // LatestButton
            // 
            this.LatestButton.Location = new System.Drawing.Point(334, 127);
            this.LatestButton.Name = "LatestButton";
            this.LatestButton.Size = new System.Drawing.Size(75, 23);
            this.LatestButton.TabIndex = 1;
            this.LatestButton.Text = "Latest";
            this.LatestButton.UseVisualStyleBackColor = true;
            this.LatestButton.Click += new System.EventHandler(this.LatestButton_Click);
            // 
            // ListButton
            // 
            this.ListButton.Location = new System.Drawing.Point(343, 232);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(75, 23);
            this.ListButton.TabIndex = 2;
            this.ListButton.Text = "List";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.LatestButton);
            this.Controls.Add(this.MeasureButton);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.ResumeLayout(false);

        }

        #endregion

        private Button MeasureButton;
        private Button LatestButton;
        private Button ListButton;
    }
}