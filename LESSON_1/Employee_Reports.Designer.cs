namespace LESSON_1
{
    partial class Employee_Reports
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
            optionCombo = new ComboBox();
            optionInputTxtbox = new TextBox();
            searchBtn = new Button();
            backBtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 60);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Select an option:";
            // 
            // optionCombo
            // 
            optionCombo.FormattingEnabled = true;
            optionCombo.Items.AddRange(new object[] { "employee_number", "surname", "firstname", "department", "designation", "zipcode", "province", "city" });
            optionCombo.Location = new Point(206, 58);
            optionCombo.Name = "optionCombo";
            optionCombo.Size = new Size(276, 23);
            optionCombo.TabIndex = 1;
            // 
            // optionInputTxtbox
            // 
            optionInputTxtbox.Location = new Point(497, 59);
            optionInputTxtbox.Name = "optionInputTxtbox";
            optionInputTxtbox.Size = new Size(243, 23);
            optionInputTxtbox.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(758, 52);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 38);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(858, 52);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 38);
            backBtn.TabIndex = 4;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1774, 809);
            dataGridView1.TabIndex = 5;
            // 
            // Employee_Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dataGridView1);
            Controls.Add(backBtn);
            Controls.Add(searchBtn);
            Controls.Add(optionInputTxtbox);
            Controls.Add(optionCombo);
            Controls.Add(label1);
            Name = "Employee_Reports";
            Text = "Employee_Reports";
            Load += Employee_Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox optionCombo;
        private TextBox optionInputTxtbox;
        private Button searchBtn;
        private Button backBtn;
        private DataGridView dataGridView1;
    }
}