using System;
using System.Windows.Forms;

namespace LESSON_1
{
    public partial class payslipreport : Form
    {
        public payslipreport()
        {
            InitializeComponent();
            prEmployeeCodeTxtBox.Enabled = false;
            prEmployeeNameTxtBox.Enabled = false;
            prDepartmentTxtBox.Enabled = false;
            prCutOffTxtBox.Enabled = false;
            prPayPeriodTxtBox.Enabled = false;
            prBasicPayHrsTxtBox.Enabled = false;
            prBasicPayIncomeTxtBox.Enabled = false;
            prHonorariumHrsTxtBox.Enabled = false;
            prHonorariumIncomeTxtBox.Enabled = false;
            prOvertimeHrsTxtBox.Enabled = false;
            prOvertimeIncomeTxtBox.Enabled = false;
            prWithholdingTxtBox.Enabled = false;
            prSSSTxtBox.Enabled = false;
            prHDMFTxtBox.Enabled = false;
            prPhilhealthTxtBox.Enabled = false;
            prWispTxtBox.Enabled = false;
            prGrossTxtBox.Enabled = false;
            prNetPayTxtBox.Enabled = false;
            prDeductionsTxtBox2.Enabled = false;
            prEarningsTxtBox.Enabled = false;
            prDeductionsTxtBox.Enabled = false;
            prOvertimeTxtBox.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;

            // Default all numeric fields to "0.00"
            prBasicPayHrsTxtBox.Text = "0.00";
            prBasicPayIncomeTxtBox.Text = "0.00";
            prHonorariumHrsTxtBox.Text = "0.00";
            prHonorariumIncomeTxtBox.Text = "0.00";
            prOvertimeHrsTxtBox.Text = "0.00";
            prOvertimeIncomeTxtBox.Text = "0.00";

            prWithholdingTxtBox.Text = "0.00";
            prSSSTxtBox.Text = "0.00";
            prHDMFTxtBox.Text = "0.00";
            prPhilhealthTxtBox.Text = "0.00";
            prWispTxtBox.Text = "0.00";

            prEarningsTxtBox.Text = "0.00";
            prDeductionsTxtBox.Text = "0.00";
            prOvertimeTxtBox.Text = "0.00";

            prGrossTxtBox.Text = "0.00";
            prDeductionsTxtBox2.Text = "0.00";
            prNetPayTxtBox.Text = "0.00";

            // Row detail textboxes
            textBox22.Text = "0.00";
            textBox21.Text = "0.00";
            textBox20.Text = "0.00";
            textBox19.Text = "0.00";
            textBox18.Text = "0.00";
            textBox17.Text = "0.00";
            textBox13.Text = "0.00";
            textBox12.Text = "0.00";
            textBox11.Text = "0.00";
            textBox10.Text = "0.00";
            textBox9.Text = "0.00";
            textBox8.Text = "0.00";
        }

        // Header
        public string EmployeeCode { get => prEmployeeCodeTxtBox.Text; set => prEmployeeCodeTxtBox.Text = value; }
        public string EmployeeName { get => prEmployeeNameTxtBox.Text; set => prEmployeeNameTxtBox.Text = value; }
        public string Department   { get => prDepartmentTxtBox.Text;   set => prDepartmentTxtBox.Text   = value; }
        public string CutOff       { get => prCutOffTxtBox.Text;       set => prCutOffTxtBox.Text       = value; }
        public string PayPeriod    { get => prPayPeriodTxtBox.Text;    set => prPayPeriodTxtBox.Text    = value; }

        // Earnings
        public string BasicPayHrs       { get => prBasicPayHrsTxtBox.Text;       set => prBasicPayHrsTxtBox.Text       = value; }
        public string BasicPayIncome    { get => prBasicPayIncomeTxtBox.Text;    set => prBasicPayIncomeTxtBox.Text    = value; }
        public string HonorariumHrs     { get => prHonorariumHrsTxtBox.Text;     set => prHonorariumHrsTxtBox.Text     = value; }
        public string HonorariumIncome  { get => prHonorariumIncomeTxtBox.Text;  set => prHonorariumIncomeTxtBox.Text  = value; }
        public string OvertimeHrs       { get => prOvertimeHrsTxtBox.Text;       set => prOvertimeHrsTxtBox.Text       = value; }
        // When OvertimeIncome is set, mirror it to the Overtime summary box
        public string OvertimeIncome
        {
            get => prOvertimeIncomeTxtBox.Text;
            set
            {
                prOvertimeIncomeTxtBox.Text = value;
                prOvertimeTxtBox.Text = value; // Summary "Overtime" shows Other Income
            }
        }
        // Explicit property if you want to set the summary directly
        public string Earnings { get => prEarningsTxtBox.Text; set => prEarningsTxtBox.Text = value; }
        public string Overtime { get => prOvertimeTxtBox.Text; set => prOvertimeTxtBox.Text = value; }

        // Deductions
        public string WithholdingTax { get => prWithholdingTxtBox.Text; set => prWithholdingTxtBox.Text = value; }
        public string SSS            { get => prSSSTxtBox.Text;         set => prSSSTxtBox.Text         = value; }
        public string Pagibig        { get => prHDMFTxtBox.Text;        set => prHDMFTxtBox.Text        = value; } // HDMF = Pagibig
        public string Philhealth     { get => prPhilhealthTxtBox.Text;  set => prPhilhealthTxtBox.Text  = value; }
        public string Wisp           { get => prWispTxtBox.Text;        set => prWispTxtBox.Text        = value; }

        // Summaries
        // When Gross is set, mirror it to the left "EARNINGS" summary box
        public string Gross
        {
            get => prGrossTxtBox.Text;
            set
            {
                prGrossTxtBox.Text = value;      // Right-side Gross Earnings
                prEarningsTxtBox.Text = value;   // Left "EARNINGS" summary shows gross
            }
        }

        // When Deductions is set, mirror it to the middle and right "DEDUCTIONS" boxes
        public string Deductions
        {
            get => prDeductionsTxtBox2.Text;
            set
            {
                prDeductionsTxtBox2.Text = value; // Right-side Deductions
                prDeductionsTxtBox.Text = value;  // Middle Deductions summary shows total deductions
            }
        }

        public string NetPay { get => prNetPayTxtBox.Text; set => prNetPayTxtBox.Text = value; }
    }
}
