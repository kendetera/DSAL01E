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
    public partial class Payrol_Report : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
        public Payrol_Report()
        {
            payrol_db_connect.payrol_connString();
            InitializeComponent();
        }
        private void payrol_select()
        {
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqladapterSelect();
            payrol_db_connect.payrol_sqldatasetSELECT();
            dataGridView1.DataSource = payrol_db_connect.payrol_sql_dataset.Tables[0];
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

        private void Payrol_Report_Load(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id";
            payrol_select();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (optionCombo.Text == "employee number")
            {
                payrol_db_connect.payrol_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE pos_empRegTbl.emp_id = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "surname")
            {
                payrol_db_connect.payrol_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE pos_empRegTbl.emp_surname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }

            else if (optionCombo.Text == "firstname")
            {
                payrol_db_connect.payrol_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE pos_empRegTbl.emp_fname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }

            else if (optionCombo.Text == "gross_income")
            {
                payrol_db_connect.payrol_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE payrolTbl.gross_income = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }

            else if (optionCombo.Text == "net_income")
            {
                payrol_db_connect.payrol_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE payrolTbl.net_income = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }

            else if (optionCombo.Text == "pay_date")
            {
                payrol_db_connect.payrol_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE payrolTbl.pay_date = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id ";
            payrol_select();
            cleartextboxes();
        }
    }
}
