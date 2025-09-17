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
    public partial class payslip : Form
    {
        // Data carrier for the payslip (constructed in prelimexam)
        public sealed record PayrollData(
            double BasicRate,
            double BasicHours,
            double BasicIncome,
            double HonorariumRate,
            double HonorariumHours,
            double HonorariumIncome,
            double OtherRate,
            double OtherHours,
            double OtherIncome,
            double GrossIncome,
            double SssContrib,
            double PagibigContrib,
            double PhilhealthContrib,
            double IncomeTaxContrib,
            double SssLoan,
            double PagibigLoan,
            double FacultyDeposit,
            double FacultyLoan,
            double SalaryLoan,
            double OtherLoans,
            double TotalDeductions,
            double NetIncome
        );

        private readonly PayrollData? _data;

        public payslip()
        {
            InitializeComponent();
        }

        public payslip(PayrollData data) : this()
        {
            _data = data;
            Load += Payslip_Load;
        }

        private void Payslip_Load(object? sender, EventArgs e)
        {
            // Map header fields from the owner prelimexam form
            SetHeaderFieldsFromOwnerForm();

            // Apply numeric data if available
            if (_data is not null)
                ApplyDataToControls(_data);

            // Disable all text boxes
            DisableAllTextBoxes(this);
        }

        private static string F(double v) => v.ToString("n");

        // Helper: try to read a TextBoxBase value from the owner form by control Name.
        private static string GetOwnerText(Control? owner, string controlName)
        {
            if (owner is null) return string.Empty;
            var match = owner.Controls.Find(controlName, true).OfType<TextBoxBase>().FirstOrDefault();
            return match?.Text ?? string.Empty;
        }

        // Map prelimexam header inputs to payslip header fields
        private void SetHeaderFieldsFromOwnerForm()
        {
            var owner = Owner as Control;
            if (owner is null) return;

            // Employee Code = employee number
            textBox1.Text = GetOwnerText(owner, "employeeNumberTxtBox");

            // Employee Name = first name + middle name + surname
            var first = GetOwnerText(owner, "firstNameTxtBox");
            var middle = GetOwnerText(owner, "middleNameTxtBox");
            var surname = GetOwnerText(owner, "surnameTxtBox");
            var fullName = string.Join(" ", new[] { first, middle, surname }.Where(s => !string.IsNullOrWhiteSpace(s)));
            textBox2.Text = fullName;

            // Department = department (shown in label8 on payslip header)
            var dept = GetOwnerText(owner, "departmentTxtBox");
            if (!string.IsNullOrWhiteSpace(dept))
                label8.Text = dept;

            // Cut-Off = paydate, Pay Period = pay date (both set to payDateTxtBox)
            var payDate = GetOwnerText(owner, "payDateTxtBox");
            textBox3.Text = payDate; // Cut-Off
            textBox4.Text = payDate; // Pay Period
        }

        // Disable all text boxes (make the payslip read-only)
        private static void DisableAllTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBoxBase tb)
                    tb.Enabled = false;

                if (c.HasChildren)
                    DisableAllTextBoxes(c);
            }
        }

        // Map data from prelimexam to payslip textboxes.
        private void ApplyDataToControls(PayrollData d)
        {
            // 


            // EARNINGS grid
            // Basic Pay
            textBox5.Text  = F(d.BasicHours);   // Day/Hrs
            textBox16.Text = F(d.BasicIncome);  // Taxable
            textBox22.Text = F(0);              // Non-Taxable (none)

            // Overtime = other income
            textBox6.Text  = F(d.OtherHours);   // Day/Hrs
            textBox15.Text = F(d.OtherIncome);  // Taxable
            textBox21.Text = F(0);              // Non-Taxable

            // Honorarium = honorarium income
            textBox7.Text  = F(d.HonorariumHours);   // Day/Hrs
            textBox14.Text = F(d.HonorariumIncome);  // Taxable
            textBox20.Text = F(0);                   // Non-Taxable

            // Honorarium Adjustment = 0
            textBox8.Text  = F(0); // Day/Hrs
            textBox13.Text = F(0); // Taxable
            textBox19.Text = F(0); // Non-Taxable

            // Substitution = 0
            textBox9.Text  = F(0); // Day/Hrs
            textBox12.Text = F(0); // Taxable
            textBox18.Text = F(0); // Non-Taxable

            // Tardy = 0
            textBox10.Text = F(0); // Day/Hrs
            textBox11.Text = F(0); // Taxable
            textBox17.Text = F(0); // Non-Taxable

            // DEDUCTIONS (statutory)
            textBox23.Text = F(d.IncomeTaxContrib);   // Withholding Tax
            textBox25.Text = F(d.PagibigContrib);     // HDMF
            textBox26.Text = F(d.PhilhealthContrib);  // Philhealth
            textBox24.Text = F(d.SssContrib);         // SSS
            textBox27.Text = F(750);                  // SSS WISP = 750

            // Section totals (labels in UI)
            textBox28.Text = F(d.GrossIncome);        // EARNINGS (left summary)
            textBox29.Text = F(d.TotalDeductions);    // DEDUCTIONS (middle summary)
            textBox30.Text = F(d.OtherIncome);        // OVERTIME

            textBox31.Text = F(d.GrossIncome);        // GROSS EARNINGS (right summary)
            textBox32.Text = F(d.TotalDeductions);    // DEDUCTIONS (right summary)
            textBox33.Text = F(d.NetIncome);          // NET PAY

            // Header fields like Company/Employee are not provided by prelimexam;
            // leave textBox1/textBox2/textBox3/textBox4 as-is or set them externally.
        }
    }
}
