﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GotoGrocery
{
    public class Members
    {
        // All Member Variables
        private string fName, lName, email, membershipStatus, phoneNo, dob, membershipStartDate;
        private int membID;

        public Members() {
            // All variables are set to "" as this will be picked up within the Validate() method.
            fName = "";
            lName = "";
            email = "";
            membershipStatus = "";
            phoneNo = "";
            dob = "";
            membershipStartDate = "";
        } 

        /*
         * Validates the current private variables
         * Returns an 8bit value corresponding to the 8 properties of the member
         * The order of bits are as follows:
         *          Bit 0 = membershipStartDate     (Membership Start Date)
         *          Bit 1 = dob                     (Date of Birth)
         *          Bit 2 = phoneNo                 (Phone Number)
         *          Bit 3 = membershipStatus        (Membership Status)
         *          Bit 4 = email                   (Email)
         *          Bit 5 = lName                   (Last Name)
         *          Bit 6 = fName                   (First Name)
         *          Bit 7 = membID                  (Member ID)
         *          
         *  NOTE:   Member ID can't be validated as it is handled and assigned by the 
         *          SQL Database and will permanently be set high (set to 1).
         *        
         */
        public uint Validate()
        {
            uint valid = 0b_1000_0000;

            if (this.FName != "") { valid = valid | 0b_0100_0000; }
            if (this.LName != "") { valid = valid | 0b_0010_0000; }
            if (this.Email != "") { valid = valid | 0b_0001_0000; }
            if (this.MembershipStatus != "") { valid = valid | 0b_0000_1000; }
            if (this.PhoneNo != "") { valid = valid | 0b_0000_0100; }
            if (this.Dob != "") { valid = valid | 0b_0000_0010; }
            if (this.MembershipStartDate != "") { valid = valid | 0b_0000_0001; }

            return valid;
        }

        /*
         * Text Validation - Private Method
         * Checks if string is in correct format on the following criteria:
         *      - Exists
         *      - Doesn't have uppercase characters
         *      - Doesn't have digits
         * Returns true or false based on if it passes
         */
        private bool textValidation(string text)
        {
            if (text == null || text.Length == 0) // Checks if exists
                return false;

            if (!Regex.IsMatch(text, @"^[a-zA-Z]+$")) // If !charactersonly
                return false;

            return true; // True if all test cases pass
        }


        /*
        * Below are all Properties who have read and write access
        * NOTE: All properties assume that values given are "VALID" values as
        *       noted by the textValidation() method above.
        *       
        *       If these variables aren't valid, they are set to empty strings
        *       and will be identified when running the validate() method.
        */
        public string FName
        {
            get => fName;
            set
            {
                // Validation based on method textValidation()
                if (!textValidation(value)) { fName = ""; }
                else { fName = value; }
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                // Validation based on method textValidation()
                if (!textValidation(value)) { lName = ""; }
                else { lName = value; }
            }
        }

        public string Email
        {
            get => email;
            set {
                // Validation for Email
                if (Regex.IsMatch(value, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    email = value;
                else
                    email = "";
            }
        }

        public string PhoneNo
        {
            get => phoneNo;
            set {
                // Validation for Australian Phone Number
                Regex regex = new Regex(@"^(\+?\(61\)|\(\+?61\)|\+?61|\(0[1-9]\)|0[1-9])?( ?-?[0-9]){7,9}$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
                bool isValidPhone = regex.IsMatch(value);
                if (isValidPhone) { phoneNo = value; }
                else { phoneNo = ""; }
            }
        }

        public string Dob
        {
            get => dob;
            set {
                DateTime tmp;
                bool check = DateTime.TryParseExact( value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp);
                if (check)
                    dob = value;
                else
                    dob = "";
            }
            // Assumes that the dates are ordered as "yyyy-MM-dd"
        }

        public string MembershipStatus
        {
            get => membershipStatus;
            set
            {
                // Validation: Membership status can only be true or false
                if(value == "true" || value == "false") { membershipStatus = value.ToLower(); }
                else { membershipStatus = ""; }
            }

        }

        public string MembershipStartDate
        {
            get => membershipStartDate;
            set {
                DateTime tmp;
                bool check = DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp);
                if (check)
                    membershipStartDate = value;
                else
                    membershipStartDate = "";
                }

        }


        public int MembID
        {
            get => membID;
            set { membID = value; }
            // No validation required for memberID as it is completed by the database
        }

    }
}
