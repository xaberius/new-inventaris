using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace New_Inventaris
{
    public partial class FrmSever : Form
    {
        ToolTip tool = new ToolTip();
        CoreEngine CE = new CoreEngine();
        public FrmSever()
        {
            InitializeComponent();
            
            // request server information and write in textbox
            Connect con = CE.readSever();
            TxtServer.Text = con.Server;
            TxtUser.Text = con.UserName;
            TxtPass.Text = con.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // try to connect database server
            string con="server=" + TxtServer.Text + ";database=new-inventaris;  uid="+ TxtUser.Text +";password="+ TxtPass.Text +";";
            string trycon = CE.konek(con);
            if (trycon == "a")
            {
                MessageBox.Show("Database Connected.");
                CE.writeServer(TxtServer.Text, TxtUser.Text, TxtPass.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show(trycon);
            }
        }

        private void FrmSever_Load(object sender, EventArgs e)
        {
            
        }
    }
}
