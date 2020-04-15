namespace SchoolY
{
    partial class Registration
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
            this.Units = new System.Windows.Forms.ComboBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.RePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pupil = new System.Windows.Forms.RadioButton();
            this.Teacher = new System.Windows.Forms.RadioButton();
            this.Registr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Units
            // 
            this.Units.FormattingEnabled = true;
            this.Units.Items.AddRange(new object[] {
            "Английский язык",
            "Русский язык",
            "Литература",
            "Математика",
            "Биология",
            "География"});
            this.Units.Location = new System.Drawing.Point(242, 99);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(121, 21);
            this.Units.TabIndex = 0;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(122, 39);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(100, 20);
            this.FIO.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(122, 66);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 2;
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(122, 96);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(100, 20);
            this.RePassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повторите пароль:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pupil);
            this.groupBox1.Controls.Add(this.Teacher);
            this.groupBox1.Location = new System.Drawing.Point(242, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кто вы?";
            // 
            // Pupil
            // 
            this.Pupil.AutoSize = true;
            this.Pupil.Location = new System.Drawing.Point(80, 19);
            this.Pupil.Name = "Pupil";
            this.Pupil.Size = new System.Drawing.Size(62, 17);
            this.Pupil.TabIndex = 1;
            this.Pupil.TabStop = true;
            this.Pupil.Text = "Ученик";
            this.Pupil.UseVisualStyleBackColor = true;
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.Location = new System.Drawing.Point(7, 19);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(67, 17);
            this.Teacher.TabIndex = 0;
            this.Teacher.TabStop = true;
            this.Teacher.Text = "Учитель";
            this.Teacher.UseVisualStyleBackColor = true;
            // 
            // Registr
            // 
            this.Registr.Location = new System.Drawing.Point(15, 186);
            this.Registr.Name = "Registr";
            this.Registr.Size = new System.Drawing.Size(139, 23);
            this.Registr.TabIndex = 10;
            this.Registr.Text = "Зарегестрироваться";
            this.Registr.UseVisualStyleBackColor = true;
            this.Registr.Click += new System.EventHandler(this.Registr_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 246);
            this.Controls.Add(this.Registr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Units);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Units;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox RePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Pupil;
        private System.Windows.Forms.RadioButton Teacher;
        private System.Windows.Forms.Button Registr;
    }
}