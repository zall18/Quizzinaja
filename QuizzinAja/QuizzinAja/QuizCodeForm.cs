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
    public partial class QuizCodeForm : Form
    {
        SqlConnection conn = Connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;
        public QuizCodeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nickname.Text.Length == 0)
            {
                MessageBox.Show("Nickname is important!");
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM [Quiz] WHERE Code = '" + code.Text + "'", conn);
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    session.quizStart(nickname.Text, rd["ID"].ToString());
                    conn.Close();
                    QuizForm quizForm = new QuizForm();
                    quizForm.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Quiz code not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
    }
}
