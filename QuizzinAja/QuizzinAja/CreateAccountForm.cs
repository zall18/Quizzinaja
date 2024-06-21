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

namespace QuizzinAja
{
    public partial class CreateAccountForm : Form
    {
        SqlConnection conn = Connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
    
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(username.Text.Length == 0)
            {
                MessageBox.Show("Username field is required");
            }else if(fullname.Text.Length == 0)
            {
                MessageBox.Show("Full Name field is required");
            }else if(pass.Text.Length == 0)
            {
                MessageBox.Show("Password field is required");
            }else if(kpass.Text.Length == 0)
            {
                MessageBox.Show("this field is required");
            }
            else
            {
                if(pass.Text.Length >= 4)
                {
                    if (pass.Text == kpass.Text)
                    {
                        conn.Open();
                        cmd = new SqlCommand("SELECT * FROM [User] WHERE Username = '" + username.Text + "'", conn);
                        rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            MessageBox.Show("Username alredy exist!", "Username Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            conn.Close();

                        }
                        else
                        {
                            conn.Close();
                            conn.Open();
                            cmd = new SqlCommand("INSERT INTO [User] VALUES('" + username.Text + "', '" + fullname.Text + "', @dob, '" + pass.Text + "')", conn);
                            cmd.Parameters.AddWithValue("@dob", dob.Value);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Register Success, Please login!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 form = new Form1();
                            form.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confirmation password doesn't match!");
                    }
                }
                else
                {
                    MessageBox.Show("Password field should have minimal 4 character");
                }
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
