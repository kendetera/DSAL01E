using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_1
{
    public partial class student_info_function : Form
    {
        String picpath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
        public student_info_function()
        {
            connectionString = @"Data Source=KEN\SQLEXPRESS ; Initial Catalog = SampleDatabaseDB ; Trusted_Connection = True";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void clrTextBoxes()
        {
            picturepathTxtBox.Clear();
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
        }

        private void cmd()
        {
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
        }

        private void sqlSelect()
        {
            sql = "SELECT * FROM studentTbl";
        }

        private void sqlAdapterSelect()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
        }

        private void sqlAdapterDelete()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();
        }

        private void sqlAdapterUpdate()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();
        }

        private void sqlAdapterInsert()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();
        }

        private void dataSet()
        {
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            griddisplay.DataSource = dset.Tables[0];
        }

        private void student_info_class_Load(object sender, EventArgs e)
        {
            picturepathTxtBox.Hide();
            connection.Open();
            sqlSelect();
            cmd();
            sqlAdapterSelect();
            dataSet();
            connection.Close();
        }

        private void savebBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) " +
                "VALUES (' " + studentNumTxtBox.Text + " ', ' " + studentNameTxtBox.Text + " ', ' " + departmentTxtBox.Text + " ', ' " + picpath + " ')";

            cmd();
            sqlAdapterInsert();
            sqlSelect();
            cmd();
            sqlAdapterSelect();
            dataSet();
            connection.Close();
            clrTextBoxes();
            pictureBox1.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "SELECT * FROM studentTbl WHERE student_id = ' " + studentNumTxtBox.Text + " ' ";

            cmd();
            sqlAdapterSelect();
            dataSet();
            studentNameTxtBox.Text = dset.Tables[0].Rows[0][1].ToString();
            departmentTxtBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picturepathTxtBox.Text = dset.Tables[0].Rows[0][3].ToString();
            connection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "DELETE FROM studentTbl WHERE student_id = ' " + studentNumTxtBox.Text + " ' ";

            cmd();
            sqlAdapterDelete();
            sqlSelect();
            cmd();
            sqlAdapterSelect();
            dataSet();
            connection.Close();
            clrTextBoxes();
            pictureBox1.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "UPDATE studentTbl SET student_name = ' " + studentNameTxtBox.Text + " ', department = ' " + departmentTxtBox.Text + " '," +
                " picpath = ' " + picpath + " ' WHERE student_id = ' " + studentNumTxtBox.Text + " ' ";

            cmd();
            sqlAdapterUpdate();
            sqlSelect();
            cmd();
            sqlAdapterSelect();
            dataSet();
            connection.Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = selectedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
