using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Benchmark;
using System.Collections.Generic;

namespace BMUnitTests
{
    /// <summary>
    /// This class is used to test the methods in 'FileManager'
    /// </summary>
    [TestClass]
    public class FileManagerUnitTests
    {
        /// <summary>
        /// Test load staffs from default file path
        /// </summary>
        [TestMethod]
        public void TestFileManagerDefaultLoadStaffs()
        {
            FileManager fileManager = new FileManager();

            var loadStaffs = fileManager.LoadStaffs();

            // In the default file path("Staffs.txt"), there is a txt file which contains staff information.
            Assert.IsNotNull(loadStaffs);
            // In the default file path, there are some staffs in it.
            Assert.IsTrue(loadStaffs.Count > 0);
        }

        /// <summary>
        /// Test load staffs from wrong file path.
        /// </summary>
        [TestMethod]
        public void TestFileManagerLoadStaffsWithWrongPath()
        {
            FileManager fileManager = new FileManager();

            // We put a wrong file path to it, it will not get staff information.
            var loadStaffs = fileManager.LoadStaffs("Staffs002.txt");

            // In the file path("Staffs002.txt"), there is no txt file exist.
            Assert.IsNull(loadStaffs);
        }

        /// <summary>
        /// Test append staff list into the default path txt file.
        /// </summary>
        [TestMethod]
        public void TestFileManagerDefaultAppendStaffsToFile()
        {
            Staff s1 = new Staff("s00011", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00012", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00013", "cJack", "vipJack@google.com", 3100);

            List<Staff> staffsAppend = new List<Staff>();
            staffsAppend.Add(s1);
            staffsAppend.Add(s2);
            staffsAppend.Add(s3);

            FileManager fileManager = new FileManager();

            bool res = fileManager.AppendStaffsToFile(staffsAppend);

            Assert.IsTrue(res);
        }

        /// <summary>
        /// Test append staffs into wrong file path.
        /// </summary>
        [TestMethod]
        public void TestFileManagerAppendStaffsToFileNotExist()
        {
            Staff s1 = new Staff("s00011", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00012", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00013", "cJack", "vipJack@google.com", 3100);

            List<Staff> staffsAppend = new List<Staff>();
            staffsAppend.Add(s1);
            staffsAppend.Add(s2);
            staffsAppend.Add(s3);

            FileManager fileManager = new FileManager();

            // We put a wrong file path to it, it will not get staff information.
            bool res = fileManager.AppendStaffsToFile(staffsAppend, "Staffs007.txt");

            // In the file path("Staffs007.txt"), there is no txt file exist.
            Assert.IsTrue(res);
        }
    }
}
