using System;
using System.Globalization;
using System.Windows.Forms;

namespace LESSON_1
{
    public partial class payroll_func : Form
    {
        public payroll_func()
        {
            InitializeComponent();
            DisableComputedBoxes();
            HookEvents();
        }

        
        private void HookEvents()
        {
            grossIncomeBtn.Click += grossIncomeBtn_Click;
            netIncomeBtn.Click += netIncomeBtn_Click;
            newBtn.Click += newBtn_Click;
            saveBtn.Click += saveBtn_Click;
        }

        
        private void DisableComputedBoxes()
        {
            biIncomeTxtBox.Enabled = false;
            hiIncomeTxtBox.Enabled = false;
            oiIncomeTxtBox.Enabled = false;
            grossIncomeTxtBox.Enabled = false;
            netIncomeTxtBox.Enabled = false;
            totalDeductionsTxtBox.Enabled = false;
            sssContribTxtBox.Enabled = false;
            philhealthContribTxtBox.Enabled = false;
            pagibigContribTxtBox.Enabled = false;
            incomeTaxContribTxtBox.Enabled = false;
        }

        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox t)
                {
                    t.Clear();
                }
                if (c.HasChildren)
                {
                    ClearAllTextBoxes(c);
                }
            }
        }

        // --------------- SAFE PARSE ---------------
        private double ReadNumber(TextBox txt)
        {
            if (double.TryParse(txt.Text, out double value))
                return value;
            return 0.0;
        }

        private string Format(double value) => value.ToString("N2", CultureInfo.InvariantCulture);

        // --------------- INCOME COMPUTATIONS ---------------
        private double ComputeIncome(double rate, double hours)
        {
            return rate * hours;
        }

        private double ComputeGross(double basic, double honorarium, double other)
        {
            return basic + honorarium + other;
        }

        // --------------- DEDUCTION COMPUTATIONS ---------------
        private double ComputeSSS(double gross)
        {
            // Same long if-else chain as original (kept simple for "beginner style")
            double sss;
            if (gross < 5250) sss = 760.00;
            else if (gross < 5750) sss = 835.00;
            else if (gross < 6250) sss = 910.00;
            else if (gross < 6750) sss = 985.00;
            else if (gross < 7250) sss = 1060.00;
            else if (gross < 7750) sss = 1135.00;
            else if (gross < 8250) sss = 1210.00;
            else if (gross < 8750) sss = 1285.00;
            else if (gross < 9250) sss = 1360.00;
            else if (gross < 9750) sss = 1435.00;
            else if (gross < 10250) sss = 1510.00;
            else if (gross < 10750) sss = 1585.00;
            else if (gross < 11250) sss = 1660.00;
            else if (gross < 11750) sss = 1735.00;
            else if (gross < 12250) sss = 1810.00;
            else if (gross < 12750) sss = 1885.00;
            else if (gross < 13250) sss = 1960.00;
            else if (gross < 13750) sss = 2035.00;
            else if (gross < 14250) sss = 2110.00;
            else if (gross < 14750) sss = 2185.00;
            else if (gross < 15250) sss = 2260.00;
            else if (gross < 15750) sss = 2335.00;
            else if (gross < 16250) sss = 2430.00;
            else if (gross < 16750) sss = 2505.00;
            else if (gross < 17250) sss = 2580.00;
            else if (gross < 17750) sss = 2655.00;
            else if (gross < 18250) sss = 2730.00;
            else if (gross < 18750) sss = 2805.00;
            else if (gross < 19250) sss = 2880.00;
            else if (gross < 19750) sss = 2955.00;
            else if (gross < 20250) sss = 3030.00;
            else if (gross < 20750) sss = 3105.00;
            else if (gross < 21250) sss = 3180.00;
            else if (gross < 21750) sss = 3255.00;
            else if (gross < 22250) sss = 3330.00;
            else if (gross < 22750) sss = 3405.00;
            else if (gross < 23250) sss = 3480.00;
            else if (gross < 23750) sss = 3555.00;
            else if (gross < 24250) sss = 3630.00;
            else if (gross < 24750) sss = 3705.00;
            else if (gross < 25250) sss = 3780.00;
            else if (gross < 25750) sss = 3855.00;
            else if (gross < 26250) sss = 3930.00;
            else if (gross < 26750) sss = 4005.00;
            else if (gross < 27250) sss = 4080.00;
            else if (gross < 27750) sss = 4155.00;
            else if (gross < 28250) sss = 4230.00;
            else if (gross < 28750) sss = 4305.00;
            else if (gross < 29250) sss = 4380.00;
            else if (gross < 29750) sss = 4455.00;
            else if (gross < 30250) sss = 4530.00;
            else if (gross < 30750) sss = 4605.00;
            else if (gross < 31250) sss = 4680.00;
            else if (gross < 31750) sss = 4755.00;
            else if (gross < 32250) sss = 4830.00;
            else if (gross < 32750) sss = 4905.00;
            else if (gross < 33250) sss = 4980.00;
            else if (gross < 33750) sss = 5055.00;
            else if (gross < 34250) sss = 5130.00;
            else if (gross < 34750) sss = 5205.00;
            else sss = 5280.00;
            return sss;
        }

        private double ComputeIncomeTax(double gross)
        {
            // Monthly gross approximated to annual by * 24 (as in original)
            double annual = gross * 24.0;
            double tax;
            double bracket1 = 250000.0;
            double bracket2 = 400000.0;
            double bracket3 = 800000.0;
            double bracket4 = 2000000.0;
            double bracket5 = 8000000.0;

            if (annual < bracket1)
            {
                tax = 0.0;
            }
            else if (annual <= bracket2)
            {
                tax = (annual - bracket1) * 0.15;
            }
            else if (annual <= bracket3)
            {
                tax = ((annual - bracket2) * 0.20) + 22500.0;
            }
            else if (annual <= bracket4)
            {
                tax = ((annual - bracket3) * 0.25) + 102500.0;
            }
            else if (annual <= bracket5)
            {
                tax = ((annual - bracket4) * 0.30) + 402500.0;
            }
            else
            {
                tax = ((annual - bracket5) * 0.35) + 2202500.0;
            }

            return tax / 24.0;
        }

        private double ComputePhilhealth(double gross)
        {
            // Original always 5%
            return gross * 0.05;
        }

        private double ComputePagibig()
        {
            return 200.00;
        }

        private double ComputeTotalDeductionsRegular(double sss, double pagibig, double philhealth, double tax)
        {
            return sss + pagibig + philhealth + tax;
        }

        private double ComputeOtherDeductions(double sssLoan, double pagibigLoan, double facultyDeposit,
            double facultyLoan, double salaryLoan, double otherLoans)
        {
            return sssLoan + pagibigLoan + facultyDeposit + facultyLoan + salaryLoan + otherLoans;
        }

        private double ComputeNet(double gross, double totalDeductions)
        {
            return gross - totalDeductions;
        }

        // --------------- BUTTON HANDLERS ---------------
        private void grossIncomeBtn_Click(object sender, EventArgs e)
        {
            // Read inputs
            double basicRate = ReadNumber(biRateTxtBox);
            double basicHours = ReadNumber(biHoursTxtBox);
            double honorariumRate = ReadNumber(hiRateTxtBox);
            double honorariumHours = ReadNumber(hiHoursTxtBox);
            double otherRate = ReadNumber(oiRateTxtBox);
            double otherHours = ReadNumber(oiHoursTxtBox);

            // Compute each income
            double basicIncome = ComputeIncome(basicRate, basicHours);
            double honorariumIncome = ComputeIncome(honorariumRate, honorariumHours);
            double otherIncome = ComputeIncome(otherRate, otherHours);

            // Gross
            double gross = ComputeGross(basicIncome, honorariumIncome, otherIncome);

            // Deductions (regular)
            double sss = ComputeSSS(gross);
            double pagibig = ComputePagibig();
            double philhealth = ComputePhilhealth(gross);
            double tax = ComputeIncomeTax(gross);

            // Show incomes
            biIncomeTxtBox.Text = Format(basicIncome);
            hiIncomeTxtBox.Text = Format(honorariumIncome);
            oiIncomeTxtBox.Text = Format(otherIncome);
            grossIncomeTxtBox.Text = Format(gross);

            // Show regular deductions
            sssContribTxtBox.Text = Format(sss);
            pagibigContribTxtBox.Text = Format(pagibig);
            philhealthContribTxtBox.Text = Format(philhealth);
            incomeTaxContribTxtBox.Text = Format(tax);

            // Clear summary fields (until net is computed)
            totalDeductionsTxtBox.Clear();
            netIncomeTxtBox.Clear();
        }

        private void netIncomeBtn_Click(object sender, EventArgs e)
        {
            double gross = ReadNumber(grossIncomeTxtBox);
            if (gross <= 0)
            {
                MessageBox.Show("Compute gross income first.");
                return;
            }

            // Regular deductions already computed
            double sss = ReadNumber(sssContribTxtBox);
            double pagibig = ReadNumber(pagibigContribTxtBox);
            double philhealth = ReadNumber(philhealthContribTxtBox);
            double tax = ReadNumber(incomeTaxContribTxtBox);

            double sssLoan = ReadNumber(sssLoanTxtBox);
            double pagibigLoan = ReadNumber(pagibigLoanTxtBox);
            double facultyDeposit = ReadNumber(facultyDepositTxtBox);
            double facultyLoan = ReadNumber(facultyLoanTxtBox);
            double salaryLoan = ReadNumber(salaryLoanTxtBox);
            double otherLoans = ReadNumber(otherLoansTxtBox);

            double regularDeductions = ComputeTotalDeductionsRegular(sss, pagibig, philhealth, tax);
            double otherDeductions = ComputeOtherDeductions(sssLoan, pagibigLoan, facultyDeposit, facultyLoan, salaryLoan, otherLoans);

            double totalDeductions = regularDeductions + otherDeductions;
            double net = ComputeNet(gross, totalDeductions);

            totalDeductionsTxtBox.Text = Format(totalDeductions);
            netIncomeTxtBox.Text = Format(net);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
            biRateTxtBox.Focus();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            payslipreport print = new payslipreport();

            // Populate via public properties (avoids accessing private controls)
            print.EmployeeCode = employeeNumberTxtBox.Text;
            print.EmployeeName = $"{firstNameTxtBox.Text} {middleNameTxtBox.Text} {surnameTxtBox.Text}";
            print.Department = departmentTxtBox.Text;
            print.CutOff = payDateTxtBox.Text;
            print.PayPeriod = payDateTxtBox.Text;

            print.BasicPayHrs = biHoursTxtBox.Text;
            print.BasicPayIncome = biIncomeTxtBox.Text;
            print.HonorariumHrs = hiHoursTxtBox.Text;
            print.HonorariumIncome = hiIncomeTxtBox.Text;
            print.OvertimeHrs = oiHoursTxtBox.Text;
            print.OvertimeIncome = oiIncomeTxtBox.Text;

            print.WithholdingTax = incomeTaxContribTxtBox.Text;
            print.SSS = sssContribTxtBox.Text;
            print.Pagibig = pagibigContribTxtBox.Text;
            print.Philhealth = philhealthContribTxtBox.Text;
            print.Wisp = "750.00";

            print.Earnings = grossIncomeTxtBox.Text;
            print.Deductions = totalDeductionsTxtBox.Text;
            print.Overtime = oiIncomeTxtBox.Text;

            print.Gross = grossIncomeTxtBox.Text;
            print.NetPay = netIncomeTxtBox.Text;
            print.Deductions = totalDeductionsTxtBox.Text;

            print.Show();
        }
    }
}
