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
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=KEKA-PC;Initial Catalog=usersAuthentication;Integrated Security=True");

        private void Authentication_Load(object sender, EventArgs e)
        {

        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            if(conn.State== System.Data.ConnectionState.Open){


                //MessageBox.Show("Connection Established!");
                string emailTxt = emailID.Text;
                string pwdTxt = password.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT email_id, user_password FROM users WHERE email_id='"+emailID.Text+"' AND user_password='" + password.Text + "'", conn);
                //sda.SelectCommand.ExecuteReader();
                DataTable myNewDataTable = new DataTable();
                sda.Fill(myNewDataTable);

                if (myNewDataTable.Rows.Count>0)
                {
                    //MessageBox.Show("User authentication verified!");
                    this.Hide();
                    Form2 welcomeForm = new Form2();
                    welcomeForm.ShowDialog();
                    conn.Close();
                    this.Close();
                }
                else {

                    MessageBox.Show("Wrong username or password, Try again!");
                    conn.Close();
                }
                    
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            createUserForm createUserForm = new createUserForm();
            createUserForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Thanks for using BHS App.");
        }

    }
}
