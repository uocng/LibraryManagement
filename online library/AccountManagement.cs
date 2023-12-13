using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_library
{
    public partial class AccountManagement : Form
    {
        string connectionString;
        SqlConnection conn;
        SqlCommand cmd;
        string choosenID;
        public AccountManagement()
        {
            InitializeComponent();
            connectionString = @"Data Source=DESKTOP-Q3KHQ96\NGUYENCUONG;Initial Catalog=onlinelibrary;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlinelibraryDataSet.account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.onlinelibraryDataSet.account);

        }
        public void Filldata()
        {
            conn.Open();
            string query = "Select * from account";
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(dt);
            dgv_account.DataSource = dt;
            conn.Close();
        }
        private void dgv_account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_account.Rows[e.RowIndex];
                    choosenID = row.Cells["accountID"].Value.ToString();
                    txt_accountID.Text = row.Cells["accountID"].Value.ToString();
                    txt_UserName.Text = row.Cells["UserName"].Value.ToString();
                    txt_UserPassword.Text = row.Cells["UserPassword"].Value.ToString();
                    txt_UserRole.Text = row.Cells["UserRole"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, "Error");
            }
        }
        private void bnt_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn logIn = new FormLogIn();
            logIn.ShowDialog();
            this.Dispose();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string accountID = txt_accountID.Text;
            if (accountID.Equals(""))
            {
                error++;
                MessageBox.Show("accountID can't be blank");
            }
            string UserName = txt_UserName.Text;
            if (UserName.Equals(" "))
            {
                error++;
                MessageBox.Show("UserName can't be blank");
            }
            else //check ID trùng
            {
                try
                {
                    conn.Open();
                    string query = "select * from account where accountID = @accountID";
                    SqlCommand cmdcheck = new SqlCommand(query, conn);
                    cmdcheck.Parameters.AddWithValue("@accountID", SqlDbType.Char); //tạo @id trong sql
                    cmdcheck.Parameters["@accountID"].Value = accountID;  //gán giá trị cho parameter = biến id
                    SqlDataReader reader = cmdcheck.ExecuteReader();
                    if (reader.Read())
                    {
                        error++;
                        MessageBox.Show("accountID had existed");
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex.Message, "Error");
                }
                finally
                {
                    conn.Close();
                }

            }
            string UserPassword = txt_UserPassword.Text;
            string UserRole = txt_UserRole.Text;

            if (error == 0)
            {

                string insert = "Insert into account values (@accountID,@UserName,@UserPassword,@UserRole)";
                conn.Open();
                SqlCommand cmdinsert = new SqlCommand(insert, conn);
                cmdinsert.Parameters.AddWithValue("@accountID", SqlDbType.Char);
                cmdinsert.Parameters["@accountID"].Value = accountID;

                cmdinsert.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar);
                cmdinsert.Parameters["@UserName"].Value = UserName;

                cmdinsert.Parameters.AddWithValue("@UserPassword", SqlDbType.NVarChar);
                cmdinsert.Parameters["@UserPassword"].Value = UserPassword;

                cmdinsert.Parameters.AddWithValue("@UserRole", SqlDbType.VarChar);
                cmdinsert.Parameters["@UserRole"].Value = UserRole;

                cmdinsert.ExecuteNonQuery();
                conn.Close();
                Filldata();
                MessageBox.Show("Insert successfully");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to update?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                String update = "Update account set UserName = @UserName , UserPassword = @UserPassword , UserRole =@UserRole " + " where accountID = @accountID";
                conn.Open();
                SqlCommand updated = new SqlCommand(update, conn);

                updated.Parameters.Add("@accountID", SqlDbType.Char);
                updated.Parameters["@accountID"].Value = txt_accountID.Text;

                updated.Parameters.Add("@UserName", SqlDbType.NVarChar);
                updated.Parameters["@UserName"].Value = txt_UserName.Text;

                updated.Parameters.Add("@UserPassword", SqlDbType.NVarChar);
                updated.Parameters["@UserPassword"].Value = txt_UserPassword.Text;

                updated.Parameters.Add("@UserRole", SqlDbType.VarChar);
                updated.Parameters["@UserRole"].Value = txt_UserRole.Text;

                int i = updated.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    Filldata();
                    MessageBox.Show("Update successful");
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (choosenID != null)
                {
                    conn.Open();
                    MessageBox.Show("Do you no delete this account=" + choosenID + "?", "confirm", MessageBoxButtons.YesNo);
                    String sqlQuery = "DELETE account WHERE accountID = @accountID";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sqlQuery;
                    cmd.Parameters.Add("@accountID", SqlDbType.Char);
                    cmd.Parameters["@accountID"].Value = choosenID;

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Filldata();
                    MessageBox.Show("deleted successfully");


                }
                else
                {
                    MessageBox.Show("Select 1 record to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, "Error");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                string query = "SELECT * FROM account WHERE accountID LIKE @SearchValue OR UserName LIKE @SearchValue OR UserRole LIKE @SearchValue";
                conn.Open();
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    dgv_account.DataSource = dt;
                }
                else
                {
                    dgv_account.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter a search value!");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Filldata();
            txt_search.Text = null;
        }

       
    }
}
