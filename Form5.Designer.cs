namespace project
{
    partial class PaymentForm
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
            CombName = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            Payment = new TextBox();
            BtnPay = new Button();
            SuspendLayout();
            // 
            // CombName
            // 
            CombName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CombName.FormattingEnabled = true;
            CombName.Location = new Point(520, 132);
            CombName.Name = "CombName";
            CombName.Size = new Size(218, 33);
            CombName.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 81);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 1;
            label1.Text = "اختر اسم الشخص المدين";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(520, 210);
            label2.Name = "label2";
            label2.Size = new Size(216, 28);
            label2.TabIndex = 2;
            label2.Text = "المبلغ المراد تسديده الان";
            // 
            // Payment
            // 
            Payment.Location = new Point(520, 259);
            Payment.Name = "Payment";
            Payment.Size = new Size(218, 31);
            Payment.TabIndex = 4;
            // 
            // BtnPay
            // 
            BtnPay.BackColor = SystemColors.ControlDarkDark;
            BtnPay.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPay.Location = new Point(537, 335);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(189, 44);
            BtnPay.TabIndex = 5;
            BtnPay.Text = "تاكيد عملية السداد";
            BtnPay.UseVisualStyleBackColor = false;
            BtnPay.Click += BtnPay_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.الخطيب;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1258, 450);
            Controls.Add(BtnPay);
            Controls.Add(Payment);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CombName);
            Name = "PaymentForm";
            Text = "Payment  Form";
            Load += PaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CombName;
        private Label label1;
        private Label label2;
        private TextBox Payment;
        private Button BtnPay;
    }
}