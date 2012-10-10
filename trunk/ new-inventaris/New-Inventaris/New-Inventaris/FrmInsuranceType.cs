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
    public partial class FrmInsuranceType : Form
    {
        // variable definition
        InsuranceType InsuranceType = new InsuranceType();
        private Connection Connection = new Connection();
        private List<InsuranceTypeData> InsDatas;
        private Boolean Edit;
        private string Deleted;

        public FrmInsuranceType()
        {
            InitializeComponent();

            // connect to database server
            if (!InsuranceType.toServer()) 
            {
                this.Close();
            }
            else
            {
                this.Grid.Location = new Point(19,111);
                refreshData();
            }
            Edit = false;
            Grid.Focus();
            Deleted = "";
            
        }

        public void refreshData()
        {
            // get all insurance data and display in grid
            InsDatas = InsuranceType.getData();
            Grid.Rows.Clear();
            foreach (var data in InsDatas)
            {
                Grid.Rows.Add(new string[] { data.Id, data.TypeName, data.Explain });
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

        private void FrmInsuranceType_Load(object sender, EventArgs e)
        {
            button(true);
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            button(false);
            TxtId.Text = string.Format("type-{0:D4}", InsDatas.Count + 1);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            button(true);
            refreshData();
            clearField();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {           
            // editing mode
            if (Deleted != "")
            {
                foreach (var InsType in InsDatas)
                {
                    if (InsType.Id == Deleted)
                    {
                        TxtId.Text = InsType.Id;
                        TxtName.Text = InsType.TypeName;
                        TxtExplain.Text = InsType.Explain;
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
                    InsuranceType.deleteData(Deleted);
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
                InsuranceType.insertData(TxtId.Text, TxtName.Text, TxtExplain.Text);
            }
            else
            {
                InsuranceType.updatetData(TxtId.Text, TxtName.Text, TxtExplain.Text);
            }

            refreshData();
            button(true);
            clearField();
        }

        public void clearField()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtExplain.Text = "";
        }

        private void CmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
