using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automated_Teller_Machine
{
    public partial class FormTransferMoneyToAcct : Form
    {
        public FormTransferMoneyToAcct()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Transfer From the Main Card Account";
                label2.RightToLeft = RightToLeft.No;
                label2.Text = "Please Enter Desired Account Number to Deposit Money and Press the Register Button.";
                submitBtn.Text = "Confirm";
                backBtn.Text = "Back";
            }
            else
            {
                label1.Text = "انتقال از حساب اصلی کارت";
                label2.Text = "لطفا شماره حساب مورد نظر را جهت واریز وجه وارد نموده و دکمه تایید را فشار دهید.";
                submitBtn.Text = "تایید";
                backBtn.Text = "بازگشت";
            }
        }

        //CtoA for saving account number in card to account transaction
        public static string CtoA;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Server=.;Database=AccountDB;Trusted_Connection=True;";
        string sqlcmd;

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TextBoxAccountNumber.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".شماره حساب کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Account Number is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE AccountNumber = " + TextBoxAccountNumber.Text + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        CtoA = dreader[0].ToString();
                        dreader.Close();
                        conn.Close();
                        if (Program.accNum == CtoA)
                        {
                            if (Program.lang == false)
                            {
                                MessageBox.Show(".شماره حساب دیگری وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Enter Another Account Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            TextBoxAccountNumber.Clear();
                            TextBoxAccountNumber.Focus();
                        }
                        else
                        {
                            FormMoneyAmount transferMoneyAmount = new FormMoneyAmount();
                            Hide();
                            transferMoneyAmount.ShowDialog();
                            Close();
                        }
                    }
                    else
                    {
                        if (Program.lang == false)
                        {
                            MessageBox.Show(".شماره حساب در دسترس نیست، لطفا مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Account Number is not Available, Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    dreader.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Search Failed, " + x.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

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

        private void TextBoxAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxAccountNumber.Text, "[^0-9]"))
            {
                TextBoxAccountNumber.Text = TextBoxAccountNumber.Text.Remove(TextBoxAccountNumber.Text.Length - 1);
            }
        }
    }
}
