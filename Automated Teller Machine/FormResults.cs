using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automated_Teller_Machine
{
    public partial class FormResults : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Server=.;Database=AccountDB;Trusted_Connection=True;";
        string sqlcmd;

        Int64 cardMoney = 0;
        Int64 billAmount = 0;
        bool error = false;

        public FormResults()
        {
            InitializeComponent();

            if (Program.lang == true)
            {
                label1.Text = "Process";
                confirmBtn.Text = "Confirm";
                buttonCancel.Text = "Cancel";
                backBtn.Text = "Another Service";
                buttonExit.Text = "Exit";
            }
            else
            {
                label1.Text = "پردازش";
                confirmBtn.Text = "تایید";
                buttonCancel.Text = "لغو";
                backBtn.Text = "خدمات دیگر";
                buttonExit.Text = "خروج";
            }

            if (Program.state == 'B')
            {
                if (Program.lang == false)
                {
                    label1.Text = "موجودی حساب";
                }
                else
                {
                    label1.Text = "Account Balance";
                }

                //نمایش نتیجه گرفتن موجودی
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE AccountNumber= " + Program.accNum + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = "موجودی حساب:\n" + dreader[7].ToString() + "\nریال است.";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "Account Balance:\n" + dreader[7].ToString() + "\nRials.";
                        }
                    }

                    dreader.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Search Failed, " + x.Message);
                    if (Program.lang == false)
                    {
                        acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                    }
                    else
                    {
                        acctBalanceLabel.RightToLeft = RightToLeft.No;
                        acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                    }
                }
                finally
                {
                    conn.Close();
                }

                backBtn.Visible = true;
                buttonExit.Visible = true;
            }
            else if (Program.state == 'W')
            {
                if (Program.lang == false)
                {
                    label1.Text = "برداشت وجه";
                }
                else
                {
                    label1.Text = "Withdraw Money";
                }

                //نمایش نتیجه برداشت وجه
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE AccountNumber = " + Program.accNum + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        cardMoney = Int64.Parse(dreader[7].ToString());
                    }

                    dreader.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Search Failed, " + x.Message);
                    if (Program.lang == false)
                    {
                        acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                    }
                    else
                    {
                        acctBalanceLabel.RightToLeft = RightToLeft.No;
                        acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                    }
                    error = true;
                }
                finally
                {
                    conn.Close();
                }

                if (error == false && cardMoney - FormWithdrawMoney.withdrawMoney >= 0)
                {
                    cardMoney = cardMoney - FormWithdrawMoney.withdrawMoney;
                    conn = new SqlConnection(connstring);
                    sqlcmd = "UPDATE atmCardTable SET AccountBalance= " + cardMoney + " WHERE AccountNumber= " + Program.accNum + " ";
                    comm = new SqlCommand(sqlcmd, conn);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = "عملیات با موفقیت انجام شد، وجه برداشت شده:\n" + FormWithdrawMoney.withdrawMoney + " ریال\nموجودی: " + cardMoney + " ریال";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "The Operation Was successful, Withdraw Cash:\n" + FormWithdrawMoney.withdrawMoney + " Rials\nAccount Balance: " + cardMoney + " Rials";
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Update Failed, " + x.Message);
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                        }
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
                        acctBalanceLabel.Text = "موجودی کافی نیست.";
                    }
                    else
                    {
                        acctBalanceLabel.RightToLeft = RightToLeft.No;
                        acctBalanceLabel.Text = "Insufficient Funds.";
                    }
                }

                backBtn.Visible = true;
                buttonExit.Visible = true;
            }
            else if (Program.state == 'C')
            {
                if (Program.lang == false)
                {
                    label1.Text = "انتقال موجودی به کارت دیگر";
                }
                else
                {
                    label1.Text = "Transfer Money to Another Card";
                }
                //انتقال موجودی به کارت دیگر
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE Part1= " + Program.accP1 + "AND Part2= " + Program.accP2 + "AND Part3= " + Program.accP3 + "AND Part4= " + Program.accP4 + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        string temp = dreader[7].ToString();
                        cardMoney = Int64.Parse(temp);
                        if (cardMoney - FormMoneyAmount.moneyAmount >= 0)
                        {
                            confirmBtn.Visible = true;
                            buttonCancel.Visible = true;
                            if (Program.lang == false)
                            {
                                acctBalanceLabel.Text = "انتقال: " + FormMoneyAmount.moneyAmount + " ریال\nبه شماره کارت: " + FormTransferMoneyToCard.CtoC1 + " " + FormTransferMoneyToCard.CtoC2 + " " + FormTransferMoneyToCard.CtoC3 + " " + FormTransferMoneyToCard.CtoC4 + "\nبرای ادامه دکمه تایید یا برای انصراف دکمه لغو را بفشارید.";
                            }
                            else
                            {
                                acctBalanceLabel.RightToLeft = RightToLeft.No;
                                acctBalanceLabel.Text = "Transfer: " + FormMoneyAmount.moneyAmount + " Rials\nto Card Number: " + FormTransferMoneyToCard.CtoC1 + " " + FormTransferMoneyToCard.CtoC2 + " " + FormTransferMoneyToCard.CtoC3 + " " + FormTransferMoneyToCard.CtoC4 + "\nPress the Confirm Button to Continue or Press the Cancel Button to Cancellation.";
                            }
                        }
                        else
                        {
                            if (Program.lang == false)
                            {
                                acctBalanceLabel.Text = "موجودی کافی نیست.";
                            }
                            else
                            {
                                acctBalanceLabel.RightToLeft = RightToLeft.No;
                                acctBalanceLabel.Text = "Insufficient Funds.";
                            }
                            backBtn.Visible = true;
                            buttonExit.Visible = true;
                        }
                    }
                    else
                    {
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                        }
                        backBtn.Visible = true;
                        buttonExit.Visible = true;
                    }
                    dreader.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Search Failed, " + x.Message);
                    backBtn.Visible = true;
                    buttonExit.Visible = true;
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (Program.state == 'A')
            {
                if (Program.lang == false)
                {
                    label1.Text = "انتقال موجودی به حساب دیگر";
                }
                else
                {
                    label1.Text = "Transfer Money to Another Account";
                }

                //نمایش نتیجه انتقال موجودی به حساب دیگر
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM atmCardTable WHERE AccountNumber = " + Program.accNum + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        string temp = dreader[7].ToString();
                        cardMoney = Int64.Parse(temp);
                        if (cardMoney - FormMoneyAmount.moneyAmount >= 0)
                        {
                            if (Program.lang == false)
                            {
                                acctBalanceLabel.Text = "انتقال: " + FormMoneyAmount.moneyAmount + " ریال\nبه شماره حساب: " + FormTransferMoneyToAcct.CtoA + "\nبرای ادامه دکمه تایید یا برای انصراف دکمه لغو را بفشارید.";
                            }
                            else
                            {
                                acctBalanceLabel.RightToLeft = RightToLeft.No;
                                acctBalanceLabel.Text = "Transfer: " + FormMoneyAmount.moneyAmount + " Rials\nto Account Number: " + FormTransferMoneyToAcct.CtoA + "\nPress the Confirm Button to Continue or Press the Cancel Button to Cancellation.";
                            }

                            confirmBtn.Visible = true;
                            buttonCancel.Visible = true;
                        }
                        else
                        {
                            if (Program.lang == false)
                            {
                                acctBalanceLabel.Text = "موجودی کافی نیست.";
                            }
                            else
                            {
                                acctBalanceLabel.RightToLeft = RightToLeft.No;
                                acctBalanceLabel.Text = "Insufficient Funds.";
                            }
                            backBtn.Visible = true;
                            buttonExit.Visible = true;
                        }
                    }
                    else
                    {
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                        }
                        backBtn.Visible = true;
                        buttonExit.Visible = true;
                    }
                    dreader.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Search Failed, " + x.Message);
                    backBtn.Visible = true;
                    buttonExit.Visible = true;
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (Program.state == 'P')
            {
                if (Program.lang == false)
                {
                    label1.Text = "تغییر رمز";
                }
                else
                {
                    label1.Text = "Change Password";
                }

                if (Program.lang == false)
                {
                    acctBalanceLabel.Text = "رمز با موفقیت تغییر یافت.";
                }
                else
                {
                    acctBalanceLabel.RightToLeft = RightToLeft.No;
                    acctBalanceLabel.Text = "The Password Was Successfully Changed.";
                }
                backBtn.Visible = true;
                buttonExit.Visible = true;
            }
            else if (Program.state == 'R')
            {
                if (Program.lang == false)
                {
                    label1.Text = "پرداخت قبوض";
                }
                else
                {
                    label1.Text = "Pay Bills";
                }
                //پرداخت قبوض
                conn = new SqlConnection(connstring);
                sqlcmd = "SELECT * FROM billsTable WHERE billsID = " + FormPayBills.billID + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        string temp1 = dreader[1].ToString();
                        billAmount = Int64.Parse(temp1);
                    }
                    else
                    {
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                        }
                        error = true;
                        backBtn.Visible = true;
                        buttonExit.Visible = true;
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
                if (error == false)
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
                            string temp2 = dreader[7].ToString();
                            cardMoney = Int64.Parse(temp2);
                            if (cardMoney - billAmount >= 0)
                            {
                                if (Program.lang == false)
                                {
                                    acctBalanceLabel.Text = "پرداخت قبض: " + FormPayBills.billID + "\nمبلغ قابل پرداخت: " + billAmount + "\nبرای ادامه دکمه تایید یا برای انصراف دکمه لغو را بفشارید.";
                                }
                                else
                                {
                                    acctBalanceLabel.RightToLeft = RightToLeft.No;
                                    acctBalanceLabel.Text = "Pay Bill: " + FormPayBills.billID + "\nPayment Fee: " + billAmount + "\nPress the Confirm Button to Continue or Press the Cancel Button to Cancellation.";
                                }

                                confirmBtn.Visible = true;
                                buttonCancel.Visible = true;
                            }
                            else
                            {
                                if (Program.lang == false)
                                {
                                    acctBalanceLabel.Text = "موجودی کافی نیست.";
                                }
                                else
                                {
                                    acctBalanceLabel.RightToLeft = RightToLeft.No;
                                    acctBalanceLabel.Text = "Insufficient Funds.";
                                }
                                backBtn.Visible = true;
                                buttonExit.Visible = true;
                            }
                        }
                        else
                        {
                            if (Program.lang == false)
                            {
                                acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                            }
                            else
                            {
                                acctBalanceLabel.RightToLeft = RightToLeft.No;
                                acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                            }
                            backBtn.Visible = true;
                            buttonExit.Visible = true;
                        }
                        dreader.Close();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Search Failed, " + x.Message);
                        backBtn.Visible = true;
                        buttonExit.Visible = true;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                if (Program.lang == false)
                {
                    acctBalanceLabel.Text = "خطایی رخ داد!\nمجددا تلاش کنید.\n☹️";
                }
                else
                {
                    acctBalanceLabel.RightToLeft = RightToLeft.No;
                    acctBalanceLabel.Text = "An Error Occurred!\nTry Again.\n☹️";
                }
                buttonExit.Visible = true;
            }
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

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (Program.state == 'C')
            {
                conn = new SqlConnection(connstring);
                sqlcmd = "UPDATE atmCardTable SET AccountBalance+= " + FormMoneyAmount.moneyAmount + " WHERE Part1= " + FormTransferMoneyToCard.CtoC1 + "AND Part2= " + FormTransferMoneyToCard.CtoC2 + "AND Part3= " + FormTransferMoneyToCard.CtoC3 + "AND Part4= " + FormTransferMoneyToCard.CtoC4 + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Update Failed, " + x.Message);
                    if (Program.lang == false)
                    {
                        acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                    }
                    else
                    {
                        acctBalanceLabel.RightToLeft = RightToLeft.No;
                        acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                    }
                    error = true;
                }
                finally
                {
                    conn.Close();
                }

                if (error == false)
                {
                    conn = new SqlConnection(connstring);
                    cardMoney = cardMoney - FormMoneyAmount.moneyAmount;
                    sqlcmd = "UPDATE atmCardTable SET AccountBalance= " + cardMoney + " WHERE AccountNumber = " + Program.accNum + " ";
                    comm = new SqlCommand(sqlcmd, conn);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = "انتقال وجه به شماره کارت:\n" + FormTransferMoneyToCard.CtoC1 + " " + FormTransferMoneyToCard.CtoC2 + " " + FormTransferMoneyToCard.CtoC3 + " " + FormTransferMoneyToCard.CtoC4 + "\nوجه منتقل شده: " + FormMoneyAmount.moneyAmount + "\nباقی مانده: " + cardMoney;
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "Transfer Money to Card Number:\n" + FormTransferMoneyToCard.CtoC1 + " " + FormTransferMoneyToCard.CtoC2 + " " + FormTransferMoneyToCard.CtoC3 + " " + FormTransferMoneyToCard.CtoC4 + "\nTransferred Money: " + FormMoneyAmount.moneyAmount + "\nAccount Balance: " + cardMoney;
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Update Failed, " + x.Message);
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                confirmBtn.Visible = false;
                buttonCancel.Visible = false;
                backBtn.Visible = true;
                buttonExit.Visible = true;
            }
            else if (Program.state == 'A')
            {
                //read and write
                conn = new SqlConnection(connstring);
                sqlcmd = "UPDATE atmCardTable SET AccountBalance+= " + FormMoneyAmount.moneyAmount + " WHERE AccountNumber = " + FormTransferMoneyToAcct.CtoA + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Update Failed, " + x.Message);
                    if (Program.lang == false)
                    {
                        acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                    }
                    else
                    {
                        acctBalanceLabel.RightToLeft = RightToLeft.No;
                        acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                    }
                    error = true;
                }
                finally
                {
                    conn.Close();
                }

                if (error == false)
                {
                    conn = new SqlConnection(connstring);
                    cardMoney = cardMoney - FormMoneyAmount.moneyAmount;
                    sqlcmd = "UPDATE atmCardTable SET AccountBalance= " + cardMoney + " WHERE AccountNumber = " + Program.accNum + " ";
                    comm = new SqlCommand(sqlcmd, conn);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = "انتقال وجه به شماره حساب:\n" + FormTransferMoneyToAcct.CtoA + "\nوجه منتقل شده: " + FormMoneyAmount.moneyAmount + "\nباقی مانده: " + cardMoney;
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "Transfer Money to Account Number:\n" + FormTransferMoneyToAcct.CtoA + "\nTransferred Money: " + FormMoneyAmount.moneyAmount + "\nAccount Balance: " + cardMoney;
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Update Failed, " + x.Message);
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else if (Program.state == 'R')
            {
                conn = new SqlConnection(connstring);
                sqlcmd = "DELETE FROM billsTable WHERE BillsID = " + FormPayBills.billID + " ";
                comm = new SqlCommand(sqlcmd, conn);
                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Deleting Failed, " + x.Message);
                    if (Program.lang == false)
                    {
                        acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                    }
                    else
                    {
                        acctBalanceLabel.RightToLeft = RightToLeft.No;
                        acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                    }
                    error = true;
                }
                finally
                {
                    conn.Close();
                }
                if (error == false)
                {
                    conn = new SqlConnection(connstring);
                    cardMoney = cardMoney - billAmount;
                    sqlcmd = "UPDATE atmCardTable SET AccountBalance= " + cardMoney + " WHERE AccountNumber = " + Program.accNum + " ";
                    comm = new SqlCommand(sqlcmd, conn);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = "پرداخت قبض با شناسه:\n" + FormPayBills.billID + "\nبا موفقیت انجام شد." + "\nباقی مانده: " + cardMoney;
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "Bill Pay With ID:\n" + FormPayBills.billID + "\nDone Successfully." + "\nAccount Balance: " + cardMoney;
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Update Failed, " + x.Message);
                        if (Program.lang == false)
                        {
                            acctBalanceLabel.Text = ".خطایی رخ داد، لطفا مجددا تلاش کنید";
                        }
                        else
                        {
                            acctBalanceLabel.RightToLeft = RightToLeft.No;
                            acctBalanceLabel.Text = "An Error Occurred, Please Try Again.";
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            confirmBtn.Visible = false;
            buttonCancel.Visible = false;
            backBtn.Visible = true;
            buttonExit.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormSelectLanguage f1 = new FormSelectLanguage();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (Program.lang == false)
            {
                acctBalanceLabel.Text = ".عملیات لغو شد";
            }
            else
            {
                acctBalanceLabel.RightToLeft = RightToLeft.No;
                acctBalanceLabel.Text = "The Operation Was Canceled.";
            }
            confirmBtn.Visible = false;
            buttonCancel.Visible = false;
            backBtn.Visible = true;
            buttonExit.Visible = true;
        }
    }
}
