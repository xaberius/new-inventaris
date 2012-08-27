using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core_Inventaris
{
    public partial class FrmLogin : Form
    {
        Connection Connection = new Connection();
        SystemCore SystemCore;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Connection.connection(TxtServer.Text, TxtUser.Text, TxtPass.Text))
            {
                MessageBox.Show("Database connected!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.writeServer(TxtServer.Text, TxtUser.Text, TxtPass.Text);
                SystemCore.writeSerialHardware();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Database = Connection.readSever();
            TxtServer.Text = Database[0];
            TxtUser.Text = Database[1];
            TxtPass.Text = Database[2];
        }
    }
}
