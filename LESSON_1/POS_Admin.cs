using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace LESSON_1
{
    public partial class POS_Admin : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;

        public POS_Admin()
        {
            posdb_connect.connString();
            posdb_connect.pos_select();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            InitializeComponent();
            pos_id_comboBox.Items.Add("1");
            pos_id_comboBox.Items.Add("2");
            pos_id_comboBox.Items.Add("3");
            pos_id_comboBox.Items.Add("4");
            pos_id_comboBox.Items.Add("5");
        }

        private void cleartextboxes()
        {
            try
            {
                pic = Image.FromFile(@"C:\Users\kenne\OneDrive\Documents\GitHub\CSharp-Projects\LESSON_1\Resources\default-user-image.png");

                picpathTxtbox1.Clear(); picpathTxtbox2.Clear(); picpathTxtbox3.Clear(); picpathTxtbox4.Clear();picpathTxtbox5.Clear();
                picpathTxtbox6.Clear(); picpathTxtbox7.Clear(); picpathTxtbox8.Clear(); picpathTxtbox9.Clear(); picpathTxtbox10.Clear();
                picpathTxtbox11.Clear(); picpathTxtbox12.Clear(); picpathTxtbox13.Clear(); picpathTxtbox14.Clear(); picpathTxtbox15.Clear();
                picpathTxtbox16.Clear(); picpathTxtbox17.Clear(); picpathTxtbox18.Clear(); picpathTxtbox19.Clear(); picpathTxtbox20.Clear();

                pictureBox1.Image = pic; pictureBox2.Image = pic; pictureBox3.Image = pic; pictureBox4.Image = pic; pictureBox5.Image = pic;
                pictureBox6.Image = pic; pictureBox7.Image = pic; pictureBox8.Image = pic; pictureBox9.Image = pic; pictureBox10.Image = pic;
                pictureBox11.Image = pic; pictureBox12.Image = pic; pictureBox13.Image = pic; pictureBox14.Image = pic; pictureBox15.Image = pic;
                pictureBox16.Image = pic; pictureBox17.Image = pic; pictureBox18.Image = pic; pictureBox19.Image = pic; pictureBox20.Image = pic;

                priceTxtbox1.Clear(); priceTxtbox2.Clear(); priceTxtbox3.Clear(); priceTxtbox4.Clear(); priceTxtbox5.Clear();
                priceTxtbox6.Clear(); priceTxtbox7.Clear(); priceTxtbox8.Clear(); priceTxtbox9.Clear(); priceTxtbox10.Clear();
                priceTxtbox11.Clear(); priceTxtbox12.Clear(); priceTxtbox13.Clear(); priceTxtbox14.Clear(); priceTxtbox15.Clear();
                priceTxtbox16.Clear(); priceTxtbox17.Clear(); priceTxtbox18.Clear(); priceTxtbox19.Clear(); priceTxtbox20.Clear();

                nameTxtbox1.Clear(); nameTxtbox2.Clear(); nameTxtbox3.Clear(); nameTxtbox4.Clear(); nameTxtbox5.Clear();
                nameTxtbox6.Clear(); nameTxtbox7.Clear(); nameTxtbox8.Clear(); nameTxtbox9.Clear(); nameTxtbox10.Clear();
                nameTxtbox11.Clear(); nameTxtbox12.Clear(); nameTxtbox13.Clear(); nameTxtbox14.Clear(); nameTxtbox15.Clear();
                nameTxtbox16.Clear(); nameTxtbox17.Clear(); nameTxtbox18.Clear(); nameTxtbox19.Clear(); nameTxtbox20.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("1");
            }
        }

        private void open_file_image()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.ShowDialog();

        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide(); picpathTxtbox4.Hide(); picpathTxtbox5.Hide();
                picpathTxtbox6.Hide(); picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide(); picpathTxtbox10.Hide();
                picpathTxtbox11.Hide(); picpathTxtbox12.Hide(); picpathTxtbox13.Hide(); picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
                picpathTxtbox16.Hide(); picpathTxtbox17.Hide(); picpathTxtbox18.Hide(); picpathTxtbox19.Hide(); picpathTxtbox20.Hide();
                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }

            catch (Exception)
            {
                MessageBox.Show("2");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '" + pos_id_comboBox.Text + "' ";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

                nameTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                nameTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                nameTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                nameTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                nameTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                nameTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                nameTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                nameTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                nameTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                nameTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                nameTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                nameTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                nameTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                nameTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                nameTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                nameTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                nameTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                nameTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                nameTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                nameTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                picpathTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                pictureBox1.Image = Image.FromFile(picpathTxtbox1.Text);
                picpathTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                pictureBox2.Image = Image.FromFile(picpathTxtbox2.Text);

                priceTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                priceTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                priceTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                priceTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                priceTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                priceTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                priceTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                priceTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                priceTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                priceTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                priceTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                priceTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                priceTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                priceTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                priceTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                priceTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                priceTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                priceTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                priceTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                priceTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql =
                    "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) " +
                    "VALUES ('" + pos_id_comboBox.Text + "', '" + nameTxtbox1.Text + "', '" + nameTxtbox2.Text + "', '" + nameTxtbox3.Text + "', '" + nameTxtbox4.Text + "', '" + nameTxtbox5.Text + "', '" + nameTxtbox6.Text + "', '" + nameTxtbox7.Text + "', '" + nameTxtbox8.Text + "', '" + nameTxtbox9.Text + "', '" + nameTxtbox10.Text + "', '" + nameTxtbox11.Text + "', '" + nameTxtbox12.Text + "', '" + nameTxtbox13.Text + "', '" + nameTxtbox14.Text + "', '" + nameTxtbox15.Text + "', '" + nameTxtbox16.Text + "', '" + nameTxtbox17.Text + "', '" + nameTxtbox18.Text + "', '" + nameTxtbox19.Text + "', '" + nameTxtbox20.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql =
                    "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) " +
                    "VALUES ('" + priceTxtbox1.Text + "', '" + priceTxtbox2.Text + "', '" + priceTxtbox3.Text + "', '" + priceTxtbox4.Text + "', '" + priceTxtbox5.Text + "', '" + priceTxtbox6.Text + "', '" + priceTxtbox7.Text + "', '" + priceTxtbox8.Text + "', '" + priceTxtbox9.Text + "', '" + priceTxtbox10.Text + "', '" + priceTxtbox11.Text + "', '" + priceTxtbox12.Text + "', '" + priceTxtbox13.Text + "', '" + priceTxtbox14.Text + "', '" + priceTxtbox15.Text + "', '" + priceTxtbox16.Text + "', '" + priceTxtbox17.Text + "', '" + priceTxtbox18.Text + "', '" + priceTxtbox19.Text + "', '" + priceTxtbox20.Text + "', '" + pos_id_comboBox.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql =
                    "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) " +
                    "VALUES ('" + picpathTxtbox1.Text + "', '" + picpathTxtbox2.Text + "', '" + picpathTxtbox3.Text + "', '" + picpathTxtbox4.Text + "', '" + picpathTxtbox5.Text + "', '" + picpathTxtbox6.Text + "', '" + picpathTxtbox7.Text + "', '" + picpathTxtbox8.Text + "', '" + picpathTxtbox9.Text + "', '" + picpathTxtbox10.Text + "', '" + picpathTxtbox11.Text + "', '" + picpathTxtbox12.Text + "', '" + picpathTxtbox13.Text + "', '" + picpathTxtbox14.Text + "', '" + picpathTxtbox15.Text + "', '" + picpathTxtbox16.Text + "', '" + picpathTxtbox17.Text + "', '" + picpathTxtbox18.Text + "', '" + picpathTxtbox19.Text + "', '" + picpathTxtbox20.Text + "', '" + pos_id_comboBox.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save failed");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
            
                posdb_connect.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + nameTxtbox1.Text + "', name2 = '" + nameTxtbox2.Text + "' WHERE pos_id = '" + pos_id_comboBox.Text + "' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + priceTxtbox1.Text + "', price2 = '" + priceTxtbox2.Text + " ' WHERE pos_id = '" + pos_id_comboBox.Text + "' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_picTbl SET pic1 = '" + picpath + "', pic2 = '" + picpath + "' WHERE pos_id = '" + pos_id_comboBox.Text + "' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();
                posdb_connect.pos_select();

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();

            }
            catch (Exception)
            {
                MessageBox.Show("5");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.pos_id = '" + pos_id_comboBox.Text + "' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_picTbl WHERE pos_picTbl.pos_id = '" + pos_id_comboBox.Text + "' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_nameTbl.pos_id = '" + pos_id_comboBox.Text + "' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("6");
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
                openFileDialog.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                picpath = openFileDialog.FileName;
                picpathTxtbox1.Text = picpath;


            }
            catch (Exception)
            {
                MessageBox.Show("7");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
                openFileDialog.ShowDialog();
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                picpath = openFileDialog.FileName;
                picpathTxtbox2.Text = picpath;
            
            }
            catch (Exception)
            {
                MessageBox.Show("8");
            }
        }

        private void pos_id_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
