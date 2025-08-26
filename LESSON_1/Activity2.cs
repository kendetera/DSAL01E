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
    // Activity2 form: Displays menu items as clickable images and shows item details.
    public partial class Activity2 : Form
    {
        // Constructor: Initializes the form and its components.
        public Activity2()
        {
            InitializeComponent();
        }

        // Form Load event: Disables input fields and loads images for menu items.
        private void Activity2_Load(object sender, EventArgs e)
        {
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

        // Each picture box click event sets the item name and price in the textboxes.
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
    }
}
