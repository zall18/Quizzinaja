namespace QuizzinAja
{
    partial class CreateAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fill in blow your information to complete your registration";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(48, 133);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(264, 30);
            this.username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(48, 200);
            this.fullname.Multiline = true;
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(264, 30);
            this.fullname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Full Name";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(371, 133);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(264, 30);
            this.pass.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // kpass
            // 
            this.kpass.Location = new System.Drawing.Point(371, 200);
            this.kpass.Multiline = true;
            this.kpass.Name = "kpass";
            this.kpass.Size = new System.Drawing.Size(264, 30);
            this.kpass.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Retype Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date of Birth";
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(48, 266);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(264, 20);
            this.dob.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(355, 387);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Already have account?";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
    }
}