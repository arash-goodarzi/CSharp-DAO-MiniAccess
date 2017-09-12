namespace MiniAccess
{
    partial class displayDescriptionOfDatabase
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
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblTabledefs = new System.Windows.Forms.Label();
            this.lblRelations = new System.Windows.Forms.Label();
            this.lblquerydefs = new System.Windows.Forms.Label();
            this.lstTabledefs = new System.Windows.Forms.ListBox();
            this.lstRelations = new System.Windows.Forms.ListBox();
            this.lstQuerydefs = new System.Windows.Forms.ListBox();
            this.btnOpenDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(350, 32);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(59, 13);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "Database: ";
            // 
            // lblTabledefs
            // 
            this.lblTabledefs.AutoSize = true;
            this.lblTabledefs.Location = new System.Drawing.Point(12, 91);
            this.lblTabledefs.Name = "lblTabledefs";
            this.lblTabledefs.Size = new System.Drawing.Size(50, 13);
            this.lblTabledefs.TabIndex = 1;
            this.lblTabledefs.Text = "tabledefs";
            // 
            // lblRelations
            // 
            this.lblRelations.AutoSize = true;
            this.lblRelations.Location = new System.Drawing.Point(353, 91);
            this.lblRelations.Name = "lblRelations";
            this.lblRelations.Size = new System.Drawing.Size(41, 13);
            this.lblRelations.TabIndex = 2;
            this.lblRelations.Text = "relation";
            // 
            // lblquerydefs
            // 
            this.lblquerydefs.AutoSize = true;
            this.lblquerydefs.Location = new System.Drawing.Point(613, 91);
            this.lblquerydefs.Name = "lblquerydefs";
            this.lblquerydefs.Size = new System.Drawing.Size(53, 13);
            this.lblquerydefs.TabIndex = 3;
            this.lblquerydefs.Text = "querydefs";
            // 
            // lstTabledefs
            // 
            this.lstTabledefs.FormattingEnabled = true;
            this.lstTabledefs.Location = new System.Drawing.Point(12, 123);
            this.lstTabledefs.Name = "lstTabledefs";
            this.lstTabledefs.Size = new System.Drawing.Size(217, 199);
            this.lstTabledefs.TabIndex = 4;
            // 
            // lstRelations
            // 
            this.lstRelations.FormattingEnabled = true;
            this.lstRelations.Location = new System.Drawing.Point(267, 123);
            this.lstRelations.Name = "lstRelations";
            this.lstRelations.Size = new System.Drawing.Size(231, 199);
            this.lstRelations.TabIndex = 4;
            // 
            // lstQuerydefs
            // 
            this.lstQuerydefs.FormattingEnabled = true;
            this.lstQuerydefs.Location = new System.Drawing.Point(523, 123);
            this.lstQuerydefs.Name = "lstQuerydefs";
            this.lstQuerydefs.Size = new System.Drawing.Size(239, 199);
            this.lstQuerydefs.TabIndex = 4;
            // 
            // btnOpenDatabase
            // 
            this.btnOpenDatabase.Location = new System.Drawing.Point(523, 32);
            this.btnOpenDatabase.Name = "btnOpenDatabase";
            this.btnOpenDatabase.Size = new System.Drawing.Size(156, 23);
            this.btnOpenDatabase.TabIndex = 5;
            this.btnOpenDatabase.Text = "Open Database";
            this.btnOpenDatabase.UseVisualStyleBackColor = true;
            this.btnOpenDatabase.Click += new System.EventHandler(this.btnOpenDatabase_Click);
            // 
            // displayDescriptionOfDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 404);
            this.Controls.Add(this.btnOpenDatabase);
            this.Controls.Add(this.lstQuerydefs);
            this.Controls.Add(this.lstRelations);
            this.Controls.Add(this.lstTabledefs);
            this.Controls.Add(this.lblquerydefs);
            this.Controls.Add(this.lblRelations);
            this.Controls.Add(this.lblTabledefs);
            this.Controls.Add(this.lblDatabase);
            this.Name = "displayDescriptionOfDatabase";
            this.Text = "displayDescriptionOfDatabase";
            this.Load += new System.EventHandler(this.displayDescriptionOfDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblTabledefs;
        private System.Windows.Forms.Label lblRelations;
        private System.Windows.Forms.Label lblquerydefs;
        private System.Windows.Forms.ListBox lstTabledefs;
        private System.Windows.Forms.ListBox lstRelations;
        private System.Windows.Forms.ListBox lstQuerydefs;
        private System.Windows.Forms.Button btnOpenDatabase;
    }
}