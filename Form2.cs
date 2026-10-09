using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAddDbt_Click(object sender, EventArgs e)
        {
            AddDebtForm addForm = new AddDebtForm();
            addForm.ShowDialog();
        }

        private void BtnViewDbt_Click(object sender, EventArgs e)
        {
            ViewDebtsForm viewForm = new ViewDebtsForm();
            viewForm.ShowDialog();
        }

        private void BtnToPay_Click(object sender, EventArgs e)
        {
            PaymentForm payForm = new PaymentForm();
            payForm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
