using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automated_Teller_Machine
{
    public partial class FormCardCheck : Form
    {
        public FormCardCheck()
        {
            InitializeComponent();

            if (Program.lang == true){
                label1.RightToLeft = RightToLeft.No;
                label1.Text = "Please Enter Your Card Information.";
                buttonEnter.Text = "Enter";
                buttonExit.Text = "Exit";
            }
            else
            {
                label1.Text = "لطفا اطلاعات کارت خود را وارد کنید.";
                buttonEnter.Text = "ورود";
                buttonExit.Text = "خروج";
            }

        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Server=.;Database=AccountDB;Trusted_Connection=True;";
        string sqlcmd;

        private void enterbtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPart1.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش اول شماره کارت کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("First Part of the Card Number is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxPart1.Focus();
            }
            else if (String.IsNullOrWhiteSpace(textBoxPart2.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش دوم شماره کارت کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Second Part of the Card Number is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxPart2.Focus();
            }
            else if (String.IsNullOrWhiteSpace(textBoxPart3.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش سوم شماره کارت کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Third Part of the Card Number is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxPart3.Focus();
            }
            else if (String.IsNullOrWhiteSpace(textBoxPart4.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش چهارم شماره کارت کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Fourth Part of the Card Number is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxPart4.Focus();
            }
            else if (String.IsNullOrWhiteSpace(textBoxCVV2.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".کد اعتبارسنجی کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("CVV2 is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxCVV2.Focus();
            }
            else
            {
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE Part1= " + textBoxPart1.Text + "AND Part2= " + textBoxPart2.Text + "AND Part3= " + textBoxPart3.Text + "AND Part4= " + textBoxPart4.Text + "AND CVV2= " + textBoxCVV2.Text + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        Program.accNum = dreader[0].ToString();
                        Program.accP1 = dreader[1].ToString();
                        Program.accP2 = dreader[2].ToString();
                        Program.accP3 = dreader[3].ToString();
                        Program.accP4 = dreader[4].ToString();

                        dreader.Close();
                        conn.Close();

                        FormPasswordCheck f3 = new FormPasswordCheck();
                        Hide();
                        f3.ShowDialog();
                        Close();
                    }
                    else
                    {
                        if (Program.lang == false)
                        {
                            MessageBox.Show(".کارت با این مشخصات پیدا نشد، لطفا مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Card With These Specifications Was Not Found, Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        textBoxPart1.Clear();
                        textBoxPart2.Clear();
                        textBoxPart3.Clear();
                        textBoxPart4.Clear();
                        textBoxCVV2.Clear();
                        textBoxPart1.Focus();
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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxPart1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPart1.Text, "[^0-9]"))
            {
                textBoxPart1.Text = textBoxPart1.Text.Remove(textBoxPart1.Text.Length - 1);
            }
        }

        private void textBoxPart2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPart2.Text, "[^0-9]"))
            {
                textBoxPart2.Text = textBoxPart2.Text.Remove(textBoxPart2.Text.Length - 1);
            }
        }

        private void textBoxPart3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPart3.Text, "[^0-9]"))
            {
                textBoxPart3.Text = textBoxPart3.Text.Remove(textBoxPart3.Text.Length - 1);
            }
        }

        private void textBoxPart4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPart4.Text, "[^0-9]"))
            {
                textBoxPart4.Text = textBoxPart4.Text.Remove(textBoxPart4.Text.Length - 1);
            }
        }

        private void textBoxCVV2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCVV2.Text, "[^0-9]"))
            {
                textBoxCVV2.Text = textBoxCVV2.Text.Remove(textBoxCVV2.Text.Length - 1);
            }
        }
    }
}
