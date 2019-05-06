using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace usersAuthenticationApp
{
    public partial class createUserForm : Form
    {
        public createUserForm()
        {
            InitializeComponent();
        }

        SqlConnection databaseConnection = new SqlConnection(@"Data Source=KEKA-PC;Initial Catalog=usersAuthentication;Integrated Security=True");


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthenticationForm loginForm = new AuthenticationForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void createUserForm_Load(object sender, EventArgs e)
        {
            createdUserMsglabel6.Visible = false;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();
            if (databaseConnection.State == System.Data.ConnectionState.Open)
            {

                //MessageBox.Show("Connection Established!");
                SqlDataAdapter myQuery = new SqlDataAdapter("INSERT INTO users VALUES('"+emailID.Text+"','"+password.Text+"')", databaseConnection);
                myQuery.SelectCommand.ExecuteNonQuery();
                createdUserMsglabel6.Visible = true;
                createdUserMsglabel6.Text = "User account Successfully created!";
                createBtn.BackColor = Color.LimeGreen;
                databaseConnection.Close();
                emailID.Text = "";
                password.Text = "";
            }
        }

      
    }
}
