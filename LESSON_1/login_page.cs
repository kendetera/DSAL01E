using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LESSON_1
{
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "Admin" && passwordTxtBox.Text == "admin123")
            {
                MessageBox.Show("Welcome Admin!");
                MainForm MainForm = new MainForm();
                MainForm.Show();
                usernameTxtBox.Clear();
                passwordTxtBox.Clear();
            }
            else if (usernameTxtBox.Text == "Cashier 1" && passwordTxtBox.Text == "cash1")
            {
                MessageBox.Show("Welcome Cashier 1!");
                Activity1 act1 = new Activity1();
                act1.Show();
                usernameTxtBox.Clear();
                passwordTxtBox.Clear();
            }
            else if (usernameTxtBox.Text == "Cashier 2" && passwordTxtBox.Text == "cash2")
            {
                MessageBox.Show("Welcome Cashier 2!");
                Activity2 act2 = new Activity2();
                act2.Show();
                usernameTxtBox.Clear();
                passwordTxtBox.Clear();
            }
            else if (usernameTxtBox.Text == "Payroll" && passwordTxtBox.Text == "payroll123")
            {
                MessageBox.Show("Welcome Payroll!");
                prelimexam prelimExam = new prelimexam();
                prelimExam.Show();
                usernameTxtBox.Clear();
                passwordTxtBox.Clear();
            }
            else if (usernameTxtBox.Text == "Cashier 3" && passwordTxtBox.Text == "cash3")
            {
                MessageBox.Show("Welcome Cashier 3!");
                Activity3 act3 = new Activity3();
                act3.Show();
                usernameTxtBox.Clear();
                passwordTxtBox.Clear();
            }
            else if (usernameTxtBox.Text == "Enrollment" && passwordTxtBox.Text == "enroll123")
            {
                MessageBox.Show("Welcome Enrollment!");
                Form1 act4 = new Form1();
                act4.Show();
                usernameTxtBox.Clear();
                passwordTxtBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                usernameTxtBox.Clear();
                passwordTxtBox.Clear();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
