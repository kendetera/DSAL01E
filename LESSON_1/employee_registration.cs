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
            emp_idTxtbox.Clear(); fnameTxtbox.Clear(); mnameTxtbox.Clear(); surnameTxtbox.Clear(); sssTxtbox.Clear(); tinTxtbox.Clear(); philhealthTxtbox.Clear();
            pagibigTxtbox.Clear(); heightTxtbox.Clear(); weightTxtbox.Clear(); current_yrsTxtbox.Clear(); current_ho_noTxtbox.Clear(); current_streetTxtbox.Clear();
            current_barangayTxtbox.Clear(); current_muinicipalityTxtbox.Clear(); current_cityTxtbox.Clear(); current_stateTxtbox.Clear(); current_zipTxtbox.Clear();
            current_countryTxtbox.Clear(); elem_nameTxtbox.Clear(); elem_addressTxtbox.Clear(); elem_awardsTxtbox.Clear(); junior_nameTxtbox.Clear(); junior_addressTxtbox.Clear();
            junior_awardsTxtbox.Clear(); senior_nameTxtbox.Clear(); senior_addressTxtbox.Clear(); senior_awardsTxtbox.Clear(); college_nameTxtbox.Clear(); college_addressTxtbox.Clear();
            college_awardsTxtbox.Clear(); othersTxtbox.Clear(); college_courseTxtbox.Clear(); positionTxtbox.Clear(); departmentTxtbox.Clear(); no_of_dependentsTxtbox.Clear(); picturepathTxtbox.Clear();
            currentSub_noTxtbox.Clear(); current_phaseTxtbox.Clear(); employee_statusTxtbox.Clear(); senior_trackTxtbox.Clear();
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
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = @empId";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sql_command.Parameters.Clear();
            emp_db_connect.employee_sql_command.Parameters.AddWithValue("@empId", emp_idTxtbox.Text);

            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();

            var table = emp_db_connect.employee_sql_dataset.Tables[0];
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No record found.");
                return;
            }

            var row = table.Rows[0];

            // Map by column name 
            fnameTxtbox.Text = row["emp_fname"].ToString();
            mnameTxtbox.Text = row["emp_mname"].ToString();
            surnameTxtbox.Text = row["emp_surname"].ToString();
            ageComboBox.Text = row["emp_age"].ToString();
            genderComboBox.Text = row["emp_gender"].ToString();
            sssTxtbox.Text = row["emp_sss_no"].ToString();
            tinTxtbox.Text = row["emp_tin_no"].ToString();
            philhealthTxtbox.Text = row["emp_philhealth_no"].ToString();
            pagibigTxtbox.Text = row["emp_pagibig_no"].ToString();
            statusComboBox.Text = row["emp_status"].ToString();
            heightTxtbox.Text = row["emp_height"].ToString();
            weightTxtbox.Text = row["emp_weight"].ToString();
            current_yrsTxtbox.Text = row["add_yrs_stay"].ToString();
            current_ho_noTxtbox.Text = row["add_house_no"].ToString();
            currentSub_noTxtbox.Text = row["add_sub_name"].ToString();
            current_phaseTxtbox.Text = row["add_phase_no"].ToString();
            current_streetTxtbox.Text = row["add_street"].ToString();
            current_barangayTxtbox.Text = row["add_barangay"].ToString();
            current_muinicipalityTxtbox.Text = row["add_municipality"].ToString();
            current_cityTxtbox.Text = row["add_city"].ToString();
            current_stateTxtbox.Text = row["add_state_province"].ToString();
            current_countryTxtbox.Text = row["add_country"].ToString();
            current_zipTxtbox.Text = row["add_zipcode"].ToString();

            elem_nameTxtbox.Text = row["elem_name"].ToString();
            elem_addressTxtbox.Text = row["elem_address"].ToString();
            elem_yr_gradTxtbox.Text = row["elem_yr_grad"].ToString();
            elem_awardsTxtbox.Text = row["elem_award"].ToString(); // ensure column name matches your table

            junior_nameTxtbox.Text = row["junior_high_name"].ToString();
            junior_addressTxtbox.Text = row["junior_high_address"].ToString();
            junior_yr_gradTxtbox.Text = row["junior_high_yr_grad"].ToString();
            junior_awardsTxtbox.Text = row["junior_high_award"].ToString();

            senior_nameTxtbox.Text = row["senior_high_name"].ToString();
            senior_addressTxtbox.Text = row["senior_high_address"].ToString();
            senior_yr_gradTxtbox.Text = row["senior_high_yr_grad"].ToString();
            senior_awardsTxtbox.Text = row["senior_high_award"].ToString();
            senior_trackTxtbox.Text = row["track"].ToString();

            college_nameTxtbox.Text = row["college_school_name"].ToString();
            college_addressTxtbox.Text = row["college_address"].ToString();
            college_courseTxtbox.Text = row["college_course"].ToString();
            college_yr_gradTxtbox.Text = row["college_yr_grad"].ToString();
            college_awardsTxtbox.Text = row["college_award"].ToString();

            othersTxtbox.Text = row["others"].ToString();
            positionTxtbox.Text = row["position"].ToString();
            employee_statusTxtbox.Text = row["emp_work_status"].ToString();

            // DateTimePicker: use Value with TryParse
            var dateHiredText = row["emp_date_hired"]?.ToString();
            if (DateTime.TryParse(dateHiredText, out var dateHired))
            {
                date_hiredTxtbox.Value = dateHired; // date_hiredTxtbox must be a DateTimePicker
            }
            else
            {
                // Optional: reset to today or leave unchanged
                // date_hiredTxtbox.Value = DateTime.Today;
            }

            departmentTxtbox.Text = row["emp_department"].ToString();
            no_of_dependentsTxtbox.Text = row["emp_no_of_dependents"].ToString();

            picturepathTxtbox.Text = row["picpath"].ToString();
            var path = picturepathTxtbox.Text;
            picbox.Image = System.IO.File.Exists(path) ? Image.FromFile(path) : null;

            dataGridView1.DataSource = table;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, add_yrs_stay, add_house_no, add_sub_name, add_phase_no, add_street, add_barangay, add_municipality, add_city, add_state_province, add_country, add_zipcode, elem_name, elem_address, elem_yr_grad, elem_award, junior_high_name, junior_high_address, junior_high_yr_grad, junior_high_award, senior_high_name, senior_high_address, senior_high_yr_grad, senior_high_award, track, college_school_name, college_address, college_yr_grad, college_award, college_course, others, position, emp_work_status, emp_date_hired, emp_department, emp_no_of_dependents, picpath) VALUES ('"
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