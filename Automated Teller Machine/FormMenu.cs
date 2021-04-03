using System;
using System.Drawing;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Select the Type of Service";
                acctBalanceBtn.Text = "Account Balance";
                withdrawMoneyBtn.Text = "Withdraw Money";
                moneyTransferBtn.Text = "Money Transfer";
                changePwdBtn.Text = "Change Password";
                otherServicesBtn.Text = "Pay Bills";
                exitCardBtn.Text = "Exit";
            }
            else
            {
                label1.Text = "انتخاب نوع خدمات";
                acctBalanceBtn.Text = "موجودی حساب";
                withdrawMoneyBtn.Text = "برداشت وجه";
                moneyTransferBtn.Text = "انتقال وجه";
                changePwdBtn.Text = "تغییر رمز";
                otherServicesBtn.Text = "پرداخت قبوض";
                exitCardBtn.Text = "خروج";
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void exitCardBtn_Click(object sender, EventArgs e)
        {
            FormSelectLanguage f1 = new FormSelectLanguage();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void acctBalanceBtn_Click(object sender, EventArgs e)
        {
            Program.state = 'B';
            FormResults acctBalance = new FormResults();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void moneyTransferBtn_Click(object sender, EventArgs e)
        {
            FormTransferMoneyMainAcct withdrawMoneyMainAcct = new FormTransferMoneyMainAcct();
            Hide();
            withdrawMoneyMainAcct.ShowDialog();
            Close();
        }

        private void otherServicesBtn_Click(object sender, EventArgs e)
        {
            FormPayBills withdrawMoney = new FormPayBills();
            Hide();
            withdrawMoney.ShowDialog();
            Close();
        }

        private void withdrawMoneyBtn_Click(object sender, EventArgs e)
        {
            FormWithdrawMoney withdrawMoney = new FormWithdrawMoney();
            Hide();
            withdrawMoney.ShowDialog();
            Close();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            FormChangePwd changePwd = new FormChangePwd();
            Hide();
            changePwd.ShowDialog();
            Close();
        }
    }
}
