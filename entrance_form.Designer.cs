namespace SchoolY
{
    partial class entrance_form
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
            this.button_entrance = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_entrance
            // 
            this.button_entrance.Location = new System.Drawing.Point(65, 330);
            this.button_entrance.Name = "button_entrance";
            this.button_entrance.Size = new System.Drawing.Size(204, 62);
            this.button_entrance.TabIndex = 0;
            this.button_entrance.Text = "Вход";
            this.button_entrance.UseVisualStyleBackColor = true;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(476, 330);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(204, 62);
            this.button_register.TabIndex = 1;
            this.button_register.Text = "Регистрация";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.ForeColor = System.Drawing.Color.Silver;
            this.textBox_login.Location = new System.Drawing.Point(230, 145);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(309, 37);
            this.textBox_login.TabIndex = 2;
            this.textBox_login.Text = "Логин";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.Silver;
            this.textBox_password.Location = new System.Drawing.Point(230, 213);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(309, 37);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.Text = "Пароль";
            // 
            // entrance_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_entrance);
            this.Name = "entrance_form";
            this.Text = "entrance_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_entrance;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
    }
}