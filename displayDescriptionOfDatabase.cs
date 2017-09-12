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

namespace MiniAccess
{
    public partial class displayDescriptionOfDatabase : Form
    {
        public displayDescriptionOfDatabase()
        {
            InitializeComponent();
        }
        DBEngine dbe;
        Database myDB;
        Field myFl;
        TableDef myTB;
        private void displayDescriptionOfDatabase_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenDatabase_Click(object sender, EventArgs e)
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
                        lblDatabase.Text += myDB.Name;
                        /////table defs
                        foreach (TableDef t in myDB.TableDefs)
                        {
                            if (t.Attributes == 0)
                            {
                                lstTabledefs.Items.Add("Table name -" + t.Name);
                                foreach (Field f in t.Fields)
                                {
                                    lstTabledefs.Items.Add("\t-field" + f.Name);

                                }
                                lstTabledefs.Items.Add("------------------index----------------");
                                foreach (_Index i in t.Indexes)
                                {
                                    lstTabledefs.Items.Add("\t-index-" + i.Name);
                                    foreach (Field f in ((IndexFields)i.Fields))
                                    {
                                        lstTabledefs.Items.Add("\t-index-field" + f.Name);
                                    }
                                }
                                lstTabledefs.Items.Add("======================================");
                            }

                        }
                        /////relations
                        foreach (Relation r in myDB.Relations)
                        {
                            lstRelations.Items.Add("-relation-field- " + r.Name);
                            lstRelations.Items.Add("-----------------------------------------");
                        }


                        ///query
                        foreach (QueryDef q in myDB.QueryDefs)
                        {
                            lstQuerydefs.Items.Add("* Query" + q.Name);
                            foreach (Field f in q.Fields)
                            {
                                lstQuerydefs.Items.Add("\t-Field" + f.Name);
                            }
                            lstQuerydefs.Items.Add("-----------------------------");
                            foreach (Parameter p in q.Parameters)
                            {
                                lstQuerydefs.Items.Add("\t-Parameter     " + p.Name);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
