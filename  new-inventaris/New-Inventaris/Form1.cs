using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace New_Inventaris
{
    public partial class FrmSever : Form
    {
        ToolTip tool = new ToolTip();
        public FrmSever()
        {
            InitializeComponent();            
            tool.UseFading = true;
            tool.UseAnimation = true;

            tool.ShowAlways = true;
            tool.AutoPopDelay = 0;
            tool.InitialDelay = 0;
            tool.ReshowDelay = 0;
            tool.SetToolTip(label1, "IP Server (ex = 192.168.1.100,localhost)");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
