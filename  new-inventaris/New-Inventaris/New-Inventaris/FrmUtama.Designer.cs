﻿namespace New_Inventaris
{
    partial class FrmUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insuranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carInsuranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingInsuranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeInsuranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBarX = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.StatusBarX.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insuranceToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // insuranceToolStripMenuItem
            // 
            this.insuranceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carInsuranceToolStripMenuItem,
            this.buildingInsuranceToolStripMenuItem,
            this.typeInsuranceToolStripMenuItem});
            this.insuranceToolStripMenuItem.Name = "insuranceToolStripMenuItem";
            this.insuranceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insuranceToolStripMenuItem.Text = "Insurance";
            // 
            // carInsuranceToolStripMenuItem
            // 
            this.carInsuranceToolStripMenuItem.Name = "carInsuranceToolStripMenuItem";
            this.carInsuranceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.carInsuranceToolStripMenuItem.Text = "Car Insurance";
            this.carInsuranceToolStripMenuItem.Click += new System.EventHandler(this.carInsuranceToolStripMenuItem_Click);
            // 
            // buildingInsuranceToolStripMenuItem
            // 
            this.buildingInsuranceToolStripMenuItem.Name = "buildingInsuranceToolStripMenuItem";
            this.buildingInsuranceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.buildingInsuranceToolStripMenuItem.Text = "Building Insurance";
            // 
            // typeInsuranceToolStripMenuItem
            // 
            this.typeInsuranceToolStripMenuItem.Name = "typeInsuranceToolStripMenuItem";
            this.typeInsuranceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.typeInsuranceToolStripMenuItem.Text = "Type Insurance";
            //
            // 


            // StatusBarX
            // 
            this.StatusBarX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3});
            this.StatusBarX.Location = new System.Drawing.Point(0, 308);
            this.StatusBarX.Name = "StatusBarX";
            this.StatusBarX.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusBarX.Size = new System.Drawing.Size(471, 22);
            this.StatusBarX.TabIndex = 1;
            this.StatusBarX.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "User : ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(187, 17);
            this.toolStripStatusLabel2.Text = "<== Xaberius Developer ==>";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel3.Text = "Date Time";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 50;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::New_Inventaris.Properties.Resources.internet_business_23_wallpaper_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 330);
            this.Controls.Add(this.StatusBarX);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusBarX.ResumeLayout(false);
            this.StatusBarX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip StatusBarX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem insuranceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carInsuranceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingInsuranceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeInsuranceToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

