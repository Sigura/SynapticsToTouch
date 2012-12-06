﻿namespace SynapticsToTouch
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
            this.calibrateButton = new System.Windows.Forms.Button();
            this.calibrateLabel = new System.Windows.Forms.Label();
            this.touchLabel = new System.Windows.Forms.Label();
            this.calibrationStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calibrateButton
            // 
            this.calibrateButton.Location = new System.Drawing.Point(12, 12);
            this.calibrateButton.Name = "calibrateButton";
            this.calibrateButton.Size = new System.Drawing.Size(75, 23);
            this.calibrateButton.TabIndex = 0;
            this.calibrateButton.Text = "Calibrate";
            this.calibrateButton.UseVisualStyleBackColor = true;
            this.calibrateButton.Click += new System.EventHandler(this.calibrateButton_Click);
            // 
            // calibrateLabel
            // 
            this.calibrateLabel.AutoSize = true;
            this.calibrateLabel.Location = new System.Drawing.Point(12, 59);
            this.calibrateLabel.Name = "calibrateLabel";
            this.calibrateLabel.Size = new System.Drawing.Size(77, 13);
            this.calibrateLabel.TabIndex = 1;
            this.calibrateLabel.Text = "Not Calibrated.";
            // 
            // touchLabel
            // 
            this.touchLabel.AutoSize = true;
            this.touchLabel.Location = new System.Drawing.Point(9, 239);
            this.touchLabel.Name = "touchLabel";
            this.touchLabel.Size = new System.Drawing.Size(61, 13);
            this.touchLabel.TabIndex = 2;
            this.touchLabel.Text = "Touch X, Y";
            // 
            // calibrationStatusLabel
            // 
            this.calibrationStatusLabel.AutoSize = true;
            this.calibrationStatusLabel.Location = new System.Drawing.Point(12, 76);
            this.calibrationStatusLabel.Name = "calibrationStatusLabel";
            this.calibrationStatusLabel.Size = new System.Drawing.Size(87, 13);
            this.calibrationStatusLabel.TabIndex = 3;
            this.calibrationStatusLabel.Text = "Calibration status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calibrationStatusLabel);
            this.Controls.Add(this.touchLabel);
            this.Controls.Add(this.calibrateLabel);
            this.Controls.Add(this.calibrateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calibrateButton;
        private System.Windows.Forms.Label calibrateLabel;
        private System.Windows.Forms.Label touchLabel;
        private System.Windows.Forms.Label calibrationStatusLabel;
    }
}

