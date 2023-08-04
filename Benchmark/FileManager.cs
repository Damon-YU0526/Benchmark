using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    /// <summary>
    /// This class is used to operate the staff information with files
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// Load staff informaiton from specified txt file
        /// This method can used with a default 'filePath', you can input another if you want
        /// </summary>
        /// <param name="filePath">The txt file path</param>
        /// <returns></returns>
        public List<Staff> LoadStaffs(string filePath = "Staffs.txt")
        {
            try
            {
                List<Staff> staffList = new List<Staff>();

                StreamReader sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();
                    string[] values = temp.Split(',');

                    Staff s = new Staff(values[0], values[1], values[2], int.Parse(values[3]));

                    staffList.Add(s);
                }

                sr.Dispose();

                return staffList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Append the staffs into the specified txt file.
        /// This method can used with a default 'filePath', you can input another if you want
        /// </summary>
        /// <param name="staffs">The staffs need to append into txt file</param>
        /// <param name="filePath">The txt file path</param>
        /// <returns></returns>
        public bool AppendStaffsToFile(List<Staff> staffs, string filePath = "Staffs.txt")
        {
            // if staffs is null or with no item, then return true directly.
            if (staffs == null || staffs.Count < 1)
            {
                return true;
            }

            try
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                
                // This is used to make a new line in txt file
                // If without this, you will add content beside last line.
                sw.WriteLine();

                foreach (var item in staffs)
                {
                    string line = string.Format("{0},{1},{2},{3}", item.StaffID, item.Name, item.Email, item.MonthlySalary);
                    
                    sw.WriteLine(line);
                }

                sw.Flush();
                sw.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
