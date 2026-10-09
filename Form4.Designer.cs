namespace project
{
    partial class ViewDebtsForm
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
            groupBox1 = new GroupBox();
            BtnRefreash = new Button();
            BtnDelete = new Button();
            BtnSearch = new Button();
            Search = new TextBox();
            label2 = new Label();
            DataGridDebt = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridDebt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(574, 25);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 0;
            label1.Text = "سجل الديون";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(BtnRefreash);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(Search);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DataGridDebt);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1239, 364);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "عمليات البجث";
            // 
            // BtnRefreash
            // 
            BtnRefreash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnRefreash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRefreash.Location = new Point(280, 305);
            BtnRefreash.Name = "BtnRefreash";
            BtnRefreash.Size = new Size(132, 34);
            BtnRefreash.TabIndex = 5;
            BtnRefreash.Text = "تحديث الجدول";
            BtnRefreash.UseVisualStyleBackColor = true;
            BtnRefreash.Click += BtnRefreash_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(858, 305);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(112, 34);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "حذف الدين المحدد";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSearch.Location = new Point(280, 56);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(128, 34);
            BtnSearch.TabIndex = 3;
            BtnSearch.Text = "اضغط للبحث";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // Search
            // 
            Search.BorderStyle = BorderStyle.FixedSingle;
            Search.Location = new Point(487, 58);
            Search.Name = "Search";
            Search.Size = new Size(294, 31);
            Search.TabIndex = 2;
            Search.TextChanged += Search_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(545, 16);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 1;
            label2.Text = "البحث باسم الشخص";
            // 
            // DataGridDebt
            // 
            DataGridDebt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridDebt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridDebt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDebt.Location = new Point(17, 95);
            DataGridDebt.Name = "DataGridDebt";
            DataGridDebt.ReadOnly = true;
            DataGridDebt.RowHeadersWidth = 62;
            DataGridDebt.Size = new Size(1200, 204);
            DataGridDebt.TabIndex = 0;
            // 
            // ViewDebtsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.الخطيب;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1256, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ViewDebtsForm";
            Text = "ViewDebt Form";
            Load += ViewDebtsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridDebt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView DataGridDebt;
        private Button BtnRefreash;
        private Button BtnDelete;
        private Button BtnSearch;
        private TextBox Search;
        private Label label2;
    }
}