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
    public partial class FrmBranchOffice : Form
    {
        BranchOffice BranchOffice = new BranchOffice();
        private Connection Connection = new Connection();
        private List<BranchOfficeData> BranchData;
        private Boolean Edit;
        private string Deleted;

        public FrmBranchOffice()
        {
            InitializeComponent();
            // connect to database server
            if (!BranchOffice.toServer())
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
            BranchData = BranchOffice.getData();
            Grid.Rows.Clear();
            foreach (var data in BranchData)
            {
                Grid.Rows.Add(new string[] { data.Id, data.BranchName, data.Address,data.Phone });
            }

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

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            button(false);
            TxtId.Text = string.Format("bo-{0:D4}", BranchData.Count + 1);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            button(true);
            clearField();
            refreshData();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            // editing mode
            if (Deleted != "")
            {
                foreach (var InsType in BranchData)
                {
                    if (InsType.Id == Deleted)
                    {
                        TxtId.Text = InsType.Id;
                        TxtName.Text = InsType.BranchName;
                        TxtAddress.Text = InsType.Address;
                        TxtPhone.Text = InsType.Phone;                        
                    }
                }

                button(false);
                Edit = true;
                TxtId.Enabled = false;
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            //command delete data
            if (Deleted != "")
            {
                if (MessageBox.Show("Are sure to delete this data?", "Delete", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BranchOffice.deleteData(Deleted);
                    refreshData();
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

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //saving and updating data
            if (!Edit)
            {
                MessageBox.Show(BranchOffice.insertData(TxtId.Text, TxtName.Text, TxtAddress.Text,TxtPhone.Text));
            }
            else
            {
                MessageBox.Show(BranchOffice.updatetData(TxtId.Text, TxtName.Text, TxtAddress.Text,TxtPhone.Text));
            }

            refreshData();
            button(true);
            clearField();
        }

        public void clearField()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtAddress.Text = "";
            TxtPhone.Text = "";
        }

        private void CmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
