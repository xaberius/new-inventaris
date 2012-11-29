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
    public partial class FrmEmployee : Form
    {
        Employee Employee = new Employee();
        private Connection Connection = new Connection();
        private EmployeeComplete EmployeeComplete;
        private List<EmployeeData> EmployeeDatax = new List<EmployeeData>();
        private List<OccupationData> OccupationDatas;
        private List<BranchOfficeData> BranchOfficeDatas;
        private SystemCore SC = new SystemCore();
        private Boolean Edit;
        private string Deleted;

        public FrmEmployee()
        {
            InitializeComponent();
            // connect to database server
            if (!Employee.toServer())
            {
                this.Close();
            }
            else
            {
                this.Grid.Location = new Point(19, 111);
                refreshData();
            }
            Edit = false;
            Grid.Focus();
            Deleted = "";
        }

        public void refreshData()
        {
            // get all insurance data and display in grid
            EmployeeComplete = Employee.getData();
            Grid.Rows.Clear();
            EmployeeDatax = EmployeeComplete.ED;
            OccupationDatas = EmployeeComplete.OD;
            BranchOfficeDatas = EmployeeComplete.BOD;

            //fill data grid with employee data
            foreach (var data in EmployeeComplete.ED)
            {
                string OccupationName = "";
                string BranchName = "";

                foreach (var data1 in EmployeeComplete.OD)
                {
                    if (data1.Id == data.Occupation)
                    {
                        OccupationName = data1.OccupationName;
                    }
                }

                foreach (var data1 in EmployeeComplete.BOD)
                {
                    if (data1.Id == data.BranchOffice)
                    {
                        BranchName = data1.BranchName;
                    }
                }

                DateTime JoinDate = SC.TimestampToLocal(data.JoinDate);

                Grid.Rows.Add(new string[] { data.Id, data.Name, data.Address, JoinDate.ToString("dd MMMM yyyy"),
                    OccupationName,BranchName });
            }


            //fill combobox occupation with occupation data

            DataSet invDataSet = new DataSet();
            invDataSet.Tables.Add("Occupation");

            invDataSet.Tables["Occupation"].Columns.Add("ID");
            invDataSet.Tables["Occupation"].Columns.Add("OccupationName");

            for(int a=0; a < OccupationDatas.Count(); a++)
            {
                invDataSet.Tables["Occupation"].Rows.Add();
                invDataSet.Tables["Occupation"].Rows[a][0] = OccupationDatas[a].Id;
                invDataSet.Tables["Occupation"].Rows[a][1] = OccupationDatas[a].OccupationName;
            }
            
            CmbOccupation.DataSource = invDataSet;
            CmbOccupation.DisplayMember = "Occupation.OccupationName";
            CmbOccupation.ValueMember = "Occupation.ID";

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

            CmbBranchOffice.DataSource = invDataSet;
            CmbBranchOffice.DisplayMember = "BranchOffice.BranchName";
            CmbBranchOffice.ValueMember = "BranchOffice.ID";

        }

        public void button(bool Status)
        {
            // button visible
            CmdAdd.Visible = Status;
            CmdEdit.Visible = Status;
            CmdDelete.Visible = Status;
            Grid.Visible = Status;

            CmdSave.Visible = !Status;
            CmdCancel.Visible = !Status;
        }

        public void clearField()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtBirthDate.Value = DateTime.Now;
            TxtAddress.Text = "";
            TxtJoinDate.Value = DateTime.Now;
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            button(false);
            TxtId.Text = string.Format("emp-{0:D4}", EmployeeDatax.Count + 1);
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {   
            // editing mode
            if (Deleted != "")
            {
                foreach (var InsType in EmployeeDatax)
                {
                    if (InsType.Id == Deleted)
                    {
                        DateTime bd = SC.TimestampToLocal(InsType.BrithDate);
                        DateTime jd = SC.TimestampToLocal(InsType.JoinDate);

                        TxtId.Text = InsType.Id;
                        TxtName.Text = InsType.Name;
                        TxtBirthDate.Value = bd;
                        TxtAddress.Text = InsType.Address;
                        TxtJoinDate.Value = jd;

                        foreach (var data in BranchOfficeDatas)
                        {
                            if (data.Id == InsType.BranchOffice)
                            {
                                CmbBranchOffice.Text = data.BranchName;
                            }
                        }

                        foreach (var data in OccupationDatas)
                        {
                            if (data.Id == InsType.Occupation)
                            {
                                CmbBranchOffice.Text = data.OccupationName;
                            }
                        }

                    }
                    button(false);
                    Edit = true;
                    TxtId.Enabled = false;
                    CmbBranchOffice.Enabled = false;
                    CmbOccupation.Enabled = false;
                }                
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //take value of grid cell
            //MessageBox.Show(e.ColumnIndex.ToString() + " " + e.RowIndex.ToString());
            if (e.RowIndex > -1)
            {
                Deleted = Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            button(true);
            CmbOccupation.Enabled = true;
            CmbBranchOffice.Enabled = true;
            refreshData();
            clearField();
        }

        private void CmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            //command delete data
            if (Deleted != "")
            {
                if (MessageBox.Show("Are sure to delete this data?", "Delete", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    Employee.deleteData(Deleted);
                    refreshData();
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //saving and updating data
            if (!Edit)
            {
                int bd = SC.LocalToTimestamp(TxtBirthDate.Value);
                int jd = SC.LocalToTimestamp(TxtJoinDate.Value);
                Employee.insertData(TxtId.Text, TxtName.Text, bd, TxtAddress.Text, jd, CmbOccupation.SelectedValue.ToString(), CmbBranchOffice.SelectedValue.ToString());
            }
            else
            {
                int bd = SC.LocalToTimestamp(TxtBirthDate.Value);
                Employee.updatetData(TxtId.Text, TxtName.Text, bd, TxtAddress.Text);
                CmbBranchOffice.Enabled = true;
                CmbOccupation.Enabled = true;
            }

            refreshData();
            button(true);
            clearField();
        }



    }
}
