using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automated_Teller_Machine
{
    public partial class FormChangePwd : Form
    {
        public FormChangePwd()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Change Password";
                currentPwdLabel.Text = "Current Password";
                newPwdLabel.Text = "New Password";
                repeatNewPwdLabel.Text = "Repeat New Password";
                ConfirmBtn.Text = "Confirm";
                cancelBtn.Text = "Cancel";
            }
            else
            {
                label1.Text = "تغییر رمز";
                currentPwdLabel.Text = "رمز فعلی";
                newPwdLabel.Text = "رمز جدید";
                repeatNewPwdLabel.Text = "تکرار رمز جدید";
                ConfirmBtn.Text = "تایید";
                cancelBtn.Text = "لغو";
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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(currentPwdTextBox.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش رمز فعلی کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Current Password Part is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                currentPwdTextBox.Focus();
            }
            else if (String.IsNullOrWhiteSpace(newPwdTextBox.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش رمز جدید کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("New Password Part is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                newPwdTextBox.Focus();
            }
            else if (String.IsNullOrWhiteSpace(repeatNewPwdTextBox.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".بخش تکرار رمز جدید کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Repeat New Password Part is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                repeatNewPwdTextBox.Focus();
            }
            else if (newPwdTextBox.Text != repeatNewPwdTextBox.Text)
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".رمز جدید با تکرار رمز جدید یکسان نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("The New Password is Not the Same as the Repeat New Password, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                repeatNewPwdTextBox.Focus();
            }
            else if (currentPwdTextBox.Text == newPwdTextBox.Text || currentPwdTextBox.Text == repeatNewPwdTextBox.Text)
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".رمز جدید نباید تکراری باشد، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("The New Password Should Not be Duplicated, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                newPwdTextBox.Focus();
            }
            else if (newPwdTextBox.Text == repeatNewPwdTextBox.Text)
            {
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE AccountNumber = " + Program.accNum + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        string temp = dreader[6].ToString();
                        dreader.Close();
                        conn.Close();
                        if (currentPwdTextBox.Text == temp)
                        {
                            conn = new SqlConnection(connstring);
                            sqlcmd = "UPDATE atmCardTable SET Password= " + newPwdTextBox.Text + " WHERE AccountNumber = " + Program.accNum + " ";
                            comm = new SqlCommand(sqlcmd, conn);
                            try
                            {
                                conn.Open();
                                comm.ExecuteNonQuery();
                                conn.Close();
                                Program.state = 'P';
                                FormResults acctBalance = new FormResults();
                                Hide();
                                acctBalance.ShowDialog();
                                Close();

                            }
                            catch (Exception x)
                            {
                                MessageBox.Show("Update Failed, " + x.Message);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                        else
                        {
                            if (Program.lang == false)
                            {
                                MessageBox.Show(".رمز فعلی اشتباه است، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("The Current Password is Wrong, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            currentPwdTextBox.Focus();
                        }
                    }
                    else
                    {
                        if (Program.lang == false)
                        {
                            MessageBox.Show(".خطایی رخ داد، لطفا مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("An Error Occurred, Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cancelBtn.Focus();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            FormMenu f4 = new FormMenu();
            Hide();
            f4.ShowDialog();
            Close();
        }

        private void currentPwdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(currentPwdTextBox.Text, "[^0-9]"))
            {
                currentPwdTextBox.Text = currentPwdTextBox.Text.Remove(currentPwdTextBox.Text.Length - 1);
            }
        }

        private void newPwdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(newPwdTextBox.Text, "[^0-9]"))
            {
                newPwdTextBox.Text = newPwdTextBox.Text.Remove(newPwdTextBox.Text.Length - 1);
            }
        }

        private void repeatNewPwdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(repeatNewPwdTextBox.Text, "[^0-9]"))
            {
                repeatNewPwdTextBox.Text = repeatNewPwdTextBox.Text.Remove(repeatNewPwdTextBox.Text.Length - 1);
            }
        }
    }
}
