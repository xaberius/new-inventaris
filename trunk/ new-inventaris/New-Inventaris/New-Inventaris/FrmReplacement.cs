using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core_Inventaris;

namespace New_Inventaris
{
    public partial class FrmReplacement : Form
    {
        //variable definition
        Employee Employee = new Employee();
        Replacement Replacement = new Replacement();
        private Connection Connection = new Connection();
        private EmployeeComplete EmployeeComplete;
        private List<EmployeeData> EmployeeDatax = new List<EmployeeData>();
        private List<BranchOfficeData> BranchOfficeDatas = new List<BranchOfficeData>();
        private List<ReplacementData> ReplacementDatas = new List<ReplacementData>();
        private SystemCore SC = new SystemCore();
        private string FromBO;

        public FrmReplacement()
        {
            InitializeComponent();
            if (!Replacement.toServer())
            {
                this.Close();
            }
            else if (!Employee.toServer())
            {
                this.Close();
            }
            else
            {
                this.Grid.Location = new Point(19, 111);
            }
            Grid.Focus();
        }

        public void button(bool button)
        {
            //visible on invisible component
            CmdAdd.Visible = button;
            CmdSave.Visible = !button;
            CmdCancel.Visible = !button;
            Grid.Visible = button;

            label5.Visible = button;
            CmbOfficeInfo.Visible = button;
            CmdRefresh.Visible = button;

        }

        public void refreshData(string BranchOffice)
        {
            // refresh data from database
            string EN = "";
            string From = "";
            string To = "";

            //get employee,branchOffice and occupation data
            EmployeeComplete = Employee.getData();
            EmployeeDatax = EmployeeComplete.ED;
            BranchOfficeDatas = EmployeeComplete.BOD;

            // get reposition data from database with branch office as condition
            if (BranchOffice != "")
            {
                ReplacementDatas = Replacement.getData(BranchOffice);
            }
            else
            {
                ReplacementDatas = Replacement.getData("");
            }

            // get all insurance data and display in grid            

            Grid.Rows.Clear();
            //fill data grid with reposition data
            foreach (var data in ReplacementDatas)
            {
                DateTime RD = SC.TimestampToLocal(data.ReplacementDate);

                foreach (var DE in EmployeeDatax)
                {
                    if (data.EmployeeID == DE.Id)
                    {
                        EN = DE.Name;
                    }
                }

                foreach (var BO in BranchOfficeDatas)
                {
                    if (data.From == BO.Id)
                    {
                        From = BO.BranchName;
                    }
                }

                Grid.Rows.Add(new string[] { RD.ToString("dd MMMM yyyy"), EN, From, To });
            }
        }

        public void fillCmbOffice()
        {
            DataSet invDataSet = new DataSet();
            //fill combobox branch office with branch office data

            invDataSet.Tables.Add("BranchOffice");
            invDataSet.Tables["BranchOffice"].Columns.Add("ID");
            invDataSet.Tables["BranchOffice"].Columns.Add("BranchName");

            for (int a = 0; a < BranchOfficeDatas.Count(); a++)
            {
                invDataSet.Tables["BranchOffice"].Rows.Add();
                invDataSet.Tables["BranchOffice"].Rows[a][0] = BranchOfficeDatas[a].Id;
                invDataSet.Tables["BranchOffice"].Rows[a][1] = BranchOfficeDatas[a].BranchName;
            }

            CmbOfficeInfo.DataSource = invDataSet;
            CmbOfficeInfo.DisplayMember = "BranchOffice.BranchName";
            CmbOfficeInfo.ValueMember = "BranchOffice.ID";

            CmbOffice.DataSource = invDataSet;
            CmbOffice.DisplayMember = "BranchOffice.BranchName";
            CmbOffice.ValueMember = "BranchOffice.ID";
        }

        private void CmbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            //visible employee's current occupation 
            if (CmbEmployee.SelectedIndex > -1 && CmbEmployee.Text != "")
            {
                foreach (var data in EmployeeDatax)
                {
                    if (data.Id == CmbEmployee.SelectedValue.ToString())
                    {
                        foreach (var datax in BranchOfficeDatas)
                        {
                            if (datax.Id == data.BranchOffice)
                            {
                                TxtFrom.Text = datax.BranchName;
                                this.FromBO = datax.Id;
                            }
                        }
                    }
                }
            }
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            button(true);
        }

        private void CmbEmployee_DropDown(object sender, EventArgs e)
        {
            DataSet invDataSet = new DataSet();
            //fill combobox branch office with branch office data

            invDataSet.Tables.Add("Employee");
            invDataSet.Tables["Employee"].Columns.Add("ID");
            invDataSet.Tables["Employee"].Columns.Add("Name");

            for (int a = 0; a < BranchOfficeDatas.Count(); a++)
            {
                invDataSet.Tables["Employee"].Rows.Add();
                invDataSet.Tables["Employee"].Rows[a][0] = BranchOfficeDatas[a].Id;
                invDataSet.Tables["Employee"].Rows[a][1] = BranchOfficeDatas[a].BranchName;
            }

            CmbOfficeInfo.DataSource = invDataSet;
            CmbOfficeInfo.DisplayMember = "Employee.hName";
            CmbOfficeInfo.ValueMember = "Employee.ID";
        }

    }
}
