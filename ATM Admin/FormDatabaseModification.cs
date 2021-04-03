using System;
using System.Windows.Forms;

namespace ATM_Admin
{
    public partial class FormDatabaseModification : Form
    {
        public FormDatabaseModification()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormATMModification acctBalance = new FormATMModification();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void buttonBillsModification_Click(object sender, EventArgs e)
        {
            FormBillsModification acctBalance = new FormBillsModification();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }
    }
}
