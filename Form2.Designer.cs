namespace project
{
    partial class MainForm
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
            BtnAddDbt = new Button();
            BtnViewDbt = new Button();
            BtnToPay = new Button();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(532, 27);
            label1.Name = "label1";
            label1.Size = new Size(192, 36);
            label1.TabIndex = 0;
            label1.Text = "نظام تتبع الديون";
            // 
            // BtnAddDbt
            // 
            BtnAddDbt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnAddDbt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddDbt.Location = new Point(531, 109);
            BtnAddDbt.Name = "BtnAddDbt";
            BtnAddDbt.Size = new Size(193, 34);
            BtnAddDbt.TabIndex = 1;
            BtnAddDbt.Text = "اضافة دين جديد";
            BtnAddDbt.UseVisualStyleBackColor = true;
            BtnAddDbt.Click += BtnAddDbt_Click;
            // 
            // BtnViewDbt
            // 
            BtnViewDbt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnViewDbt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnViewDbt.Location = new Point(531, 184);
            BtnViewDbt.Name = "BtnViewDbt";
            BtnViewDbt.Size = new Size(193, 34);
            BtnViewDbt.TabIndex = 2;
            BtnViewDbt.Text = "عرض سجل الدين";
            BtnViewDbt.UseVisualStyleBackColor = true;
            BtnViewDbt.Click += BtnViewDbt_Click;
            // 
            // BtnToPay
            // 
            BtnToPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnToPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnToPay.Location = new Point(531, 254);
            BtnToPay.Name = "BtnToPay";
            BtnToPay.Size = new Size(193, 34);
            BtnToPay.TabIndex = 3;
            BtnToPay.Text = "تسديد دين مالي";
            BtnToPay.UseVisualStyleBackColor = true;
            BtnToPay.Click += BtnToPay_Click;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnExit.BackColor = SystemColors.ControlDarkDark;
            BtnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.Location = new Point(532, 344);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(192, 52);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "خروج من البرنامج";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.الخطيب;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 450);
            Controls.Add(BtnExit);
            Controls.Add(BtnToPay);
            Controls.Add(BtnViewDbt);
            Controls.Add(BtnAddDbt);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnAddDbt;
        private Button BtnViewDbt;
        private Button BtnToPay;
        private Button BtnExit;
    }
}