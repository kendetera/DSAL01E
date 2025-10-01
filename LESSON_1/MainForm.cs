using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void xYZPOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void xYZPOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 newMDIChild = new Activity2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity3 newMDIChild = new Activity3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prelimexam newMDIChild = new prelimexam();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void userAccountPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void xYZPOSIncToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Activity1 newMDIChild = new Activity1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
