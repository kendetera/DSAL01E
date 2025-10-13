using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_1
{
    public partial class pos1_func : Form
    {
        private int qty;
        private double discount_amt, discounted_amt, price;
        public pos1_func()
        {
            InitializeComponent();
            // Disable textboxes for item details and totals.
            itemnametxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            discount_txtbox.Enabled = false;
            discounted_txtbox.Enabled = false;
            qty_totalbox.Enabled = false;
            discount_totalbox.Enabled = false;
            discounted_totalbox.Enabled = false;
            changetxtbox.Enabled = false;

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
        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {
            // Do nothing here, or maybe just validate numeric input
            if (!int.TryParse(quantitytxtbox.Text, out _))
            {
                // Optional: show a message or ignore non-numeric input
                return;
            }
        }

        private void quantity_price_Convert()
        {
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
        }

        private void computation_Formula_and_DisplayData()
        {
            // Compute the discounted amount (total after discount)
            discounted_amt = (qty * price) - discount_amt;

            // Show discount given
            discount_txtbox.Text = discount_amt.ToString("n");

            // Show final price after discount
            discounted_txtbox.Text = discounted_amt.ToString("n");
        }

        // Helper so all discount handlers share same logic
        private void ApplyDiscount1()
        {
            quantity_price_Convert();
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;
            computation_Formula_and_DisplayData();
        }

        private void ApplyDiscount2()
        {
            quantity_price_Convert();
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            computation_Formula_and_DisplayData();
        }

        private void ApplyDiscount3()
        {
            quantity_price_Convert();
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;
            computation_Formula_and_DisplayData();
        }

        private void ApplyDiscount4()
        {
            quantity_price_Convert();
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;
            computation_Formula_and_DisplayData();
        }

        private bool InputsReady()
        {
            if (string.IsNullOrWhiteSpace(pricetxtbox.Text))
            {
                MessageBox.Show("Select an item first.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(quantitytxtbox.Text))
            {
                MessageBox.Show("Enter quantity first.");
                return false;
            }
            return true;
        }

        private void seniorCtznRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && !rb.Checked) return;
            try
            {
                if (!InputsReady()) return;
                quantity_price_Convert();
                ApplyDiscount1();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }

        private void withDiscCardRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && !rb.Checked) return;
            try
            {
                if (!InputsReady()) return;
                quantity_price_Convert();
                ApplyDiscount2();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
            ;
        }

        private void employeeDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && !rb.Checked) return;
            try
            {
                if (!InputsReady()) return;
                quantity_price_Convert();
                ApplyDiscount3();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }

        private void nodiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && !rb.Checked) return;
            try
            {
                if (!InputsReady()) return;
                quantity_price_Convert();
                ApplyDiscount4(); // No discount
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(quantitytxtbox.Text, out int qty))
            {
                MessageBox.Show("Please enter a valid quantity.");
                quantitytxtbox.Focus();
                return;
            }

            // Discount fields might be empty if no radio button selected
            double discount_amt = 0;
            double discounted_amt = 0;

            // Try parse with current culture because ToString("n") used current culture for formatting
            double.TryParse(discount_txtbox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out discount_amt);
            if (!double.TryParse(discounted_txtbox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out discounted_amt))
            {
                // If discounted amount isn't set yet, compute from price
                if (!double.TryParse(pricetxtbox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double price))
                {
                    MessageBox.Show("Please select an item first.");
                    return;
                }
                discounted_amt = qty * price - discount_amt;
            }

            if (!double.TryParse(cash_renderedtxtbox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out double cash_rendered))
            {
                MessageBox.Show("Please enter a valid cash amount.");
                cash_renderedtxtbox.Focus();
                return;
            }

            int qty_total = 0;
            double discount_totalgiven = 0, discounted_total = 0;

            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            double change = cash_rendered - discounted_amt;

            qty_totalbox.Text = qty_total.ToString();
            discount_totalbox.Text = discount_totalgiven.ToString("n");
            discounted_totalbox.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cash_renderedtxtbox.Text = cash_rendered.ToString("n");
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Code for clearing all textboxes
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discount_txtbox.Clear();
            discounted_txtbox.Clear();
            cash_renderedtxtbox.Clear();
            changetxtbox.Clear();

            // Re-enable and clear discount selection
            seniorCtznRdBtn.Enabled = true;
            withDiscCardRdBtn.Enabled = true;
            employeeDiscRdBtn.Enabled = true;
            noDiscRdBtn.Enabled = true;

            // Uncheck without triggering calculations (handlers now early-return when unchecked)
            seniorCtznRdBtn.Checked = false;
            withDiscCardRdBtn.Checked = false;
            employeeDiscRdBtn.Checked = false;
            noDiscRdBtn.Checked = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Breakfast Hotdog";
            itemnametxtbox.Text = "Breakfast Hotdog";
            pricetxtbox.Text = "95.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            name2lbl.Text = "Burger Steak";
            itemnametxtbox.Text = "Burger Steak";
            pricetxtbox.Text = "99.90";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            name3lbl.Text = "Chicken Fillet";
            itemnametxtbox.Text = "Chicken Fillet";
            pricetxtbox.Text = "120.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            name4lbl.Text = "Bucket Meal A";
            itemnametxtbox.Text = "Bucket Meal A";
            pricetxtbox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            name5lbl.Text = "Burger Steak w/ Egg";
            itemnametxtbox.Text = "Burger Steak w/ Egg";
            pricetxtbox.Text = "189.30";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            name10lbl.Text = "Corned Beef";
            itemnametxtbox.Text = "Corned Beef";
            pricetxtbox.Text = "95.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            namel9bl.Text = "Spaghetti n Yumburger";
            itemnametxtbox.Text = "Spaghetti n Yumburger";
            pricetxtbox.Text = "98.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            name8lbl.Text = "Family Bucket Meal";
            itemnametxtbox.Text = "Bucket Meal B";
            pricetxtbox.Text = "999.90";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            name7bl.Text = "Chickenjoy C1";
            itemnametxtbox.Text = "CHickenjoy C1";
            pricetxtbox.Text = "127.30";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            name6lbl.Text = "Chickenjoy C2";
            itemnametxtbox.Text = "Chickenjoy C2";
            pricetxtbox.Text = "149.10";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            name15lbl.Text = "Palabok Meal";
            itemnametxtbox.Text = "Palabok Meal";
            pricetxtbox.Text = "120.50";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            name14lbl.Text = "Chickenjoy C3";
            itemnametxtbox.Text = "Chickenjoy C3";
            pricetxtbox.Text = "191.30";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            name13lbl.Text = "Pancake Meal";
            itemnametxtbox.Text = "Pancake Meal";
            pricetxtbox.Text = "97.30";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            name12lbl.Text = "Shanghai Meal";
            itemnametxtbox.Text = "Shanghai Meal";
            pricetxtbox.Text = "133.30";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            name11lbl.Text = "Lunch Meal A";
            itemnametxtbox.Text = "Lunch Meal A";
            pricetxtbox.Text = "191.30";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            namel16bl.Text = "6 pc. Chicken Nuggets";
            itemnametxtbox.Text = "6 pc. Chicken Nuggets";
            pricetxtbox.Text = "449.30";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            name17lbl.Text = "Yumburger and Fries";
            itemnametxtbox.Text = "Yumburger and Fries";
            pricetxtbox.Text = "138.30";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            name18lbl.Text = "Fries";
            itemnametxtbox.Text = "Fries";
            pricetxtbox.Text = "85.30";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            name19lbl.Text = "Yumburger Gamejoy Combo";
            itemnametxtbox.Text = "Yumburger Gamejoy Combo";
            pricetxtbox.Text = "235.70";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            name20lbl.Text = "Jolly Hotdog";
            itemnametxtbox.Text = "Jolly Hotdog";
            pricetxtbox.Text = "130.90";
        }

        private void withDiscCardRdBtn_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}