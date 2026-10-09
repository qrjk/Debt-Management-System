namespace project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserName = new TextBox();
            UserPassword = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 37);
            label1.Name = "label1";
            label1.Size = new Size(429, 45);
            label1.TabIndex = 0;
            label1.Text = "مرحباً بك في برنامج تتبع الديون";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(609, 138);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 1;
            label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(625, 254);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 2;
            label3.Text = "كلمة المرور";
            // 
            // UserName
            // 
            UserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserName.BorderStyle = BorderStyle.FixedSingle;
            UserName.Location = new Point(552, 190);
            UserName.Name = "UserName";
            UserName.Size = new Size(257, 34);
            UserName.TabIndex = 3;
            // 
            // UserPassword
            // 
            UserPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserPassword.BorderStyle = BorderStyle.FixedSingle;
            UserPassword.Location = new Point(552, 314);
            UserPassword.Name = "UserPassword";
            UserPassword.Size = new Size(257, 34);
            UserPassword.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ControlDarkDark;
            LoginBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LoginBtn.Location = new Point(625, 384);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(122, 47);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "دخول";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.الخطيب;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1358, 504);
            Controls.Add(LoginBtn);
            Controls.Add(UserPassword);
            Controls.Add(UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "Form1";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserName;
        private TextBox UserPassword;
        private Button LoginBtn;
    }
}
