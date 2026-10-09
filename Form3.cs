using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project
{
    public partial class AddDebtForm : Form
    {
        public AddDebtForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(Amount.Text))
            {
                MessageBox.Show("الرجاء كتابة الاسم والمبلغ أولاً!");
                return;
            }

            Debt newDebt = new Debt();
            newDebt.Name = Name.Text;
            newDebt.Date = Date.Value;
            newDebt.Notes = Notes.Text;

            try
            {
                newDebt.Amount = Convert.ToDouble(Amount.Text);
            }
            catch
            {
                MessageBox.Show("يرجى كتابة أرقام فقط في خانة المبلغ!");
                return;
            }

            DataStore.DebtsList.Add(newDebt);

            MessageBox.Show("تم حفظ البيانات في السجل المشترك بنجاح!", "تم الحفظ");

            Name.Clear();
            Amount.Clear();
            Notes.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
