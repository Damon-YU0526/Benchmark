using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    /// <summary>
    /// This class is used to operate staff objects by sorting, searching and so on.
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Sort staffs by staff name ascending
        /// </summary>
        /// <param name="staffList">The staffs need to sort asc</param>
        /// <returns>The staffs have been sorted</returns>
        public List<Staff> SortAZByName(List<Staff> staffList)
        {
            staffList = staffList.OrderBy(x => x.Name).ToList();

            return staffList;
        }

        /// <summary>
        /// Sort staffs by staff name descending
        /// </summary>
        /// <param name="staffList">The staffs need to sort desc</param>
        /// <returns>The staffs have been sorted</returns>
        public List<Staff> SortZAByName(List<Staff> staffList)
        {
            staffList = (from x in staffList
                         orderby x.Name descending
                         select x).ToList();

            return staffList;
        }

        /// <summary>
        /// Search the staffs by staff name based on a key word
        /// </summary>
        /// <param name="staffList">The staffs used to search</param>
        /// <param name="term">the key word</param>
        /// <returns>The staffs have been searched</returns>
        public List<Staff> SearchByName(List<Staff> staffList, string term)
        {
            List<Staff> results = new List<Staff>();

            results = staffList.Where(s => s.Name.ToLower().Contains(term.ToLower())).ToList();

            return results;
        }
    }
}
