﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core_Inventaris;
using MySql.Data.MySqlClient;

namespace New_Inventaris
{
    public partial class FrmUtama : Form
    {
        Connection Connection = new Connection();
        SystemCore SystemCore =new SystemCore();
        Insurance Insurance = new Insurance();

        private int X = 0;

        public FrmUtama()
        {
            InitializeComponent();            
        }

        private void genuineCheck()
        {
            if (!SystemCore.readSerialHardware())
            {
                MessageBox.Show("Aplication error please reinstall this program", "Critical Error.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FrmUtama_Load(object sender, EventArgs e)
        {
            List<string> Database = Connection.readSever();

            try
            {
                Connection.connection(Database[0], Database[1], Database[2]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database disconnect. Please contact your administrator.", "Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                Console.WriteLine(ex.Message);
            }            

            genuineCheck();
            toolStripStatusLabel2.Text = "";
            toolStripProgressBar1.AutoSize = false;
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel3.AutoSize = false;

            toolStripProgressBar1.Width = (StatusBarX.Width / 5) + 49;
            toolStripStatusLabel1.Width = (StatusBarX.Width / 4) - 69;
            toolStripStatusLabel2.Width = (StatusBarX.Width / 4) + 69;
            toolStripStatusLabel3.Width = (StatusBarX.Width / 4);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string Merk = " <== Xaberius Developer ==> ";                

            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text + Merk[X];
            this.X++;

            if (this.X == Merk.Length)
            {
                //toolStripStatusLabel2.Text = "";
                this.X = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value < toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Value + 1;                
            }
            else
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
            }
            //else if (toolStripProgressBar1.Value >= toolStripProgressBar1.Maximum)
            //{
            //    toolStripProgressBar1.Value = toolStripProgressBar1.Value - 10;
            //}

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value > toolStripProgressBar1.Minimum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Value - 1;
            }
            else
            {
                timer3.Enabled = true;
                timer4.Enabled = false;
            }
        }

        private void carInsuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            FrmInsurance FrmIns= new FrmInsurance();
            FrmIns.Show();
        }

        private void buildingInsuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open insurance menu
            FrmInsurance FrmIns = new FrmInsurance();
            FrmIns.Show(this);
        }

        private void typeInsuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open insurance type menu
            FrmInsuranceType FrmInsType = new FrmInsuranceType();
            FrmInsType.Show(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //open car type menu
            FrmCarType FrmCarType = new FrmCarType();
            FrmCarType.Show(this);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //open branch office menu
            FrmBranchOffice FrmBranchOffice = new FrmBranchOffice();
            FrmBranchOffice.Show(this);
        }

        private void occupationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open occupation menu
            FormOccupation FrmOccupation = new FormOccupation();
            FrmOccupation.Show(this);
        }

        private void employeeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open employee menu
            FrmEmployee FrmEmployee = new FrmEmployee();
            FrmEmployee.Show(this);
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open repositon menu
            FrmPromotion FrmPromotion = new FrmPromotion();
            FrmPromotion.Show(this);
        }

        private void translocationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //open replacement menu
            FrmReplacement FrmReplacement= new FrmReplacement();
            FrmReplacement.Show(this);
        }

    }
}
