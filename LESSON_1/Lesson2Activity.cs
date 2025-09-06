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
    public partial class Form1 : Form
    {
        private int totalUnits = 0;
        public Form1()
        {
            InitializeComponent();

            // Populate the Programs combo box.
            SchoolComboBox.Items.Add("BSCE (Bachelor of Science in Civil Engineering)");
            SchoolComboBox.Items.Add("BSCpE (Bachelor of Science in Computer Engineering)");
            SchoolComboBox.Items.Add("BSECE (Bachelor of Science in Electronics Engineering)");
            SchoolComboBox.Items.Add("BSEE (Bachelor of Science in Electrical Engineering)");
            SchoolComboBox.Items.Add("BSME (Bachelor of Science in Mechanical Engineering)");
            SchoolComboBox.Items.Add("BSIE (Bachelor of Science in Industrial Engineering)");

            totalNumUnitsTxtBox.Enabled = false;
            totalNumUnits2TxtBox.Enabled = false;
            totalTuitionFeeTxtBox.Enabled = false;
            totalTuitionFee2TxtBox.Enabled = false;
            creditUnitsTxtBox.Enabled = false;
            totalMiscFeeTxtBox.Enabled = false;
            totalMiscFee2TxtBox.Enabled = false;
            totalTuitionAndFeeTxtBox.Enabled = false;
            totalTuitionAndFee2TxtBox.Enabled = false;
            comLabFeeTxtBox.Enabled = false;
            ciscoLabFee2TxtBox.Enabled = false;
            examBookletFee2TxtBox.Enabled = false;
            totalOtherFeeTxtBox.Enabled = false;
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
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

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Accumulate the total number of units.
            int unitLec, unitLab, creditUnit;
            unitLec = Convert.ToInt32(unitLecTxtBox.Text);
            unitLab = Convert.ToInt32(unitLabTxtBox.Text);
            creditUnit = unitLec + unitLab;
            totalUnits += creditUnit;
            totalNumUnits2TxtBox.Text = totalUnits.ToString();
            totalNumUnitsTxtBox.Text = totalUnits.ToString();
            creditUnitsTxtBox.Text = creditUnit.ToString();

            // Read values from the input TextBoxes.
            string courseNumber = courseNumberTxtBox.Text;
            string courseCode = courseCodeTxtBox.Text;
            string courseDescription = courseDescTxtBox.Text;
            string unitLecture = unitLecTxtBox.Text;
            string unitLaboratory = unitLabTxtBox.Text;
            string creditUnits = creditUnitsTxtBox.Text;
            string time = timeTxtBox.Text;
            string day = dayTxtBox.Text;

            

            // Add the entered values to the corresponding ListBoxes.
            numListBox.Items.Add(courseNumber);
            courseCodeListBox.Items.Add(courseCode);
            courseDescListBox.Items.Add(courseDescription);
            unitLecListBox.Items.Add(unitLecture);
            unitLabListBox.Items.Add(unitLaboratory);
            creditUnitsListBox.Items.Add(creditUnits);
            timeListBox.Items.Add(time);
            dayListBox.Items.Add(day);

            // Mirror totals/fees to the summary TextBoxes.
            totalTuitionFee2TxtBox.Text = totalTuitionFeeTxtBox.Text;
            totalMiscFee2TxtBox.Text = totalMiscFeeTxtBox.Text;
            ciscoLabFee2TxtBox.Text = ciscoLabFeeTxtBox.Text;
            examBookletFee2TxtBox.Text = examBookletFeeTxtBox.Text;
            totalNumUnits2TxtBox.Text = totalNumUnitsTxtBox.Text;
            totalTuitionFee2TxtBox.Text = totalTuitionFeeTxtBox.Text; // Duplicate copy (ok).
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Clear input text boxes controls on the form.
            courseNumberTxtBox.Clear();
            courseCodeTxtBox.Clear();
            courseDescTxtBox.Clear();
            unitLecTxtBox.Clear();
            unitLabTxtBox.Clear();
            timeTxtBox.Clear();
            dayTxtBox.Clear();
            comLabTxtBox.Clear();
            ciscoLabFeeTxtBox.Clear();
            examBookletFeeTxtBox.Clear();
            creditUnitsTxtBox.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalTuitionFee, totalMiscFee, totalTuitionAndFee, ciscoLabFee, examBookletFee, comLabFee;

            ciscoLabFee = Convert.ToDouble(examBookletFeeTxtBox.Text);
            examBookletFee = Convert.ToDouble(examBookletFeeTxtBox.Text);
            comLabFee = Convert.ToDouble(comLabTxtBox.Text);

            totalTuitionFee = totalUnits * 1700;
            totalMiscFee = examBookletFee + ciscoLabFee + comLabFee;
            totalTuitionAndFee = totalTuitionFee + totalMiscFee;

            totalTuitionFeeTxtBox.Text = totalTuitionFee.ToString("n");
            totalMiscFeeTxtBox.Text = totalMiscFee.ToString("n");
            totalTuitionAndFeeTxtBox.Text = totalTuitionAndFee.ToString("n");
            totalTuitionAndFee2TxtBox.Text = totalTuitionAndFeeTxtBox.Text;
            totalTuitionFee2TxtBox.Text = totalTuitionFeeTxtBox.Text;
            totalMiscFee2TxtBox.Text = totalMiscFeeTxtBox.Text;
            comLabFeeTxtBox.Text = comLabTxtBox.Text;
            ciscoLabFee2TxtBox.Text = ciscoLabFeeTxtBox.Text;
            examBookletFee2TxtBox.Text = examBookletFeeTxtBox.Text;
            
        }
    }
}
