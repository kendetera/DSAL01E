namespace LESSON_1
{
    public partial class Activity1 : Form
    {
        public Activity1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "121.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Friend Meal A";
            priceTxtbox.Text = "391.90";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Double Value Meal A";
            priceTxtbox.Text = "191.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Family Combo Meal A";
            priceTxtbox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "91.30";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "95.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Pasta Meal 101";
            priceTxtbox.Text = "98.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Family Combo Meal A";
            priceTxtbox.Text = "999.90";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "CHicken Meal A";
            priceTxtbox.Text = "177.30";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Lunch Value Meal 1";
            priceTxtbox.Text = "199.10";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Palabok Meal";
            priceTxtbox.Text = "120.50";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Chicken Meal 2";
            priceTxtbox.Text = "191.30";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Pancake Value Meal A";
            priceTxtbox.Text = "97.30";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "133.30";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Lunch Value Meal B";
            priceTxtbox.Text = "191.30";
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
