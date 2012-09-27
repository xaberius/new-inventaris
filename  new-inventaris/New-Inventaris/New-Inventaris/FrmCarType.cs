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
    public partial class FrmCarType : Form
    {
        // variable definition
        CartType CarType = new CartType();
        private Connection Connection = new Connection();
        private List<CarTypeData> CarDatas;
        private Boolean Edit;
        private string Deleted;

        public FrmCarType()
        {
            InitializeComponent();

            // connect to database server
            if (!CarType.toServer())
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
            CarDatas = CarType.getData();
            Grid.Rows.Clear();
            foreach (var data in CarDatas)
            {
                Grid.Rows.Add(new string[] { data.Id, data.TypeName, data.Variant });
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
            TxtId.Text = string.Format("car-{0:D4}", CarDatas.Count + 1);
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
                foreach (var InsType in CarDatas)
                {
                    if (InsType.Id == Deleted)
                    {
                        TxtId.Text = InsType.Id;
                        TxtName.Text = InsType.TypeName;
                        TxtVariant.Text = InsType.Variant;
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
                    CarType.deleteData(Deleted);
                    refreshData();
                }
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //take value of grid cell
            Deleted = Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //saving and updating data
            if (!Edit)
            {
                CarType.insertData(TxtId.Text, TxtName.Text, TxtVariant.Text);
            }
            else
            {
                CarType.updatetData(TxtId.Text, TxtName.Text, TxtVariant.Text);
            }

            refreshData();
            button(true);
            clearField();
        }

        public void clearField()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtVariant.Text = "";
        }

        private void CmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
