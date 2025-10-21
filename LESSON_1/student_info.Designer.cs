namespace LESSON_1
{
    partial class student_info
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
            label4 = new Label();
            newBtn = new Button();
            cancelBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            searchBtn = new Button();
            savebBtn = new Button();
            griddisplay = new DataGridView();
            picturepathTxtBox = new TextBox();
            departmentTxtBox = new TextBox();
            label3 = new Label();
            studentNameTxtBox = new TextBox();
            label2 = new Label();
            studentNumTxtBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            browseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)griddisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(742, 83);
            label4.Name = "label4";
            label4.Size = new Size(369, 44);
            label4.TabIndex = 31;
            label4.Text = "Student Information";
            // 
            // newBtn
            // 
            newBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newBtn.Location = new Point(1478, 887);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(205, 71);
            newBtn.TabIndex = 30;
            newBtn.Text = "NEW";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(1213, 887);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(205, 71);
            cancelBtn.TabIndex = 29;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBtn.Location = new Point(939, 887);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(205, 71);
            editBtn.TabIndex = 28;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(1478, 794);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(205, 71);
            deleteBtn.TabIndex = 27;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(1213, 794);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(205, 71);
            searchBtn.TabIndex = 26;
            searchBtn.Text = "SEARCH";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // savebBtn
            // 
            savebBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savebBtn.Location = new Point(939, 794);
            savebBtn.Name = "savebBtn";
            savebBtn.Size = new Size(205, 71);
            savebBtn.TabIndex = 25;
            savebBtn.Text = "SAVE";
            savebBtn.UseVisualStyleBackColor = true;
            savebBtn.Click += savebBtn_Click;
            // 
            // griddisplay
            // 
            griddisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            griddisplay.Location = new Point(906, 362);
            griddisplay.Name = "griddisplay";
            griddisplay.Size = new Size(852, 413);
            griddisplay.TabIndex = 24;
            // 
            // picturepathTxtBox
            // 
            picturepathTxtBox.Location = new Point(1086, 177);
            picturepathTxtBox.Name = "picturepathTxtBox";
            picturepathTxtBox.Size = new Size(363, 23);
            picturepathTxtBox.TabIndex = 23;
            // 
            // departmentTxtBox
            // 
            departmentTxtBox.Location = new Point(1086, 318);
            departmentTxtBox.Name = "departmentTxtBox";
            departmentTxtBox.Size = new Size(363, 23);
            departmentTxtBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(950, 317);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 21;
            label3.Text = "Department:";
            // 
            // studentNameTxtBox
            // 
            studentNameTxtBox.Location = new Point(1086, 269);
            studentNameTxtBox.Name = "studentNameTxtBox";
            studentNameTxtBox.Size = new Size(363, 23);
            studentNameTxtBox.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(950, 268);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 19;
            label2.Text = "Student Name:";
            // 
            // studentNumTxtBox
            // 
            studentNumTxtBox.Location = new Point(1086, 225);
            studentNumTxtBox.Name = "studentNumTxtBox";
            studentNumTxtBox.Size = new Size(363, 23);
            studentNumTxtBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(950, 224);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 17;
            label1.Text = "Student Number:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(147, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 627);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // browseBtn
            // 
            browseBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browseBtn.Location = new Point(414, 879);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(205, 71);
            browseBtn.TabIndex = 32;
            browseBtn.Text = "BROWSE";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // student_info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(browseBtn);
            Controls.Add(label4);
            Controls.Add(newBtn);
            Controls.Add(cancelBtn);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(searchBtn);
            Controls.Add(savebBtn);
            Controls.Add(griddisplay);
            Controls.Add(picturepathTxtBox);
            Controls.Add(departmentTxtBox);
            Controls.Add(label3);
            Controls.Add(studentNameTxtBox);
            Controls.Add(label2);
            Controls.Add(studentNumTxtBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "student_info";
            Text = "student_info";
            ((System.ComponentModel.ISupportInitialize)griddisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button newBtn;
        private Button cancelBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Button searchBtn;
        private Button savebBtn;
        private DataGridView griddisplay;
        private TextBox picturepathTxtBox;
        private TextBox departmentTxtBox;
        private Label label3;
        private TextBox studentNameTxtBox;
        private Label label2;
        private TextBox studentNumTxtBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Button browseBtn;
    }
}