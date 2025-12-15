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
    public partial class LoginFrm_Database : Form
    {
        private String username1, password1, user_level;
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        loginDb_dbconnections login_db_connect = new loginDb_dbconnections();
        public LoginFrm_Database()
        {
            login_db_connect.login_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            usernameTxtBox.Clear();
            passwordTxtBox.Clear();
            usernameTxtBox.Focus();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            login_db_connect.login_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, username, password, account_type, pos_terminal_no FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE username = '" + usernameTxtBox.Text + "' AND password = '" + passwordTxtBox.Text + "'";
            login_db_connect.login_cmd();
            login_db_connect.login_sqladapterSelect();
            login_db_connect.login_sqldatasetSELECT();

            username1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][4].ToString();
            password1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][5].ToString();
            user_level = login_db_connect.login_sql_dataset.Tables[0].Rows[0][6].ToString();

            if ((username1 == usernameTxtBox.Text) && password1 == (passwordTxtBox.Text))
            {
                if (user_level == "Administrator")
                {
                    MessageBox.Show("Access Granted");
                    MainForm myform = new MainForm();
                    myform.Show();
                    cleartextboxes();
                    this.Hide();
                }

                else if (user_level == "Cashier1")
                {
                    MessageBox.Show("Access Granted");
                    Example3_Finals myform = new Example3_Finals();
                    cleartextboxes();
                    myform.Show();
                }

                else if (user_level == "Cashier2")
                {
                    MessageBox.Show("Access Granted");
                    Example2_Finals myform = new Example2_Finals();
                    myform.terminal_noLbl.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][6].ToString();
                    myform.emp_idLbl.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][0].ToString();
                    myform.emp_fnameLbl.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][1].ToString();
                    myform.emp_surnameLbl.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][2].ToString();
                    DateTime dateTime = DateTime.Now;
                    myform.time_dateLbl.Text = dateTime.ToString("MMMM dd, yyyy");
                    cleartextboxes();
                    myform.Show();
                }

                else if (user_level == "HR Staff")
                {
                    MessageBox.Show("Access Granted");
                    employee_registration myform = new employee_registration();
                    myform.deleteBtn.Enabled = false;
                    cleartextboxes();
                    myform.Show();
                }

                else if (user_level == "Accounting Staff")
                {
                    MessageBox.Show("Access Granted");
                    payslip_view myform = new payslip_view();
                    myform.searchEditBtn.Hide();
                    myform.editBtn.Hide();
                    myform.deleteBtn.Hide();
                    cleartextboxes();
                    myform.Show();
                }

                else if (user_level == "IT Staff")
                {
                    MessageBox.Show("Access Granted");
                    User_Account myform = new User_Account();
                    myform.searchForUpdateBtn.Hide();
                    myform.updateBtn.Hide();
                    myform.deleteBtn.Hide();
                    cleartextboxes();
                    myform.Show();
                }

                else
                {
                    MessageBox.Show("Access Denied!");
                    cleartextboxes();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
