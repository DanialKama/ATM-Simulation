using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Admin
{
    public partial class FormATMModification : Form
    {
        public FormATMModification()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Server=.;Database=AccountDB;Trusted_Connection=True;";
        string sqlcmd;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            sqlcmd = "INSERT INTO ATMCardTable (AccountNumber, Part1, Part2, Part3, Part4, CVV2, Password, AccountBalance) VALUES (" + textBoxAccountNumber.Text + "," + textBoxPart1.Text + "," + textBoxPart2.Text + "," + textBoxPart3.Text + "," + textBoxPart4.Text + "," + textBoxCVV2.Text + "," + textBoxPassword.Text + "," + textBoxAccountBalance.Text + ")";
            SqlCommand comm = new SqlCommand(sqlcmd, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("New Card Added.");
            }
            catch (Exception x)
            {
                MessageBox.Show("Adding Failed, " + x.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAccountNumber.Clear();
            textBoxPart1.Clear();
            textBoxPart2.Clear();
            textBoxPart3.Clear();
            textBoxPart4.Clear();
            textBoxCVV2.Clear();
            textBoxPassword.Clear();
            textBoxAccountBalance.Clear();
            textBoxAccountNumber.Focus();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            sqlcmd = "DELETE FROM atmCardTable WHERE AccountNumber = " + textBoxAccountNumber.Text + " ";
            comm = new SqlCommand(sqlcmd, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Card Deleted.");
                textBoxAccountNumber.Clear();
                textBoxPart1.Clear();
                textBoxPart2.Clear();
                textBoxPart3.Clear();
                textBoxPart4.Clear();
                textBoxCVV2.Clear();
                textBoxPassword.Clear();
                textBoxAccountBalance.Clear();
                textBoxAccountNumber.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("Deleting Failed, " + x.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            sqlcmd = "SELECT * FROM atmCardTable WHERE AccountNumber = " + textBoxAccountNumber.Text + " ";
            comm = new SqlCommand(sqlcmd, conn);
            try
            {
                conn.Open();
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    textBoxPart1.Text = dreader[1].ToString();
                    textBoxPart2.Text = dreader[2].ToString();
                    textBoxPart3.Text = dreader[3].ToString();
                    textBoxPart4.Text = dreader[4].ToString();
                    textBoxCVV2.Text = dreader[5].ToString();
                    textBoxPassword.Text = dreader[6].ToString();
                    textBoxAccountBalance.Text = dreader[7].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found.");
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            sqlcmd = "UPDATE atmCardTable SET Part1= " + textBoxPart1.Text + ", Part2= " + textBoxPart2.Text + ", Part3= " + textBoxPart3.Text + ", Part4= " + textBoxPart4.Text + ", CVV2= " + textBoxCVV2.Text + ", Password= " + textBoxPassword.Text + ", AccountBalance= " + textBoxAccountBalance.Text + " WHERE AccountNumber = " + textBoxAccountNumber.Text + " ";
            comm = new SqlCommand(sqlcmd, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Record Updated.");
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormDatabaseModification acctBalance = new FormDatabaseModification();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }
    }
}
