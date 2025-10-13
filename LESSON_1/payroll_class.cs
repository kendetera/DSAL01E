using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_1
{
    public partial class payroll_class : Form
    {
        Variables1 variables = new Variables1();

        private readonly PayrollCalculator _calc = new PayrollCalculator();

        public payroll_class()
        {
            InitializeComponent();
            DisableComputedBoxes();
            HookEvents();
        }

        // ---------------- UI Helpers ----------------
        private void HookEvents()
        {
            calculateBtn.Click += calculateBtn_Click;
            newBtn.Click += newBtn_Click;
            cancelBtn.Click += cancelBtn_Click;
            exitBtn.Click += exitBtn_Click;

            printPayslipBtn.Click += printPayslipBtn_Click; // show details in list box
        }

        private void DisableComputedBoxes()
        {
            // Income outputs
            biIncomeTxtBox.Enabled = false;
            hiIncomeTxtBox.Enabled = false;
            oiIncomeTxtBox.Enabled = false;
            // Summary outputs
            grossIncomeTxtBox.Enabled = false;
            netIncomeTxtBox.Enabled = false;
            totalDeductionsTxtBox.Enabled = false;
            // Deductions outputs
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

        private double ReadNumber(TextBox txt)
        {
            if (double.TryParse(txt.Text, out var value))
                return value;
            return 0.0;
        }

        private string Format(double value) => value.ToString("N2", CultureInfo.InvariantCulture);

        // ---------------- Event Handlers ----------------
        private void calculateBtn_Click(object? sender, EventArgs e)
        {
            // Read inputs for basic, honorarium, other income
            double biRate = ReadNumber(biRateTxtBox);
            double biHours = ReadNumber(biHoursTxtBox);
            double hiRate = ReadNumber(hiRateTxtBox);
            double hiHours = ReadNumber(hiHoursTxtBox);
            double oiRate = ReadNumber(oiRateTxtBox);
            double oiHours = ReadNumber(oiHoursTxtBox);

            // Compute incomes
            double biIncome = _calc.ComputeIncome(biRate, biHours);
            double hiIncome = _calc.ComputeIncome(hiRate, hiHours);
            double oiIncome = _calc.ComputeIncome(oiRate, oiHours);

            // Gross
            double gross = _calc.ComputeGross(biIncome, hiIncome, oiIncome);

            // Regular deductions
            double sss = _calc.ComputeSSS(gross);
            double pagibig = _calc.ComputePagibig();
            double philhealth = _calc.ComputePhilhealth(gross);
            double tax = _calc.ComputeIncomeTax(gross);

            // Other deductions
            double sssLoan = ReadNumber(sssLoanTxtBox);
            double pagibigLoan = ReadNumber(pagibigLoanTxtBox);
            double facultyDeposit = ReadNumber(facultyDepositTxtBox);
            double facultyLoan = ReadNumber(facultyLoanTxtBox);
            double salaryLoan = ReadNumber(salaryLoanTxtBox);
            double otherLoans = ReadNumber(otherLoansTxtBox);

            double regularDeductions = _calc.ComputeTotalDeductionsRegular(sss, pagibig, philhealth, tax);
            double otherDeductions = _calc.ComputeOtherDeductions(sssLoan, pagibigLoan, facultyDeposit, facultyLoan, salaryLoan, otherLoans);
            double totalDeductions = regularDeductions + otherDeductions;

            // Net
            double net = _calc.ComputeNet(gross, totalDeductions);

            // Show incomes
            biIncomeTxtBox.Text = Format(biIncome);
            hiIncomeTxtBox.Text = Format(hiIncome);
            oiIncomeTxtBox.Text = Format(oiIncome);
            grossIncomeTxtBox.Text = Format(gross);

            // Show regular deductions
            sssContribTxtBox.Text = Format(sss);
            pagibigContribTxtBox.Text = Format(pagibig);
            philhealthContribTxtBox.Text = Format(philhealth);
            incomeTaxContribTxtBox.Text = Format(tax);

            // Show totals
            totalDeductionsTxtBox.Text = Format(totalDeductions);
            netIncomeTxtBox.Text = Format(net);
        }

        private void newBtn_Click(object? sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
            biRateTxtBox.Focus();
        }

        private void cancelBtn_Click(object? sender, EventArgs e)
        {
            // Treat cancel as reset for now
            ClearAllTextBoxes(this);
            biRateTxtBox.Focus();
        }

        private void exitBtn_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void printPayslipBtn_Click(object sender, EventArgs e)
        {
            // Local numeric formatter using the form helpers
            string F(TextBox tb) => Format(ReadNumber(tb));
            string JoinName(params string[] parts) =>
                string.Join(" ", parts.Where(s => !string.IsNullOrWhiteSpace(s)));

            var name = JoinName(firstNameTxtBox.Text, middleNameTxtBox.Text, surnameTxtBox.Text);
            var payDate = payDatePicker.Value.ToString("yyyy-MM-dd");

            payslipListBox.BeginUpdate();
            try
            {
                payslipListBox.Items.Clear();
                payslipListBox.Items.Add("=== PAYSLIP PREVIEW ===");
                payslipListBox.Items.Add($"Employee No.: {employeeNumberTxtBox.Text}");
                payslipListBox.Items.Add($"Name        : {name}");
                payslipListBox.Items.Add($"Civil Status: {civilStatusTxtBox.Text}");
                payslipListBox.Items.Add($"Dependents  : {numDependentsTxtBox.Text}");
                payslipListBox.Items.Add($"Status      : {employeeStatusTxtBox.Text}");
                payslipListBox.Items.Add($"Department  : {departmentTxtBox.Text}");
                payslipListBox.Items.Add($"Designation : {designationTxtBox.Text}");
                payslipListBox.Items.Add($"Pay Date    : {payDate}");
                payslipListBox.Items.Add("");

                payslipListBox.Items.Add("--- Income ---");
                payslipListBox.Items.Add($"Basic     Rate/Hour: {biRateTxtBox.Text} | Hours: {biHoursTxtBox.Text} | Income: {F(biIncomeTxtBox)}");
                payslipListBox.Items.Add($"Honorarium Rate/Hour: {hiRateTxtBox.Text} | Hours: {hiHoursTxtBox.Text} | Income: {F(hiIncomeTxtBox)}");
                payslipListBox.Items.Add($"Other     Rate/Hour: {oiRateTxtBox.Text} | Hours: {oiHoursTxtBox.Text} | Income: {F(oiIncomeTxtBox)}");
                payslipListBox.Items.Add($"GROSS INCOME: {F(grossIncomeTxtBox)}");
                payslipListBox.Items.Add("");

                payslipListBox.Items.Add("--- Regular Deductions ---");
                payslipListBox.Items.Add($"SSS        : {F(sssContribTxtBox)}");
                payslipListBox.Items.Add($"PhilHealth : {F(philhealthContribTxtBox)}");
                payslipListBox.Items.Add($"Pag-IBIG   : {F(pagibigContribTxtBox)}");
                payslipListBox.Items.Add($"Income Tax : {F(incomeTaxContribTxtBox)}");
                payslipListBox.Items.Add("");

                payslipListBox.Items.Add("--- Other Deductions ---");
                payslipListBox.Items.Add($"SSS Loan           : {F(sssLoanTxtBox)}");
                payslipListBox.Items.Add($"Pag-IBIG Loan      : {F(pagibigLoanTxtBox)}");
                payslipListBox.Items.Add($"Faculty Deposit    : {F(facultyDepositTxtBox)}");
                payslipListBox.Items.Add($"Faculty Savings L. : {F(facultyLoanTxtBox)}");
                payslipListBox.Items.Add($"Salary Loan        : {F(salaryLoanTxtBox)}");
                payslipListBox.Items.Add($"Other Loans        : {F(otherLoansTxtBox)}");
                payslipListBox.Items.Add("");

                payslipListBox.Items.Add($"GROSS INCOME: {F(grossIncomeTxtBox)}");
                payslipListBox.Items.Add($"TOTAL DEDUCTIONS: {F(totalDeductionsTxtBox)}");
                payslipListBox.Items.Add($"NET INCOME      : {F(netIncomeTxtBox)}");
            }
            finally
            {
                payslipListBox.EndUpdate();
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            // Let the user pick an image file.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false;

                // If a file was chosen, load it into the PictureBox.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = selectedImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Fit image to box.
                }
            }
        }
    }


    public sealed class PayrollCalculator
    {
        public double ComputeIncome(double rate, double hours) => rate * hours;

        public double ComputeGross(double basic, double honorarium, double other) => basic + honorarium + other;

        public double ComputeSSS(double gross)
        {
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

        public double ComputeIncomeTax(double gross)
        {
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

        public double ComputePhilhealth(double gross) => gross * 0.05;

        public double ComputePagibig() => 200.00;

        public double ComputeTotalDeductionsRegular(double sss, double pagibig, double philhealth, double tax)
            => sss + pagibig + philhealth + tax;

        public double ComputeOtherDeductions(double sssLoan, double pagibigLoan, double facultyDeposit,
            double facultyLoan, double salaryLoan, double otherLoans)
            => sssLoan + pagibigLoan + facultyDeposit + facultyLoan + salaryLoan + otherLoans;

        public double ComputeNet(double gross, double totalDeductions) => gross - totalDeductions;
    }
}
