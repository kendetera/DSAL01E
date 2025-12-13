namespace LESSON_1
{
    partial class LoginFrm_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm_Database));
            cancelBtn = new Button();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            passwordTxtBox = new TextBox();
            usernameTxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(1000, 635);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(97, 46);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(897, 635);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(97, 46);
            loginBtn.TabIndex = 12;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(908, 360);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(877, 592);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.Size = new Size(248, 23);
            passwordTxtBox.TabIndex = 10;
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(877, 550);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(248, 23);
            usernameTxtBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(779, 590);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(779, 548);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 7;
            label1.Text = "Username:";
            // 
            // LoginFrm_Database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(cancelBtn);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(passwordTxtBox);
            Controls.Add(usernameTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginFrm_Database";
            Text = "LoginFrm_Database";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button loginBtn;
        private PictureBox pictureBox1;
        private TextBox passwordTxtBox;
        private TextBox usernameTxtBox;
        private Label label2;
        private Label label1;
    }
}