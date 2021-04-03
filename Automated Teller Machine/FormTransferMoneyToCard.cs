using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automated_Teller_Machine
{
    public partial class FormTransferMoneyToCard : Form
    {
        public FormTransferMoneyToCard()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Transfer From the Main Card Account";
                label2.RightToLeft = RightToLeft.No;
                label2.Text = "Please Enter Desired Card Number to Deposit Money and Press the Register Button.";
                submitBtn.Text = "Confirm";
                backBtn.Text = "Back";
            }
            else
            {
                label1.Text = "انتقال از حساب اصلی کارت";
                label2.Text = ".لطفا شماره کارت مورد نظر را جهت واریز وجه وارد نموده و دکمه ثبت را فشار دهید";
                submitBtn.Text = "تایید";
                backBtn.Text = "بازگشت";
            }
        }

        //CtoC1 to CtoC4 for saving four parts of the card number in card to card transaction
        public static string CtoC1;
        public static string CtoC2;
        public static string CtoC3;
        public static string CtoC4;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Server=.;Database=AccountDB;Trusted_Connection=True;";
        string sqlcmd;

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

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(part1.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش اول شماره کارت کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("First Part of the Card Number is Not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (String.IsNullOrWhiteSpace(part2.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش دوم شماره کارت کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Second Part of the Card Number is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (String.IsNullOrWhiteSpace(part3.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش سوم شماره کارت کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Third Part of the Card Number is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (String.IsNullOrWhiteSpace(part4.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش چهارم شماره کارت کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Fourth Part of the Card Number is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE Part1= " + part1.Text + "AND Part2= " + part2.Text + "AND Part3= " + part3.Text + "AND Part4= " + part4.Text + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        CtoC1 = dreader[1].ToString();
                        CtoC2 = dreader[2].ToString();
                        CtoC3 = dreader[3].ToString();
                        CtoC4 = dreader[4].ToString();
                        dreader.Close();
                        conn.Close();
                        if (Program.accP1 == CtoC1 && Program.accP2 == CtoC2 && Program.accP3 == CtoC3 && Program.accP4 == CtoC4)
                        {
                            if (Program.lang == false)
                            {
                                MessageBox.Show(".شماره کارت دیگری وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Enter Another Card Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            part1.Clear();
                            part2.Clear();
                            part3.Clear();
                            part4.Clear();
                            part1.Focus();
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
                            MessageBox.Show(".شماره کارت در دسترس نیست، لطفا مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Card Number is not Available, Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void part1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(part1.Text, "[^0-9]"))
            {
                part1.Text = part1.Text.Remove(part1.Text.Length - 1);
            }
        }

        private void part2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(part2.Text, "[^0-9]"))
            {
                part2.Text = part2.Text.Remove(part2.Text.Length - 1);
            }
        }

        private void part3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(part3.Text, "[^0-9]"))
            {
                part3.Text = part3.Text.Remove(part3.Text.Length - 1);
            }
        }

        private void part4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(part4.Text, "[^0-9]"))
            {
                part4.Text = part4.Text.Remove(part4.Text.Length - 1);
            }
        }
    }
}
