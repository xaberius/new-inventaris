using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core_Inventaris;
using System.Drawing.Drawing2D;

namespace New_Inventaris
{
    public partial class FrmInsurance : Form
    {
        // variable definition
        Insurance Insurance = new Insurance();
        Connection Connection = new Connection();
        private List<InsuranceData> InsDatas;
        private Boolean Edit;
        private int Code;
        private string Deleted, IDx, InsuranceNamex, Addressx, Cityx, Phonex, Contactx;

        public FrmInsurance(int Code)
        {
            InitializeComponent();

            if (Code == 1)
            {
                this.Text = "Car Insurance";
                this.Code = Code;
            }
            else
            {
                this.Text = "Building Insurance";
                this.Code = Code;
            }

            // connect to database server
            if (Insurance.toServer() != true)
            {
                this.Close();
            }
            else
            {
                this.Grid.Location = new Point(19, 111);
                Image.Height = this.Height + 1;
                Image.Width = this.Width + 1;
                refreshData();
            }
            Edit = false;
            Grid.Focus();
            Deleted = "";
        }

        public void refreshData()
        {
            // get all insurance data and display in grid
            InsDatas = Insurance.getData(this.Code);
            Grid.Rows.Clear();
            foreach (var data in InsDatas)
            {
                Grid.Rows.Add(new string[] { data.Id, data.Name, data.Address, data.City, data.Phone, data.Contact });
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

        private void FrmInsurance_Load(object sender, EventArgs e)
        {
            /*GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0,this.Width,this.Height);  
            Region region = new Region(path);  
            this.Region = region; */
            button(true);
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            button(false);
            //id set automatic
            if (Code == 1)
            {
                this.Text = "Car Insurance";
                TxtId.Text = string.Format("insc-{0:D4}", InsDatas.Count + 1);
            }
            else
            {
                this.Text = "Building Insurance";
                TxtId.Text = string.Format("insb-{0:D4}", InsDatas.Count + 1);
            }
            
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            button(true);
            refreshData();
            clearField();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            //command delete data
            if (Deleted != "")
            {
                if (MessageBox.Show("Are sure to delete this data?", "Delete", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    Insurance.deleteData(Deleted);
                    refreshData();
                }
            }
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            //editing mode
            TxtId.Enabled = false;
            if (Deleted != "")
            {
                Edit = true;
                TxtId.Text = IDx;
                TxtName.Text = InsuranceNamex;
                TxtAddress.Text = Addressx;
                TxtCity.Text = Cityx;
                TxtPhone.Text = Phonex;
                TxtContact.Text = Contactx;

                TxtId.Enabled = false;
                button(false);
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //command save and update data
            if (!Edit)
            {
                MessageBox.Show(Insurance.insertData(TxtId.Text, TxtName.Text, TxtAddress.Text, TxtCity.Text, TxtPhone.Text, TxtContact.Text,this.Code));
            }
            else
            {
                MessageBox.Show(Insurance.updatetData(TxtId.Text, TxtName.Text, TxtAddress.Text, TxtCity.Text, TxtPhone.Text, TxtContact.Text));
            }
            clearField();
            refreshData();
            button(true);            
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // take value of grid cell
            //take value of grid cell
            //MessageBox.Show(e.ColumnIndex.ToString() + " " + e.RowIndex.ToString());
            if (e.RowIndex > -1)
            {
                Deleted = Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                IDx = Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                InsuranceNamex = Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                Addressx = Grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                Cityx = Grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                Phonex = Grid.Rows[e.RowIndex].Cells[4].Value.ToString();
                Contactx = Grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            
        }

        public void clearField()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtAddress.Text = "";
            TxtCity.Text = "";
            TxtPhone.Text = "";
            TxtContact.Text = "";
        }

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void CmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
