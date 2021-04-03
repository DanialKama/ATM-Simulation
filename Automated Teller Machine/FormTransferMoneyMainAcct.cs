using System;
using System.Drawing;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class FormTransferMoneyMainAcct : Form
    {
        public FormTransferMoneyMainAcct()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Transfer From the Main Card Account";
                toOtherAcctBtn.Text = "To Other Accounts";
                toOtherCardBtn.Text = "To Other Cards";
                backBtn.Text = "Back";
            }
            else
            {
                label1.Text = "انتقال از حساب اصلی کارت";
                toOtherAcctBtn.Text = "به سایر حسابهای متمرکز";
                toOtherCardBtn.Text = "به سایر کارتها";
                backBtn.Text = "بازگشت";
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormMenu f4 = new FormMenu();
            Hide();
            f4.ShowDialog();
            Close();
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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toOtherAcctBtn_Click(object sender, EventArgs e)
        {
            Program.state = 'A';
            FormTransferMoneyToAcct withdrawMoneyMainAcct1 = new FormTransferMoneyToAcct();
            Hide();
            withdrawMoneyMainAcct1.ShowDialog();
            Close();
        }

        private void toOtherCardBtn_Click(object sender, EventArgs e)
        {
            Program.state = 'C';
            FormTransferMoneyToCard withdrawMoneyMainAcct2 = new FormTransferMoneyToCard();
            Hide();
            withdrawMoneyMainAcct2.ShowDialog();
            Close();
        }
    }
}
