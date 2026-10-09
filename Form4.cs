using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class ViewDebtsForm : Form
    {
        public ViewDebtsForm()
        {
            InitializeComponent();
        }

        private void ViewDebt()
        {
            DataGridDebt.DataSource = null;
            DataGridDebt.DataSource = DataStore.DebtsList;
        }

        private void ViewDebtsForm_Load(object sender, EventArgs e)
        {
            ViewDebt();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = Search.Text;
            var filtered = DataStore.DebtsList.FindAll(d => d.Name.Contains(keyword));
            DataGridDebt.DataSource = null;
            DataGridDebt.DataSource = filtered;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DataGridDebt.CurrentRow != null)
            {
                var ask = MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == DialogResult.Yes)
                {
                    int index = DataGridDebt.CurrentRow.Index;
                    DataStore.DebtsList.RemoveAt(index);
                    ViewDebt();
                }
            }
        }

        private void BtnRefreash_Click(object sender, EventArgs e)
        {
            ViewDebt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
