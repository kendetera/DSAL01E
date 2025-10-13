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
    public partial class act1_func : Form
    {
        public act1_func()
        {
            InitializeComponent();
        }

        private void displaytextbox(string itemname, string price)
        {
            itemnameTxtbox.Text = itemname;
            priceTxtbox.Text = price;
        }
        private void quantitytextbox()
        {
            qtyTxtBox.Clear();
            qtyTxtBox.Focus();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displaytextbox("Adobo", "100");
            quantitytextbox();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            displaytextbox("Adobo", "100");
            quantitytextbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displaytextbox("Adobo", "100");
            quantitytextbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displaytextbox("Adobo", "100");
            quantitytextbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displaytextbox("Adobo", "100");
            quantitytextbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            displaytextbox("Adobo", "100");
            quantitytextbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displaytextbox("Breakfast Meal B", "100");
            quantitytextbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            displaytextbox("Friend Meal A", "100");
            quantitytextbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            displaytextbox("Double Value Meal A", "100");
            quantitytextbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            displaytextbox("Family Combo Meal A", "100");
            quantitytextbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            displaytextbox("Breakfast Meal A", "100");
            quantitytextbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            displaytextbox("Breakfast Meal A", "100");
            quantitytextbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            displaytextbox("Pasta Meal 101", "100");
            quantitytextbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            displaytextbox("Family Combo Meal A", "100");
            quantitytextbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            displaytextbox("AdLunch Value Meal", "100");
            quantitytextbox();
        }
    }
}
