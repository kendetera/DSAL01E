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
    public partial class Example3_Finals : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Variables variables = new Variables();
        Price_Item_Value price_discountamount_value = new Price_Item_Value();
        public Example3_Finals()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void quantityTxtbox()
        {
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void GetPriceDiscountAmount()
        {
            priceTxtBox.Text = (price_discountamount_value.GetPriceItem());
            discountAmountTxtBox.Text = (price_discountamount_value.GetDiscountAmount());
            variables.price = Convert.ToDouble(priceTxtBox.Text);
        }

        private void Example3_Finals_Load(object sender, EventArgs e)
        {
            priceTxtBox.Enabled = false;
            discountAmountTxtBox.Enabled = false;
            totalBillsTxtBox.Enabled = false;
            discountedAmtTxtBox.Enabled = false;
            totalQtyTxtBox.Enabled = false;

            posdb_connect.pos_select_cashier1();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            checkBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            checkBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            checkBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            checkBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            checkBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            checkBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            checkBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            checkBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            checkBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            checkBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            checkBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            checkBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            checkBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            checkBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            checkBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            checkBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            checkBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            checkBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            checkBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            checkBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

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

            picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide(); picpathTxtbox4.Hide(); picpathTxtbox5.Hide();
            picpathTxtbox6.Hide(); picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide(); picpathTxtbox10.Hide();
            picpathTxtbox11.Hide(); picpathTxtbox12.Hide(); picpathTxtbox13.Hide(); picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
            picpathTxtbox16.Hide(); picpathTxtbox17.Hide(); picpathTxtbox18.Hide(); picpathTxtbox19.Hide(); picpathTxtbox20.Hide();

            A_BurgerNFriesChkBox.Checked = false;
            A_ChickenjoyC1ChkBox.Checked = false;
            A_PalabokChkBox.Checked = false;

            B_ChickenjoyC2ChkBox.Checked = false;
            B_FriesChkBox.Checked = false;
            B_JollyHotdogChkBox.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox1.Text + "" + priceTxtBox.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox2.Text + "" + priceTxtBox.Text);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox3.Text + "" + priceTxtBox.Text);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox4.Text + "" + priceTxtBox.Text);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox5.Text + "" + priceTxtBox.Text);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox6.Text + "" + priceTxtBox.Text);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox7.Text + "" + priceTxtBox.Text);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox8.Text + "" + priceTxtBox.Text);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox9.Text + "" + priceTxtBox.Text);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox10.Text + "" + priceTxtBox.Text);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox11.Text + "" + priceTxtBox.Text);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox12.Text + "" + priceTxtBox.Text);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox13.Text + "" + priceTxtBox.Text);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox14.Text + "" + priceTxtBox.Text);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox15.Text + "" + priceTxtBox.Text);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox16.Text + "" + priceTxtBox.Text);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox17.Text + "" + priceTxtBox.Text);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox18.Text + "" + priceTxtBox.Text);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox19.Text + "" + priceTxtBox.Text);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", pricelbl1.Text);
            GetPriceDiscountAmount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox20.Text + "" + priceTxtBox.Text);
        }
    }
}
