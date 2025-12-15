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
            Example3_Finals newMDIChild = new Example3_Finals();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_Admin newMDIChild = new POS_Admin();
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
            User_Account newMDIChild = new User_Account();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void xYZPOSIncToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Example2_Finals newMDIChild = new Example2_Finals();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void xYZPOSOrderingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Example6 newMDICchild = new Example6();
            newMDICchild.MdiParent = this;
            newMDICchild.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeRegistrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_registration newMDIChild = new employee_registration();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void salesReprotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Reports newMDIChild = new Sales_Reports();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Reports newMDIChild = new Employee_Reports();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollReprotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payrol_Report newMDIChild = new Payrol_Report();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void userReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccount_Report newMDIChild = new UserAccount_Report();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void activity1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 newMDIChild = new Activity1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void activity2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos1_func newMDIChild = new pos1_func();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void activity3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos1_class newMDIChild = new pos1_class();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOS2FunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos2_func newMDIChild = new pos2_func();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOS2ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos2_class newMDIChild = new pos2_class();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void hRPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_registration newMDIChild = new employee_registration();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void iTAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Account newMDIChild = new User_Account();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void xYZPOSIncToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            payslip_view newMDIChild = new payslip_view();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
