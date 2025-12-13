namespace LESSON_1
{
    partial class User_Account
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
            picpathTxtbox = new TextBox();
            exitBtn = new Button();
            cancelBtn = new Button();
            submitBtn = new Button();
            pictureBox1 = new PictureBox();
            deleteBtn = new Button();
            updateBtn = new Button();
            accountTypeComboBox = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            confirmPasswordTxtbox = new TextBox();
            passwordTxtbox = new TextBox();
            label6 = new Label();
            usernameTxtbox = new TextBox();
            label5 = new Label();
            designationTxtbox = new TextBox();
            label4 = new Label();
            searchForUpdateBtn = new Button();
            searchBtn = new Button();
            surnameTxtbox = new TextBox();
            middlenameTxtbox = new TextBox();
            firstnameTxtbox = new TextBox();
            label3 = new Label();
            userIDTxtbox = new TextBox();
            label2 = new Label();
            emp_idTxtbox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            account_statusComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // picpathTxtbox
            // 
            picpathTxtbox.Location = new Point(1258, 185);
            picpathTxtbox.Name = "picpathTxtbox";
            picpathTxtbox.Size = new Size(166, 23);
            picpathTxtbox.TabIndex = 56;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(1265, 375);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(159, 38);
            exitBtn.TabIndex = 55;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(1265, 331);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(159, 38);
            cancelBtn.TabIndex = 54;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitBtn.Location = new Point(1265, 287);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(159, 38);
            submitBtn.TabIndex = 53;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(1217, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 209);
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(1052, 379);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(159, 38);
            deleteBtn.TabIndex = 51;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(872, 379);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(159, 38);
            updateBtn.TabIndex = 50;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // accountTypeComboBox
            // 
            accountTypeComboBox.FormattingEnabled = true;
            accountTypeComboBox.Items.AddRange(new object[] { "Administrator", "Accounting Staff" });
            accountTypeComboBox.Location = new Point(551, 387);
            accountTypeComboBox.Name = "accountTypeComboBox";
            accountTypeComboBox.Size = new Size(307, 23);
            accountTypeComboBox.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(408, 387);
            label8.Name = "label8";
            label8.Size = new Size(99, 17);
            label8.TabIndex = 48;
            label8.Text = "Account Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(408, 343);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 46;
            label7.Text = "Status:";
            // 
            // confirmPasswordTxtbox
            // 
            confirmPasswordTxtbox.Location = new Point(864, 297);
            confirmPasswordTxtbox.Name = "confirmPasswordTxtbox";
            confirmPasswordTxtbox.PasswordChar = '*';
            confirmPasswordTxtbox.PlaceholderText = "Confirm Password";
            confirmPasswordTxtbox.Size = new Size(347, 23);
            confirmPasswordTxtbox.TabIndex = 45;
            // 
            // passwordTxtbox
            // 
            passwordTxtbox.AccessibleName = "";
            passwordTxtbox.Location = new Point(551, 297);
            passwordTxtbox.Name = "passwordTxtbox";
            passwordTxtbox.PlaceholderText = "Password";
            passwordTxtbox.Size = new Size(307, 23);
            passwordTxtbox.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(408, 297);
            label6.Name = "label6";
            label6.Size = new Size(73, 17);
            label6.TabIndex = 43;
            label6.Text = "Password:";
            // 
            // usernameTxtbox
            // 
            usernameTxtbox.Location = new Point(551, 249);
            usernameTxtbox.Name = "usernameTxtbox";
            usernameTxtbox.Size = new Size(660, 23);
            usernameTxtbox.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(408, 249);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 41;
            label5.Text = "Username:";
            // 
            // designationTxtbox
            // 
            designationTxtbox.Location = new Point(551, 207);
            designationTxtbox.Name = "designationTxtbox";
            designationTxtbox.Size = new Size(660, 23);
            designationTxtbox.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(408, 207);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 39;
            label4.Text = "Designation:";
            // 
            // searchForUpdateBtn
            // 
            searchForUpdateBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchForUpdateBtn.Location = new Point(776, 111);
            searchForUpdateBtn.Name = "searchForUpdateBtn";
            searchForUpdateBtn.Size = new Size(191, 38);
            searchForUpdateBtn.TabIndex = 38;
            searchForUpdateBtn.Text = "Search for Update";
            searchForUpdateBtn.UseVisualStyleBackColor = true;
            searchForUpdateBtn.Click += searchForUpdateBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(776, 67);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(191, 38);
            searchBtn.TabIndex = 37;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // surnameTxtbox
            // 
            surnameTxtbox.Location = new Point(995, 161);
            surnameTxtbox.Name = "surnameTxtbox";
            surnameTxtbox.PlaceholderText = "Surname";
            surnameTxtbox.Size = new Size(216, 23);
            surnameTxtbox.TabIndex = 36;
            // 
            // middlenameTxtbox
            // 
            middlenameTxtbox.Location = new Point(773, 161);
            middlenameTxtbox.Name = "middlenameTxtbox";
            middlenameTxtbox.PlaceholderText = "Middle Name";
            middlenameTxtbox.Size = new Size(216, 23);
            middlenameTxtbox.TabIndex = 35;
            // 
            // firstnameTxtbox
            // 
            firstnameTxtbox.AccessibleName = "";
            firstnameTxtbox.Location = new Point(551, 161);
            firstnameTxtbox.Name = "firstnameTxtbox";
            firstnameTxtbox.PlaceholderText = "First Name";
            firstnameTxtbox.Size = new Size(216, 23);
            firstnameTxtbox.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(408, 161);
            label3.Name = "label3";
            label3.Size = new Size(119, 17);
            label3.TabIndex = 33;
            label3.Text = "Employee Name:";
            // 
            // userIDTxtbox
            // 
            userIDTxtbox.Location = new Point(551, 114);
            userIDTxtbox.Name = "userIDTxtbox";
            userIDTxtbox.Size = new Size(216, 23);
            userIDTxtbox.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(408, 116);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 31;
            label2.Text = "User Id:";
            // 
            // emp_idTxtbox
            // 
            emp_idTxtbox.Location = new Point(551, 73);
            emp_idTxtbox.Name = "emp_idTxtbox";
            emp_idTxtbox.Size = new Size(216, 23);
            emp_idTxtbox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(408, 75);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 29;
            label1.Text = "Employee Id:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 439);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1041, 540);
            dataGridView1.TabIndex = 57;
            // 
            // account_statusComboBox
            // 
            account_statusComboBox.FormattingEnabled = true;
            account_statusComboBox.Items.AddRange(new object[] { "Active" });
            account_statusComboBox.Location = new Point(551, 343);
            account_statusComboBox.Name = "account_statusComboBox";
            account_statusComboBox.Size = new Size(660, 23);
            account_statusComboBox.TabIndex = 58;
            // 
            // User_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(account_statusComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(picpathTxtbox);
            Controls.Add(exitBtn);
            Controls.Add(cancelBtn);
            Controls.Add(submitBtn);
            Controls.Add(pictureBox1);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(accountTypeComboBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(confirmPasswordTxtbox);
            Controls.Add(passwordTxtbox);
            Controls.Add(label6);
            Controls.Add(usernameTxtbox);
            Controls.Add(label5);
            Controls.Add(designationTxtbox);
            Controls.Add(label4);
            Controls.Add(searchForUpdateBtn);
            Controls.Add(searchBtn);
            Controls.Add(surnameTxtbox);
            Controls.Add(middlenameTxtbox);
            Controls.Add(firstnameTxtbox);
            Controls.Add(label3);
            Controls.Add(userIDTxtbox);
            Controls.Add(label2);
            Controls.Add(emp_idTxtbox);
            Controls.Add(label1);
            Name = "User_Account";
            Text = "User_Account";
            Load += User_Account_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox picpathTxtbox;
        private Button exitBtn;
        private Button cancelBtn;
        private Button submitBtn;
        private PictureBox pictureBox1;
        private ComboBox accountTypeComboBox;
        private Label label8;
        private TextBox textBox10;
        private Label label7;
        private TextBox confirmPasswordTxtbox;
        private TextBox passwordTxtbox;
        private Label label6;
        private TextBox usernameTxtbox;
        private Label label5;
        private TextBox designationTxtbox;
        private Label label4;
        private Button searchBtn;
        private TextBox surnameTxtbox;
        private TextBox middlenameTxtbox;
        private TextBox firstnameTxtbox;
        private Label label3;
        private TextBox userIDTxtbox;
        private Label label2;
        private TextBox emp_idTxtbox;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox account_statusComboBox;
        public Button deleteBtn;
        public Button updateBtn;
        public Button searchForUpdateBtn;
    }
}