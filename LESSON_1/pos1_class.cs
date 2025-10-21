using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_1
{
    public partial class pos1_class : Form
    {
        // Centralized POS logic/state in a class while retaining all existing functions and logic.
        private PosEngine _engine = new PosEngine();

        private int qty;
        private double price;

        public pos1_class()
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

        private void GetPriceItemValue()
        {
            itemnametxtbox.Text = _engine.PriceItemValue.GetItemName();
            pricetxtbox.Text = _engine.PriceItemValue.GetPrice();
        }

        private void pos1_class_Load(object sender, EventArgs e)
        {

        }

        private void ComputationFormulaAndDisplayData()
        {
            // Keep exact computation formula and display logic.
            var m = _engine.Model;
            m.discounted_amt = (m.qty * m.price) - m.discount_amt;
            discount_txtbox.Text = m.discount_amt.ToString("n");
            discounted_txtbox.Text = m.discounted_amt.ToString("n");
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var m = _engine.Model;

                m.qty = Convert.ToInt32(quantitytxtbox.Text);
                m.discount_amt = Convert.ToDouble(discount_txtbox.Text);
                m.discounted_amt = Convert.ToDouble(discounted_txtbox.Text);
                m.cash_rendered = Convert.ToDouble(cash_renderedtxtbox.Text);

                m.qty_total += m.qty;
                m.discount_totalgiven += m.discount_amt;
                m.discounted_total += m.discounted_amt;
                m.change = m.cash_rendered - m.discounted_amt;

                qty_totalbox.Text = m.qty_total.ToString("n");
                discount_totalbox.Text = m.discount_totalgiven.ToString("n");
                discounted_totalbox.Text = m.discounted_total.ToString("n");
                changetxtbox.Text = m.change.ToString("n");
                cash_renderedtxtbox.Text = m.cash_rendered.ToString("n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a valid data. " + ex.Message);
            }
        }

        private void quantity_price_Convert()
        {
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);

            // Keep the shared model in sync (this is what your formulas use)
            _engine.Model.qty = qty;
            _engine.Model.price = price;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _engine.PriceItemValue.SetPriceItemValue("Breakfast Hotdog", " 95.30");
            GetPriceItemValue();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _engine.PriceItemValue.SetPriceItemValue("Burger Steak", " 120.50");
            GetPriceItemValue();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _engine.PriceItemValue.SetPriceItemValue("Pork Chop", " 150.75");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _engine.PriceItemValue.SetPriceItemValue("Chicken BBQ", " 180.25");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _engine.PriceItemValue.SetPriceItemValue("Spaghetti", " 110.00");
            GetPriceItemValue();
        }

        private void seniorCtznRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is RadioButton rb && !rb.Checked) return;
                try
                {
                    quantity_price_Convert();
                    var m = _engine.Model;
                    m.discount_amt = (m.qty * m.price) * 0.30;
                    ComputationFormulaAndDisplayData();
                    withDiscCardRdBtn.Enabled = false;
                    noDiscRdBtn.Enabled = false;
                    employeeDiscRdBtn.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid input: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a valid data. " + ex.Message);
            }
        }

        private void withDiscCardRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                var m = _engine.Model;
                m.discount_amt = (m.qty * m.price) * 0.10;
                ComputationFormulaAndDisplayData();
                seniorCtznRdBtn.Enabled = false;
                noDiscRdBtn.Enabled = false;
                employeeDiscRdBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }

        private void employeeDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                var m = _engine.Model;
                m.discount_amt = (m.qty * m.price) * 0.15;
                ComputationFormulaAndDisplayData();
                seniorCtznRdBtn.Enabled = false;
                noDiscRdBtn.Enabled = false;
                withDiscCardRdBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }

        private void noDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                var m = _engine.Model;
                m.discount_amt = (m.qty * m.price) * 0;
                ComputationFormulaAndDisplayData();
                seniorCtznRdBtn.Enabled = false;
                employeeDiscRdBtn.Enabled = false;
                withDiscCardRdBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
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

        // Encapsulated POS state and simple operations in a class (used above).
        private class PosEngine
        {
            public Price_Item_Value PriceItemValue { get; } = new Price_Item_Value();
            public Variables1 Model { get; } = new Variables1();
        }
    }
}
