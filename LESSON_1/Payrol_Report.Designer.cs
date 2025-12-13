namespace LESSON_1
{
    partial class Payrol_Report
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
            dataGridView1 = new DataGridView();
            backBtn = new Button();
            searchBtn = new Button();
            optionInputTxtbox = new TextBox();
            optionCombo = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1774, 809);
            dataGridView1.TabIndex = 11;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(863, 82);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 38);
            backBtn.TabIndex = 10;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(763, 82);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 38);
            searchBtn.TabIndex = 9;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // optionInputTxtbox
            // 
            optionInputTxtbox.Location = new Point(502, 89);
            optionInputTxtbox.Name = "optionInputTxtbox";
            optionInputTxtbox.Size = new Size(243, 23);
            optionInputTxtbox.TabIndex = 8;
            // 
            // optionCombo
            // 
            optionCombo.FormattingEnabled = true;
            optionCombo.Items.AddRange(new object[] { "employee_number", "surname", "firstname", "gross_income", "net_income", "pay_date" });
            optionCombo.Location = new Point(211, 88);
            optionCombo.Name = "optionCombo";
            optionCombo.Size = new Size(276, 23);
            optionCombo.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 90);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 6;
            label1.Text = "Select an option:";
            // 
            // Payrol_Report
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
            Name = "Payrol_Report";
            Text = "Payrol_Report";
            Load += Payrol_Report_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button backBtn;
        private Button searchBtn;
        private TextBox optionInputTxtbox;
        private ComboBox optionCombo;
        private Label label1;
    }
}