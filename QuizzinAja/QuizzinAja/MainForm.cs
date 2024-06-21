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
    public partial class MainForm : Form
    {
        SqlConnection conn = Connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;
        DataTable dt;

        public void table_load()
        {

            conn.Open();
            cmd = new SqlCommand("SELECT Quiz.id AS id, Quiz.Name AS Quizz_Name, Quiz.Code As Code, Quiz.Description AS Description FROM [Quiz]", conn);
            dr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "delete";
            button.HeaderText = "Delete";
            button.Text = "Delete";
            button.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(button);

        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            table_load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {

                if(MessageBox.Show("Are you sure to delete this quiz?", "Delete QUiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow data = this.dataGridView1.Rows[e.RowIndex];

                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM [Question] WHERE QuizID = '" + data.Cells["id"].Value.ToString() + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM [Quiz] WHERE Code = '" + data.Cells["Code"].Value.ToString() + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Quiz success to delete", "Delete Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table_load();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuizForm addQuizForm = new AddQuizForm();
            addQuizForm.Show();
            this.Hide();
        }
    }
}
