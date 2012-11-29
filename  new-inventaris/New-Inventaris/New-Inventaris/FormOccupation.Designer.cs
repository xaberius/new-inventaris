namespace New_Inventaris
{
    partial class FormOccupation
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
            this.CmdQuit = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtExplanation = new System.Windows.Forms.TextBox();
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
            this.Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdQuit
            // 
            this.CmdQuit.Location = new System.Drawing.Point(562, 315);
            this.CmdQuit.Name = "CmdQuit";
            this.CmdQuit.Size = new System.Drawing.Size(75, 23);
            this.CmdQuit.TabIndex = 77;
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
            this.Column2});
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.Location = new System.Drawing.Point(272, 111);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.Size = new System.Drawing.Size(625, 198);
            this.Grid.TabIndex = 69;
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
            this.Column5.HeaderText = "Occupation Name";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Expalaination";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // TxtExplanation
            // 
            this.TxtExplanation.Location = new System.Drawing.Point(166, 201);
            this.TxtExplanation.Name = "TxtExplanation";
            this.TxtExplanation.Size = new System.Drawing.Size(173, 20);
            this.TxtExplanation.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Expalaination";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(166, 175);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(173, 20);
            this.TxtName.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Occupation Name";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(166, 149);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Occupation ID";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(400, 315);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 67;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(481, 315);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 68;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(187, 315);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 66;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(106, 315);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(75, 23);
            this.CmdEdit.TabIndex = 65;
            this.CmdEdit.Text = "&Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(25, 315);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(75, 23);
            this.CmdAdd.TabIndex = 64;
            this.CmdAdd.Text = "&Add New";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Aachen BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 76;
            this.label7.Text = "Occupation";
            // 
            // Image
            // 
            this.Image.Image = global::New_Inventaris.Properties.Resources.Form1;
            this.Image.Location = new System.Drawing.Point(2, 0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(665, 397);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 80;
            this.Image.TabStop = false;
            // 
            // FormOccupation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 400);
            this.Controls.Add(this.CmdQuit);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.TxtExplanation);
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
            this.Controls.Add(this.Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOccupation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOccupation";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdQuit;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox TxtExplanation;
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
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}