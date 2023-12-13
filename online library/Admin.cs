using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace online_library
{
    public partial class Admin : Form
    {
        string connectionString;
        SqlConnection conn;
        SqlCommand cmd;
        string choosenID;
        

        public Admin()
        {
            InitializeComponent();
            connectionString = @"Data Source=DESKTOP-Q3KHQ96\NGUYENCUONG;Initial Catalog=onlinelibrary;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            
           // lbl_User.Text = "User: " + username;

        }
        private void bnt_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn logIn = new FormLogIn();
            logIn.ShowDialog();
            this.Dispose();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlinelibraryDataSet2.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.onlinelibraryDataSet2.Books);
            //this.categoryTapleAdapter.Fill(this.onlinelibraryDataSet.);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Books.Rows[e.RowIndex];
                    choosenID = row.Cells["BookID"].Value.ToString();
                    txt_BookID.Text = row.Cells["BookID"].Value.ToString();
                    txt_BookName.Text = row.Cells["BookName"].Value.ToString();
                    txt_Author.Text = row.Cells["Author"].Value.ToString();
                    txt_BookDesdription.Text = row.Cells["BookDesdription"].Value.ToString();
                    txt_AvailableQuantity.Text = row.Cells["AvailableQuantity"].Value.ToString();
                    txt_EventID.Text = row.Cells["EventID"].Value.ToString();
                }
            } catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex.Message, "Error");            
                }
        }
        public void Filldata()
        {
            conn.Open();
            string query = "Select * from Books";
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(dt);
            dgv_Books.DataSource = dt;
            conn.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string bookid = txt_BookID.Text;
            if (bookid.Equals(""))
            {
                error++;
                lbl_BookID.Text = "BookID can't be blank";
            }
            else
            {
                lbl_BookID.Text = " ";
            }
            string BookName = txt_BookName.Text;
            if (BookName.Equals(" "))
            {
                error++;
                lbl_BookName.Text = "BookName can't be blank";
            }
            else //check ID trùng
            {
                try
                {
                    conn.Open();
                    string query = "select * from Books where BookID = @BookID";
                    SqlCommand cmdcheck = new SqlCommand(query, conn);
                    cmdcheck.Parameters.AddWithValue("@BookID", SqlDbType.Char); //tạo @id trong sql
                    cmdcheck.Parameters["@BookID"].Value = bookid;  //gán giá trị cho parameter = biến id
                    SqlDataReader reader = cmdcheck.ExecuteReader();
                    if (reader.Read())
                    {
                        error++;
                        lbl_Error.Text = "BookID had existed";
                    }
                    else
                    {
                        lbl_BookName.Text = "";
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

            string Author = txt_Author.Text;
            string BookDescription = txt_BookDesdription.Text;
            string AvailableQuantity = txt_AvailableQuantity.Text;
            string EventID = txt_EventID.Text;

            if (error == 0)
            {

                string insert = "Insert into Books values (@BookID,@BookName,@Author,@BookDescription,@AvailableQuantity,@EventID)";
                conn.Open();
                SqlCommand cmdinsert = new SqlCommand(insert, conn);
                cmdinsert.Parameters.AddWithValue("@BookID", SqlDbType.Char);
                cmdinsert.Parameters["@BookID"].Value = bookid;
                cmdinsert.Parameters.AddWithValue("@BookName", SqlDbType.NVarChar);
                cmdinsert.Parameters["@BookName"].Value = BookName;
                cmdinsert.Parameters.AddWithValue("@Author", SqlDbType.NVarChar);
                cmdinsert.Parameters["@Author"].Value = Author;
                cmdinsert.Parameters.AddWithValue("@BookDescription", SqlDbType.VarChar);
                cmdinsert.Parameters["@BookDescription"].Value = BookDescription;
                cmdinsert.Parameters.AddWithValue("@AvailableQuantity", SqlDbType.Int);
                cmdinsert.Parameters["@AvailableQuantity"].Value = AvailableQuantity;
                cmdinsert.Parameters.AddWithValue("@EventID", SqlDbType.Char);
                cmdinsert.Parameters["@EventID"].Value = EventID;
               
                cmdinsert.ExecuteNonQuery();
                conn.Close();
                Filldata();
                MessageBox.Show("Insert successfully");
                
            }

            
        }

        private void bnt_Update_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to update?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                String update = "Update Books set BookName = @BookName , Author = @Author , BookDescription =@BookDescription , AvailableQuantity = @AvailableQuantity , EventID = @EventID " + " where BookID = @BookID";
                conn.Open();
                SqlCommand updated = new SqlCommand(update, conn);

                updated.Parameters.Add("@BookID", SqlDbType.Char);
                updated.Parameters["@BookID"].Value = txt_BookID.Text;

                updated.Parameters.Add("@BookName", SqlDbType.NVarChar);
                updated.Parameters["@BookName"].Value = txt_BookName.Text;

                updated.Parameters.Add("@Author", SqlDbType.NVarChar);
                updated.Parameters["@Author"].Value = txt_Author.Text;

                updated.Parameters.Add("@BookDescription", SqlDbType.VarChar);
                updated.Parameters["@BookDescription"].Value = txt_BookDesdription.Text;

                updated.Parameters.Add("@AvailableQuantity", SqlDbType.Int);
                updated.Parameters["@AvailableQuantity"].Value = txt_AvailableQuantity.Text;

                updated.Parameters.Add("@EventID", SqlDbType.Char);
                updated.Parameters["@EventID"].Value = txt_EventID.Text;

                int i = updated.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    Filldata();
                    MessageBox.Show("Update successful");
                }

                
            }
        }

        private void bnt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (choosenID != null)
                {
                    conn.Open();
                    MessageBox.Show("Do you no delete this book=" + choosenID + "?", "confirm", MessageBoxButtons.YesNo);
                    String sqlQuery = "DELETE Books WHERE BookID = @BookID";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sqlQuery;
                    cmd.Parameters.Add("@BookID", SqlDbType.Char);
                    cmd.Parameters["@BookID"].Value=choosenID;
                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Filldata();
                    MessageBox.Show("deleted successfully");
                    

                }
                else
                {
                    MessageBox.Show("Select 1 record to delete");
                }
            }catch(Exception ex) 
            {
                MessageBox.Show("Error!" + ex.Message, "Error");
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                string query = "SELECT * FROM Books WHERE BookID LIKE @SearchValue OR BookName LIKE @SearchValue OR Author LIKE @SearchValue";
                conn.Open();
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    dgv_Books.DataSource = dt;
                }
                else
                {
                    dgv_Books.DataSource = null;
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
        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountManagement account = new AccountManagement();
            account.ShowDialog();
            this.Dispose();
        }





















        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void label6_Click(object sender, EventArgs e)
            {

            }

    }
}
