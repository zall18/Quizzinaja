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
    public partial class ViewReportPage : Form
    {
        SqlConnection conn = Connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;
        DataTable dt;

        public void table_load()
        {

            gdgv.Columns.Clear();
            gdgv.ColumnCount = 3;
            gdgv.Columns[0].Name = "ParticipantNickname";
            gdgv.Columns[1].Name = "Time Taken";
            gdgv.Columns[2].Name = "Correct Percentage";


        }

        public void quiz_load()
        {

            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [Quiz] WHERE UserID = '" + session.id_user + "'", conn);
            rd = cmd.ExecuteReader();
            if(rd.HasRows)
            {
                while (rd.Read())
                {
                    quiz.Items.Add(rd["Name"].ToString() + "-" + rd["Code"].ToString());
                }
            }
            rd.Close();
            conn.Close();

        }

        public ViewReportPage()
        {
            InitializeComponent();
        }

        private void ViewReportPage_Load(object sender, EventArgs e)
        {
            table_load();
            quiz_load();
        }

        private void quiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = quiz.Text.Split('-')[1];
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Quiz] WHERE Code = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);

                
            SqlDataReader rd = cmd.ExecuteReader();
            
            if (rd.HasRows)
            
            {
            
                rd.Read();
                
                string id = rd["ID"].ToString();
                int avgCorrect = 0;
                    
                SqlCommand cmdd = new SqlCommand("SELECT * FROM [Participant] WHERE QuizID = @id", conn);
                
                cmdd.Parameters.AddWithValue("@id", id);

                
                SqlDataReader rdrr = cmdd.ExecuteReader();
                
                if (rdrr.HasRows)
                
                {
                
                    int jml = 0;

                    
                    while (rdrr.Read())
                    
                    {
                    
                        string pid = rdrr["ID"].ToString();
                        jml++;
                        TimeSpan timeSpan = TimeSpan.FromSeconds(int.Parse(rdrr["TimeTaken"].ToString()));
                       
                        gdgv.Rows.Add(1);
                        
                        gdgv.Rows[gdgv.Rows.Count - 2].Cells[0].Value = rdrr["ParticipantNickname"].ToString();
                        
                        gdgv.Rows[gdgv.Rows.Count - 2].Cells[1].Value = timeSpan.ToString(@"hh\:mm\:ss");


                            
                        SqlCommand cmdPercentage = new SqlCommand("SELECT COUNT(*) AS TotalAnswers, " +
                        
                            "ROUND(COUNT(CASE WHEN pa.Answer = q.CorrectAnswer THEN 1 ELSE NULL END) * 100 / COUNT(*), 2) AS Percentage " +
                            
                            "FROM [ParticipantAnswer] pa INNER JOIN [Question] q ON pa.QuestionID = q.ID " +
                            
                            "WHERE pa.ParticipantID = @pid " +
                            
                            "GROUP BY pa.ParticipantID", conn);
                            
                        cmdPercentage.Parameters.AddWithValue("@pid", pid);                        
                        SqlDataReader rdr = cmdPercentage.ExecuteReader();                        
                        rdr.Read();
                        avgCorrect += int.Parse(rdr["Percentage"].ToString());
                        gdgv.Rows[gdgv.Rows.Count - 2].Cells[2].Value = rdr["Percentage"].ToString() + "%";                        
                        rdr.Close();                        
                    }                    
                    prtc.Text = jml.ToString() + " Participant(s)";
                    decimal avgPercentage = avgCorrect / jml;
                    avgCP.Text = avgPercentage.ToString("F2") + "%";
                }

                cmd = new SqlCommand("SELECT AVG(TimeTaken) as avg FROM [Participant]", conn);
                rd = cmd.ExecuteReader();
                rd.Read();
                TimeSpan ts = TimeSpan.FromSeconds(int.Parse(rd["avg"].ToString()));
                avg.Text = ts.ToString(@"hh\:mm\:ss");
            }            
            else            
            {            
                MessageBox.Show("Data kosong");    
            }
            
        }
    }
}
