﻿namespace GotoGrocery
{
    partial class DashboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.DashboardInfoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(453, 144);
            this.WelcomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(513, 26);
            this.WelcomeLbl.TabIndex = 1;
            this.WelcomeLbl.Text = "Welcome to the Goto Grocery Management System";
            // 
            // DashboardInfoLbl
            // 
            this.DashboardInfoLbl.AutoSize = true;
            this.DashboardInfoLbl.Location = new System.Drawing.Point(564, 330);
            this.DashboardInfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashboardInfoLbl.Name = "DashboardInfoLbl";
            this.DashboardInfoLbl.Size = new System.Drawing.Size(283, 20);
            this.DashboardInfoLbl.TabIndex = 2;
            this.DashboardInfoLbl.Text = "For help refer to documentation ver 1.0";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.DashboardInfoLbl);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label DashboardInfoLbl;
    }
}