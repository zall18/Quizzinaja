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
    public partial class AddQuizForm : Form
    {
        SqlConnection conn = Connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;
        DataTable dt;

        int no = 1;

        public void table_load()
        {

            gdgv.Columns.Clear();
            gdgv.Rows.Clear();
            gdgv.ColumnCount = 7;
            gdgv.Columns[0].Name = "No";
            gdgv.Columns[1].Name = "Question";
            gdgv.Columns[2].Name = "Option A";
            gdgv.Columns[3].Name = "Option B";
            gdgv.Columns[4].Name = "Option C";
            gdgv.Columns[5].Name = "Option D";  
            gdgv.Columns[6].Name = "Correct Answer";





        }
        public AddQuizForm()
        {
            InitializeComponent();
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(question.Text.Length == 0)
            {
                MessageBox.Show("Question is important");
            }else if(optionA.Text.Length == 0)
            {
                MessageBox.Show("Option A is important");
            }else if(optionB.Text.Length == 0)
            {
                MessageBox.Show("Option B is important");
            }else if(optionC.Text.Length == 0)
            {
                MessageBox.Show("Option C is important");
            }else if(optionD.Text.Length == 0)
            {
                MessageBox.Show("Option D is important");
            }else
            {
                gdgv.Rows.Add(1);
                gdgv.Rows[gdgv.Rows.Count - 2].Cells[0].Value = no.ToString();
                gdgv.Rows[gdgv.Rows.Count - 2].Cells[1].Value = question.Text;
                gdgv.Rows[gdgv.Rows.Count - 2].Cells[2].Value = optionA.Text;
                gdgv.Rows[gdgv.Rows.Count - 2].Cells[3].Value = optionB.Text;
                gdgv.Rows[gdgv.Rows.Count - 2].Cells[4].Value = optionC.Text;
                gdgv.Rows[gdgv.Rows.Count - 2].Cells[5].Value = optionD.Text;

                if (a.Checked)
                {
                    gdgv.Rows[gdgv.Rows.Count - 2].Cells[6].Value = optionA.Text;
                }
                else if (b.Checked)
                {
                    gdgv.Rows[gdgv.Rows.Count - 2].Cells[6].Value = optionB.Text;
                }
                else if (c.Checked)
                {
                    gdgv.Rows[gdgv.Rows.Count - 2].Cells[6].Value = optionC.Text;
                }
                else if (d.Checked)
                {
                    gdgv.Rows[gdgv.Rows.Count - 2].Cells[6].Value = optionD.Text;
                }
                else
                {
                    MessageBox.Show("Please choose the correct answer!");
                }

                /*DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Actions";
                buttonColumn.HeaderText = "Actions";
                buttonColumn.Text = "Delete"; // This will be the text on the button
                buttonColumn.UseColumnTextForButtonValue = true; // This will make the button display the text
                gdgv.Columns.Add(buttonColumn);*/

                question.Text = null;
                a.Checked = false;
                b.Checked = false; c.Checked = false; d.Checked = false;
                optionA.Text = null;
                optionB.Text = null;
                optionC.Text = null;
                optionD.Text = null;
            }


        }

        private void AddQuizForm_Load(object sender, EventArgs e)
        {
            table_load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(quizName.Text.Length  == 0)
            {
                MessageBox.Show("Quiz name is important");
            }else if(quizCode.Text.Length == 0)
            {
                MessageBox.Show("Quiz code is important");
            }else if(quizDesc.Text.Length == 0)
            {
                MessageBox.Show("Quiz description is important");
            }
            else
            {
                if(gdgv.Rows.Count > 0)
                {
                    string quizCodeText = quizCode.Text;
                    bool containsUpper = false;
                    bool containsDigit = false;

                    foreach (char c in quizCodeText)
                    {
                        if (char.IsUpper(c))
                        {
                            containsUpper = true;
                        }
                        if (char.IsDigit(c))
                        {
                            containsDigit = true;
                        }
                    }

                    if (!containsUpper || !containsDigit)
                    {
                        MessageBox.Show("Quiz Code must be uppercase and contain both letters and numbers!");
                        return; // Exit the method if validation fails
                    }

                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM [Quiz] WHERE Code = '" + quizCode.Text + "'", conn);
                    rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        conn.Close();
                        rd.Close();
                        MessageBox.Show("Quiz Code has been used, use another code");
                    }
                    else
                    {
                        conn.Close();
                        rd.Close();

                        conn.Open();
                        cmd = new SqlCommand("INSERT INTO [Quiz] VALUES (" + session.id_user + ", '" + quizName.Text + "', '" + quizCode.Text + "', '" + quizDesc.Text + "', @waktu)", conn);
                        cmd.Parameters.AddWithValue("@waktu", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        conn.Open();
                        cmd = new SqlCommand("SELECT TOP 1 ID FROM[QUIZ] ORDER BY ID DESC", conn);
                        rd = cmd.ExecuteReader();
                        rd.Read();
                        string id = rd["ID"].ToString();
                        rd.Close();
                        conn.Close();

                        for (int i = 0; i < gdgv.Rows.Count - 1; i++)
                        {
                            conn.Open();
                            cmd = new SqlCommand("INSERT INTO [Question] VALUES('" + id + "', '" + gdgv.Rows[i].Cells[1].Value + "', '" + gdgv.Rows[i].Cells[2].Value + "', '" + gdgv.Rows[i].Cells[3].Value + "', '" + gdgv.Rows[i].Cells[4].Value + "', '" + gdgv.Rows[i].Cells[5].Value + "', '" + gdgv.Rows[i].Cells[1].Value + "')", conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        MessageBox.Show("Question save");
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();


                    }
                }
                else
                {
                    MessageBox.Show("Please add a question, minimum 1");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to leave? the progress will remove if you leave now", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
