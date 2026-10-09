namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "Hammam" && UserPassword.Text == "777834111")
            {
                MessageBox.Show("مرحباً بك! تم تسجيل الدخول بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("خطأ في اسم المستخدم أو كلمة المرور!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
