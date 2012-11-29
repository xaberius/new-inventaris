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
    public partial class FrmInsurance : Form
    {
        Insurance Insurance = new Insurance();
        Connection Connection = new Connection();
        public FrmInsurance()
        {
            InitializeComponent();

            if (Insurance.toServer() != true)
            {
                this.Close();
            }
            else
            {
                this.Grid.Location = new Point(12, 12);
                refreshData();
            }
        }

        public void refreshData()
        {
            List<InsuranceData> InsDatas = new List<InsuranceData>();
            InsDatas = Insurance.getData(0);
            Grid.Items.Clear();
            foreach (var data in InsDatas)
            {
                Grid.Items.Add(new ListViewItem(new string[] { data.Id, data.Name, data.Address, data.City, data.Phone, data.Contact }));
            }
            
        }

        public void button(bool Status)
        {
            CmdAdd.Visible = Status;
            CmdEdit.Visible = Status;
            CmdDelete.Visible = Status;
            Grid.Visible = Status;

            CmdSave.Visible = !Status;
            CmdCancel.Visible = !Status;
        }

        private void FrmInsurance_Load(object sender, EventArgs e)
        {
            button(true);
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            button(false);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            button(true);
            refreshData();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            
        }

    }
}
