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
    public partial class Example2_Finals : Form
    {
        // codes for database connection
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        public Example2_Finals()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void quantityTxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }

        private void quantity_price_convert()
        {
            variables.quantity = Convert.ToInt32(quantitytxtbox.Text);
            variables.price = Convert.ToDouble(pricetxtbox.Text);
        }

        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) - variables.discount_amt;
            discount_txtbox.Text = variables.discount_amt.ToString("n");
            discounted_txtbox.Text = variables.discounted_amt.ToString("n");
        }

        public void GetPriceItemValue()
        {
            itemnametxtbox.Text = (price_item_value.GetItemName());
            pricetxtbox.Text = (price_item_value.GetPrice());
        }

        private void cleartextboxes()
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discount_txtbox.Clear();
            discounted_txtbox.Clear();
            changetxtbox.Clear();
            cash_renderedtxtbox.Clear();
        }

        private void Example2_Finals_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discount_txtbox.Clear();
            discount_totalbox.Clear();
            discounted_totalbox.Clear();
            discounted_txtbox.Clear();
            changetxtbox.Clear();

            picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide(); picpathTxtbox4.Hide(); picpathTxtbox5.Hide();
            picpathTxtbox6.Hide(); picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide(); picpathTxtbox10.Hide();
            picpathTxtbox11.Hide(); picpathTxtbox12.Hide(); picpathTxtbox13.Hide(); picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
            picpathTxtbox16.Hide(); picpathTxtbox17.Hide(); picpathTxtbox18.Hide(); picpathTxtbox19.Hide(); picpathTxtbox20.Hide();

            posdb_connect.pos_select_cashier();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            name1lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            name2lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            name3lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            name4lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            name5lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            name10lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            name9lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            name8lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            name7lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            name6lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            name15lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            name14lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            name13lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            name12lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            name11lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            name20lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            name19lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            name18lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            name17lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            name16lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

            picpathTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pictureBox1.Image = Image.FromFile(picpathTxtbox1.Text);
            picpathTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pictureBox2.Image = Image.FromFile(picpathTxtbox2.Text);
            picpathTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pictureBox3.Image = Image.FromFile(picpathTxtbox3.Text);
            picpathTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pictureBox4.Image = Image.FromFile(picpathTxtbox4.Text);
            picpathTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pictureBox5.Image = Image.FromFile(picpathTxtbox5.Text);
            picpathTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pictureBox6.Image = Image.FromFile(picpathTxtbox6.Text);
            picpathTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pictureBox7.Image = Image.FromFile(picpathTxtbox7.Text);
            picpathTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pictureBox8.Image = Image.FromFile(picpathTxtbox8.Text);
            picpathTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pictureBox9.Image = Image.FromFile(picpathTxtbox9.Text);
            picpathTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pictureBox10.Image = Image.FromFile(picpathTxtbox10.Text);
            picpathTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pictureBox11.Image = Image.FromFile(picpathTxtbox11.Text);
            picpathTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pictureBox12.Image = Image.FromFile(picpathTxtbox12.Text);
            picpathTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pictureBox13.Image = Image.FromFile(picpathTxtbox13.Text);
            picpathTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pictureBox14.Image = Image.FromFile(picpathTxtbox14.Text);
            picpathTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pictureBox15.Image = Image.FromFile(picpathTxtbox15.Text);
            picpathTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pictureBox16.Image = Image.FromFile(picpathTxtbox16.Text);
            picpathTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pictureBox17.Image = Image.FromFile(picpathTxtbox17.Text);
            picpathTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pictureBox18.Image = Image.FromFile(picpathTxtbox18.Text);
            picpathTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pictureBox19.Image = Image.FromFile(picpathTxtbox19.Text);
            picpathTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            pictureBox20.Image = Image.FromFile(picpathTxtbox20.Text);

            pricelbl1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
            pricelbl2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
            pricelbl3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
            pricelbl4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
            pricelbl5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
            pricelbl6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
            pricelbl7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
            pricelbl8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
            pricelbl9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
            pricelbl10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
            pricelbl11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
            pricelbl12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
            pricelbl13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
            pricelbl14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
            pricelbl15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
            pricelbl16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
            pricelbl17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
            pricelbl18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
            pricelbl19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
            pricelbl20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();

            posdb_connect.pos_select_cashier_display();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_select_cashier_SELECTdisplay();


            terminal_noLbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            emp_idLbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][0].ToString();
            emp_fnameLbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][1].ToString();
            emp_surnameLbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            DateTime dateTime = DateTime.Now;
            time_dateLbl.Text = dateTime.ToString("MMMM dd, yyyy");
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (seniorCtznRdBtn.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl(product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                    "VALUES ('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text + "', '" + pricetxtbox.Text + "', '" + seniorCtznRdBtn.Text + "', '" + discount_txtbox.Text + "', '" + discounted_txtbox.Text + "', '" + qty_totalbox.Text + "', '" + discount_totalbox.Text + "', '" + discounted_totalbox + "', '" + terminal_noLbl + "', '" + time_dateLbl + "', '" + emp_idLbl + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

            else if (withDiscCardRdBtn.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl(product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                    "VALUES ('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text + "', '" + pricetxtbox.Text + "', '" + withDiscCardRdBtn.Text + "', '" + discount_txtbox.Text + "', '" + discounted_txtbox.Text + "', '" + qty_totalbox.Text + "', '" + discount_totalbox.Text + "', '" + discounted_totalbox + "', '" + terminal_noLbl + "', '" + time_dateLbl + "', '" + emp_idLbl + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

            else if (employeeDiscRdBtn.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl(product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                    "VALUES ('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text + "', '" + pricetxtbox.Text + "', '" + employeeDiscRdBtn.Text + "', '" + discount_txtbox.Text + "', '" + discounted_txtbox.Text + "', '" + qty_totalbox.Text + "', '" + discount_totalbox.Text + "', '" + discounted_totalbox + "', '" + terminal_noLbl + "', '" + time_dateLbl + "', '" + emp_idLbl + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

            else if (noDiscRdBtn.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl(product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                    "VALUES ('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text + "', '" + pricetxtbox.Text + "', '" + noDiscRdBtn.Text + "', '" + discount_txtbox.Text + "', '" + discounted_txtbox.Text + "', '" + qty_totalbox.Text + "', '" + discount_totalbox.Text + "', '" + discounted_totalbox + "', '" + terminal_noLbl + "', '" + time_dateLbl + "', '" + emp_idLbl + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

        }

        private void seniorCtznRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0.30;
            computation_Formula_and_DisplayData();
            withDiscCardRdBtn.Checked = false;
            employeeDiscRdBtn.Checked = false;
            noDiscRdBtn.Checked = false;
        }

        private void withDiscCardRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0.10;
            computation_Formula_and_DisplayData();
            seniorCtznRdBtn.Checked = false;
            employeeDiscRdBtn.Checked = false;
            noDiscRdBtn.Checked = false;
        }

        private void employeeDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0.15;
            computation_Formula_and_DisplayData();
            seniorCtznRdBtn.Checked = false;
            withDiscCardRdBtn.Checked = false;
            noDiscRdBtn.Checked = false;
        }

        private void noDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0;
            computation_Formula_and_DisplayData();
            seniorCtznRdBtn.Checked = false;
            withDiscCardRdBtn.Checked = false;
            employeeDiscRdBtn.Checked = false;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            variables.quantity = Convert.ToInt32(quantitytxtbox.Text);
            variables.discount_amt = Convert.ToDouble(discount_txtbox.Text);
            variables.discounted_amt = Convert.ToDouble(discounted_txtbox.Text);
            variables.cash_given = Convert.ToDouble(cash_renderedtxtbox.Text);

            variables.qty_total += variables.quantity;
            variables.discount_totalgiven += variables.discount_amt;
            variables.discounted_total += variables.discounted_amt;
            variables.change = variables.cash_given - variables.discounted_amt;

            qty_totalbox.Text = variables.qty_total.ToString();
            discount_totalbox.Text = variables.discount_totalgiven.ToString("n");
            discounted_totalbox.Text = variables.discounted_total.ToString("n");
            changetxtbox.Text = variables.change.ToString("n");
            cash_renderedtxtbox.Text = variables.cash_given.ToString("n");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name1lbl.Text, pricelbl1.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name2lbl.Text, pricelbl2.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name3lbl.Text, pricelbl3.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name4lbl.Text, pricelbl4.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name5lbl.Text, pricelbl5.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name10lbl.Text, pricelbl10.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name9lbl.Text, pricelbl9.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name8lbl.Text, pricelbl8.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name6lbl.Text, pricelbl6.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name7lbl.Text, pricelbl7.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name11lbl.Text, pricelbl11.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name12lbl.Text, pricelbl12.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name13lbl.Text, pricelbl13.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name14lbl.Text, pricelbl14.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name15lbl.Text, pricelbl15.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name20lbl.Text, pricelbl20.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name19lbl.Text, pricelbl19.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name18lbl.Text, pricelbl18.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name17lbl.Text, pricelbl17.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name16lbl.Text, pricelbl16.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }
    }





}
