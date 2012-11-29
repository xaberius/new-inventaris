namespace New_Inventaris
{
    partial class FrmBranchOffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranchOffice));
            this.CmdQuit = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdQuit
            // 
            this.CmdQuit.Location = new System.Drawing.Point(564, 349);
            this.CmdQuit.Name = "CmdQuit";
            this.CmdQuit.Size = new System.Drawing.Size(75, 23);
            this.CmdQuit.TabIndex = 58;
            this.CmdQuit.Text = "&Quit";
            this.CmdQuit.UseVisualStyleBackColor = true;
            this.CmdQuit.Click += new System.EventHandler(this.CmdQuit_Click);
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
            this.Grid.Location = new System.Drawing.Point(216, 132);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.Size = new System.Drawing.Size(625, 198);
            this.Grid.TabIndex = 50;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Type ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Branch Name";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Address";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(144, 215);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(173, 20);
            this.TxtAddress.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Address";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(144, 189);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(173, 20);
            this.TxtName.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Branch Office";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(144, 163);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Branch ID";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(402, 349);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 48;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(483, 349);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 49;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(189, 349);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 47;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(108, 349);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(75, 23);
            this.CmdEdit.TabIndex = 46;
            this.CmdEdit.Text = "&Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(27, 349);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(75, 23);
            this.CmdAdd.TabIndex = 45;
            this.CmdAdd.Text = "&Add New";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Branch Office";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Phone";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(144, 241);
            this.TxtPhone.Mask = "0000-000-000-000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(173, 20);
            this.TxtPhone.TabIndex = 63;
            // 
            // Image
            // 
            this.Image.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Image.ErrorImage")));
            this.Image.Image = global::New_Inventaris.Properties.Resources.Form1;
            this.Image.Location = new System.Drawing.Point(2, 1);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(665, 397);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 59;
            this.Image.TabStop = false;
            // 
            // FrmBranchOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 398);
            this.Controls.Add(this.CmdQuit);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBranchOffice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdQuit;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.PictureBox Image;
    }
}