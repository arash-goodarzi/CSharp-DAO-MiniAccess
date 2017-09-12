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
    public partial class frmRelatioship : Form
    {
        public frmRelatioship()
        {
            InitializeComponent();
        }
        //vaiable
        DBEngine dbe;
        Database myDB;

        Relation myRel;
        Field myFl;


        string tablePrimary;
        string fieldPrimary;
        string tableForeign;
        string fieldForeign;


        private void EnableAndAble(bool lblOne, bool lblOpenDatabase, bool btnOpenDatabase, bool lblNameRelationship, bool txtNameRelationship, bool lblTwo, bool lblPrimaryKey, bool lsdTablePrimaryKey, bool lblDirectionPrimary, bool lsdFieldPrimaryKey, bool lblThree, bool lblForeignKey, bool lsdTableForeignKey, bool lblDIrection, bool lsdFieldForeignKey)
        {
            this.lblOne.Enabled = lblOne;
            this.lblOpenDatabase.Enabled = lblOpenDatabase;
            this.btnOpenDatabase.Enabled = btnOpenDatabase;
            this.lblNameRelationship.Enabled = lblNameRelationship;
            this.txtNameRelationship.Enabled = txtNameRelationship;
            this.lblTwo.Enabled = lblTwo;
            this.lblPrimaryKey.Enabled = lblPrimaryKey;
            this.lsdTablePrimaryKey.Enabled = lsdTablePrimaryKey;
            this.lblDirectionPrimary.Enabled = lblDirectionPrimary;
            this.lsdFieldPrimaryKey.Enabled = lsdFieldPrimaryKey;
            this.lblThree.Enabled = lblThree;
            this.lblForeignKey.Enabled = lblForeignKey;
            this.lsdTableForeignKey.Enabled = lsdTableForeignKey;
            this.lblDirection.Enabled = lblDIrection;
            this.lsdFieldForeignKey.Enabled = lsdFieldForeignKey;

        }


        private void frmRealatioship_Load(object sender, EventArgs e)
        {
            EnableAndAble(true, true, true, false, false, false, false,false, false, false,false, false, false, false, false);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbe = new DBEngine();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Access 2000 Database (*.mdb)|*.mdb|Access Database (*.accdb)|*.accdb";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        myDB = dbe.OpenDatabase(openFileDialog1.FileName);
                        foreach (TableDef t in myDB.TableDefs)
                        {
                            if (t.Attributes == 0)
                            {
                                lsdTablePrimaryKey.Items.Add(t.Name);
                            }
                        }
                        EnableAndAble(false, false, false, true, true, true,true, true, true, true,true, false, false, false, false); 

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            //foreach (TableDef t in myDB.TableDefs)
            //{
            //    if (t.Attributes==0)
            //    {
            //        lsdTablePrimaryKey.Items.Add(t.Name);
            //    }
                
                ////if (t.Attributes == 0)
                ////{
                ////    lsdInfos.Items.Add("Table name -" + t.Name);
                ////    foreach (Field f in t.Fields)
                ////    {
                ////        lsdInfos.Items.Add("\t-field" + f.Name);
                ////    }
                ////    lsdInfos.Items.Add("------------------index----------------");
                ////    foreach (_Index i in t.Indexes)
                ////    {
                ////        lsdInfos.Items.Add("\t-index-" + i.Name);
                ////        foreach (Field f in ((IndexFields)i.Fields))
                ////        {
                ////            lsdInfos.Items.Add("\t-index-field" + f.Name);
                ////        }
                ////    }
                ////    lsdInfos.Items.Add("======================================");
                ////}

            //}





        }

        private void btnPrimaryKey_Click(object sender, EventArgs e)
        {



            

        }

        private void btnForeignKey_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lsdTableForeignKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsdFieldForeignKey.Items.Clear();
            tableForeign = lsdTableForeignKey.SelectedItem.ToString();
            foreach (TableDef t in myDB.TableDefs)
            {
                if (t.Attributes == 0)
                {
                    ///////////
                    foreach (Field f in t.Fields)
                    {
                        if (f.SourceTable == tableForeign)
                        {
                            lsdFieldForeignKey.Items.Add(f.Name);
                        }
                    }
                }
            }
        }

        private void lsdTablePrimaryKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablePrimary = lsdTablePrimaryKey.SelectedItem.ToString();
            lsdFieldPrimaryKey.Items.Clear();
            foreach (TableDef t in myDB.TableDefs)
            {
                if (t.Attributes == 0)
                {
                     foreach (Field f in t.Fields)
                     {
                         if (f.SourceTable==tablePrimary)
                         {
                             lsdFieldPrimaryKey.Items.Add(f.Name);
                         }
                        
                     }











                }
            }         
        }

        private void lsdFieldForeignKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            fieldForeign = lsdFieldForeignKey.SelectedItem.ToString();
            ////////////////////////
            ////////////////////////
            if (txtNameRelationship.Text=="")
            {
                txtNameRelationship.Text = "Relationship";
            }
            myRel = myDB.CreateRelation(txtNameRelationship.Text, tablePrimary, tableForeign);//gave name /table/table
            myFl = myRel.CreateField(fieldPrimary);//primary
            myFl.ForeignName = fieldForeign;//foregign
            myRel.Fields.Append(myFl);
            myDB.Relations.Append(myRel);
            this.Close();
        }

        private void lsdFieldPrimaryKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsdFieldPrimaryKey.SelectedIndex==0)
            {
                foreach (TableDef t in myDB.TableDefs)
                {
                    if (t.Attributes == 0)
                    {
                        foreach (_Index i in t.Indexes)
                        {
                            if (i.Primary)
                            {
                                foreach (Field f in ((IndexFields)i.Fields))
                                {
                                    
                                    fieldPrimary = lsdFieldPrimaryKey.SelectedItem.ToString();
                                }

                            }
                        }
                    }

                }

                foreach (TableDef t in myDB.TableDefs)
                {
                    if (t.Attributes == 0)
                    {
                        lsdTableForeignKey.Items.Add(t.Name);
                    }
                }
                EnableAndAble(false, false, false, true, true, false, false,false, false, false,true, true, true, true, true); 
                //EnableAndAble(false, false, false, false, false, false, false, false, true, true, true, true, true); 
            }
            else
            {
                MessageBox.Show("Please choose the primary key");
            }
        }
    }
}
