namespace QuizzinAja
{
    partial class AddQuizForm
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
            this.quizName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quizCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quizDesc = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optionD = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.RadioButton();
            this.optionC = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.RadioButton();
            this.optionB = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.RadioButton();
            this.optionA = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.RadioButton();
            this.gdgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(21, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 2;
            this.name.Text = "Add New Quiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fill in the quiz below";
            // 
            // quizName
            // 
            this.quizName.Location = new System.Drawing.Point(25, 91);
            this.quizName.Multiline = true;
            this.quizName.Name = "quizName";
            this.quizName.Size = new System.Drawing.Size(220, 30);
            this.quizName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quiz Name";
            // 
            // quizCode
            // 
            this.quizCode.Location = new System.Drawing.Point(25, 148);
            this.quizCode.Multiline = true;
            this.quizCode.Name = "quizCode";
            this.quizCode.Size = new System.Drawing.Size(220, 30);
            this.quizCode.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quiz Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quiz Description";
            // 
            // quizDesc
            // 
            this.quizDesc.Location = new System.Drawing.Point(267, 91);
            this.quizDesc.Name = "quizDesc";
            this.quizDesc.Size = new System.Drawing.Size(497, 87);
            this.quizDesc.TabIndex = 11;
            this.quizDesc.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optionD);
            this.panel1.Controls.Add(this.d);
            this.panel1.Controls.Add(this.optionC);
            this.panel1.Controls.Add(this.c);
            this.panel1.Controls.Add(this.optionB);
            this.panel1.Controls.Add(this.b);
            this.panel1.Controls.Add(this.optionA);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.gdgv);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.question);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(25, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 313);
            this.panel1.TabIndex = 12;
            // 
            // optionD
            // 
            this.optionD.Location = new System.Drawing.Point(262, 112);
            this.optionD.Name = "optionD";
            this.optionD.Size = new System.Drawing.Size(100, 20);
            this.optionD.TabIndex = 28;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(242, 117);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(14, 13);
            this.d.TabIndex = 27;
            this.d.TabStop = true;
            this.d.UseVisualStyleBackColor = true;
            // 
            // optionC
            // 
            this.optionC.Location = new System.Drawing.Point(262, 86);
            this.optionC.Name = "optionC";
            this.optionC.Size = new System.Drawing.Size(100, 20);
            this.optionC.TabIndex = 26;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(242, 91);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(14, 13);
            this.c.TabIndex = 25;
            this.c.TabStop = true;
            this.c.UseVisualStyleBackColor = true;
            // 
            // optionB
            // 
            this.optionB.Location = new System.Drawing.Point(262, 60);
            this.optionB.Name = "optionB";
            this.optionB.Size = new System.Drawing.Size(100, 20);
            this.optionB.TabIndex = 24;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(242, 65);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(14, 13);
            this.b.TabIndex = 23;
            this.b.TabStop = true;
            this.b.UseVisualStyleBackColor = true;
            // 
            // optionA
            // 
            this.optionA.Location = new System.Drawing.Point(262, 34);
            this.optionA.Name = "optionA";
            this.optionA.Size = new System.Drawing.Size(100, 20);
            this.optionA.TabIndex = 22;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(242, 39);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(14, 13);
            this.a.TabIndex = 18;
            this.a.TabStop = true;
            this.a.UseVisualStyleBackColor = true;
            // 
            // gdgv
            // 
            this.gdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdgv.Location = new System.Drawing.Point(13, 139);
            this.gdgv.Name = "gdgv";
            this.gdgv.Size = new System.Drawing.Size(702, 150);
            this.gdgv.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Answer";
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(13, 34);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(207, 87);
            this.question.TabIndex = 14;
            this.question.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Question Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quizDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quizCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quizName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "AddQuizForm";
            this.Text = "AddQuizForm";
            this.Load += new System.EventHandler(this.AddQuizForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quizName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quizCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox quizDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gdgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox question;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.TextBox optionD;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.TextBox optionC;
        private System.Windows.Forms.RadioButton c;
        private System.Windows.Forms.TextBox optionB;
        private System.Windows.Forms.RadioButton b;
        private System.Windows.Forms.TextBox optionA;
    }
}