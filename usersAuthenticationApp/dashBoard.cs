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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=KEKA-PC;Initial Catalog=usersAuthentication;Integrated Security=True");
                    
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cPassword.Visible = false;
            nPassword.Visible = false;
            vPassword.Visible = false;
            cplabel3.Visible = false;
            nplabel4.Visible = false;
            vplabel5.Visible = false;
            cPasswortBtn.Visible = false;
            deactiveText.Visible = false;
            deactlabel3.Visible = false;
            button1Deact.Visible = false;
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cPassword.Visible = true;
            nPassword.Visible = true;
            vPassword.Visible = true;
            cplabel3.Visible = true;
            nplabel4.Visible = true;
            vplabel5.Visible = true;
            cPasswortBtn.Visible = true;
        }

        private void cPasswortBtn_Click(object sender, EventArgs e)
        {
            if (cPassword.Text != "" && nPassword.Text != "" && vPassword.Text != "")
            {
                if (vPassword.Text != nPassword.Text)
                {
                    MessageBox.Show("Verifying Password not match!");
                }
                else
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=KEKA-PC;Initial Catalog=usersAuthentication;Integrated Security=True");
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        //MessageBox.Show("Connected!");
                        SqlDataAdapter sda = new SqlDataAdapter(/*use update query here:::                                     
                STRUCTURE: UPDATE tabelname SET columnname= new 
                dataValue [WHERE condition]*/

                            "UPDATE users SET user_password='" + nPassword.Text + "' WHERE user_password='" + cPassword.Text + "'", conn);
                        if (MessageBox.Show("Do you want to change your current password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            sda.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Password changed, Successfully.");

                            cPassword.Text = "";
                            nPassword.Text = "";
                            vPassword.Text = "";
                          
                            conn.Close();
                            return;
                        }
                        else
                        {
                            cPassword.Text = "";
                            nPassword.Text = "";
                            vPassword.Text = "";

                        }
                        //else if (MessageBox.Show("Do you want to change your current password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        //{
                        //    return;
                        //}

                    }
                }
            }
            else {

                cPassword.Text = "";
                nPassword.Text = "";
                vPassword.Text = "";
                MessageBox.Show("Please type to change your current password!");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthenticationForm loginForm = new AuthenticationForm();
            loginForm.ShowDialog();
            this.Close();

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
            deactiveText.Visible = true;
            deactlabel3.Visible = true;
            button1Deact.Visible = true;
        }

        private void button1Deact_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (deactiveText.Text != "")
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM users where email_id='" + deactiveText.Text + "'", conn);
                    if (MessageBox.Show("Do you want to deactive your account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sda.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Account successfully deactivated!");
                        deactiveText.Text = "";
                    }
                    //conn.Close();
                }
                conn.Close();
            }
            else {

                MessageBox.Show("No account name typed!");
            }
            
        }

        
    }
}
