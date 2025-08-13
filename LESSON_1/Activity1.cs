namespace LESSON_1
{
    // Partial class for the Activity1 form, containing event handlers for UI interactions
    public partial class Activity1 : Form
    {
        // Constructor: Initializes the form and its components
        public Activity1()
        {
            InitializeComponent();
        }

        // Handles click event for pictureBox1
        // Sets item name and price for "Breakfast Meal B"
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "121.30";
        }

        // Handles click event for pictureBox2
        // Sets item name and price for "Friend Meal A"
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Friend Meal A";
            priceTxtbox.Text = "391.90";                                
        }

        // Handles click event for pictureBox3
        // Sets item name and price for "Double Value Meal A"
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Double Value Meal A";
            priceTxtbox.Text = "191.00";
        }

        // Handles click event for pictureBox4
        // Sets item name and price for "Family Combo Meal A"
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Family Combo Meal A";
            priceTxtbox.Text = "799.30";
        }

        // Handles click event for pictureBox5
        // Sets item name and price for "Breakfast Meal A"
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "91.30";
        }

        // Handles click event for pictureBox10
        // Sets item name and price for "Breakfast Meal A" (alternate price)
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "95.00";
        }

        // Handles click event for pictureBox9
        // Sets item name and price for "Pasta Meal 101"
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Pasta Meal 101";
            priceTxtbox.Text = "98.00";
        }

        // Handles click event for pictureBox8
        // Sets item name and price for "Family Combo Meal A" (alternate price)
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Family Combo Meal A";
            priceTxtbox.Text = "999.90";
        }

        // Handles click event for pictureBox7
        // Sets item name and price for "CHicken Meal A"
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "CHicken Meal A";
            priceTxtbox.Text = "177.30";
        }

        // Handles click event for pictureBox6
        // Sets item name and price for "Lunch Value Meal 1"
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Lunch Value Meal 1";
            priceTxtbox.Text = "199.10";
        }

        // Handles click event for pictureBox15
        // Sets item name and price for "Palabok Meal"
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Palabok Meal";
            priceTxtbox.Text = "120.50";
        }

        // Handles click event for pictureBox14
        // Sets item name and price for "Chicken Meal 2"
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Chicken Meal 2";
            priceTxtbox.Text = "191.30";
        }

        // Handles click event for pictureBox13
        // Sets item name and price for "Pancake Value Meal A"
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Pancake Value Meal A";
            priceTxtbox.Text = "97.30";
        }

        // Handles click event for pictureBox12
        // Sets item name and price for "Breakfast Meal B" (alternate price)
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "133.30";
        }

        // Handles click event for pictureBox11
        // Sets item name and price for "Lunch Value Meal B"
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Lunch Value Meal B";
            priceTxtbox.Text = "191.30";
        }

        // Handles click event for newBtn
        // Clears the item name and price text boxes
        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
        }

        // Handles click event for exitBtn
        // Closes the form
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
