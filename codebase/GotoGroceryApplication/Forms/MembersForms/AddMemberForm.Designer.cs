﻿
namespace GotoGrocery
{
    partial class AddMemberForm
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
            this.FnameLbl = new System.Windows.Forms.Label();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.DOBLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.FNameTB = new System.Windows.Forms.TextBox();
            this.LNameTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.DOBTB = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddMemberDetailsBtn = new System.Windows.Forms.Button();
            this.CancelNewMemberBtn = new System.Windows.Forms.Button();
            this.AddMemberTitleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FnameLbl
            // 
            this.FnameLbl.AutoSize = true;
            this.FnameLbl.Location = new System.Drawing.Point(78, 110);
            this.FnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FnameLbl.Name = "FnameLbl";
            this.FnameLbl.Size = new System.Drawing.Size(116, 25);
            this.FnameLbl.TabIndex = 0;
            this.FnameLbl.Text = "First Name";
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Location = new System.Drawing.Point(78, 177);
            this.LNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(115, 25);
            this.LNameLbl.TabIndex = 1;
            this.LNameLbl.Text = "Last Name";
            // 
            // DOBLbl
            // 
            this.DOBLbl.AutoSize = true;
            this.DOBLbl.Location = new System.Drawing.Point(96, 237);
            this.DOBLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DOBLbl.Name = "DOBLbl";
            this.DOBLbl.Size = new System.Drawing.Size(69, 25);
            this.DOBLbl.TabIndex = 2;
            this.DOBLbl.Text = "D.O.B";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(78, 290);
            this.PhoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(107, 25);
            this.PhoneLbl.TabIndex = 3;
            this.PhoneLbl.Text = "Phone No";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(96, 363);
            this.EmailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(65, 25);
            this.EmailLbl.TabIndex = 4;
            this.EmailLbl.Text = "Email";
            // 
            // FNameTB
            // 
            this.FNameTB.Location = new System.Drawing.Point(282, 110);
            this.FNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(494, 31);
            this.FNameTB.TabIndex = 5;
            // 
            // LNameTB
            // 
            this.LNameTB.Location = new System.Drawing.Point(282, 177);
            this.LNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(494, 31);
            this.LNameTB.TabIndex = 6;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(282, 290);
            this.PhoneTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(284, 31);
            this.PhoneTB.TabIndex = 7;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(282, 363);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(494, 31);
            this.EmailTB.TabIndex = 9;
            // 
            // DOBTB
            // 
            this.DOBTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBTB.Location = new System.Drawing.Point(282, 231);
            this.DOBTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DOBTB.Name = "DOBTB";
            this.DOBTB.Size = new System.Drawing.Size(182, 31);
            this.DOBTB.TabIndex = 10;
            // 
            // AddMemberDetailsBtn
            // 
            this.AddMemberDetailsBtn.Location = new System.Drawing.Point(638, 448);
            this.AddMemberDetailsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMemberDetailsBtn.Name = "AddMemberDetailsBtn";
            this.AddMemberDetailsBtn.Size = new System.Drawing.Size(188, 42);
            this.AddMemberDetailsBtn.TabIndex = 11;
            this.AddMemberDetailsBtn.Text = "Add Member";
            this.AddMemberDetailsBtn.UseVisualStyleBackColor = true;
            this.AddMemberDetailsBtn.Click += new System.EventHandler(this.AddMemberDetailsBtn_Click);
            // 
            // CancelNewMemberBtn
            // 
            this.CancelNewMemberBtn.Location = new System.Drawing.Point(138, 448);
            this.CancelNewMemberBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelNewMemberBtn.Name = "CancelNewMemberBtn";
            this.CancelNewMemberBtn.Size = new System.Drawing.Size(114, 42);
            this.CancelNewMemberBtn.TabIndex = 12;
            this.CancelNewMemberBtn.Text = "Cancel";
            this.CancelNewMemberBtn.UseVisualStyleBackColor = true;
            this.CancelNewMemberBtn.Click += new System.EventHandler(this.CancelNewMemberBtn_Click);
            // 
            // AddMemberTitleLbl
            // 
            this.AddMemberTitleLbl.AutoSize = true;
            this.AddMemberTitleLbl.Location = new System.Drawing.Point(374, 27);
            this.AddMemberTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddMemberTitleLbl.Name = "AddMemberTitleLbl";
            this.AddMemberTitleLbl.Size = new System.Drawing.Size(195, 25);
            this.AddMemberTitleLbl.TabIndex = 13;
            this.AddMemberTitleLbl.Text = "Enter New Member";
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 540);
            this.Controls.Add(this.AddMemberTitleLbl);
            this.Controls.Add(this.CancelNewMemberBtn);
            this.Controls.Add(this.AddMemberDetailsBtn);
            this.Controls.Add(this.DOBTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.LNameTB);
            this.Controls.Add(this.FNameTB);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.DOBLbl);
            this.Controls.Add(this.LNameLbl);
            this.Controls.Add(this.FnameLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMemberForm";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FnameLbl;
        private System.Windows.Forms.Label LNameLbl;
        private System.Windows.Forms.Label DOBLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox FNameTB;
        private System.Windows.Forms.TextBox LNameTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.DateTimePicker DOBTB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AddMemberDetailsBtn;
        private System.Windows.Forms.Button CancelNewMemberBtn;
        private System.Windows.Forms.Label AddMemberTitleLbl;
    }
}