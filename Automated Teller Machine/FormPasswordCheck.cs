using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automated_Teller_Machine
{
    public partial class FormPasswordCheck : Form
    {
        public FormPasswordCheck()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Please Enter Card Password";
                submitbtn.Text = "Enter";
                exitCardBtn.Text = "Exit";
            }
            else
            {
                label1.Text = "لطفا رمز کارت را وارد کنید";
                submitbtn.Text = "ورود";
                exitCardBtn.Text = "خروج";
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

        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(pass.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".کادر رمز عبور خالی است، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Password Field is Empty, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE AccountNumber= " + Program.accNum + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        if (pass.Text == dreader[6].ToString())
                        {
                            FormMenu f4 = new FormMenu();
                            Hide();
                            f4.ShowDialog();
                            Close();
                        }
                        else
                        {
                            if (Program.lang == false)
                            {
                                MessageBox.Show(".رمز اشتباه است، لطفا مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Password is Wrong, Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            pass.Clear();
                            pass.Focus();
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

        private void pass_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(pass.Text, "[^0-9]"))
            {
                pass.Text = pass.Text.Remove(pass.Text.Length - 1);
            }
        }
    }
}
