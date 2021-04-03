using System;
using System.Drawing;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class FormMoneyAmount : Form
    {
        public FormMoneyAmount()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label2.RightToLeft = RightToLeft.No;
                label2.Text = "Please Enter the Desired Amount and Press the Confirm Button. (Rials)";
                confirmBtn.Text = "Confirm";
                backBtn.Text = "Cancel";
            }
            else
            {
                label2.Text = "لطفا مبلغ مورد نظر را وارد نموده و دکمه تایید را فشار دهید. (ریال)";
                confirmBtn.Text = "تایید";
                backBtn.Text = "لغو";
            }
        }

        public static Int64 moneyAmount = 0;
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
            if (String.IsNullOrWhiteSpace(textBoxMoneyAmount.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بدون ورودی، لطفا مجددا تلاش کنید", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No Input, Please Try Again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                moneyAmount = Int64.Parse(textBoxMoneyAmount.Text);
                FormResults acctBalance = new FormResults();
                Hide();
                acctBalance.ShowDialog();
                Close();
            }
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
