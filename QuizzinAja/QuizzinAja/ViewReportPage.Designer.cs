namespace QuizzinAja
{
    partial class ViewReportPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quiz = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avgCP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prtc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gdgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(24, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 20);
            this.name.TabIndex = 3;
            this.name.Text = "View Quiz Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quiz";
            // 
            // quiz
            // 
            this.quiz.FormattingEnabled = true;
            this.quiz.Location = new System.Drawing.Point(59, 60);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(195, 21);
            this.quiz.TabIndex = 5;
            this.quiz.SelectedIndexChanged += new System.EventHandler(this.quiz_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Avarage Time Taken :";
            // 
            // avg
            // 
            this.avg.AutoSize = true;
            this.avg.Location = new System.Drawing.Point(425, 63);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(10, 13);
            this.avg.TabIndex = 7;
            this.avg.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Average Correct Percentage :";
            // 
            // avgCP
            // 
            this.avgCP.AutoSize = true;
            this.avgCP.Location = new System.Drawing.Point(460, 87);
            this.avgCP.Name = "avgCP";
            this.avgCP.Size = new System.Drawing.Size(10, 13);
            this.avgCP.TabIndex = 9;
            this.avgCP.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Participant : ";
            // 
            // prtc
            // 
            this.prtc.AutoSize = true;
            this.prtc.Location = new System.Drawing.Point(405, 111);
            this.prtc.Name = "prtc";
            this.prtc.Size = new System.Drawing.Size(77, 13);
            this.prtc.TabIndex = 11;
            this.prtc.Text = "0 Participant(s)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdgv);
            this.panel1.Location = new System.Drawing.Point(28, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 297);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Detail Data";
            // 
            // gdgv
            // 
            this.gdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdgv.Location = new System.Drawing.Point(3, 8);
            this.gdgv.Name = "gdgv";
            this.gdgv.Size = new System.Drawing.Size(737, 286);
            this.gdgv.TabIndex = 0;
            // 
            // ViewReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prtc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.avgCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "ViewReportPage";
            this.Text = "ViewReportPage";
            this.Load += new System.EventHandler(this.ViewReportPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox quiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label avg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avgCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label prtc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gdgv;
        private System.Windows.Forms.Label label5;
    }
}