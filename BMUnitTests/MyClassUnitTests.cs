using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Benchmark;
using System.Collections.Generic;

namespace BMUnitTests
{
    /// <summary>
    /// This class is used to test the methods, properties and constructors in 'Staff'
    /// </summary>
    [TestClass]
    public class MyClassUnitTests
    {
        /// <summary>
        /// Test the default constructor, check if the staff list will be initialized.
        /// </summary>
        [TestMethod]
        public void TestMyClassDefaultConstructor()
        {
            MyClass myClass = new MyClass();

            Assert.IsNotNull(myClass.GetCurrentStaffs());

            // When first initialized, there will be no element in staff list
            Assert.AreEqual(0, myClass.GetCurrentStaffs().Count);
        }

        /// <summary>
        /// Test the param constructor, check if the staff list will be set.
        /// </summary>
        [TestMethod]
        public void TestMyClassParamConstructor()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00002", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00003", "cJack", "vipJack@google.com", 3100);
            Staff s4 = new Staff("s00004", "dLilei", "vipLilei@google.com", 2999);
            Staff s5 = new Staff("s00005", "eJhon", "vipJhon@google.com", 3000);

            List<Staff> staffExpected = new List<Staff>();
            staffExpected.Add(s1);
            staffExpected.Add(s2);
            staffExpected.Add(s3);
            staffExpected.Add(s4);
            staffExpected.Add(s5);

            MyClass myClass = new MyClass(staffExpected);

            Assert.IsNotNull(myClass.GetCurrentStaffs());
            Assert.AreEqual(5, myClass.GetCurrentStaffs().Count);
            CollectionAssert.AreEqual(staffExpected, myClass.GetCurrentStaffs());
        }

        /// <summary>
        /// Test the param constructor, check if the staff list will be set.
        /// </summary>
        [TestMethod]
        public void TestMyClassReloadFileStaff()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00002", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00003", "cJack", "vipJack@google.com", 3100);
            Staff s4 = new Staff("s00004", "dLilei", "vipLilei@google.com", 2999);
            Staff s5 = new Staff("s00005", "eJhon", "vipJhon@google.com", 3000);

            List<Staff> staffExpected = new List<Staff>();
            staffExpected.Add(s1);
            staffExpected.Add(s2);
            staffExpected.Add(s3);
            staffExpected.Add(s4);
            staffExpected.Add(s5);

            MyClass myClass = new MyClass();

            myClass.ReloadFileStaff(staffExpected);

            Assert.IsNotNull(myClass.GetCurrentStaffs());
            Assert.AreEqual(staffExpected.Count, myClass.GetCurrentStaffs().Count);
            CollectionAssert.AreEqual(staffExpected, myClass.GetCurrentStaffs());
        }

        /// <summary>
        /// Test if the current staff list return the right result
        /// </summary>
        [TestMethod]
        public void TestMyClassGetCurrentStaffs()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00002", "bLucy", "vipLucy@google.com", 1988);

            List<Staff> staffExpected = new List<Staff>();
            staffExpected.Add(s1);
            staffExpected.Add(s2);

            MyClass myClass = new MyClass(staffExpected);

            Assert.IsNotNull(myClass.GetCurrentStaffs());
            Assert.AreEqual(staffExpected.Count, myClass.GetCurrentStaffs().Count);
        }

        /// <summary>
        /// Test if the CheckStaffIDValid method will checkout the error data.
        /// </summary>
        [TestMethod]
        public void TestMyClassCheckStaffIDValid()
        {
            MyClass myClass = new MyClass();

            Assert.IsFalse(myClass.CheckStaffIDValid("qwert"));
            Assert.IsFalse(myClass.CheckStaffIDValid(""));
            Assert.IsFalse(myClass.CheckStaffIDValid("s00000007"));

            Assert.IsTrue(myClass.CheckStaffIDValid("qwerty"));
            Assert.IsTrue(myClass.CheckStaffIDValid("s00006"));
        }

        /// <summary>
        /// Test if the CheckStaffName method will checkout the error data.
        /// </summary>
        [TestMethod]
        public void TestMyClassCheckStaffName()
        {
            MyClass myClass = new MyClass();

            Assert.IsFalse(myClass.CheckStaffName(""));
            Assert.IsFalse(myClass.CheckStaffName("le"));
            Assert.IsFalse(myClass.CheckStaffName("e"));

            Assert.IsTrue(myClass.CheckStaffName("JACK"));
            Assert.IsTrue(myClass.CheckStaffName("tom"));
        }

        /// <summary>
        /// Test if the CheckStaffEmail method will checkout the error data.
        /// </summary>
        [TestMethod]
        public void TestMyClassCheckStaffEmail()
        {
            MyClass myClass = new MyClass();

            Assert.IsFalse(myClass.CheckStaffEmail(""));
            Assert.IsFalse(myClass.CheckStaffEmail("qweuwiwj"));
            Assert.IsFalse(myClass.CheckStaffEmail("ererGoofle.com"));

            Assert.IsTrue(myClass.CheckStaffEmail("viptom@google.com"));
            Assert.IsTrue(myClass.CheckStaffEmail("yeurwr@126.com"));
        }

        /// <summary>
        /// Test if the CheckStaffMonthlySalary method will checkout the error data.
        /// </summary>
        [TestMethod]
        public void TestMyClassCheckStaffMonthlySalary()
        {
            MyClass myClass = new MyClass();

            Assert.IsFalse(myClass.CheckStaffMonthlySalary(0));
            Assert.IsFalse(myClass.CheckStaffMonthlySalary(1499));
            Assert.IsFalse(myClass.CheckStaffMonthlySalary(-20));

            Assert.IsTrue(myClass.CheckStaffMonthlySalary(1500));
            Assert.IsTrue(myClass.CheckStaffMonthlySalary(3000));
        }

        /// <summary>
        /// Test if the current staff is exist in the staff list
        /// </summary>
        [TestMethod]
        public void TestMyClassCheckIfStaffExist()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00002", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00003", "cJack", "vipJack@google.com", 3100);

            List<Staff> staffExpected = new List<Staff>();
            staffExpected.Add(s1);
            staffExpected.Add(s2);

            MyClass myClass = new MyClass(staffExpected);

            Assert.IsTrue(myClass.CheckIfStaffExist(s1));
            Assert.IsTrue(myClass.CheckIfStaffExist(s2));
            Assert.IsFalse(myClass.CheckIfStaffExist(s3));
        }

        /// <summary>
        /// Test if the wrong staff will not be added into the staff list
        /// </summary>
        [TestMethod]
        public void TestMyClassAddStaff()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00002", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00003", "cJack", "vipJack@google.com", 3100);

            MyClass myClass = new MyClass();

            Assert.ThrowsException<Exception>(() => myClass.AddStaff(null));

            myClass.AddStaff(s1);
            // Because we have added the s1 into the list, so we should not add again.
            Assert.ThrowsException<Exception>(() => myClass.AddStaff(s1));
        }

        /// <summary>
        /// Test if the wrong staff information will lead to exception.
        /// </summary>
        [TestMethod]
        public void TestMyClassDeleteStaff()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00002", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00003", "cJack", "vipJack@google.com", 3100);

            MyClass myClass = new MyClass();
            myClass.AddStaff(s1);
            myClass.AddStaff(s2);

            Assert.ThrowsException<Exception>(() => myClass.DeleteStaff(null));
            // Because s3 is not exist in the staff list, so we should not delete it from list.
            Assert.ThrowsException<Exception>(() => myClass.DeleteStaff(s3));

            myClass.DeleteStaff(s2);
        }
    }
}
