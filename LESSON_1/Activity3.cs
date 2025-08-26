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
    public partial class Activity3 : Form
    {
        // Constructor: Initializes the form and its components
        public Activity3()
        {
            InitializeComponent();
        }

        // Event handler for form load: Sets the initial background color
        private void Activity3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
        }

        // Event handler for selecting Food Bundle A radio button
        private void foodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Change the form background color to indicate selection
            this.BackColor = Color.IndianRed;

            // Ensure Food Bundle B radio button is not selected
            foodBRdbtn.Checked = false;

            // Display the image for Food Bundle A and stretch it to fit the PictureBox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 1 Images\\chickenjoy-bucket-with-rice-1-768x768.png");
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Check all checkboxes related to Food Bundle A
            A_CokeCheckBox.Checked = true;
            A_FriedChickenCheckBox.Checked = true;
            A_FriesCheckBox.Checked = true;
            A_SideDishCheckBox.Checked = true;
            A_SpecialPizzaCheckBox.Checked = true;

            // Uncheck all checkboxes related to Food Bundle B
            B_CarbonaraCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HaloHaloCheckBox.Checked = false;
            B_HawaiianCheckBox.Checked = false;

            // Display price and discount information for Food Bundle A
            priceTxtbox.Text = "1000.00";
            discountTxtbox.Text = "(20% of the Price) P200";
        }

        // Event handler for selecting Food Bundle B radio button
        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Change the form background color to indicate selection
            this.BackColor = Color.LightGoldenrodYellow;

            // Ensure Food Bundle A radio button is not selected
            foodARdbtn.Checked = false;

            // Display the image for Food Bundle B and stretch it to fit the PictureBox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\Gemini_Generated_Image_9pkc4w9pkc4w9pkc.png");
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Uncheck all checkboxes related to Food Bundle A
            A_CokeCheckBox.Checked = false;
            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_SideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;

            // Check all checkboxes related to Food Bundle B
            B_CarbonaraCheckBox.Checked = true;
            B_ChickenCheckBox.Checked = true;
            B_FriesCheckBox.Checked = true;
            B_HaloHaloCheckBox.Checked = true;
            B_HawaiianCheckBox.Checked = true;

            // Display price and discount information for Food Bundle B
            priceTxtbox.Text = "1,299.00";
            discountTxtbox.Text = "(20% of the Price) P194.85";
        }

        // Event handler for the reset button: Clears selections and resets the form
        private void button1_Click(object sender, EventArgs e)
        {
            // Uncheck both radio buttons
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            // Display the default image and stretch it to fit the PictureBox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Uncheck all checkboxes for both bundles
            A_CokeCheckBox.Checked = false;
            A_FriedChickenCheckBox.Checked = false;                                                                                                                                                                                                                             
            A_FriesCheckBox.Checked = false;
            A_SideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HaloHaloCheckBox.Checked = false;
            B_HawaiianCheckBox.Checked = false;

            // Clear price and discount textboxes
            priceTxtbox.Clear();                                                                                                        
            discountTxtbox.Clear();
        }                                                                                                                                                                                                   

        // Event handler for the close button: Closes the form
        private void button3_Click(object sender, EventArgs e)
        {                                                                                           
            this.Close();
        }
    }
}
