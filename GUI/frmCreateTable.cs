using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace MiniAccess.GUI
{
    public partial class frmCreateTable : Form
    {
        public frmCreateTable()
        {
            InitializeComponent();
        }
        //vaiable
        DBEngine dbe;
        Database myDB;
        TableDef myTB;
        Field myFl;
        Field myFli;
        string pathOfDatabase;

        bool useChooseNameAndPath = false;
        




        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Access 2000 Database (*.mdb)|*.mdb|Access Database (*.accdb)|*.accdb";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathOfDatabase = saveFileDialog1.FileName;
                useChooseNameAndPath = true;
            }

        }


        private void EnableAndAble(bool lblCreateDatabase, bool btnCreateDatatbase, bool btnPath, bool btnGoCreateDatabase, bool btnEndCreateDatabase, bool lblAddTable, bool btnAddTable, bool lblTableName, bool txtTableName, bool btnGoAddTable, bool btnEndAddTable, bool lblAddFields, bool btnAddFields, bool lblFieldName, bool txtNameField, bool lblFieldType, bool cboFieldType, bool chkPrimaryKey, bool btnGoAddFields, bool btnEndAddFields)
        {
            this.lblCreateDatabase.Enabled = lblCreateDatabase;
            this.btnCreateDatatbase.Enabled = btnCreateDatatbase;
            this.btnPath.Enabled = btnPath;
            this.btnGoCreateDatabase.Enabled = btnGoCreateDatabase;
            this.btnEndCreateDatabase.Enabled = btnEndCreateDatabase;
            //
            this.lblAddTable.Enabled = lblAddTable;
            this.btnAddTable.Enabled = btnAddTable;
            this.lblTableName.Enabled = lblTableName;
            this.txtTableName.Enabled = txtTableName;
            this.btnGoAddTable.Enabled = btnGoAddTable;
            this.btnEndAddTable.Enabled = btnEndAddTable;
            //
            this.lblAddFields.Enabled = lblAddFields;
            this.btnAddFields.Enabled = btnAddFields;
            this.lblFieldName.Enabled = lblFieldName;
            this.txtNameField.Enabled = txtNameField;
            this.lblFieldType.Enabled = lblFieldType;
            this.cboFieldType.Enabled = cboFieldType;
            this.chkPrimaryKey.Enabled = chkPrimaryKey;
            this.btnGoAddFields.Enabled = btnGoAddFields;
            this.btnEndAddFields.Enabled = btnEndAddFields;
        }

        private void frmCreateTable_Load(object sender, EventArgs e)
        {
            EnableAndAble(true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
        }

        private void btnCreateDatatbase_Click(object sender, EventArgs e)
        {
            EnableAndAble(true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
        }

        private void btnGoCreateDatabase_Click(object sender, EventArgs e)
        {
            if (useChooseNameAndPath)
            {
                //MessageBox.Show(pathOfDatabase);
                dbe = new DBEngine();
                myDB = dbe.CreateDatabase(pathOfDatabase, DAO.LanguageConstants.dbLangGeneral);



                EnableAndAble(false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false);
                lblWarningDatabase.Text = "";
            }
            else
            {
                lblWarningDatabase.Text = "Please choose name and path";
            }

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            txtTableName.Clear();
            EnableAndAble(false, false, false, false, false, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false);
        }

        private void btnGoAddTable_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text != "")
            {
                myTB = myDB.CreateTableDef(txtTableName.Text);

                EnableAndAble(false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false);
                lblWarningTable.Text = "";
            }
            else
            {
                lblWarningTable.Text = "Please give name to table";
            }

        }

        private void btnAddFields_Click(object sender, EventArgs e)
        {
            txtNameField.Clear();
            cboFieldType.SelectedIndex = 0;
            chkPrimaryKey.Checked = false;
            EnableAndAble(false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true);
        }

        private void btnEndAddFields_Click(object sender, EventArgs e)
        {
            myDB.TableDefs.Append(myTB);
            EnableAndAble(false, false, false, false, false, true, true, false, false, false, true, false, false, false, false, false, false, false, false, false);
        }

        private void btnEndAddTable_Click(object sender, EventArgs e)
        {

            EnableAndAble(false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
        }

        private void btnGoAddFields_Click(object sender, EventArgs e)
        {
            if (txtNameField.Text!="")
            {
                string comboBoxContent = cboFieldType.SelectedItem.ToString();

                if (comboBoxContent == "Text")
                {
                    myFl = myTB.CreateField(txtNameField.Text.ToString(), DAO.DataTypeEnum.dbText);
                }
                else if (comboBoxContent == "Long")
                {
                    myFl = myTB.CreateField(txtNameField.Text.ToString(), DAO.DataTypeEnum.dbLong);
                }
                else if (comboBoxContent == "Number")
                {
                    myFl = myTB.CreateField(txtNameField.Text, DAO.DataTypeEnum.dbInteger);
                }
                else if (comboBoxContent == "Double")
                {
                    myFl = myTB.CreateField(txtNameField.Text.ToString(), DAO.DataTypeEnum.dbDouble);
                }
                else if (comboBoxContent == "Boolean")
                {
                    myFl = myTB.CreateField(txtNameField.Text.ToString(), DAO.DataTypeEnum.dbBoolean);
                }

                myTB.Fields.Append(myFl);
                //index

                if (chkPrimaryKey.Checked)
                {
                    Index myInd = myTB.CreateIndex("PrimaryKey");
                    myFli = myInd.CreateField(txtNameField.Text.ToString());
                    ((IndexFields)(myInd.Fields)).Append(myFli);
                    myInd.Primary = true;
                    myTB.Indexes.Append(myInd);
                }


                EnableAndAble(false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, true);
                lblWarningField.Text = "";
            }
            else
            {
                lblWarningField.Text = "Please choose the field Name";
            }
        }

        private void btnEndCreateDatabase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
