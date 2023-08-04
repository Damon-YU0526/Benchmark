using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Benchmark;
using System.Collections.Generic;

namespace BMUnitTests
{
    /// <summary>
    /// This class is used to test the functions in 'Filter'
    /// </summary>
    [TestClass]
    public class FilterUnitTests
    {
        /// <summary>
        /// Test sorting by staff name ascending
        /// </summary>
        [TestMethod]
        public void TestFilterSortNameToAZ()
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

            List<Staff> staffActual = new List<Staff>();
            staffActual.Add(s3);
            staffActual.Add(s5);
            staffActual.Add(s2);
            staffActual.Add(s4);
            staffActual.Add(s1);

            var f = new Filter();

            staffActual = f.SortAZByName(staffActual);

            CollectionAssert.AreEqual(staffExpected, staffActual);
        }

        /// <summary>
        /// Test sorting by staff name descending
        /// </summary>
        [TestMethod]
        public void TestFilterSortToZA()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00002", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00003", "cJack", "vipJack@google.com", 3100);
            Staff s4 = new Staff("s00004", "dLilei", "vipLilei@google.com", 2999);
            Staff s5 = new Staff("s00005", "eJhon", "vipJhon@google.com", 3000);

            List<Staff> staffExpected = new List<Staff>();
            staffExpected.Add(s5);
            staffExpected.Add(s4);
            staffExpected.Add(s3);
            staffExpected.Add(s2);
            staffExpected.Add(s1);

            List<Staff> staffActual = new List<Staff>();
            staffActual.Add(s3);
            staffActual.Add(s5);
            staffActual.Add(s2);
            staffActual.Add(s4);
            staffActual.Add(s1);

            var f = new Filter();

            staffActual = f.SortZAByName(staffActual);

            CollectionAssert.AreEqual(staffExpected, staffActual);
        }

        /// <summary>
        /// Test searching staffs by staff name based on a key word
        /// </summary>
        [TestMethod]
        public void TestFilterSearch()
        {
            Staff s1 = new Staff("s00001", "aTom", "viptom@google.com", 2335);
            Staff s2 = new Staff("s00002", "bLucy", "vipLucy@google.com", 1988);
            Staff s3 = new Staff("s00003", "cJack", "vipJack@google.com", 3100);
            Staff s4 = new Staff("s00004", "dLilei", "vipLilei@google.com", 2999);
            Staff s5 = new Staff("s00005", "eJhon", "vipJhon@google.com", 3000);

            List<Staff> staffList = new List<Staff>();
            staffList.Add(s5);
            staffList.Add(s4);
            staffList.Add(s3);
            staffList.Add(s2);
            staffList.Add(s1);

            Filter f = new Filter();

            List<Staff> searchResult = new List<Staff>();

            searchResult = f.SearchByName(staffList, "o");

            CollectionAssert.Contains(searchResult, s1);
            CollectionAssert.Contains(searchResult, s5);
            CollectionAssert.DoesNotContain(searchResult, s2);
            CollectionAssert.DoesNotContain(searchResult, s3);
            CollectionAssert.DoesNotContain(searchResult, s4);

            // Test if the key word can be transfered to lower case
            searchResult = f.SearchByName(staffList, "O");

            CollectionAssert.Contains(searchResult, s1);
            CollectionAssert.Contains(searchResult, s5);
            CollectionAssert.DoesNotContain(searchResult, s2);
            CollectionAssert.DoesNotContain(searchResult, s3);
            CollectionAssert.DoesNotContain(searchResult, s4);
        }
    }
}
