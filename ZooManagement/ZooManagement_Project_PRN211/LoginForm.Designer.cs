namespace ZooManagement_Project_PRN211
{
    partial class LoginForm
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
            txt_mail = new Label();
            txt_pass = new Label();
            txt_email = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_exit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_mail
            // 
            txt_mail.AutoSize = true;
            txt_mail.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txt_mail.Location = new Point(84, 138);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(198, 46);
            txt_mail.TabIndex = 0;
            txt_mail.Text = "Username :";
            // 
            // txt_pass
            // 
            txt_pass.AutoSize = true;
            txt_pass.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pass.Location = new Point(84, 202);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(198, 46);
            txt_pass.TabIndex = 1;
            txt_pass.Text = "Password  :";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(297, 155);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(258, 27);
            txt_email.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(297, 219);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(258, 27);
            txt_password.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(315, 291);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(430, 291);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(67, 77);
            label1.Name = "label1";
            label1.Size = new Size(507, 46);
            label1.TabIndex = 6;
            label1.Text = "Welcome To Zoo Management";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 384);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_pass);
            Controls.Add(txt_mail);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_mail;
        private Label txt_pass;
        private TextBox txt_email;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_exit;
        private Label label1;
    }
}