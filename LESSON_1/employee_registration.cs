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
    public partial class employee_registration : Form
    {
        string picpath;
        employee_dbconnection emp_db_connect = new employee_dbconnection();

        public employee_registration()
        {
            emp_db_connect.employee_connString();
            InitializeComponent();
        }
        private void cleartextboxes()
        {
            emp_idTxtbox.Clear(); fnameTxtbox.Clear(); surnameTxtbox.Clear(); sssTxtbox.Clear(); tinTxtbox.Clear(); philhealthTxtbox.Clear();
            pagibigTxtbox.Clear(); heightTxtbox.Clear(); weightTxtbox.Clear(); current_yrsTxtbox.Clear(); current_ho_noTxtbox.Clear(); current_streetTxtbox.Clear();
            current_barangayTxtbox.Clear(); current_muinicipalityTxtbox.Clear(); current_cityTxtbox.Clear(); current_stateTxtbox.Clear(); current_zipTxtbox.Clear();
            current_countryTxtbox.Clear(); elem_nameTxtbox.Clear(); elem_addressTxtbox.Clear(); elem_awardsTxtbox.Clear(); junior_nameTxtbox.Clear(); junior_addressTxtbox.Clear();
            junior_awardsTxtbox.Clear(); senior_nameTxtbox.Clear(); senior_addressTxtbox.Clear(); senior_awardsTxtbox.Clear(); college_nameTxtbox.Clear(); college_addressTxtbox.Clear();
            college_awardsTxtbox.Clear(); othersTxtbox.Clear(); college_courseTxtbox.Clear(); positionTxtbox.Clear(); departmentTxtbox.Clear(); no_of_dependentsTxtbox.Clear(); picturepathTxtbox.Clear();
        }

        private void employee_registration_Load(object sender, EventArgs e)
        {
            picturepathTxtbox.Hide();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
            openFileDialog.ShowDialog();
            picbox.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picturepathTxtbox.Text = picpath;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            fnameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][2].ToString();
            mnameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][3].ToString();
            surnameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][4].ToString();
            ageComboBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][5].ToString();
            genderComboBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][6].ToString();
            sssTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][7].ToString();
            tinTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][8].ToString();
            philhealthTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][9].ToString();
            pagibigTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][10].ToString();
            statusComboBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][11].ToString();
            heightTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][12].ToString();
            weightTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][13].ToString();
            current_yrsTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][14].ToString();
            current_ho_noTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][15].ToString();
            currentSub_noTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][16].ToString();
            current_phaseTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][17].ToString();
            current_streetTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][18].ToString();
            current_barangayTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][19].ToString();
            current_muinicipalityTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][20].ToString();
            current_cityTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][21].ToString();
            current_stateTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][22].ToString();
            current_countryTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][23].ToString();
            current_zipTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][24].ToString();
            elem_nameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][25].ToString();
            elem_addressTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][26].ToString();
            elem_yr_gradTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][27].ToString();
            elem_awardsTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][28].ToString();
            junior_nameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][29].ToString();
            junior_addressTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][30].ToString();
            junior_yr_gradTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][31].ToString();
            junior_awardsTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][32].ToString();
            senior_nameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][33].ToString();
            senior_addressTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][34].ToString();
            senior_yr_gradTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][35].ToString();
            senior_awardsTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][36].ToString();
            senior_trackTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][37].ToString();
            college_nameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][38].ToString();
            college_addressTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][39].ToString();
            college_courseTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][40].ToString();
            college_yr_gradTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][41].ToString();
            college_awardsTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][42].ToString();
            othersTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][43].ToString();
            positionTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][44].ToString();
            employee_statusTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][45].ToString();
            date_hiredTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][46].ToString();
            departmentTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][47].ToString();
            no_of_dependentsTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][48].ToString();
            picturepathTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][49].ToString();
            picbox.Image = Image.FromFile(picturepathTxtbox.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, add_yrs_stay, add_house_no, add_sub_name, add_phase_no, add_street, add_barangay, add_municipality, add_city, add_state_province, add_country, add_zipcode, elem_name, elem_address, elem_yr_grad, elem_awards, junior_high_name, junior_high_address, junior_high_yr_grad, junior_high_awards, senior_high_name, senior_high_address, senior_high_yr_grad, senior_high_awards, senior_high_track, college_school_name, college_address, college_yr_grad, college_awards, college_course, others, position, emp_work_status, emp_date_hired, emp_department, emp_no_of_dependents, picpath) VALUES ('"
                + emp_idTxtbox.Text + "', '" + fnameTxtbox.Text + "', '" + mnameTxtbox.Text + "', '" + surnameTxtbox.Text + "', '" + ageComboBox.Text + "', '" + genderComboBox.Text + "', '" + sssTxtbox.Text + "', '" + tinTxtbox.Text + "', '" + philhealthTxtbox.Text + "', '" + pagibigTxtbox.Text + "', '" + statusComboBox.Text + "', '" + heightTxtbox.Text + "', '" + weightTxtbox.Text + "', '" + current_yrsTxtbox.Text + "', '" + current_ho_noTxtbox.Text + "', '" + currentSub_noTxtbox.Text + "', '" + current_phaseTxtbox.Text + "', '" + current_streetTxtbox.Text + "', '" + current_barangayTxtbox.Text + "', '" + current_muinicipalityTxtbox.Text + "', '" + current_cityTxtbox.Text + "', '" + current_stateTxtbox.Text + "', '" + current_countryTxtbox.Text + "', '" + current_zipTxtbox.Text + "', '" + elem_nameTxtbox.Text + "', '" + elem_addressTxtbox.Text + "', '" + elem_yr_gradTxtbox.Text + "', '" + elem_awardsTxtbox.Text + "', '" + junior_nameTxtbox.Text + "', '" + junior_addressTxtbox.Text + "', '" + junior_yr_gradTxtbox.Text + "', '" + junior_awardsTxtbox.Text + "', '" + senior_nameTxtbox.Text + "', '" + senior_addressTxtbox.Text + "', '" + senior_yr_gradTxtbox.Text + "', '" + senior_awardsTxtbox.Text + "', '" + senior_trackTxtbox.Text + "', '" + college_nameTxtbox.Text + "', '" + college_addressTxtbox.Text + "', '" + college_yr_gradTxtbox.Text + "', '" + college_awardsTxtbox.Text + "', '" + college_courseTxtbox.Text + "', '" + othersTxtbox.Text + "', '" + positionTxtbox.Text + "', '" + employee_statusTxtbox.Text + "', '" + date_hiredTxtbox.Text + "', '" + departmentTxtbox.Text + "', '" + no_of_dependentsTxtbox.Text + "', '" + picturepathTxtbox.Text + "')";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterInsert();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "UPDATE pos_empRegTbl SET emp_fname = '" + fnameTxtbox.Text + "', emp_mname = '" + mnameTxtbox.Text + "', emp_surname = '" + surnameTxtbox.Text + "', emp_age = '" + ageComboBox.Text + "', emp_gender = '" + genderComboBox.Text + "', emp_sss_no = '" + sssTxtbox.Text + "', emp_tin_no = '" + tinTxtbox.Text + "', emp_philhealth_no = '" + philhealthTxtbox.Text + "', emp_pagibig_no = '" + pagibigTxtbox.Text + "', emp_status = '" + statusComboBox.Text + "', emp_height = '" + heightTxtbox.Text + "', emp_weight = '" + weightTxtbox.Text + "', add_yrs_stay = '" + current_yrsTxtbox.Text + "', add_house_no = '" + current_ho_noTxtbox.Text + "', add_sub_name = '" + currentSub_noTxtbox.Text + "', add_phase_no = '" + current_phaseTxtbox.Text + "', add_street = '" + current_streetTxtbox.Text + "', add_barangay = '" + current_barangayTxtbox.Text + "', add_municipality = '" + current_muinicipalityTxtbox.Text + "', add_city = '" + current_cityTxtbox.Text + "', add_state_province = '" + current_stateTxtbox.Text + "', add_country = '" + current_countryTxtbox.Text + "', add_zipcode = '" + current_zipTxtbox.Text + "', elem_name = '" + elem_nameTxtbox.Text + "', elem_address = '" + elem_addressTxtbox.Text + "', elem_yr_grad = '" + elem_yr_gradTxtbox.Text + "', elem_awards = '" + elem_awardsTxtbox.Text + "', junior_high_name = '" + junior_nameTxtbox.Text + "', junior_high_address = '" + junior_addressTxtbox.Text + "', junior_high_yr_grad = '" + junior_yr_gradTxtbox.Text + "', junior_high_awards = '" + junior_awardsTxtbox.Text + "', senior_high_name = '" + senior_nameTxtbox.Text + "', senior_high_address = '" + senior_addressTxtbox.Text + "', senior_high_yr_grad = '" + senior_yr_gradTxtbox.Text + "', senior_high_awards = '" + senior_awardsTxtbox.Text + "', senior_high_track = '" + senior_trackTxtbox.Text + "', college_school_name = '" + college_nameTxtbox.Text + "', college_address = '" + college_addressTxtbox.Text + "', college_yr_grad = '" + college_yr_gradTxtbox.Text + "', college_awards = '" + college_awardsTxtbox.Text + "', college_course = '" + college_courseTxtbox.Text + "', others = '" + othersTxtbox.Text + "', position = '" + positionTxtbox.Text + "', emp_work_status = '" + employee_statusTxtbox.Text + "', emp_date_hired = '" + date_hiredTxtbox.Text + "', emp_department = '" + departmentTxtbox.Text + "', emp_no_of_dependents = '" + no_of_dependentsTxtbox.Text + "', picpath = '" + picturepathTxtbox.Text + "' WHERE emp_id = '" + emp_idTxtbox.Text + "'";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterUpdate();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterDelete();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}