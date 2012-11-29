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
    public partial class FormOccupation : Form
    {
        // variable definition
        Occupation Occupation = new Occupation();
        private Connection Connection = new Connection();
        private List<OccupationData> OccupationDatas;
        private Boolean Edit;
        private string Deleted;
       
        public FormOccupation()
        {
            InitializeComponent();
            // connect to database server
            if (!Occupation.toServer())
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
            OccupationDatas = Occupation.getData();
            Grid.Rows.Clear();
            foreach (var data in OccupationDatas)
            {
                Grid.Rows.Add(new string[] { data.Id, data.OccupationName, data.Explaination });
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

        public void clearField()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtExplanation.Text = "";
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            button(false);
            TxtId.Text = string.Format("occ-{0:D4}", OccupationDatas.Count + 1);
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            // editing mode
            if (Deleted != "")
            {
                foreach (var InsType in OccupationDatas)
                {
                    if (InsType.Id == Deleted)
                    {
                        TxtId.Text = InsType.Id;
                        TxtName.Text = InsType.OccupationName;
                        TxtExplanation.Text = InsType.Explaination;
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
                    Occupation.deleteData(Deleted);
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
                MessageBox.Show(Occupation.insertData(TxtId.Text, TxtName.Text, TxtExplanation.Text));
            }
            else
            {
                MessageBox.Show(Occupation.updatetData(TxtId.Text, TxtName.Text, TxtExplanation.Text));
            }

            refreshData();
            button(true);
            clearField();
        }

        private void CmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
