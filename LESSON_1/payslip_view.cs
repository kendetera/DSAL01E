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
    public partial class payslip_view : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
        payroll_variable pay_variables = new payroll_variable();
        public payslip_view()
        {
            payrol_db_connect.payrol_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            empNumberTxtbox.Clear(); firstnameTxtbox.Clear(); MNameTxtbox.Clear(); surnameTxtbox.Clear(); civilStatusTxtBox.Clear();
            designationTxtbox.Clear(); numDependentsTxtbox.Clear(); emp_statusTxtbox.Clear(); departmentTxtbox.Clear(); basic_rateTxtBox.Clear();
            basic_numhrsTxtBox.Clear(); basic_netincomeTxtBox.Clear(); hono_rateTxtBox.Clear(); hono_numhrsTxtbox.Clear(); hono_netincomeTxtBox.Clear();
            other_rateTxtBox.Clear(); other_numhrsTxtBox.Clear(); other_netincomeTxtBox.Clear(); netIncomeTxtBox.Clear(); grossIncomeTxtBox.Clear();
            sssContribTxtBox.Clear(); pagibigContribTxtBox.Clear(); philhealthContribTxtBox.Clear(); TaxContribTxtBox.Clear(); sssLoanTxtBox.Clear();
            pagibig_loanTxtBox.Clear(); facultyDepositTxtBox.Clear(); facultyLoanTxtBox.Clear(); others_loanCombo.Text = "Select other loan"; totalDeductionsTxtBox.Clear();
            salaryLoanTxtBox.Clear(); others_loanTxtbox.Clear(); payslip_view_listbox.Items.Clear();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "INSERT INTO payrolTbl (basic_rate_hr, basic_no_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, emp_id, pay_date) " +
                "VALUES ('" + basic_rateTxtBox + "', '" + basic_numhrsTxtBox + "', '" + basic_netincomeTxtBox + "', '" + hono_rateTxtBox + "', '" + hono_numhrsTxtbox + "', '" + hono_netincomeTxtBox + "', '" + other_rateTxtBox + "', '" + other_numhrsTxtBox + "', '" + other_netincomeTxtBox + "', '" + sssContribTxtBox + "', '" + philhealthContribTxtBox + "', '" + pagibigContribTxtBox + "', '" + TaxContribTxtBox + "', '" + sssLoanTxtBox + "', '" + pagibig_loanTxtBox + "', '" + facultyDepositTxtBox + "', '" + facultyLoanTxtBox + "', '" + salaryLoanTxtBox + "', '" + others_loanTxtbox + "', '" + totalDeductionsTxtBox + "', '" + grossIncomeTxtBox + "', '" + netIncomeTxtBox + "', '" + empNumberTxtbox + "', '" + paydateDatePicker.Text + "')";
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqladapterInsert();
            cleartextboxes();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "UPDATE payrolTbl SET basic_rate_hr = '" + basic_rateTxtBox.Text + "', basic_no_hrs_cutOff = '" + basic_numhrsTxtBox.Text + "', basic_income_per_cutOff = '" + basic_netincomeTxtBox.Text + "', honorarium_rate_hr = '" + hono_rateTxtBox.Text + "', honorarium_no_hrs_cutOff = '" + hono_numhrsTxtbox.Text + "', honorarium_income_per_cutOff = '" + hono_netincomeTxtBox.Text + "', other_rate_hr = '" + other_rateTxtBox.Text + "', other_no_hrs_cutOff = '" + other_numhrsTxtBox.Text + "', other_income_per_cutOff = '" + other_netincomeTxtBox.Text + "', sss_contrib = '" + sssContribTxtBox.Text + "', philhealth_contrib = '" + philhealthContribTxtBox.Text + "', pagibig_contrib = '" + pagibigContribTxtBox.Text + "', tax_contrib = '" + TaxContribTxtBox.Text + "', sss_loan = '" + sssLoanTxtBox.Text + "', pagibig_loan = '" + pagibig_loanTxtBox.Text + "', fac_savings_deposit = '" + facultyDepositTxtBox.Text + "', fac_savings_loan = '" + facultyLoanTxtBox.Text + "', salary_loan = '" + salaryLoanTxtBox.Text + "', other_loans = '" + others_loanTxtbox.Text + "', total_deductions = '" + totalDeductionsTxtBox.Text + "', gross_income = '" + grossIncomeTxtBox.Text + "', net_income = '" + netIncomeTxtBox.Text + "', pay_date = '" + paydateDatePicker.Text + "' WHERE payrolTbl.emp_id = '" + empNumberTxtbox.Text + "' AND pay_date = '" + paydateDatePicker.Text + "'";
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqladapterUpdate();
            cleartextboxes();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "DELETE FROM payrolTbl WHERE payrolTbl.emp_id = '" + empNumberTxtbox.Text + "'";
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqladapterDelete();
            cleartextboxes();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, emp_work_status, emp_department, picpath FROM pos_empRegTbl WHERE emp_id ='" + empNumberTxtbox.Text + "'";
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqladapterSelect();
            payrol_db_connect.payrol_sqldatasetSELECT();

            firstnameTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][1].ToString();
            MNameTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][2].ToString();
            surnameTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][3].ToString();
            civilStatusTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][4].ToString();
            designationTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][5].ToString();
            numDependentsTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][6].ToString();
            emp_statusTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][7].ToString();
            departmentTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][8].ToString();
            picpathTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][9].ToString();
            pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
        }

        private void searchEditBtn_Click(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, emp_work_status, emp_department, picpath, basic_rate_hr, basic_no_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, payrolTbl.emp_id, paydate FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE (payrolTbl.emp_id = '" + empNumberTxtbox.Text + "' AND payrolTbl.pay_date = '" + paydateDatePicker.Text + "')";
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqladapterSelect();
            payrol_db_connect.payrol_sqldatasetSELECT();

            firstnameTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][1].ToString();
            MNameTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][2].ToString();
            surnameTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][3].ToString();
            civilStatusTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][4].ToString();
            designationTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][5].ToString();
            numDependentsTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][6].ToString();
            emp_statusTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][7].ToString();
            departmentTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][8].ToString();
            picpathTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][9].ToString();
            pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
            basic_rateTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][10].ToString();
            basic_numhrsTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][11].ToString();
            basic_netincomeTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][12].ToString();
            hono_rateTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][13].ToString();
            hono_numhrsTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][14].ToString();
            hono_netincomeTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][15].ToString();
            other_rateTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][16].ToString();
            other_numhrsTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][17].ToString();
            other_netincomeTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][18].ToString();
            sssContribTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][19].ToString();
            philhealthContribTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][20].ToString();
            pagibigContribTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][21].ToString();
            TaxContribTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][22].ToString();
            sssLoanTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][23].ToString();
            pagibig_loanTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][24].ToString();
            facultyDepositTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][25].ToString();
            facultyLoanTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][26].ToString();
            salaryLoanTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][27].ToString();
            others_loanTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][28].ToString();
            totalDeductionsTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][29].ToString();
            grossIncomeTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][30].ToString();
            netIncomeTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][31].ToString();
        }
    }
}