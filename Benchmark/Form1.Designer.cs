namespace Benchmark
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxLoadSort = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAppendToFile = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.tbxStaffID = new System.Windows.Forms.TextBox();
            this.lbxStaffs = new System.Windows.Forms.ListBox();
            this.tbxAnnualSalary = new System.Windows.Forms.TextBox();
            this.SortZA = new System.Windows.Forms.Button();
            this.tbxMonthlySalary = new System.Windows.Forms.TextBox();
            this.SortAZ = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbxSearchSave = new System.Windows.Forms.GroupBox();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.loadAndSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnDeleteSelect = new System.Windows.Forms.Button();
            this.gbxLoadSort.SuspendLayout();
            this.gbxSearchSave.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLoadSort
            // 
            this.gbxLoadSort.Controls.Add(this.btnDeleteSelect);
            this.gbxLoadSort.Controls.Add(this.btnAddNew);
            this.gbxLoadSort.Controls.Add(this.btnAppendToFile);
            this.gbxLoadSort.Controls.Add(this.btnAddToList);
            this.gbxLoadSort.Controls.Add(this.tbxStaffID);
            this.gbxLoadSort.Controls.Add(this.lbxStaffs);
            this.gbxLoadSort.Controls.Add(this.tbxAnnualSalary);
            this.gbxLoadSort.Controls.Add(this.SortZA);
            this.gbxLoadSort.Controls.Add(this.tbxMonthlySalary);
            this.gbxLoadSort.Controls.Add(this.SortAZ);
            this.gbxLoadSort.Controls.Add(this.tbxEmail);
            this.gbxLoadSort.Controls.Add(this.btnLoadFromFile);
            this.gbxLoadSort.Controls.Add(this.tbxName);
            this.gbxLoadSort.Controls.Add(this.lblName);
            this.gbxLoadSort.Controls.Add(this.lblAnnualSalary);
            this.gbxLoadSort.Controls.Add(this.lblMonthlySalary);
            this.gbxLoadSort.Controls.Add(this.lblStaffID);
            this.gbxLoadSort.Controls.Add(this.lblEmail);
            this.gbxLoadSort.Location = new System.Drawing.Point(11, 33);
            this.gbxLoadSort.Name = "gbxLoadSort";
            this.gbxLoadSort.Size = new System.Drawing.Size(720, 391);
            this.gbxLoadSort.TabIndex = 0;
            this.gbxLoadSort.TabStop = false;
            this.gbxLoadSort.Text = "Load and Sort";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(496, 202);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(106, 23);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAppendToFile
            // 
            this.btnAppendToFile.Location = new System.Drawing.Point(363, 20);
            this.btnAppendToFile.Name = "btnAppendToFile";
            this.btnAppendToFile.Size = new System.Drawing.Size(106, 23);
            this.btnAppendToFile.TabIndex = 5;
            this.btnAppendToFile.Text = "Append to File";
            this.btnAppendToFile.UseVisualStyleBackColor = true;
            this.btnAppendToFile.Click += new System.EventHandler(this.btnAppendToFile_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(608, 202);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(106, 23);
            this.btnAddToList.TabIndex = 5;
            this.btnAddToList.Text = "Add to List";
            this.ttpToolTips.SetToolTip(this.btnAddToList, "Save selected creature");
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // tbxStaffID
            // 
            this.tbxStaffID.Location = new System.Drawing.Point(593, 54);
            this.tbxStaffID.Name = "tbxStaffID";
            this.tbxStaffID.ReadOnly = true;
            this.tbxStaffID.Size = new System.Drawing.Size(121, 21);
            this.tbxStaffID.TabIndex = 4;
            this.ttpToolTips.SetToolTip(this.tbxStaffID, "Owner of selected creature");
            // 
            // lbxStaffs
            // 
            this.lbxStaffs.FormattingEnabled = true;
            this.lbxStaffs.HorizontalScrollbar = true;
            this.lbxStaffs.ItemHeight = 12;
            this.lbxStaffs.Location = new System.Drawing.Point(6, 45);
            this.lbxStaffs.Name = "lbxStaffs";
            this.lbxStaffs.Size = new System.Drawing.Size(463, 340);
            this.lbxStaffs.TabIndex = 1;
            this.ttpToolTips.SetToolTip(this.lbxStaffs, "Displays a list of creatures");
            this.lbxStaffs.SelectedIndexChanged += new System.EventHandler(this.lbxStaffs_SelectedIndexChanged);
            // 
            // tbxAnnualSalary
            // 
            this.tbxAnnualSalary.Location = new System.Drawing.Point(593, 164);
            this.tbxAnnualSalary.Name = "tbxAnnualSalary";
            this.tbxAnnualSalary.ReadOnly = true;
            this.tbxAnnualSalary.Size = new System.Drawing.Size(121, 21);
            this.tbxAnnualSalary.TabIndex = 4;
            // 
            // SortZA
            // 
            this.SortZA.Location = new System.Drawing.Point(273, 19);
            this.SortZA.Name = "SortZA";
            this.SortZA.Size = new System.Drawing.Size(84, 23);
            this.SortZA.TabIndex = 0;
            this.SortZA.Text = "SortNameZA";
            this.ttpToolTips.SetToolTip(this.SortZA, "Sort creatures ZA");
            this.SortZA.UseVisualStyleBackColor = true;
            this.SortZA.Click += new System.EventHandler(this.SortZA_Click);
            // 
            // tbxMonthlySalary
            // 
            this.tbxMonthlySalary.Location = new System.Drawing.Point(593, 137);
            this.tbxMonthlySalary.Name = "tbxMonthlySalary";
            this.tbxMonthlySalary.ReadOnly = true;
            this.tbxMonthlySalary.Size = new System.Drawing.Size(121, 21);
            this.tbxMonthlySalary.TabIndex = 4;
            this.ttpToolTips.SetToolTip(this.tbxMonthlySalary, "Age of selected creature");
            // 
            // SortAZ
            // 
            this.SortAZ.Location = new System.Drawing.Point(186, 19);
            this.SortAZ.Name = "SortAZ";
            this.SortAZ.Size = new System.Drawing.Size(81, 23);
            this.SortAZ.TabIndex = 0;
            this.SortAZ.Text = "SortNameAZ";
            this.ttpToolTips.SetToolTip(this.SortAZ, "Sort creatures AZ");
            this.SortAZ.UseVisualStyleBackColor = true;
            this.SortAZ.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(593, 110);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(121, 21);
            this.tbxEmail.TabIndex = 4;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(5, 19);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(175, 23);
            this.btnLoadFromFile.TabIndex = 0;
            this.btnLoadFromFile.Text = "Load From File";
            this.ttpToolTips.SetToolTip(this.btnLoadFromFile, "Loads a list of Creatures");
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(593, 83);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(121, 21);
            this.tbxName.TabIndex = 4;
            this.ttpToolTips.SetToolTip(this.tbxName, "Name of selected creature");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(545, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 14);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAnnualSalary.Location = new System.Drawing.Point(482, 168);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(105, 14);
            this.lblAnnualSalary.TabIndex = 3;
            this.lblAnnualSalary.Text = "Annual Salary:";
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMonthlySalary.Location = new System.Drawing.Point(475, 141);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(112, 14);
            this.lblMonthlySalary.TabIndex = 3;
            this.lblMonthlySalary.Text = "Monthly Salary:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStaffID.Location = new System.Drawing.Point(524, 57);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(63, 14);
            this.lblStaffID.TabIndex = 3;
            this.lblStaffID.Text = "StaffID:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmail.Location = new System.Drawing.Point(538, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 14);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // gbxSearchSave
            // 
            this.gbxSearchSave.Controls.Add(this.lbxSearchResults);
            this.gbxSearchSave.Controls.Add(this.btnSearch);
            this.gbxSearchSave.Controls.Add(this.tbxSearch);
            this.gbxSearchSave.Location = new System.Drawing.Point(737, 33);
            this.gbxSearchSave.Name = "gbxSearchSave";
            this.gbxSearchSave.Size = new System.Drawing.Size(462, 391);
            this.gbxSearchSave.TabIndex = 1;
            this.gbxSearchSave.TabStop = false;
            this.gbxSearchSave.Text = "Search and Save";
            // 
            // lbxSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.HorizontalScrollbar = true;
            this.lbxSearchResults.ItemHeight = 12;
            this.lbxSearchResults.Location = new System.Drawing.Point(6, 48);
            this.lbxSearchResults.Name = "lbxSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(445, 340);
            this.lbxSearchResults.TabIndex = 2;
            this.ttpToolTips.SetToolTip(this.lbxSearchResults, "Displays a list of creatures");
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(161, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.ttpToolTips.SetToolTip(this.btnSearch, "Search creatures list");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(6, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(149, 21);
            this.tbxSearch.TabIndex = 0;
            this.ttpToolTips.SetToolTip(this.tbxSearch, "Enter a search term");
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAndSortToolStripMenuItem,
            this.saveAndSearchToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1199, 25);
            this.mnsMenu.TabIndex = 2;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // loadAndSortToolStripMenuItem
            // 
            this.loadAndSortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.sortAZToolStripMenuItem,
            this.sortZAToolStripMenuItem});
            this.loadAndSortToolStripMenuItem.Name = "loadAndSortToolStripMenuItem";
            this.loadAndSortToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.loadAndSortToolStripMenuItem.Text = "Load and Sort";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loadToolStripMenuItem.Text = "LoadFromFile";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // sortAZToolStripMenuItem
            // 
            this.sortAZToolStripMenuItem.Name = "sortAZToolStripMenuItem";
            this.sortAZToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sortAZToolStripMenuItem.Text = "Sort AZ";
            this.sortAZToolStripMenuItem.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // sortZAToolStripMenuItem
            // 
            this.sortZAToolStripMenuItem.Name = "sortZAToolStripMenuItem";
            this.sortZAToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sortZAToolStripMenuItem.Text = "Sort ZA";
            this.sortZAToolStripMenuItem.Click += new System.EventHandler(this.SortZA_Click);
            // 
            // saveAndSearchToolStripMenuItem
            // 
            this.saveAndSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.saveAndSearchToolStripMenuItem.Name = "saveAndSearchToolStripMenuItem";
            this.saveAndSearchToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.saveAndSearchToolStripMenuItem.Text = "Save and Search";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveToolStripMenuItem.Text = "Append to file";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnAppendToFile_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 427);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(1199, 22);
            this.stsStatus.TabIndex = 3;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(44, 17);
            this.tslStatus.Text = "Ready";
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Location = new System.Drawing.Point(608, 25);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteSelect.TabIndex = 5;
            this.btnDeleteSelect.Text = "Delete Select";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnDeleteSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 449);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.gbxSearchSave);
            this.Controls.Add(this.gbxLoadSort);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "SD6503 Benchmark Application";
            this.gbxLoadSort.ResumeLayout(false);
            this.gbxLoadSort.PerformLayout();
            this.gbxSearchSave.ResumeLayout(false);
            this.gbxSearchSave.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLoadSort;
        private System.Windows.Forms.Button SortAZ;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button SortZA;
        private System.Windows.Forms.ListBox lbxStaffs;
        private System.Windows.Forms.GroupBox gbxSearchSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Label lblMonthlySalary;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox tbxStaffID;
        private System.Windows.Forms.TextBox tbxMonthlySalary;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem loadAndSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.ToolTip ttpToolTips;
        private System.Windows.Forms.TextBox tbxAnnualSalary;
        private System.Windows.Forms.Label lblAnnualSalary;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAppendToFile;
        private System.Windows.Forms.Button btnDeleteSelect;
    }
}

