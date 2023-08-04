using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    public class Staff
    {
        private string staffID;
        private string name;
        private string email;
        private int monthlySalary;

        // This is used to help check the email address.
        private EmailAddressAttribute emailCheck = new EmailAddressAttribute();

        /// <summary>
        /// The unique ID of staff which is used to distinguish the staff (The name of staff may be same)
        /// We will check the StaffID should not be empty and the length should be 6
        /// </summary>
        public string StaffID
        {
            get { return staffID; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("StaffID should not be empty");
                }

                if (value.Length != 6)
                {
                    throw new Exception("The length of StaffID should be 6");
                }

                staffID = value; 
            }
        }

        /// <summary>
        /// The name of the staff, maybe some staffs' name will be the same.
        /// We should check the name should not be empty and should not be less than 3
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name should not be empty");
                }

                if (value.Length < 3)
                {
                    throw new Exception("The length of Name should not be less than 3");
                }

                name = value; 
            }
        }

        /// <summary>
        /// The email of staff.
        /// We will check if the email is valid
        /// </summary>
        public string Email
        {
            get { return email; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Email should not be empty");
                }

                if (!emailCheck.IsValid(value))
                {
                    throw new Exception("This email is not valid");
                }

                email = value;
            }
        }

        /// <summary>
        /// The salary earned by month.
        /// We should check the salary should not be less than 1500 because of the minimum guarantee.
        /// </summary>
        public int MonthlySalary
        {
            get { return monthlySalary; }
            set 
            {
                if (value < 1500)
                {
                    throw new Exception("MonthlySalary should not be less than 1500");
                }

                monthlySalary = value; 
            }
        }

        /// <summary>
        /// The annual salary is based on the 12 months' salary and plus another 1 month salary as bonus
        /// </summary>
        public int AnnualSalary 
        { 
            get { return this.monthlySalary * 13; }
        }

        /// <summary>
        /// This constructor is used to set the original value to properties.
        /// </summary>
        /// <param name="sID"></param>
        /// <param name="sName"></param>
        /// <param name="sEmail"></param>
        /// <param name="mSalary"></param>
        public Staff(string sID, string sName, string sEmail, int mSalary)
        {
            StaffID = sID;
            Name = sName;
            Email = sEmail;
            MonthlySalary = mSalary;
        }

        public override string ToString()
        {
            return "StaffID:" + StaffID + " Name:" + Name + " Email:" + Email + " MonthlySalary:" + MonthlySalary.ToString() + " AnnualSalary:" + AnnualSalary;
        }
    }
}
