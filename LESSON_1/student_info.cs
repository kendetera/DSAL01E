using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;



namespace LESSON_1
{
    public partial class student_info : Form
    {
        String picpath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;



        public student_info()
        {
            connectionString = @"Data Source=KEN\SQLEXPRESS ; Initial Catalog = SampleDatabaseDB ; Trusted_Connection = True";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void savebBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) " +
                "VALUES (' " + studentNumTxtBox.Text + " ', ' " + studentNameTxtBox.Text + " ', ' " + departmentTxtBox.Text + " ', ' " + picpath + " ')";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            griddisplay.DataSource = dset.Tables[0];

            pictureBox1.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();

            if (connection.State != ConnectionState.Closed)
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            sql = "SELECT * FROM studentTbl WHERE student_id = ' " + studentNumTxtBox.Text + " ' ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            griddisplay.DataSource = dset.Tables[0];

            studentNameTxtBox.Text = dset.Tables[0].Rows[0][1].ToString();
            departmentTxtBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picturepathTxtBox.Text = dset.Tables[0].Rows[0][3].ToString();

            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            sql = "DELETE FROM studentTbl WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            griddisplay.DataSource = dset.Tables[0];

            pictureBox1.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            sql = "UPDATE studentTbl SET student_name = ' " + studentNameTxtBox.Text + " ', department = ' " + departmentTxtBox.Text + " '," +
                " picpath = ' " + picpath + " ' WHERE student_id = ' " + studentNumTxtBox.Text + " ' ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            griddisplay.DataSource = dset.Tables[0];

            pictureBox1.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();

            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\kende\\source\\repos\\LESSON_1\\Activity 3 Images\\360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
