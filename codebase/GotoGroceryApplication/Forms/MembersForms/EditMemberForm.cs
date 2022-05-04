﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

namespace GotoGrocery.Forms.MembersForms
{
    public partial class EditMemberForm : Form
    {
        private MembersForm mf;

        public EditMemberForm(String id, MembersForm membersForm)
        {
            InitializeComponent();
            mf = membersForm;
            int formattedID = -1;
            try { formattedID = Int32.Parse(id); }
            catch (FormatException) { Console.WriteLine($"Unable to parse '{id}'"); }

            Members memb = new Members();
            memb = GetMemberFromDB(memb, formattedID);

            MemberIdTB.Text = memb.MembID.ToString();
            EditFNameTB.Text = Capitalize(memb.FName);
            EditLNameTB.Text = Capitalize(memb.LName);
            EditDOBInput.Text = memb.Dob;
            EditEmailTB.Text = memb.Email;
            EditPhoneTB.Text = memb.PhoneNo;
            EditdateStartInput.Text = memb.MembershipStartDate;

        }

        private string Capitalize(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }

        private Members GetMemberFromDB(Members member, int id)
        {
            DatabaseConnection db = new DatabaseConnection();
            List<String> m = db.MembertoString(id);


            // Convert from list of strings to Member Object
            member.MembID = id;
            member.FName = m[1];
            member.LName = m[2];
            member.Dob = m[3];
            member.PhoneNo = m[4];
            member.Email = m[5];
            member.MembershipStatus = m[6].ToLower();
            member.MembershipStartDate = m[7];

            // Membership Status Logic
            if (member.MembershipStatus == "true")
            {
                StatusTrueCheck.Checked = true;
            }
            else if (member.MembershipStatus == "false")
            {
                StatusFalseCheck.Checked = true;
            }

            return member;
        }

        private void CancelEditMemberBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AcceptEditMemberDetailsBtn_Click(object sender, EventArgs e)
        {
            // Push all information from textbox to Member Object
            Members memb = new Members();

            memb.MembID = Int32.Parse(MemberIdTB.Text);
            memb.FName = EditFNameTB.Text;
            memb.LName = EditLNameTB.Text;
            memb.Dob = EditDOBInput.Text;
            memb.Email = EditEmailTB.Text;
            memb.PhoneNo = EditPhoneTB.Text;
            memb.MembershipStartDate = EditdateStartInput.Text;
            memb.MembershipStatus = "true";

            //Membership Status Logic
            if (StatusTrueCheck.Checked == true)
                memb.MembershipStatus = "true";
            else
                memb.MembershipStatus = "false";

            // Validate
            uint pass = memb.Validate();
            string errorMsg = "";
            if (!IsBitSet(pass, 0)) { errorMsg += "\nID Invalid"; }
            if (!IsBitSet(pass, 1)) { errorMsg += "\nFirst Name Invalid"; }
            if (!IsBitSet(pass, 2)) { errorMsg += "\nLast Name Invalid"; }
            //if (!IsBitSet(pass, 3)) { errorMsg += "\nEmail Invalid"; } Email Validation not needed at is used as first point of reference and validated upon adding
            if (!IsBitSet(pass, 4)) { errorMsg += "\nMembership Status Name Invalid"; }
            if (!IsBitSet(pass, 5)) { errorMsg += "\nPhone Number Invalid"; }
            if (!IsBitSet(pass, 6)) { errorMsg += "\nDoB Invalid"; }
            if (!IsBitSet(pass, 7)) { errorMsg += "\nMembership Start Date Invalid"; }


            // Push to database
            DatabaseConnection db = new DatabaseConnection();
            //bool passDB = db.AddMember(memb.FName, memb.LName, memb.Dob, memb.PhoneNo, memb.Email, memb.MembershipStartDate);
            bool passDB = false;
            passDB = db.UpdateMember(memb.Email, "Member_FirstName", memb.FName);
            passDB = db.UpdateMember(memb.Email, "Member_LastName", memb.LName);
            passDB = db.UpdateMember(memb.Email, "Member_DOB", datefix(memb.Dob));
            passDB = db.UpdateMember(memb.Email, "Member_phoneNumber", memb.PhoneNo);
            passDB = db.UpdateMember(memb.Email, "Member_Status", memb.MembershipStatus);
            passDB = db.UpdateMember(memb.Email, "Member_StartDate", datefix(memb.MembershipStartDate));

            // Error Messages
            if (errorMsg != "")
            {
                MessageBox.Show(errorMsg + "\n" + Convert.ToString(pass, 2));
                Console.WriteLine(errorMsg);
            }
            else if (passDB)
            {
                MessageBox.Show("Member edited successfully!");
                Console.WriteLine("Member edited successfully!");
                this.Close();
                mf.LoadMembersIntoTable();
            }
            else if (!passDB)
            {
                MessageBox.Show("Error pushing to database!");
                Console.WriteLine("Error pushing to database!");
            }
        }

        bool IsBitSet(uint b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        private void StatusFalseCheck_CheckedChanged(object sender, EventArgs e)
        {
            StatusFalseCheck.Checked = true;
            StatusTrueCheck.Checked = false;

        }

        private void StatusTrueCheck_CheckedChanged(object sender, EventArgs e)
        {
            StatusTrueCheck.Checked = true;
            StatusFalseCheck.Checked = false;

        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {

        }
        //ahhhhhhhhhhhhh
        private string datefix(string givenDate)
        {
            string[] split = givenDate.Split('/');
            return split[2] + "-" + split[1] + "-" + split[0];
        }

        private void StatusTrueCheck_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}