using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_1
{
    public partial class Example6 : Form
    {
        // Added backing fields to track totals and amounts
        private double discountAmount;
        private double discountedAmount;
        private int totalQty;
        private double totalAmount;
        private double price;

        public Example6()
        {
            InitializeComponent();
            // Load images into picture boxes for menu items.
            pictureBox1.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\Longganisa-Meal.jpg");
            pictureBox2.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\1pc-Burger-Steak-Solo-by-Jollibee-600x450.jpg");
            pictureBox3.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\jollibee-chicken-fillet-march-2025-1741595318.jpg");
            pictureBox4.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\chickenjoy-bucket-with-rice-1-768x768.png");
            pictureBox5.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 1 Images\\da76da64-0c18-4cb7-9af0-f7da23c87873.png");
            pictureBox10.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 1 Images\\images.jpg");
            pictureBox9.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\741cc_jollibee_offers.jpg");
            pictureBox8.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\chickenjoy-bucket-with-jolly-spaghetti-family-pack.jpg");
            pictureBox7.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\1-pc.-Chickenjoy-With-Coke-Float.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\Jollibee-Chickenjoy-2018-1.jpg");
            pictureBox15.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\Palabok-Solo-1.jpg");
            pictureBox14.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\2-pc.-Chickenjoy-With-Drink.png");
            pictureBox13.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\jollibee-breakfast-pancakes.png");
            pictureBox12.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\microsoftteams-image-1696386903.jpg");
            pictureBox11.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON1\\Chickenjoy-with-Fries-Super-Meal.jpg");
            pictureBox16.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 2 Images\\6pc-Chicken-Nuggets-Jollibee.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 2 Images\\82a04771-e067-4ed8-bcdd-aaa0676a52a0.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 2 Images\\2222223-500x500.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 2 Images\\Group-GameJoy-Combo-413x413.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 2 Images\\jolly.png");

            // Disabling text boxes that display calculated values to prevent user input.
            priceTxtBox.Enabled = false;
            discAmtTxtBox.Enabled = false;
            discountedAmtTxtBox.Enabled = false;
            totalBillsTxtBox.Enabled = false;
            totalQtyTxtBox.Enabled = false;
            changeTxtBox.Enabled = false;

        }

        private void qtyTxtBox_TextChanged(object sender, EventArgs e)
        {
            int qty;
            price = Convert.ToDouble(priceTxtBox.Text);
            qty = Convert.ToInt32(qtyTxtBox.Text);
            discountAmount = Convert.ToDouble(discAmtTxtBox.Text);
            discountedAmount = (price * qty) - discountAmount;
            totalQty += qty;
            totalQtyTxtBox.Text += totalQty.ToString();
            totalAmount += discountedAmount;
            totalBillsTxtBox.Text = totalAmount.ToString("n");
            discountedAmtTxtBox.Text = discountedAmount.ToString("n");
        }

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
            A_ChickenjoyC1ChkBox.Checked = true;
            A_BurgerNFriesChkBox.Checked = true;
            A_PalabokChkBox.Checked = true;


            // Uncheck all checkboxes related to Food Bundle B
            B_ChickenjoyC2ChkBox.Checked = false;
            B_FriesChkBox.Checked = false;
            B_JollyHotdogChkBox.Checked = false;

            // Display price and discount information for Food Bundle A
            priceTxtBox.Text = "300.00";
            discAmtTxtBox.Text = "50";
            
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(foodARdbtn.Text + "          " + priceTxtBox.Text);
            displayListBox.Items.Add("Discount: " + discAmtTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;

            foodARdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\Gemini_Generated_Image_sk5wausk5wausk5w.png");
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            B_ChickenjoyC2ChkBox.Checked = true;
            B_FriesChkBox.Checked = true;
            B_JollyHotdogChkBox.Checked = true;

            A_ChickenjoyC1ChkBox.Checked = false;
            A_BurgerNFriesChkBox.Checked = false;
            A_PalabokChkBox.Checked = false;

            priceTxtBox.Text = "250.00";
            discAmtTxtBox.Text = "30";

            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(foodBRdbtn.Text + "          " + priceTxtBox.Text);
            displayListBox.Items.Add("Discount: " + discAmtTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void calculateBillsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double cashGiven, totalAmountPaid, change;

                cashGiven = Convert.ToDouble(cashGivenTxtBox.Text);
                totalAmountPaid = Convert.ToDouble(totalBillsTxtBox.Text);
                change = cashGiven - totalAmountPaid;
                changeTxtBox.Text = change.ToString("n");
                displayListBox.Items.Add("Total Bills: " + "          " + totalBillsTxtBox.Text);
                displayListBox.Items.Add("Cash Given: " + "          " + cashGivenTxtBox.Text);
                displayListBox.Items.Add("Change: " + "          " + changeTxtBox.Text);
                displayListBox.Items.Add("Total No. of Items: " + "          " + totalQtyTxtBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter amount of cash given!");
                cashGivenTxtBox.Clear();
                cashGivenTxtBox.Focus();
            }

        }

        private void printTransactBtn_Click(object sender, EventArgs e)
        {
            Example6 print = new Example6();
            print.displayListBox.Items.AddRange(this.displayListBox.Items);
            print.Show();
        }

        private void removeOrderBtn_Click(object sender, EventArgs e)
        {
            displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;
            A_BurgerNFriesChkBox.Checked = false;
            A_ChickenjoyC1ChkBox.Checked = false;
            A_PalabokChkBox.Checked = false;
            B_ChickenjoyC2ChkBox.Checked = false;
            B_FriesChkBox.Checked = false;
            B_JollyHotdogChkBox.Checked = false;

            priceTxtBox.Clear();
            qtyTxtBox.Clear();
            cashGivenTxtBox.Clear();
            displayListBox.Items.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "95.30";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox1.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "99.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox2.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "120.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox3.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "799.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox4.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "180.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox5.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "98.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox6.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "95.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox7.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "999.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox8.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "125.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox9.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "150.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox10.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "120.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox11.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "125.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox12.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "89.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox13.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "119.30";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox14.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "189.30";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox15.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "128.30";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox16.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "109.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox17.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "69.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox18.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "249.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox19.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "95.30";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox20.Text + "          " + priceTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }
    }
}
