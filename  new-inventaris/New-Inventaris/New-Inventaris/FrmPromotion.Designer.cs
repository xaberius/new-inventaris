namespace New_Inventaris
{
    partial class FrmPromotion
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.CmbOffice = new System.Windows.Forms.ComboBox();
            this.CmbEmployee = new System.Windows.Forms.ComboBox();
            this.CmbTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbOfficeInfo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdQuit = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.TxtFrom = new System.Windows.Forms.TextBox();
            this.CmdRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3});
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.Location = new System.Drawing.Point(19, 111);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.Size = new System.Drawing.Size(625, 217);
            this.Grid.TabIndex = 89;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Reposition Date";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Employee name";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "From";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "To";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Aachen BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 90;
            this.label7.Text = "Reposition";
            // 
            // Image1
            // 
            this.Image1.Image = global::New_Inventaris.Properties.Resources.Form1;
            this.Image1.Location = new System.Drawing.Point(2, 2);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(665, 397);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image1.TabIndex = 91;
            this.Image1.TabStop = false;
            // 
            // CmbOffice
            // 
            this.CmbOffice.FormattingEnabled = true;
            this.CmbOffice.Location = new System.Drawing.Point(167, 162);
            this.CmbOffice.Name = "CmbOffice";
            this.CmbOffice.Size = new System.Drawing.Size(121, 21);
            this.CmbOffice.TabIndex = 92;
            this.CmbOffice.DropDown += new System.EventHandler(this.CmbOffice_DropDown);
            this.CmbOffice.SelectedValueChanged += new System.EventHandler(this.CmbOffice_SelectedValueChanged);
            // 
            // CmbEmployee
            // 
            this.CmbEmployee.FormattingEnabled = true;
            this.CmbEmployee.Location = new System.Drawing.Point(167, 189);
            this.CmbEmployee.Name = "CmbEmployee";
            this.CmbEmployee.Size = new System.Drawing.Size(121, 21);
            this.CmbEmployee.TabIndex = 93;
            this.CmbEmployee.SelectedValueChanged += new System.EventHandler(this.CmbEmployee_SelectedValueChanged);
            // 
            // CmbTo
            // 
            this.CmbTo.FormattingEnabled = true;
            this.CmbTo.Location = new System.Drawing.Point(167, 243);
            this.CmbTo.Name = "CmbTo";
            this.CmbTo.Size = new System.Drawing.Size(121, 21);
            this.CmbTo.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Office";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(66, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Employee name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(66, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(66, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "To";
            // 
            // CmbOfficeInfo
            // 
            this.CmbOfficeInfo.FormattingEnabled = true;
            this.CmbOfficeInfo.Location = new System.Drawing.Point(502, 84);
            this.CmbOfficeInfo.Name = "CmbOfficeInfo";
            this.CmbOfficeInfo.Size = new System.Drawing.Size(121, 21);
            this.CmbOfficeInfo.TabIndex = 100;
            this.CmbOfficeInfo.DropDown += new System.EventHandler(this.CmbOfficeInfo_DropDown);
            this.CmbOfficeInfo.SelectedValueChanged += new System.EventHandler(this.CmbOfficeInfo_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Office";
            // 
            // CmdQuit
            // 
            this.CmdQuit.Location = new System.Drawing.Point(564, 334);
            this.CmdQuit.Name = "CmdQuit";
            this.CmdQuit.Size = new System.Drawing.Size(75, 23);
            this.CmdQuit.TabIndex = 108;
            this.CmdQuit.Text = "&Quit";
            this.CmdQuit.UseVisualStyleBackColor = true;
            this.CmdQuit.Click += new System.EventHandler(this.CmdQuit_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(402, 334);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 106;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(483, 334);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 107;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(27, 334);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(75, 23);
            this.CmdAdd.TabIndex = 104;
            this.CmdAdd.Text = "&Add New";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // TxtFrom
            // 
            this.TxtFrom.Enabled = false;
            this.TxtFrom.Location = new System.Drawing.Point(167, 217);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.Size = new System.Drawing.Size(121, 20);
            this.TxtFrom.TabIndex = 109;
            // 
            // CmdRefresh
            // 
            this.CmdRefresh.Location = new System.Drawing.Point(108, 334);
            this.CmdRefresh.Name = "CmdRefresh";
            this.CmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.CmdRefresh.TabIndex = 110;
            this.CmdRefresh.Text = "&Refresh";
            this.CmdRefresh.UseVisualStyleBackColor = true;
            this.CmdRefresh.Click += new System.EventHandler(this.CmdRefresh_Click);
            // 
            // FrmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 402);
            this.Controls.Add(this.CmdRefresh);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.TxtFrom);
            this.Controls.Add(this.CmdQuit);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbOfficeInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTo);
            this.Controls.Add(this.CmbEmployee);
            this.Controls.Add(this.CmbOffice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Image1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPromotion";
            this.Load += new System.EventHandler(this.FrmPromotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox CmbOffice;
        private System.Windows.Forms.ComboBox CmbEmployee;
        private System.Windows.Forms.ComboBox CmbTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbOfficeInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CmdQuit;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.TextBox TxtFrom;
        private System.Windows.Forms.Button CmdRefresh;
    }
}