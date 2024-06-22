using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzinAja
{
    public partial class QuizForm : Form
    {
        int timeSecond = 0;
        SqlConnection conn = Connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;

        public QuizForm()
        {
            InitializeComponent();
            InitializeTimer();
            numberListButton();
        }


        public void numberListButton()
        {
            flowLayoutPanel1.Controls.Clear();

            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [Question] WHERE QuizID = '" + session.code.ToString() + "'", conn);
            rd = cmd.ExecuteReader();
            int i = 1;
            while (rd.Read())
            {
                Button questionButton = new Button();
                questionButton.Text = i.ToString();
                questionButton.Tag = i;
                questionButton.Click += QuestionButton_Click;
                questionButton.Width = 40;
                questionButton.Height = 40;
                flowLayoutPanel1.Controls.Add(questionButton);
                i++;
            }

        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Tag.ToString());
        }

        private void InitializeTimer()
        {
            // Create a timer with a one second interval
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 ms = 1 second

            // Hook up the Tick event for the timer
            timer.Tick += OnTimerTick;

            // Start the timer
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            // Increment the seconds counter
            timeSecond++;

            // Convert seconds to a TimeSpan object
            TimeSpan timeSpan = TimeSpan.FromSeconds(timeSecond);

            // Update the label with the formatted time
            timerQuiz.Text = timeSpan.ToString(@"hh\:mm\:ss");
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            

        }
    }
}
