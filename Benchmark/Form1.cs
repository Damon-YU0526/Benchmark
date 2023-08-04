using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benchmark
{
    public partial class Form1 : Form
    {
        //private List<Staff> staffs = new List<Staff>();
        private MyClass myClass = new MyClass();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load staff list data from txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            var fileStaffs = fm.LoadStaffs();

            if (fileStaffs == null)
            {
                MessageBox.Show("Error Loading Staffs", "File IO Error");
                return;
            }

            myClass.ReloadFileStaff(fileStaffs);

            lbxStaffs.Items.Clear();
            lbxStaffs.Items.AddRange(myClass.GetCurrentStaffs().ToArray());
        }

        /// <summary>
        /// Sort the staff list by staff name ascending.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortAZ_Click(object sender, EventArgs e)
        {
            Filter sFilter = new Filter();

            var staffs = sFilter.SortAZByName(myClass.GetCurrentStaffs());

            lbxStaffs.Items.Clear();
            lbxStaffs.Items.AddRange(staffs.ToArray());
        }

        /// <summary>
        /// Sort the staff list by staff name descending.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortZA_Click(object sender, EventArgs e)
        {
            Filter sFilter = new Filter();

            var staffs = sFilter.SortZAByName(myClass.GetCurrentStaffs());

            lbxStaffs.Items.Clear();
            lbxStaffs.Items.AddRange(staffs.ToArray());
        }

        /// <summary>
        /// Search for staffs by names based on a key word.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Staff> results = new List<Staff>();

            Filter sFilter = new Filter();

            string term = tbxSearch.Text;

            // We should check if the input content is not empty
            if (string.IsNullOrWhiteSpace(term))
            {
                MessageBox.Show("The search content should not be empty");
                return;
            }

            // I think this is important that make sure there is no other empty space besides it.
            term = term.Trim();

            results = sFilter.SearchByName(myClass.GetCurrentStaffs(), term);

            lbxSearchResults.Items.Clear();
            lbxSearchResults.Items.AddRange(results.ToArray());
        }

        /// <summary>
        /// This method is just used to clear the text boxes, and make the text boxes enabled(not readonly).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbxStaffID.ReadOnly = false;
            tbxStaffID.Text = string.Empty;
            tbxName.ReadOnly = false;
            tbxName.Text = string.Empty;
            tbxEmail.ReadOnly = false;
            tbxEmail.Text = string.Empty;
            tbxMonthlySalary.ReadOnly = false;
            tbxMonthlySalary.Text = string.Empty;

            // Because the annual salary will be calculated by monthly salary, so we should not edit it.
            tbxAnnualSalary.ReadOnly = true;
            tbxAnnualSalary.Text = string.Empty;
        }

        /// <summary>
        /// Add the new staff into the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxStaffID.Text))
            {
                MessageBox.Show("StaffID should not be empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxName.Text))
            {
                MessageBox.Show("Name should not be empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxEmail.Text))
            {
                MessageBox.Show("Email should not be empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxMonthlySalary.Text))
            {
                MessageBox.Show("MonthlySalary should not be empty");
                return;
            }

            if (!myClass.CheckStaffIDValid(tbxStaffID.Text.Trim()))
            {
                MessageBox.Show("The length of StaffID should be 6");
                return;
            }

            if (!myClass.CheckStaffName(tbxName.Text.Trim()))
            {
                MessageBox.Show("The length of Name should not be less than 3");
                return;
            }

            if (!myClass.CheckStaffEmail(tbxEmail.Text.Trim()))
            {
                MessageBox.Show("The email is not valid");
                return;
            }

            int msalary;
            if (!int.TryParse(tbxMonthlySalary.Text.Trim(), out msalary))
            {
                MessageBox.Show("The monthly salary should be integer");
                return;
            }

            if (!myClass.CheckStaffMonthlySalary(msalary))
            {
                MessageBox.Show("MonthlySalary should not be less than 1500");
                return;
            }

            Staff newStaff = new Staff(tbxStaffID.Text.Trim(), tbxName.Text.Trim(), tbxEmail.Text.Trim(), msalary);

            // Check if the staff exist, we will check it by staffID.
            if (myClass.CheckIfStaffExist(newStaff))
            {
                MessageBox.Show("Current staff is exist");
                return;
            }

            myClass.AddStaff(newStaff);

            lbxStaffs.Items.Clear();
            lbxStaffs.Items.AddRange(myClass.GetCurrentStaffs().ToArray());

            MessageBox.Show("Add staff success");

            btnAddNew_Click(null, null);
        }

        /// <summary>
        /// Delete the one staff you selected in the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            // You must select one item first, after you select one item, the text box will be readonly and the staffID will not be empty.
            if (lbxStaffs.SelectedItem == null|| !tbxStaffID.ReadOnly || string.IsNullOrWhiteSpace(tbxStaffID.Text))
            {
                MessageBox.Show("Please select one staff first");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure to delete?", "Remind", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                Staff s = (Staff)lbxStaffs.SelectedItem;

                myClass.DeleteStaff(s);

                // Reload the staffs in list box.
                lbxStaffs.Items.Clear();
                lbxStaffs.Items.AddRange(myClass.GetCurrentStaffs().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }


        /// <summary>
        /// After you select one satff in list box, we should load the data into the text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxStaffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // In case you click the side or some wrong place.
            if (lbxStaffs.SelectedItem == null)
            {
                return;
            }

            try
            {
                Staff s = (Staff)lbxStaffs.SelectedItem;

                tbxStaffID.Text = s.StaffID;
                tbxName.Text = s.Name;
                tbxEmail.Text = s.Email;
                tbxMonthlySalary.Text = s.MonthlySalary.ToString();
                tbxAnnualSalary.Text = s.AnnualSalary.ToString();

                tbxStaffID.ReadOnly = true;
                tbxName.ReadOnly = true;
                tbxEmail.ReadOnly = true;
                tbxMonthlySalary.ReadOnly = true;
                tbxAnnualSalary.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        /// <summary>
        /// Append the staffs in list box but not in the text file into the end of existed data in text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAppendToFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to append staffs to file?", "Remind", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
            {
                return;
            }

            var currentStaffs = this.myClass.GetCurrentStaffs();

            FileManager fm = new FileManager();
            var fileStaffs = fm.LoadStaffs();

            if (fileStaffs == null)
            {
                MessageBox.Show("Error Loading Staffs", "File IO Error");
                return;
            }

            List<Staff> appendList = new List<Staff>();

            foreach (var cs in currentStaffs)
            {
                // This is very important that we should make sure the staffID is not exist in the text file.
                // If staffID has already exist in the text file, we should not add it into the file.
                if (!fileStaffs.Any(fs => fs.StaffID == cs.StaffID))
                {
                    appendList.Add(cs);
                }
            }

            if (!fm.AppendStaffsToFile(appendList))
            {
                MessageBox.Show("Append failed");
            }
            else
            {
                MessageBox.Show("Append success");
            }
        }
    }
}
