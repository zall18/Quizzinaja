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
    public partial class Form1 : Form
    {
        SqlConnection conn = Connection.Connect();
        SqlCommand cmd;
        SqlDataAdapter dr;
        SqlDataReader rd;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [User] WHERE Username = '" + username.Text + "' AND password = '" + password.Text + "'", conn);
            rd = cmd.ExecuteReader();
            if(rd.HasRows)
            {
                rd.Read();
                int id = (int)rd["ID"];
                string nama = rd["Username"].ToString();
                session.start(id, nama);
                rd.Close();
                conn.Close();

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username and password doesn't match", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                conn.Close() ;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
            this.Hide();
        }
    }
}
