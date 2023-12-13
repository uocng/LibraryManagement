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
using System.Xml.Linq;

namespace online_library
{
    public partial class FormLogIn : Form
    {
        string connectionString;
        SqlConnection conn;
        public FormLogIn()
        {
            InitializeComponent();
            connectionString = @"Data Source=DESKTOP-Q3KHQ96\NGUYENCUONG;Initial Catalog=onlinelibrary;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            conn.Open();
            MessageBox.Show("Connected");
            conn.Close();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_managementDataSet.product' table. You can move, or remove it, as needed.
           // this.productTableAdapter.Fill(this.product_managementDataSet.product);
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string password = txt_Password.Text;
            string query = "Select * from account where UserName = @UserName and UserPassword = @Password";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar);
            cmd.Parameters["@UserName"].Value = username;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar);
            cmd.Parameters["@Password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["UserRole"].ToString();    
                if (role.Equals("admin"))
                {
                    MessageBox.Show("Login successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    Admin ad = new Admin();  //chuyển form
                    ad.ShowDialog(); //show hộp thoại thông báo
                    this.Dispose(); //Xóa bộ nhớ
                }
                else if (role.Equals("user"))
                {
                    MessageBox.Show("Login successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    User us = new User();  //chuyển form
                    us.ShowDialog(); //show hộp thoại thông báo
                    this.Dispose(); //Xóa bộ nhớ
                }
                else
                {
                    lbl_Error.Text = "You are not allowed to accesss!";
                }

            }
            else
            {
                lbl_Error.Text = "Wrong username or password";
            }

        }







        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
