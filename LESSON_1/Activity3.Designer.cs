namespace LESSON_1
{
    partial class Activity3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            foodBRdbtn = new RadioButton();
            foodARdbtn = new RadioButton();
            groupBox2 = new GroupBox();
            button3 = new Button();
            label4 = new Label();
            button1 = new Button();
            DisplayPictureBox = new PictureBox();
            discountTxtbox = new TextBox();
            priceTxtbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            A_SpecialPizzaCheckBox = new CheckBox();
            A_SideDishCheckBox = new CheckBox();
            A_CokeCheckBox = new CheckBox();
            A_FriesCheckBox = new CheckBox();
            A_FriedChickenCheckBox = new CheckBox();
            groupBox4 = new GroupBox();
            B_HawaiianCheckBox = new CheckBox();
            B_FriesCheckBox = new CheckBox();
            B_HaloHaloCheckBox = new CheckBox();
            B_CarbonaraCheckBox = new CheckBox();
            B_ChickenCheckBox = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 33);
            label1.Name = "label1";
            label1.Size = new Size(585, 35);
            label1.TabIndex = 0;
            label1.Text = "4JEE Food Ordering Application";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(foodBRdbtn);
            groupBox1.Controls.Add(foodARdbtn);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(89, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 140);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food Order Choices";
            // 
            // foodBRdbtn
            // 
            foodBRdbtn.AutoSize = true;
            foodBRdbtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodBRdbtn.Location = new Point(56, 90);
            foodBRdbtn.Name = "foodBRdbtn";
            foodBRdbtn.Size = new Size(137, 25);
            foodBRdbtn.TabIndex = 3;
            foodBRdbtn.TabStop = true;
            foodBRdbtn.Text = "Food Bundle B";
            foodBRdbtn.UseVisualStyleBackColor = true;
            foodBRdbtn.CheckedChanged += foodBRdbtn_CheckedChanged;
            // 
            // foodARdbtn
            // 
            foodARdbtn.AutoSize = true;
            foodARdbtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodARdbtn.Location = new Point(56, 44);
            foodARdbtn.Name = "foodARdbtn";
            foodARdbtn.Size = new Size(141, 25);
            foodARdbtn.TabIndex = 2;
            foodARdbtn.TabStop = true;
            foodARdbtn.Text = "Food Bundle A";
            foodARdbtn.UseVisualStyleBackColor = true;
            foodARdbtn.CheckedChanged += foodARdbtn_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(DisplayPictureBox);
            groupBox2.Controls.Add(discountTxtbox);
            groupBox2.Controls.Add(priceTxtbox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(89, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(435, 539);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oder Details";
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(222, 457);
            button3.Name = "button3";
            button3.Size = new Size(186, 62);
            button3.TabIndex = 8;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 269);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 7;
            label4.Text = "Order Image:";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(20, 457);
            button1.Name = "button1";
            button1.Size = new Size(186, 62);
            button1.TabIndex = 3;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BorderStyle = BorderStyle.Fixed3D;
            DisplayPictureBox.Location = new Point(140, 175);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(270, 221);
            DisplayPictureBox.TabIndex = 3;
            DisplayPictureBox.TabStop = false;
            // 
            // discountTxtbox
            // 
            discountTxtbox.Location = new Point(140, 89);
            discountTxtbox.Name = "discountTxtbox";
            discountTxtbox.Size = new Size(270, 27);
            discountTxtbox.TabIndex = 6;
            // 
            // priceTxtbox
            // 
            priceTxtbox.Location = new Point(140, 41);
            priceTxtbox.Name = "priceTxtbox";
            priceTxtbox.Size = new Size(270, 27);
            priceTxtbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 89);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 4;
            label3.Text = "Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 41);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(A_SpecialPizzaCheckBox);
            groupBox3.Controls.Add(A_SideDishCheckBox);
            groupBox3.Controls.Add(A_CokeCheckBox);
            groupBox3.Controls.Add(A_FriesCheckBox);
            groupBox3.Controls.Add(A_FriedChickenCheckBox);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(616, 93);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(436, 344);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Food Bundles A";
            // 
            // A_SpecialPizzaCheckBox
            // 
            A_SpecialPizzaCheckBox.AutoSize = true;
            A_SpecialPizzaCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_SpecialPizzaCheckBox.Location = new Point(57, 281);
            A_SpecialPizzaCheckBox.Name = "A_SpecialPizzaCheckBox";
            A_SpecialPizzaCheckBox.Size = new Size(192, 25);
            A_SpecialPizzaCheckBox.TabIndex = 8;
            A_SpecialPizzaCheckBox.Text = "Special Pizza Delights";
            A_SpecialPizzaCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_SideDishCheckBox
            // 
            A_SideDishCheckBox.AutoSize = true;
            A_SideDishCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_SideDishCheckBox.Location = new Point(58, 224);
            A_SideDishCheckBox.Name = "A_SideDishCheckBox";
            A_SideDishCheckBox.Size = new Size(125, 25);
            A_SideDishCheckBox.TabIndex = 7;
            A_SideDishCheckBox.Text = "4 Side Dishes";
            A_SideDishCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_CokeCheckBox
            // 
            A_CokeCheckBox.AutoSize = true;
            A_CokeCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_CokeCheckBox.Location = new Point(58, 167);
            A_CokeCheckBox.Name = "A_CokeCheckBox";
            A_CokeCheckBox.Size = new Size(96, 25);
            A_CokeCheckBox.TabIndex = 6;
            A_CokeCheckBox.Text = "1.5 Coke";
            A_CokeCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_FriesCheckBox
            // 
            A_FriesCheckBox.AutoSize = true;
            A_FriesCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_FriesCheckBox.Location = new Point(58, 110);
            A_FriesCheckBox.Name = "A_FriesCheckBox";
            A_FriesCheckBox.Size = new Size(122, 25);
            A_FriesCheckBox.TabIndex = 5;
            A_FriesCheckBox.Text = "2 Large Fries";
            A_FriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_FriedChickenCheckBox
            // 
            A_FriedChickenCheckBox.AutoSize = true;
            A_FriedChickenCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_FriedChickenCheckBox.Location = new Point(58, 53);
            A_FriedChickenCheckBox.Name = "A_FriedChickenCheckBox";
            A_FriedChickenCheckBox.Size = new Size(191, 25);
            A_FriedChickenCheckBox.TabIndex = 4;
            A_FriedChickenCheckBox.Text = "10 pcs. Fried Chicken";
            A_FriedChickenCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(B_HawaiianCheckBox);
            groupBox4.Controls.Add(B_FriesCheckBox);
            groupBox4.Controls.Add(B_HaloHaloCheckBox);
            groupBox4.Controls.Add(B_CarbonaraCheckBox);
            groupBox4.Controls.Add(B_ChickenCheckBox);
            groupBox4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(616, 443);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(436, 335);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Food Bundles B";
            // 
            // B_HawaiianCheckBox
            // 
            B_HawaiianCheckBox.AutoSize = true;
            B_HawaiianCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_HawaiianCheckBox.Location = new Point(57, 277);
            B_HawaiianCheckBox.Name = "B_HawaiianCheckBox";
            B_HawaiianCheckBox.Size = new Size(225, 25);
            B_HawaiianCheckBox.TabIndex = 13;
            B_HawaiianCheckBox.Text = "1 Medium Hawaiian Pizza";
            B_HawaiianCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_FriesCheckBox
            // 
            B_FriesCheckBox.AutoSize = true;
            B_FriesCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_FriesCheckBox.Location = new Point(58, 220);
            B_FriesCheckBox.Name = "B_FriesCheckBox";
            B_FriesCheckBox.Size = new Size(168, 25);
            B_FriesCheckBox.TabIndex = 12;
            B_FriesCheckBox.Text = "1 Family Pack Fries";
            B_FriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_HaloHaloCheckBox
            // 
            B_HaloHaloCheckBox.AutoSize = true;
            B_HaloHaloCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_HaloHaloCheckBox.Location = new Point(58, 49);
            B_HaloHaloCheckBox.Name = "B_HaloHaloCheckBox";
            B_HaloHaloCheckBox.Size = new Size(281, 25);
            B_HaloHaloCheckBox.TabIndex = 9;
            B_HaloHaloCheckBox.Text = "4 cups Special Halo Halo Regular";
            B_HaloHaloCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_CarbonaraCheckBox
            // 
            B_CarbonaraCheckBox.AutoSize = true;
            B_CarbonaraCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_CarbonaraCheckBox.Location = new Point(58, 163);
            B_CarbonaraCheckBox.Name = "B_CarbonaraCheckBox";
            B_CarbonaraCheckBox.Size = new Size(223, 25);
            B_CarbonaraCheckBox.TabIndex = 11;
            B_CarbonaraCheckBox.Text = "1 Family Pack Carbonara";
            B_CarbonaraCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_ChickenCheckBox
            // 
            B_ChickenCheckBox.AutoSize = true;
            B_ChickenCheckBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_ChickenCheckBox.Location = new Point(58, 106);
            B_ChickenCheckBox.Name = "B_ChickenCheckBox";
            B_ChickenCheckBox.Size = new Size(182, 25);
            B_ChickenCheckBox.TabIndex = 10;
            B_ChickenCheckBox.Text = "6 pcs. Fried Chicken";
            B_ChickenCheckBox.UseVisualStyleBackColor = true;
            // 
            // Activity3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 827);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Activity3";
            Text = "Activity3";
            Load += Activity3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton foodARdbtn;
        private RadioButton foodBRdbtn;
        private GroupBox groupBox2;
        private TextBox discountTxtbox;
        private TextBox priceTxtbox;
        private Label label3;
        private Label label2;
        private Button button3;
        private Label label4;
        private Button button1;
        private PictureBox DisplayPictureBox;
        private GroupBox groupBox3;
        private CheckBox A_CokeCheckBox;
        private CheckBox A_FriesCheckBox;
        private CheckBox A_FriedChickenCheckBox;
        private CheckBox A_SpecialPizzaCheckBox;
        private CheckBox A_SideDishCheckBox;
        private GroupBox groupBox4;
        private CheckBox B_HawaiianCheckBox;
        private CheckBox B_FriesCheckBox;
        private CheckBox B_HaloHaloCheckBox;
        private CheckBox B_CarbonaraCheckBox;
        private CheckBox B_ChickenCheckBox;
    }
}