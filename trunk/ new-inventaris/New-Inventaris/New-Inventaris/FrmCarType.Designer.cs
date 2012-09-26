namespace New_Inventaris
{
    partial class FrmCarType
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
            this.TxtVariant = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
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
            this.Column2});
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.Location = new System.Drawing.Point(12, 14);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(625, 198);
            this.Grid.TabIndex = 35;
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
            this.Column5.HeaderText = "Type Name";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Variant";
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // TxtVariant
            // 
            this.TxtVariant.Location = new System.Drawing.Point(111, 79);
            this.TxtVariant.Name = "TxtVariant";
            this.TxtVariant.Size = new System.Drawing.Size(173, 20);
            this.TxtVariant.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Variant";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 53);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(173, 20);
            this.TxtName.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Type Name";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(111, 27);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Type ID";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(469, 218);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 33;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(550, 218);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 34;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(180, 218);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 32;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(99, 218);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(75, 23);
            this.CmdEdit.TabIndex = 31;
            this.CmdEdit.Text = "&Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(18, 218);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(75, 23);
            this.CmdAdd.TabIndex = 30;
            this.CmdAdd.Text = "&Add New";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // FrmCarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 254);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.TxtVariant);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarType";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox TxtVariant;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}