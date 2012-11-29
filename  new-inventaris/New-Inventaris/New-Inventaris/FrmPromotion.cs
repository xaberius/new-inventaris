using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core_Inventaris;
using System.Threading;

namespace New_Inventaris
{
    public partial class FrmPromotion : Form
    {
        //variable definition
        Employee Employee = new Employee();
        Reposition Repostion = new Reposition();
        private Connection Connection = new Connection();
        private EmployeeComplete EmployeeComplete;
        private List<EmployeeData> EmployeeDatax = new List<EmployeeData>();
        private List<OccupationData> OccupationDatas = new List<OccupationData>();
        private List<BranchOfficeData> BranchOfficeDatas = new List<BranchOfficeData>();
        private List<RepositionData> RepositionDatas = new List<RepositionData>();
        private SystemCore SC = new SystemCore();
        private string FromOcc;
        

        public FrmPromotion()
        {
            InitializeComponent();
            // connect to database server
            if (!Repostion.toServer())
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
            OccupationDatas = EmployeeComplete.OD;
            BranchOfficeDatas = EmployeeComplete.BOD;

            // get reposition data from database with branch office as condition
            if (BranchOffice != "")
            {
                RepositionDatas = Repostion.getData(BranchOffice);
            }
            else
            {
                RepositionDatas = Repostion.getData("");
            }

            // get all insurance data and display in grid            

            Grid.Rows.Clear();
            //fill data grid with reposition data
            foreach (var data in RepositionDatas)
            {
                DateTime RD = SC.TimestampToLocal(data.RepositionDate);

                foreach (var DE in EmployeeDatax)
                {
                    if (data.EmployeeID == DE.Id)
                    {
                        EN = DE.Name;
                    }
                }

                foreach (var DO in OccupationDatas)
                {
                    if (data.From == DO.Id)
                    {
                        From = DO.OccupationName;
                    }
                }

                foreach (var DO in OccupationDatas)
                {
                    if (data.To == DO.Id)
                    {
                        To = DO.OccupationName;
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

        private void CmbOfficeInfo_DropDown(object sender, EventArgs e)
        {
            fillCmbOffice();
        }

        private void CmbOffice_DropDown(object sender, EventArgs e)
        {
            fillCmbOffice();
        }

        private void CmbOffice_SelectedValueChanged(object sender, EventArgs e)
        {
            DataSet invDataSet = new DataSet();
            //fill combobox employee with employee data in selected branch office

            invDataSet.Tables.Add("Employee");
            invDataSet.Tables["Employee"].Columns.Add("ID");
            invDataSet.Tables["Employee"].Columns.Add("EmployeeName");

            List<EmployeeData> Choosen = new List<EmployeeData>();

            foreach (EmployeeData data in EmployeeDatax)
            {
                if (data.BranchOffice == CmbOffice.SelectedValue.ToString())
                {
                    Choosen.Add(data);
                }
            }

            if (Choosen.Count() > 0)
            {
                for (int a = 0; a < Choosen.Count(); a++)
                {
                    //MessageBox.Show("data ke : " + a + " nama : " + EmployeeDatax[a].Name);
                    invDataSet.Tables["Employee"].Rows.Add();
                    invDataSet.Tables["Employee"].Rows[a][0] = Choosen[a].Id;
                    invDataSet.Tables["Employee"].Rows[a][1] = Choosen[a].Name;
                }

                CmbEmployee.DataSource = invDataSet;
                CmbEmployee.DisplayMember = "Employee.EmployeeName";
                CmbEmployee.ValueMember = "Employee.ID";
            }
            else
            {
                CmbEmployee.DataSource = null;
            }
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
                        foreach (var datax in OccupationDatas)
                        {
                            if (datax.Id == data.Occupation)
                            {
                                TxtFrom.Text = datax.OccupationName;
                                this.FromOcc = datax.Id;
                            }
                        }
                    }
                }

                //fill combobox occupation with occupation data except current occupation

                DataSet invDataSet = new DataSet();
                invDataSet.Tables.Add("Occupation");

                invDataSet.Tables["Occupation"].Columns.Add("ID");
                invDataSet.Tables["Occupation"].Columns.Add("OccupationName");

                List<OccupationData> Choosen = new List<OccupationData>();

                foreach (EmployeeData data in EmployeeDatax)
                {
                    if (data.Id == CmbEmployee.SelectedValue.ToString())
                    {
                        foreach (OccupationData datax in OccupationDatas)
                        {
                            if (data.Occupation != datax.Id)
                            {
                                Choosen.Add(datax);
                            }
                        }
                    }
                }

                for (int a = 0; a < Choosen.Count(); a++)
                {
                    invDataSet.Tables["Occupation"].Rows.Add();
                    invDataSet.Tables["Occupation"].Rows[a][0] = Choosen[a].Id;
                    invDataSet.Tables["Occupation"].Rows[a][1] = Choosen[a].OccupationName;
                }

                CmbTo.DataSource = invDataSet;
                CmbTo.DisplayMember = "Occupation.OccupationName";
                CmbTo.ValueMember = "Occupation.ID";
            }
            else
            {
                CmbTo.DataSource = null;
                TxtFrom.Text = "";
            }
        }

        public void clearField()
        {
            //clear field and commbo box
            CmbEmployee.Text= "";
            CmbOffice.Text = "";
            CmbTo.Text = "";
            TxtFrom.Text = "";
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            button(false);
        }

        private void FrmPromotion_Load(object sender, EventArgs e)
        {
            refreshData("");
            button(true);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            clearField();
            button(true);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            int RD = SC.LocalToTimestamp(DateTime.Now);
            Repostion.insertData(RD, CmbEmployee.SelectedValue.ToString(), FromOcc, CmbTo.SelectedValue.ToString(),CmbOffice.SelectedValue.ToString());
            clearField();
            button(true);
            refreshData("");
        }

        private void CmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbOfficeInfo_SelectedValueChanged(object sender, EventArgs e)
        {
            refreshData(CmbOfficeInfo.SelectedValue.ToString());
        }

        private void CmdRefresh_Click(object sender, EventArgs e)
        {
            refreshData("");
        }
    }
}
