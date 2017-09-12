namespace MiniAccess.GUI
{
    partial class frmCreateTable
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreateDatatbase = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtNameField = new System.Windows.Forms.TextBox();
            this.cboFieldType = new System.Windows.Forms.ComboBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblFieldType = new System.Windows.Forms.Label();
            this.btnAddFields = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnGoCreateDatabase = new System.Windows.Forms.Button();
            this.btnGoAddTable = new System.Windows.Forms.Button();
            this.btnGoAddFields = new System.Windows.Forms.Button();
            this.btnEndCreateDatabase = new System.Windows.Forms.Button();
            this.btnEndAddTable = new System.Windows.Forms.Button();
            this.btnEndAddFields = new System.Windows.Forms.Button();
            this.chkPrimaryKey = new System.Windows.Forms.CheckBox();
            this.lblCreateDatabase = new System.Windows.Forms.Label();
            this.lblAddTable = new System.Windows.Forms.Label();
            this.lblAddFields = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblWarningDatabase = new System.Windows.Forms.Label();
            this.lblWarningTable = new System.Windows.Forms.Label();
            this.lblWarningField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(332, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create Table";
            // 
            // btnCreateDatatbase
            // 
            this.btnCreateDatatbase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateDatatbase.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDatatbase.ForeColor = System.Drawing.Color.Black;
            this.btnCreateDatatbase.Location = new System.Drawing.Point(46, 76);
            this.btnCreateDatatbase.Name = "btnCreateDatatbase";
            this.btnCreateDatatbase.Size = new System.Drawing.Size(152, 44);
            this.btnCreateDatatbase.TabIndex = 3;
            this.btnCreateDatatbase.Text = "Create Database";
            this.btnCreateDatatbase.UseVisualStyleBackColor = false;
            this.btnCreateDatatbase.Click += new System.EventHandler(this.btnCreateDatatbase_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddTable.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.Color.Black;
            this.btnAddTable.Location = new System.Drawing.Point(46, 134);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(152, 44);
            this.btnAddTable.TabIndex = 4;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(211, 158);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(169, 20);
            this.txtTableName.TabIndex = 5;
            // 
            // txtNameField
            // 
            this.txtNameField.Location = new System.Drawing.Point(211, 219);
            this.txtNameField.Name = "txtNameField";
            this.txtNameField.Size = new System.Drawing.Size(169, 20);
            this.txtNameField.TabIndex = 9;
            // 
            // cboFieldType
            // 
            this.cboFieldType.FormattingEnabled = true;
            this.cboFieldType.Items.AddRange(new object[] {
            "Text",
            "Long",
            "Number",
            "Double",
            "Boolean"});
            this.cboFieldType.Location = new System.Drawing.Point(389, 218);
            this.cboFieldType.Name = "cboFieldType";
            this.cboFieldType.Size = new System.Drawing.Size(75, 21);
            this.cboFieldType.TabIndex = 10;
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldName.Location = new System.Drawing.Point(208, 195);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(83, 18);
            this.lblFieldName.TabIndex = 11;
            this.lblFieldName.Text = "Field Name";
            // 
            // lblFieldType
            // 
            this.lblFieldType.AutoSize = true;
            this.lblFieldType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldType.Location = new System.Drawing.Point(386, 194);
            this.lblFieldType.Name = "lblFieldType";
            this.lblFieldType.Size = new System.Drawing.Size(78, 18);
            this.lblFieldType.TabIndex = 12;
            this.lblFieldType.Text = "Field Type";
            // 
            // btnAddFields
            // 
            this.btnAddFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddFields.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFields.ForeColor = System.Drawing.Color.Black;
            this.btnAddFields.Location = new System.Drawing.Point(46, 195);
            this.btnAddFields.Name = "btnAddFields";
            this.btnAddFields.Size = new System.Drawing.Size(152, 44);
            this.btnAddFields.TabIndex = 13;
            this.btnAddFields.Text = "Add Fields";
            this.btnAddFields.UseVisualStyleBackColor = false;
            this.btnAddFields.Click += new System.EventHandler(this.btnAddFields_Click);
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPath.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(212, 81);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(168, 34);
            this.btnPath.TabIndex = 14;
            this.btnPath.Text = "Choose Name and Path";
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnGoCreateDatabase
            // 
            this.btnGoCreateDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGoCreateDatabase.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoCreateDatabase.ForeColor = System.Drawing.Color.Black;
            this.btnGoCreateDatabase.Location = new System.Drawing.Point(765, 75);
            this.btnGoCreateDatabase.Name = "btnGoCreateDatabase";
            this.btnGoCreateDatabase.Size = new System.Drawing.Size(58, 44);
            this.btnGoCreateDatabase.TabIndex = 3;
            this.btnGoCreateDatabase.Text = "Go";
            this.btnGoCreateDatabase.UseVisualStyleBackColor = false;
            this.btnGoCreateDatabase.Click += new System.EventHandler(this.btnGoCreateDatabase_Click);
            // 
            // btnGoAddTable
            // 
            this.btnGoAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGoAddTable.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoAddTable.ForeColor = System.Drawing.Color.Black;
            this.btnGoAddTable.Location = new System.Drawing.Point(765, 133);
            this.btnGoAddTable.Name = "btnGoAddTable";
            this.btnGoAddTable.Size = new System.Drawing.Size(58, 44);
            this.btnGoAddTable.TabIndex = 3;
            this.btnGoAddTable.Text = "Go";
            this.btnGoAddTable.UseVisualStyleBackColor = false;
            this.btnGoAddTable.Click += new System.EventHandler(this.btnGoAddTable_Click);
            // 
            // btnGoAddFields
            // 
            this.btnGoAddFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGoAddFields.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoAddFields.ForeColor = System.Drawing.Color.Black;
            this.btnGoAddFields.Location = new System.Drawing.Point(765, 194);
            this.btnGoAddFields.Name = "btnGoAddFields";
            this.btnGoAddFields.Size = new System.Drawing.Size(58, 44);
            this.btnGoAddFields.TabIndex = 3;
            this.btnGoAddFields.Text = "Go";
            this.btnGoAddFields.UseVisualStyleBackColor = false;
            this.btnGoAddFields.Click += new System.EventHandler(this.btnGoAddFields_Click);
            // 
            // btnEndCreateDatabase
            // 
            this.btnEndCreateDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEndCreateDatabase.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndCreateDatabase.ForeColor = System.Drawing.Color.Black;
            this.btnEndCreateDatabase.Location = new System.Drawing.Point(841, 75);
            this.btnEndCreateDatabase.Name = "btnEndCreateDatabase";
            this.btnEndCreateDatabase.Size = new System.Drawing.Size(57, 44);
            this.btnEndCreateDatabase.TabIndex = 3;
            this.btnEndCreateDatabase.Text = "End";
            this.btnEndCreateDatabase.UseVisualStyleBackColor = false;
            this.btnEndCreateDatabase.Click += new System.EventHandler(this.btnEndCreateDatabase_Click);
            // 
            // btnEndAddTable
            // 
            this.btnEndAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEndAddTable.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndAddTable.ForeColor = System.Drawing.Color.Black;
            this.btnEndAddTable.Location = new System.Drawing.Point(840, 133);
            this.btnEndAddTable.Name = "btnEndAddTable";
            this.btnEndAddTable.Size = new System.Drawing.Size(58, 44);
            this.btnEndAddTable.TabIndex = 3;
            this.btnEndAddTable.Text = "End";
            this.btnEndAddTable.UseVisualStyleBackColor = false;
            this.btnEndAddTable.Click += new System.EventHandler(this.btnEndAddTable_Click);
            // 
            // btnEndAddFields
            // 
            this.btnEndAddFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEndAddFields.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndAddFields.ForeColor = System.Drawing.Color.Black;
            this.btnEndAddFields.Location = new System.Drawing.Point(840, 194);
            this.btnEndAddFields.Name = "btnEndAddFields";
            this.btnEndAddFields.Size = new System.Drawing.Size(58, 44);
            this.btnEndAddFields.TabIndex = 3;
            this.btnEndAddFields.Text = "End";
            this.btnEndAddFields.UseVisualStyleBackColor = false;
            this.btnEndAddFields.Click += new System.EventHandler(this.btnEndAddFields_Click);
            // 
            // chkPrimaryKey
            // 
            this.chkPrimaryKey.AutoSize = true;
            this.chkPrimaryKey.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrimaryKey.Location = new System.Drawing.Point(470, 218);
            this.chkPrimaryKey.Name = "chkPrimaryKey";
            this.chkPrimaryKey.Size = new System.Drawing.Size(94, 19);
            this.chkPrimaryKey.TabIndex = 15;
            this.chkPrimaryKey.Text = "Primery Key";
            this.chkPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // lblCreateDatabase
            // 
            this.lblCreateDatabase.AutoSize = true;
            this.lblCreateDatabase.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblCreateDatabase.ForeColor = System.Drawing.Color.Black;
            this.lblCreateDatabase.Location = new System.Drawing.Point(10, 86);
            this.lblCreateDatabase.Name = "lblCreateDatabase";
            this.lblCreateDatabase.Size = new System.Drawing.Size(20, 24);
            this.lblCreateDatabase.TabIndex = 16;
            this.lblCreateDatabase.Text = "1";
            // 
            // lblAddTable
            // 
            this.lblAddTable.AutoSize = true;
            this.lblAddTable.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblAddTable.ForeColor = System.Drawing.Color.Black;
            this.lblAddTable.Location = new System.Drawing.Point(9, 144);
            this.lblAddTable.Name = "lblAddTable";
            this.lblAddTable.Size = new System.Drawing.Size(20, 24);
            this.lblAddTable.TabIndex = 16;
            this.lblAddTable.Text = "2";
            // 
            // lblAddFields
            // 
            this.lblAddFields.AutoSize = true;
            this.lblAddFields.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblAddFields.ForeColor = System.Drawing.Color.Black;
            this.lblAddFields.Location = new System.Drawing.Point(9, 205);
            this.lblAddFields.Name = "lblAddFields";
            this.lblAddFields.Size = new System.Drawing.Size(20, 24);
            this.lblAddFields.TabIndex = 16;
            this.lblAddFields.Text = "3";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(208, 134);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(85, 18);
            this.lblTableName.TabIndex = 6;
            this.lblTableName.Text = "Table Name";
            // 
            // lblWarningDatabase
            // 
            this.lblWarningDatabase.AutoSize = true;
            this.lblWarningDatabase.ForeColor = System.Drawing.Color.Red;
            this.lblWarningDatabase.Location = new System.Drawing.Point(576, 102);
            this.lblWarningDatabase.Name = "lblWarningDatabase";
            this.lblWarningDatabase.Size = new System.Drawing.Size(0, 13);
            this.lblWarningDatabase.TabIndex = 17;
            // 
            // lblWarningTable
            // 
            this.lblWarningTable.AutoSize = true;
            this.lblWarningTable.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTable.Location = new System.Drawing.Point(576, 155);
            this.lblWarningTable.Name = "lblWarningTable";
            this.lblWarningTable.Size = new System.Drawing.Size(0, 13);
            this.lblWarningTable.TabIndex = 17;
            // 
            // lblWarningField
            // 
            this.lblWarningField.AutoSize = true;
            this.lblWarningField.ForeColor = System.Drawing.Color.Red;
            this.lblWarningField.Location = new System.Drawing.Point(576, 224);
            this.lblWarningField.Name = "lblWarningField";
            this.lblWarningField.Size = new System.Drawing.Size(0, 13);
            this.lblWarningField.TabIndex = 17;
            // 
            // frmCreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 305);
            this.Controls.Add(this.lblWarningField);
            this.Controls.Add(this.lblWarningTable);
            this.Controls.Add(this.lblWarningDatabase);
            this.Controls.Add(this.lblAddFields);
            this.Controls.Add(this.lblAddTable);
            this.Controls.Add(this.lblCreateDatabase);
            this.Controls.Add(this.chkPrimaryKey);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnAddFields);
            this.Controls.Add(this.lblFieldType);
            this.Controls.Add(this.lblFieldName);
            this.Controls.Add(this.cboFieldType);
            this.Controls.Add(this.txtNameField);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.btnGoAddFields);
            this.Controls.Add(this.btnEndAddFields);
            this.Controls.Add(this.btnEndAddTable);
            this.Controls.Add(this.btnGoAddTable);
            this.Controls.Add(this.btnEndCreateDatabase);
            this.Controls.Add(this.btnGoCreateDatabase);
            this.Controls.Add(this.btnCreateDatatbase);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreateTable";
            this.Text = "frmCreateTable";
            this.Load += new System.EventHandler(this.frmCreateTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateDatatbase;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtNameField;
        private System.Windows.Forms.ComboBox cboFieldType;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblFieldType;
        private System.Windows.Forms.Button btnAddFields;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnGoCreateDatabase;
        private System.Windows.Forms.Button btnGoAddTable;
        private System.Windows.Forms.Button btnGoAddFields;
        private System.Windows.Forms.Button btnEndCreateDatabase;
        private System.Windows.Forms.Button btnEndAddTable;
        private System.Windows.Forms.Button btnEndAddFields;
        private System.Windows.Forms.CheckBox chkPrimaryKey;
        private System.Windows.Forms.Label lblCreateDatabase;
        private System.Windows.Forms.Label lblAddTable;
        private System.Windows.Forms.Label lblAddFields;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblWarningDatabase;
        private System.Windows.Forms.Label lblWarningTable;
        private System.Windows.Forms.Label lblWarningField;
    }
}