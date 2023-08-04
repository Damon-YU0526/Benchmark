using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Benchmark;
using System.Collections.Generic;

namespace BMUnitTests
{
    /// <summary>
    /// This class is used to test the functions in 'Staff'
    /// </summary>
    [TestClass]
    public class StaffUnitTests
    {
        /// <summary>
        /// Test if something wrong with Staff ID, there would be exception thrown
        /// </summary>
        [TestMethod]
        public void TestStaffIDCheckException()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);

            // Test when staffID is empty
            Assert.ThrowsException<Exception>(() => s1.StaffID = "");

            // Test when staffID is not 6 length
            Assert.ThrowsException<Exception>(() => s1.StaffID = "hjkasdf");
        }

        /// <summary>
        /// Test Staff ID could be set right
        /// </summary>
        [TestMethod]
        public void TestStaffIDProperty()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);

            // Test when staffID is right
            s1.StaffID = "sxuiok";
            Assert.AreEqual("sxuiok", s1.StaffID);
        }

        /// <summary>
        /// Test if something wrong with Staff Name, there would be exception thrown
        /// </summary>
        [TestMethod]
        public void TestStaffNameCheckException()
        {
            Staff s2 = new Staff("s00002", "Lucy", "vipLucy@google.com", 3778);

            // Test when staff name is empty
            Assert.ThrowsException<Exception>(() => s2.Name = "");

            // Test when staff name is less than 3 length
            Assert.ThrowsException<Exception>(() => s2.Name = "er");
        }

        /// <summary>
        /// Test Staff Name could be set right
        /// </summary>
        [TestMethod]
        public void TestStaffNameProperty()
        {
            Staff s2 = new Staff("s00002", "Lucy", "vipLucy@google.com", 3778);

            // Test when staffID is right
            s2.Name = "Hanjh";
            Assert.AreEqual("Hanjh", s2.Name);
        }

        /// <summary>
        /// Test if something wrong with Email, there would be exception thrown
        /// </summary>
        [TestMethod]
        public void TestStaffEmailCheckException()
        {
            Staff s2 = new Staff("s00002", "Lucy", "vipLucy@google.com", 3778);

            // Test when staff email is empty
            Assert.ThrowsException<Exception>(() => s2.Email = "");

            // Test when staff email is not valid
            Assert.ThrowsException<Exception>(() => s2.Email = "er");
        }

        /// <summary>
        /// Test Email could be set right
        /// </summary>
        [TestMethod]
        public void TestStaffEmailProperty()
        {
            Staff s2 = new Staff("s00002", "Lucy", "vipLucy@google.com", 3778);

            // Test when staffID is right
            s2.Email = "vipuey@google.com";
            Assert.AreEqual("vipuey@google.com", s2.Email);
        }

        /// <summary>
        /// Test if something wrong with MonthlySalary, there would be exception thrown
        /// </summary>
        [TestMethod]
        public void TestStaffMonthlySalaryCheckException()
        {
            Staff s2 = new Staff("s00002", "Lucy", "vipLucy@google.com", 3778);

            // Test if MonthlySalary is less than 1500
            Assert.ThrowsException<Exception>(() => s2.MonthlySalary = 1499);
            Assert.ThrowsException<Exception>(() => s2.MonthlySalary = -10);
        }

        /// <summary>
        /// Test MonthlySalary could be set right
        /// </summary>
        [TestMethod]
        public void TestStaffMonthlySalaryProperty()
        {
            Staff s2 = new Staff("s00002", "Lucy", "vipLucy@google.com", 3778);

            // Test when Monthly Salary is less than 1500
            s2.MonthlySalary = 3000;
            Assert.AreEqual(3000, s2.MonthlySalary);
        }

        /// <summary>
        /// Test if the calculation of Annual Salary is right
        /// </summary>
        [TestMethod]
        public void TestStaffAnnualSalaryProperty()
        {
            Staff s2 = new Staff("s00002", "Lucy", "vipLucy@google.com", 3778);

            // Test when if annual salary is MonthlySalary * 13
            s2.MonthlySalary = 3000;
            Assert.AreEqual(39000, s2.AnnualSalary);

            s2.MonthlySalary = 2000;
            Assert.AreEqual(26000, s2.AnnualSalary);

            s2.MonthlySalary = 1500;
            Assert.AreEqual(19500, s2.AnnualSalary);
        }

        /// <summary>
        /// Test if the staff constructor can throw exception when property is not right
        /// </summary>
        [TestMethod]
        public void TestStaffConstructorException()
        {
            // Test if staff construct error
            Assert.ThrowsException<Exception>(() => new Staff("s0000299", "Lu", "vipLucy", 1499));
        }

        /// <summary>
        /// Test if the toString method is right
        /// </summary>
        [TestMethod]
        public void TestStaffToStringFormat()
        {
            Staff s2 = new Staff("s00002", "Lucy", "vipLucy@google.com", 3000);

            Assert.AreEqual("StaffID:s00002 Name:Lucy Email:vipLucy@google.com MonthlySalary:3000 AnnualSalary:39000", s2.ToString());
        }
    }
}
