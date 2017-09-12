using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniAccess.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void createToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCreateTable createTable = new frmCreateTable();
            createTable.MdiParent = this;
            createTable.Show();
        }

        private void relationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatioship relatonship = new frmRelatioship();
            relatonship.MdiParent = this;
            relatonship.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayDescriptionOfDatabase display = new displayDescriptionOfDatabase();
            display.MdiParent = this;
            display.Show();
        }
    }
}
