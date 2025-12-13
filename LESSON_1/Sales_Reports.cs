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
    public partial class Sales_Reports : Form
    {
        pos_dbconnection pos_db_connect = new pos_dbconnection();
        public Sales_Reports()
        {
            pos_db_connect.pos_connString();
            InitializeComponent();
        }
        private void pos_select()
        {
            pos_db_connect.pos_cmd();
            pos_db_connect.pos_sqladapterSelect();
            pos_db_connect.pos_sqldatasetSELECT();
            dataGridView1.DataSource = pos_db_connect.pos_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            optionCombo.Text = "";
            optionInputTxtbox.Clear();
            optionCombo.Focus();
        }

        private void cleartextboxes1()
        {
            optionInputTxtbox.Clear();
            optionInputTxtbox.Focus();
        }

        private void Sales_Reports_Load(object sender, EventArgs e)
        {
            pos_db_connect.pos_sql = "SELECT * FROM salesTbl";
            pos_db_connect.pos_cmd();
            pos_db_connect.pos_sqladapterSelect();
            pos_db_connect.pos_sqldatasetSELECTSALES();
            dataGridView1.DataSource = pos_db_connect.pos_sql_dataset.Tables[0];
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (optionCombo.Text == "transaction_id")
            {
                pos_db_connect.pos_sql = "SELECT * FROM salesTbl WHERE transaction_id = '" + optionInputTxtbox.Text + "'";
                pos_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "terminal_no")
            {
                pos_db_connect.pos_sql = "SELECT * FROM salesTbl WHERE terminal_no = '" + optionInputTxtbox.Text + "'";
                pos_select();
                cleartextboxes1();
            }

            else if (optionCombo.Text == "date and time")
            {
                pos_db_connect.pos_sql = "SELECT * FROM salesTbl WHERE time_date = '" + optionInputTxtbox.Text + "'";
                pos_select();
                cleartextboxes1();
            }

            else if (optionCombo.Text == "product name")
            {
                pos_db_connect.pos_sql = "SELECT * FROM salesTbl WHERE product_name = '" + optionInputTxtbox.Text + "'";
                pos_select();
                cleartextboxes();
            }

            else if (optionCombo.Text == "employee_number")
            {
                pos_db_connect.pos_sql = "SELECT * FROM salesTbl WHERE emp_id  = '" + optionInputTxtbox.Text + "'";
                pos_select();
                cleartextboxes1();
            }

            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            pos_db_connect.pos_sql = "SELECT * FROM salesTbl";
            pos_select();
        }
    }
}
