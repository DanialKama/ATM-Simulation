using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Admin
{
    public partial class FormBillsModification : Form
    {
        public FormBillsModification()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Server=.;Database=AccountDB;Trusted_Connection=True;";
        string sqlcmd;

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormDatabaseModification acctBalance = new FormDatabaseModification();
            Hide();
            acctBalance.ShowDialog();
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            sqlcmd = "INSERT INTO BillsTable (BillsID, Amount) VALUES (" + textBoxBillsID.Text + "," + textBoxBillsCost.Text + ")";
            SqlCommand comm = new SqlCommand(sqlcmd, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("New Bills Added.");
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
            textBoxBillsID.Clear();
            textBoxBillsCost.Clear();
            textBoxBillsID.Focus();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            sqlcmd = "DELETE FROM BillsTable WHERE BillsID = " + textBoxBillsID.Text + " ";
            comm = new SqlCommand(sqlcmd, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Bills Deleted.");
                textBoxBillsID.Clear();
                textBoxBillsCost.Clear();
                textBoxBillsID.Focus();
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
            sqlcmd = "SELECT * FROM BillsTable WHERE BillsID = " + textBoxBillsID.Text + " ";
            comm = new SqlCommand(sqlcmd, conn);
            try
            {
                conn.Open();
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    textBoxBillsCost.Text = dreader[7].ToString();
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
            sqlcmd = "UPDATE BillsTable SET Amount= " + textBoxBillsCost.Text + " WHERE BillsID = " + textBoxBillsID.Text + " ";
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
    }
}
