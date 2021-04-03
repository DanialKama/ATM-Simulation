using System;
using System.Drawing;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class FormWithdrawMoney : Form
    {
        public FormWithdrawMoney()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Withdraw Money";
                label2.RightToLeft = RightToLeft.No;
                label2.Text = "Select the Desired Amount or Enter the Amount. (Rials)";
                confirmBtn.Text = "Confirm";
                backBtn.Text = "Back";
            }
            else
            {
                label1.Text = "برداشت وجه";
                label2.Text = "مبلغ مورد نظر را انتخاب کنید یا مبلغ را وارد کنید. (ریال)";
                confirmBtn.Text = "تایید";
                backBtn.Text = "بازگشت";
            }
        }

        public static Int64 withdrawMoney = 0;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormMenu f4 = new FormMenu();
            Hide();
            f4.ShowDialog();
            Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Program.state = 'W';
            withdrawMoney = Int64.Parse(textBoxMoneyAmount.Text);
            FormResults acctBalance = new FormResults();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.state = 'W';
            withdrawMoney = 100000;
            FormResults acctBalance = new FormResults();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Program.state = 'W';
            withdrawMoney = 200000;
            FormResults acctBalance = new FormResults();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Program.state = 'W';
            withdrawMoney = 300000;
            FormResults acctBalance = new FormResults();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Program.state = 'W';
            withdrawMoney = 500000;
            FormResults acctBalance = new FormResults();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Program.state = 'W';
            withdrawMoney = 1000000;
            FormResults acctBalance = new FormResults();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void button200_Click(object sender, EventArgs e)
        {
            Program.state = 'W';
            withdrawMoney = 2000000;
            FormResults acctBalance = new FormResults();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void textBoxMoneyAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMoneyAmount.Text, "[^0-9]"))
            {
                textBoxMoneyAmount.Text = textBoxMoneyAmount.Text.Remove(textBoxMoneyAmount.Text.Length - 1);
            }
        }
    }
}
