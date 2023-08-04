using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    public class MyClass
    {
        // The staffs used through the application
        private List<Staff> currentStaffs = new List<Staff>();

        // This is used to help check the email address.
        private EmailAddressAttribute emailCheck = new EmailAddressAttribute();

        /// <summary>
        /// When we create the object of MyClass, we should input the information of staffs into this object
        /// </summary>
        /// <param name="staffs"></param>
        public MyClass(List<Staff> staffs)
        {
            this.currentStaffs = staffs;
        }

        /// <summary>
        /// A default constructor to init.
        /// </summary>
        public MyClass()
        {
            this.currentStaffs = new List<Staff>();
        }

        /// <summary>
        /// This is used to reload the current staffs from file.
        /// </summary>
        /// <param name="fileStaffs"></param>
        public void ReloadFileStaff(List<Staff> fileStaffs)
        {
            this.currentStaffs = fileStaffs;
        }

        /// <summary>
        /// Get current staff list
        /// This is used to get staffs safely.
        /// </summary>
        /// <returns></returns>
        public List<Staff> GetCurrentStaffs() 
        {
            return this.currentStaffs;
        }

        /// <summary>
        /// We will check the StaffID should not be empty and the length should be 6
        /// </summary>
        /// <param name="staffID"></param>
        /// <returns></returns>
        public bool CheckStaffIDValid(string staffID)
        {
            if (string.IsNullOrWhiteSpace(staffID))
            {
                //throw new Exception("StaffID should not be empty");
                return false;
            }

            if (staffID.Length != 6)
            {
                //throw new Exception("The length of StaffID should be 6");
                return false;
            }

            return true;
        }

        /// <summary>
        /// We should check the name should not be empty and should not be less than 3
        /// </summary>
        /// <param name="staffName"></param>
        /// <returns></returns>
        public bool CheckStaffName(string staffName)
        {
            if (string.IsNullOrWhiteSpace(staffName))
            {
                //throw new Exception("Name should not be empty");
                return false;
            }

            if (staffName.Length < 3)
            {
                //throw new Exception("The length of StaffID should not be less than 3");
                return false;
            }

            return true;
        }

        /// <summary>
        /// We will check if the email is valid
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckStaffEmail(string email) 
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                //throw new Exception("Email should not be empty");
                return false;
            }

            if (!emailCheck.IsValid(email))
            {
                //throw new Exception("This email is not valid");
                return false;
            }

            return true;
        }

        /// <summary>
        /// We should check the salary should not be less than 1500 because of the minimum guarantee.
        /// </summary>
        /// <returns></returns>
        public bool CheckStaffMonthlySalary(int monthlySalary)
        {
            if (monthlySalary < 1500)
            {
                //throw new Exception("MonthlySalary should not be less than 1500");
                return false;
            }

            return true;
        }

        /// <summary>
        /// This is used to check if the staff is in the current list.
        /// We assume the staff ID should be unique
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public bool CheckIfStaffExist(Staff staff)
        {
            return this.currentStaffs.Any(s => s.StaffID == staff.StaffID);
        }

        /// <summary>
        /// Add staff to current list, but we will check if the staff is valid.
        /// </summary>
        /// <param name="staff"></param>
        /// <exception cref="Exception"></exception>
        public void AddStaff(Staff staff)
        {
            if (staff == null)
            {
                throw new Exception("Staff should not be null");
            }

            if (CheckIfStaffExist(staff))
            {
                throw new Exception("This staff is exist");
            }

            this.currentStaffs.Add(staff);
        }

        /// <summary>
        /// Delete staff from current staff list.
        /// </summary>
        /// <param name="staff"></param>
        /// <exception cref="Exception"></exception>
        public void DeleteStaff(Staff staff)
        {
            if (staff == null)
            {
                throw new Exception("Staff should not be null");
            }

            // Be carefule if you want to delete the staff, you should check if the staff is in the current list.
            if (!CheckIfStaffExist(staff))
            {
                throw new Exception("This staff should exist in the current list");
            }

            this.currentStaffs.Remove(staff);
        }
    }
}
