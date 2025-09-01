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
            // Clear all TextBox controls on the form.
            ClearTextBoxes(this);
        }

        private static void ClearTextBoxes(Control parent)
        {
            // Walk through all child controls.
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox textBox)
                {
                    // Empty the TextBox content.
                    textBox.Clear();
                }
                else if (c.HasChildren)
                {
                    // Recurse into container controls (e.g., Panels/GroupBoxes).
                    ClearTextBoxes(c);
                }
            }
        }
    }
}
