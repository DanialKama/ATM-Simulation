using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automated_Teller_Machine
{
    public partial class FormPayBills : Form
    {
        public FormPayBills()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Pay Bills";
                label2.RightToLeft = RightToLeft.No;
                label2.Text = "Please Enter the Desired Bill ID for Payment and Press the Confirm Button.";
                buttonConfirm.Text = "Confirm";
                buttonCancel.Text = "Cancel";
            }
            else
            {
                label1.Text = "پرداخت قبوض";
                label2.Text = "لطفا شناسه قبض مورد نظر را جهت پرداخت وارد نموده و دکمه تایید را فشار دهید.";
                buttonConfirm.Text = "تایید";
                buttonCancel.Text = "لغو";
            }
        }

        public static string billID = " ";

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Server=.;Database=AccountDB;Trusted_Connection=True;";
        string sqlcmd;

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormMenu f4 = new FormMenu();
            Hide();
            f4.ShowDialog();
            Close();
        }

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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TextBoxBillsID.Text))
            {
                if (Program.lang == false)
                {
                    MessageBox.Show(".شناسه قبض کامل نیست، لطفا مجددا تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bills ID is not Complete, Please Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM billsTable WHERE BillsID = " + TextBoxBillsID.Text + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        billID = dreader[0].ToString();
                        Program.state = 'R';
                        dreader.Close();
                        conn.Close();
                        FormResults acctBalance = new FormResults();
                        Hide();
                        acctBalance.ShowDialog();
                        Close();
                    }
                    else
                    {
                        if (Program.lang == false)
                        {
                            MessageBox.Show(".قبض یافت نشد، لطفا مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("No Bill Found, Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TextBoxAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxBillsID.Text, "[^0-9]"))
            {
                TextBoxBillsID.Text = TextBoxBillsID.Text.Remove(TextBoxBillsID.Text.Length - 1);
            }
        }
    }
}
