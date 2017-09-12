namespace MiniAccess.GUI
{
    partial class frmRelatioship
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
            this.lblOpenDatabase = new System.Windows.Forms.Label();
            this.btnOpenDatabase = new System.Windows.Forms.Button();
            this.lsdTablePrimaryKey = new System.Windows.Forms.ListBox();
            this.lsdTableForeignKey = new System.Windows.Forms.ListBox();
            this.lblPrimaryKey = new System.Windows.Forms.Label();
            this.lblForeignKey = new System.Windows.Forms.Label();
            this.lsdFieldForeignKey = new System.Windows.Forms.ListBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.lsdFieldPrimaryKey = new System.Windows.Forms.ListBox();
            this.txtNameRelationship = new System.Windows.Forms.TextBox();
            this.lblNameRelationship = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDirectionPrimary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpenDatabase
            // 
            this.lblOpenDatabase.AutoSize = true;
            this.lblOpenDatabase.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblOpenDatabase.Location = new System.Drawing.Point(62, 67);
            this.lblOpenDatabase.Name = "lblOpenDatabase";
            this.lblOpenDatabase.Size = new System.Drawing.Size(175, 18);
            this.lblOpenDatabase.TabIndex = 0;
            this.lblOpenDatabase.Text = "Please open your database";
            // 
            // btnOpenDatabase
            // 
            this.btnOpenDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOpenDatabase.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnOpenDatabase.Location = new System.Drawing.Point(328, 62);
            this.btnOpenDatabase.Name = "btnOpenDatabase";
            this.btnOpenDatabase.Size = new System.Drawing.Size(120, 36);
            this.btnOpenDatabase.TabIndex = 1;
            this.btnOpenDatabase.Text = "Open Database";
            this.btnOpenDatabase.UseVisualStyleBackColor = false;
            this.btnOpenDatabase.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsdTablePrimaryKey
            // 
            this.lsdTablePrimaryKey.FormattingEnabled = true;
            this.lsdTablePrimaryKey.Location = new System.Drawing.Point(328, 115);
            this.lsdTablePrimaryKey.Name = "lsdTablePrimaryKey";
            this.lsdTablePrimaryKey.Size = new System.Drawing.Size(120, 95);
            this.lsdTablePrimaryKey.TabIndex = 2;
            this.lsdTablePrimaryKey.SelectedIndexChanged += new System.EventHandler(this.lsdTablePrimaryKey_SelectedIndexChanged);
            // 
            // lsdTableForeignKey
            // 
            this.lsdTableForeignKey.FormattingEnabled = true;
            this.lsdTableForeignKey.Location = new System.Drawing.Point(328, 272);
            this.lsdTableForeignKey.Name = "lsdTableForeignKey";
            this.lsdTableForeignKey.Size = new System.Drawing.Size(120, 95);
            this.lsdTableForeignKey.TabIndex = 2;
            this.lsdTableForeignKey.SelectedIndexChanged += new System.EventHandler(this.lsdTableForeignKey_SelectedIndexChanged);
            // 
            // lblPrimaryKey
            // 
            this.lblPrimaryKey.AutoSize = true;
            this.lblPrimaryKey.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblPrimaryKey.Location = new System.Drawing.Point(62, 136);
            this.lblPrimaryKey.Name = "lblPrimaryKey";
            this.lblPrimaryKey.Size = new System.Drawing.Size(258, 18);
            this.lblPrimaryKey.TabIndex = 3;
            this.lblPrimaryKey.Text = "Please Choose the table as primary key";
            // 
            // lblForeignKey
            // 
            this.lblForeignKey.AutoSize = true;
            this.lblForeignKey.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblForeignKey.Location = new System.Drawing.Point(62, 272);
            this.lblForeignKey.Name = "lblForeignKey";
            this.lblForeignKey.Size = new System.Drawing.Size(257, 18);
            this.lblForeignKey.TabIndex = 4;
            this.lblForeignKey.Text = "Please Choose the table as Foreign key";
            // 
            // lsdFieldForeignKey
            // 
            this.lsdFieldForeignKey.FormattingEnabled = true;
            this.lsdFieldForeignKey.Location = new System.Drawing.Point(591, 272);
            this.lsdFieldForeignKey.Name = "lsdFieldForeignKey";
            this.lsdFieldForeignKey.Size = new System.Drawing.Size(120, 95);
            this.lsdFieldForeignKey.TabIndex = 2;
            this.lsdFieldForeignKey.SelectedIndexChanged += new System.EventHandler(this.lsdFieldForeignKey_SelectedIndexChanged);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.Location = new System.Drawing.Point(462, 307);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(103, 25);
            this.lblDirection.TabIndex = 6;
            this.lblDirection.Text = ">>>>>>>>>>>>>";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblThree.ForeColor = System.Drawing.Color.Black;
            this.lblThree.Location = new System.Drawing.Point(22, 264);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(20, 24);
            this.lblThree.TabIndex = 17;
            this.lblThree.Text = "3";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblTwo.ForeColor = System.Drawing.Color.Black;
            this.lblTwo.Location = new System.Drawing.Point(22, 128);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(20, 24);
            this.lblTwo.TabIndex = 18;
            this.lblTwo.Text = "2";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblOne.ForeColor = System.Drawing.Color.Black;
            this.lblOne.Location = new System.Drawing.Point(22, 67);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(20, 24);
            this.lblOne.TabIndex = 19;
            this.lblOne.Text = "1";
            // 
            // lsdFieldPrimaryKey
            // 
            this.lsdFieldPrimaryKey.FormattingEnabled = true;
            this.lsdFieldPrimaryKey.Location = new System.Drawing.Point(591, 115);
            this.lsdFieldPrimaryKey.Name = "lsdFieldPrimaryKey";
            this.lsdFieldPrimaryKey.Size = new System.Drawing.Size(120, 95);
            this.lsdFieldPrimaryKey.TabIndex = 2;
            this.lsdFieldPrimaryKey.SelectedIndexChanged += new System.EventHandler(this.lsdFieldPrimaryKey_SelectedIndexChanged);
            // 
            // txtNameRelationship
            // 
            this.txtNameRelationship.Location = new System.Drawing.Point(715, 69);
            this.txtNameRelationship.Name = "txtNameRelationship";
            this.txtNameRelationship.Size = new System.Drawing.Size(100, 20);
            this.txtNameRelationship.TabIndex = 20;
            // 
            // lblNameRelationship
            // 
            this.lblNameRelationship.AutoSize = true;
            this.lblNameRelationship.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblNameRelationship.Location = new System.Drawing.Point(588, 72);
            this.lblNameRelationship.Name = "lblNameRelationship";
            this.lblNameRelationship.Size = new System.Drawing.Size(127, 18);
            this.lblNameRelationship.TabIndex = 21;
            this.lblNameRelationship.Text = "NameRelationship";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(250, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 38);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Create Relationship";
            // 
            // lblDirectionPrimary
            // 
            this.lblDirectionPrimary.AutoSize = true;
            this.lblDirectionPrimary.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionPrimary.Location = new System.Drawing.Point(462, 147);
            this.lblDirectionPrimary.Name = "lblDirectionPrimary";
            this.lblDirectionPrimary.Size = new System.Drawing.Size(103, 25);
            this.lblDirectionPrimary.TabIndex = 6;
            this.lblDirectionPrimary.Text = ">>>>>>>>>>>>>";
            // 
            // frmRelatioship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 397);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNameRelationship);
            this.Controls.Add(this.txtNameRelationship);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.lblDirectionPrimary);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblForeignKey);
            this.Controls.Add(this.lblPrimaryKey);
            this.Controls.Add(this.lsdFieldForeignKey);
            this.Controls.Add(this.lsdTableForeignKey);
            this.Controls.Add(this.lsdFieldPrimaryKey);
            this.Controls.Add(this.lsdTablePrimaryKey);
            this.Controls.Add(this.btnOpenDatabase);
            this.Controls.Add(this.lblOpenDatabase);
            this.Name = "frmRelatioship";
            this.Text = "frmRealatioship";
            this.Load += new System.EventHandler(this.frmRealatioship_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpenDatabase;
        private System.Windows.Forms.Button btnOpenDatabase;
        private System.Windows.Forms.ListBox lsdTablePrimaryKey;
        private System.Windows.Forms.ListBox lsdTableForeignKey;
        private System.Windows.Forms.Label lblPrimaryKey;
        private System.Windows.Forms.Label lblForeignKey;
        private System.Windows.Forms.ListBox lsdFieldForeignKey;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.ListBox lsdFieldPrimaryKey;
        private System.Windows.Forms.TextBox txtNameRelationship;
        private System.Windows.Forms.Label lblNameRelationship;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDirectionPrimary;
    }
}