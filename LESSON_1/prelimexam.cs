using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LESSON_1
{
    public partial class prelimexam : Form
    {
        public prelimexam()
        {
            InitializeComponent();
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

        private void grossIncomeBtn_Click(object sender, EventArgs e)
        {
            double basicRate, basicHours, basicIncome, honorariumRate, honorariumHours, honorariumIncome, otherRate, otherHours, otherIncome, grossIncome,
                sssContrib, pagibigContrib = 200.00, philhealthContrib, incomeTaxContrib;

            basicRate = Convert.ToDouble(biRateTxtBox.Text);
            basicHours = Convert.ToDouble(biHoursTxtBox.Text);
            honorariumRate = Convert.ToDouble(hiRateTxtBox.Text);
            honorariumHours = Convert.ToDouble(hiHoursTxtBox.Text);
            otherRate = Convert.ToDouble(oiRateTxtBox.Text);
            otherHours = Convert.ToDouble(oiHoursTxtBox.Text);

            basicIncome = basicRate * basicHours;
            honorariumIncome = honorariumRate * honorariumHours;
            otherIncome = otherRate * otherHours;

            grossIncome = basicIncome + honorariumIncome + otherIncome;

            grossIncomeTxtBox.Text = grossIncome.ToString("n");
            biIncomeTxtBox.Text = basicIncome.ToString("n");
            hiIncomeTxtBox.Text = honorariumIncome.ToString("n");
            oiIncomeTxtBox.Text = otherIncome.ToString("n");

            if (grossIncome < 5250)
                sssContrib = 760.00;
            else if (grossIncome >= 5250 && grossIncome < 5749.99)
                sssContrib = 835.00;
            else if (grossIncome >= 5750 && grossIncome < 6249.99)
                sssContrib = 910.00;
            else if (grossIncome >= 6250 && grossIncome < 6749.99)
                sssContrib = 985.00;
            else if (grossIncome >= 6750 && grossIncome < 7249.99)
                sssContrib = 1060.00;
            else if (grossIncome >= 7250 && grossIncome < 7749.99)
                sssContrib = 1135.00;
            else if (grossIncome >= 7750 && grossIncome < 8249.99)
                sssContrib = 1210.00;
            else if (grossIncome >= 8250 && grossIncome < 8749.99)
                sssContrib = 1285.00;
            else if (grossIncome >= 8750 && grossIncome < 9249.99)
                sssContrib = 1360.00;
            else if (grossIncome >= 9250 && grossIncome < 9749.99)
                sssContrib = 1435.00;
            else if (grossIncome >= 9750 && grossIncome < 10249.99)
                sssContrib = 1510.00;
            else if (grossIncome >= 10250 && grossIncome < 10749.99)
                sssContrib = 1585.00;
            else if (grossIncome >= 10750 && grossIncome < 11249.99)
                sssContrib = 1660.00;
            else if (grossIncome >= 11250 && grossIncome < 11749.99)
                sssContrib = 1735.00;
            else if (grossIncome >= 11750 && grossIncome < 12249.99)
                sssContrib = 1810.00;
            else if (grossIncome >= 12250 && grossIncome < 12749.99)
                sssContrib = 1885.00;
            else if (grossIncome >= 12750 && grossIncome < 13249.99)
                sssContrib = 1960.00;
            else if (grossIncome >= 13250 && grossIncome < 13749.99)
                sssContrib = 2035.00;
            else if (grossIncome >= 13750 && grossIncome < 14249.99)
                sssContrib = 2110.00;
            else if (grossIncome >= 14250 && grossIncome < 14749.99)
                sssContrib = 2185.00;
            else if (grossIncome >= 14750 && grossIncome < 15249.99)
                sssContrib = 2260.00;
            else if (grossIncome >= 15250 && grossIncome < 15749.99)
                sssContrib = 2335.00;
            else if (grossIncome >= 15750 && grossIncome < 16249.99)
                sssContrib = 2430.00;
            else if (grossIncome >= 16250 && grossIncome < 16749.99)
                sssContrib = 2505.00;
            else if (grossIncome >= 16750 && grossIncome < 17249.99)
                sssContrib = 2580.00;
            else if (grossIncome >= 17250 && grossIncome < 17749.99)
                sssContrib = 2655.00;
            else if (grossIncome >= 17750 && grossIncome < 18249.99)
                sssContrib = 2730.00;
            else if (grossIncome >= 18250 && grossIncome < 18749.99)
                sssContrib = 2805.00;
            else if (grossIncome >= 18750 && grossIncome < 19249.99)
                sssContrib = 2880.00;
            else if (grossIncome >= 19250 && grossIncome < 19749.99)
                sssContrib = 2955.00;
            else if (grossIncome >= 19750 && grossIncome < 20249.99)
                sssContrib = 3030.00;
            else if (grossIncome >= 20250 && grossIncome < 20749.99)
                sssContrib = 3105.00;
            else if (grossIncome >= 20750 && grossIncome < 21249.99)
                sssContrib = 3180.00;
            else if (grossIncome >= 21250 && grossIncome < 21749.99)
                sssContrib = 3255.00;
            else if (grossIncome >= 21750 && grossIncome < 22249.99)
                sssContrib = 3330.00;
            else if (grossIncome >= 22250 && grossIncome < 22749.99)
                sssContrib = 3405.00;
            else if (grossIncome >= 22750 && grossIncome < 23249.99)
                sssContrib = 3480.00;
            else if (grossIncome >= 23250 && grossIncome < 23749.99)
                sssContrib = 3555.00;
            else if (grossIncome >= 23750 && grossIncome < 24249.99)
                sssContrib = 3630.00;
            else if (grossIncome >= 24250 && grossIncome < 24749.99)
                sssContrib = 3705.00;
            else if (grossIncome >= 24750 && grossIncome < 25249.99)
                sssContrib = 3780.00;
            else if (grossIncome >= 25250 && grossIncome < 25749.99)
                sssContrib = 3855.00;
            else if (grossIncome >= 25750 && grossIncome < 26249.99)
                sssContrib = 3930.00;
            else if (grossIncome >= 26250 && grossIncome < 26749.99)
                sssContrib = 4005.00;
            else if (grossIncome >= 26750 && grossIncome < 27249.99)
                sssContrib = 4080.00;
            else if (grossIncome >= 27250 && grossIncome < 27749.99)
                sssContrib = 4155.00;
            else if (grossIncome >= 27750 && grossIncome < 28249.99)
                sssContrib = 4230.00;
            else if (grossIncome >= 28250 && grossIncome < 28749.99)
                sssContrib = 4305.00;
            else if (grossIncome >= 28750 && grossIncome < 29249.99)
                sssContrib = 4380.00;
            else if (grossIncome >= 29250 && grossIncome < 29749.99)
                sssContrib = 4455.00;
            else if (grossIncome >= 29750 && grossIncome < 30249.99)
                sssContrib = 4530.00;
            else if (grossIncome >= 30250 && grossIncome < 30749.99)
                sssContrib = 4605.00;
            else if (grossIncome >= 30750 && grossIncome < 31249.99)
                sssContrib = 4680.00;
            else if (grossIncome >= 31250 && grossIncome < 31749.99)
                sssContrib = 4755.00;
            else if (grossIncome >= 31750 && grossIncome < 32249.99)
                sssContrib = 4830.00;
            else if (grossIncome >= 32250 && grossIncome < 32749.99)
                sssContrib = 4905.00;
            else if (grossIncome >= 32750 && grossIncome < 33249.99)
                sssContrib = 4980.00;
            else if (grossIncome >= 33250 && grossIncome < 33749.99)
                sssContrib = 5055.00;
            else if (grossIncome >= 33750 && grossIncome < 34249.99)
                sssContrib = 5130.00;
            else if (grossIncome >= 34250 && grossIncome < 34749.99)
                sssContrib = 5205.00;
            else
            {
                sssContrib = 5280.00;
            }

           if (grossIncome < (250000 / 24))
            {
                incomeTaxContrib = 0.00;
            }
           else if (grossIncome >= (250000 / 24) && grossIncome <= (400000 / 24))
            {
                incomeTaxContrib = ((((grossIncome * 24) - 250000) * 0.15) / 24);
            }
           else if (grossIncome >= (400000 / 24) && grossIncome <= (800000 / 24))
            {
                incomeTaxContrib = ((((grossIncome * 24) - 400000) * 0.20) + 22500) / 24;
            }
            else if (grossIncome >= (800000 / 24) && grossIncome <= (2000000 / 24))
            {
                 incomeTaxContrib = ((((grossIncome * 24) - 800000) * 0.25) + 102500) / 24;
            }
           else if (grossIncome >= (2000000 / 24) && grossIncome <= (8000000 / 24))
            {
                incomeTaxContrib = ((((grossIncome * 24) - 2000000) * 0.30) + 402500) / 24;
            }
            else
            {
                incomeTaxContrib = ((((grossIncome * 24) - 8000000) * 0.35) + 2202500) / 24;
            }


            if (grossIncome <= 10000)
                philhealthContrib = grossIncome * 0.05;
            else if (grossIncome > 10000 && grossIncome <= 99999.99)
                philhealthContrib = grossIncome * 0.05;
            else
            {
                philhealthContrib = grossIncome * 0.05;
            }

            sssContribTxtBox.Text = sssContrib.ToString("n");
            philhealthContribTxtBox.Text = philhealthContrib.ToString("n");
            pagibigContribTxtBox.Text = pagibigContrib.ToString("n");
            incomeTaxContribTxtBox.Text = incomeTaxContrib.ToString("n");
        }

        private void netIncomeBtn_Click(object sender, EventArgs e)
        {
            double sssLoan, pagibigLoan, facultyDeposit, facultyLoan, salaryLoan, otherLoans, totalDeductions, netIncome, grossIncome;

            sssLoan = Convert.ToDouble(sssLoanTxtBox.Text);
            pagibigLoan = Convert.ToDouble(pagibigLoanTxtBox.Text);
            facultyDeposit = Convert.ToDouble(facultyDepositTxtBox.Text);
            facultyLoan = Convert.ToDouble(facultyLoanTxtBox.Text);
            salaryLoan = Convert.ToDouble(salaryLoanTxtBox.Text);
            otherLoans = Convert.ToDouble(otherLoansTxtBox.Text);

            totalDeductions = Convert.ToDouble(sssContribTxtBox.Text) + Convert.ToDouble(pagibigContribTxtBox.Text) + Convert.ToDouble(philhealthContribTxtBox.Text) +
                Convert.ToDouble(incomeTaxContribTxtBox.Text) + sssLoan + pagibigLoan + facultyDeposit + facultyLoan + salaryLoan + otherLoans;
            grossIncome = Convert.ToDouble(grossIncomeTxtBox.Text);

            netIncome = grossIncome - totalDeductions;

            totalDeductionsTxtBox.Text = totalDeductions.ToString("n");
            netIncomeTxtBox.Text = netIncome.ToString("n");
        }

        private static void ClearTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBoxBase tb)
                    tb.Clear();

                if (c.HasChildren)
                    ClearTextBoxes(c);
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
            biRateTxtBox.Focus();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            payslipreport print = new payslipreport();

            // Populate via public properties (avoids accessing private controls)
            print.EmployeeCode = employeeNumberTxtBox.Text;
            print.EmployeeName = $"{firstNameTxtBox.Text} {middleNameTxtBox.Text} {surnameTxtBox.Text}";
            print.Department   = departmentTxtBox.Text;
            print.CutOff       = payDateTxtBox.Text;
            print.PayPeriod    = payDateTxtBox.Text;

            print.BasicPayHrs      = biHoursTxtBox.Text;
            print.BasicPayIncome   = biIncomeTxtBox.Text;
            print.HonorariumHrs    = hiHoursTxtBox.Text;
            print.HonorariumIncome = hiIncomeTxtBox.Text;
            print.OvertimeHrs      = oiHoursTxtBox.Text;
            print.OvertimeIncome   = oiIncomeTxtBox.Text;

            print.WithholdingTax = incomeTaxContribTxtBox.Text;
            print.SSS            = sssContribTxtBox.Text;
            print.Pagibig        = pagibigContribTxtBox.Text;
            print.Philhealth     = philhealthContribTxtBox.Text;
            print.Wisp           = "750";

            print.Earnings   = grossIncomeTxtBox.Text;
            print.Deductions = totalDeductionsTxtBox.Text;
            print.Overtime   = oiIncomeTxtBox.Text;

            print.Gross       = grossIncomeTxtBox.Text;
            print.NetPay      = netIncomeTxtBox.Text;
            print.Deductions  = totalDeductionsTxtBox.Text;

            print.Show();
        }
    }
}
