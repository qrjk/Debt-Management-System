namespace project
{
    partial class AddDebtForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Name = new TextBox();
            Amount = new TextBox();
            Notes = new TextBox();
            Date = new DateTimePicker();
            Save = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(570, 33);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "اسم الشخص";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(603, 117);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 1;
            label2.Text = "المبلغ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(603, 194);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "التاريخ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(582, 266);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 3;
            label4.Text = "ملاحظات";
            // 
            // Name
            // 
            Name.BorderStyle = BorderStyle.FixedSingle;
            Name.Location = new Point(527, 73);
            Name.Name = "Name";
            Name.Size = new Size(201, 31);
            Name.TabIndex = 4;
            // 
            // Amount
            // 
            Amount.BorderStyle = BorderStyle.FixedSingle;
            Amount.Location = new Point(527, 145);
            Amount.Name = "Amount";
            Amount.Size = new Size(201, 31);
            Amount.TabIndex = 5;
            // 
            // Notes
            // 
            Notes.BorderStyle = BorderStyle.FixedSingle;
            Notes.Location = new Point(479, 294);
            Notes.Multiline = true;
            Notes.Name = "Notes";
            Notes.Size = new Size(297, 59);
            Notes.TabIndex = 7;
            // 
            // Date
            // 
            Date.Location = new Point(479, 222);
            Date.Name = "Date";
            Date.Size = new Size(297, 31);
            Date.TabIndex = 8;
            // 
            // Save
            // 
            Save.BackColor = SystemColors.ControlDarkDark;
            Save.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.Location = new Point(639, 369);
            Save.Name = "Save";
            Save.Size = new Size(137, 48);
            Save.TabIndex = 9;
            Save.Text = "حفظ الدين";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = SystemColors.ControlDarkDark;
            BtnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnBack.Location = new Point(479, 369);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(120, 48);
            BtnBack.TabIndex = 10;
            BtnBack.Text = "خروج";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += button1_Click;
            // 
            // AddDebtForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.الخطيب;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1256, 450);
            Controls.Add(BtnBack);
            Controls.Add(Save);
            Controls.Add(Date);
            Controls.Add(Notes);
            Controls.Add(Amount);
            Controls.Add(Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            
            Text = "Add Debt Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Name;
        private TextBox Amount;
        private TextBox Notes;
        private DateTimePicker Date;
        private Button Save;
        private Button BtnBack;
    }
}