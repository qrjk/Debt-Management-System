using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            CombName.Items.Clear();
            foreach (var debt in DataStore.DebtsList)
            {
                CombName.Items.Add(debt.Name);
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (CombName.SelectedItem == null || string.IsNullOrWhiteSpace(Payment.Text))
            {
                MessageBox.Show("تأكد من اختيار الاسم وإدخال قيمة المبلغ المدفوع!");
                return;
            }

            string selectedName = CombName.SelectedItem.ToString();
            double paid = Convert.ToDouble(Payment.Text);

            foreach (var debt in DataStore.DebtsList)
            {
                if (debt.Name == selectedName)
                {
                    debt.Amount -= paid; // خصم القيمة
                    MessageBox.Show($"تم الخصم. المتبقي الحالي على {debt.Name} هو: {debt.Amount}", "تحديث السداد");
                    this.Close();
                    return;
                }
            }
        }
    }
}
    
