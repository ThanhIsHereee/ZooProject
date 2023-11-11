namespace ZooManagement_Project_PRN211
{
    partial class ZooTrainerProfile
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
            groupBox1 = new GroupBox();
            lb_welcome = new Label();
            txt_Experience = new TextBox();
            txt_Address = new TextBox();
            txt_Phonenumber = new TextBox();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            txt_Fullname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_Return = new Button();
            btn_Save = new Button();
            btn_Update = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_welcome);
            groupBox1.Controls.Add(txt_Experience);
            groupBox1.Controls.Add(txt_Address);
            groupBox1.Controls.Add(txt_Phonenumber);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(txt_Username);
            groupBox1.Controls.Add(txt_Fullname);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // lb_welcome
            // 
            lb_welcome.AutoSize = true;
            lb_welcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_welcome.Location = new Point(279, 34);
            lb_welcome.Name = "lb_welcome";
            lb_welcome.Size = new Size(96, 37);
            lb_welcome.TabIndex = 12;
            lb_welcome.Text = "label7";
            // 
            // txt_Experience
            // 
            txt_Experience.Location = new Point(515, 269);
            txt_Experience.Name = "txt_Experience";
            txt_Experience.Size = new Size(225, 23);
            txt_Experience.TabIndex = 11;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(515, 186);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(225, 23);
            txt_Address.TabIndex = 10;
            // 
            // txt_Phonenumber
            // 
            txt_Phonenumber.Location = new Point(515, 109);
            txt_Phonenumber.Name = "txt_Phonenumber";
            txt_Phonenumber.Size = new Size(225, 23);
            txt_Phonenumber.TabIndex = 9;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(107, 269);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(225, 23);
            txt_Password.TabIndex = 8;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(106, 186);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(225, 23);
            txt_Username.TabIndex = 7;
            // 
            // txt_Fullname
            // 
            txt_Fullname.Location = new Point(106, 109);
            txt_Fullname.Name = "txt_Fullname";
            txt_Fullname.Size = new Size(225, 23);
            txt_Fullname.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 272);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Experience:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 189);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 112);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Phonenumber:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 272);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 189);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 112);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Fullname:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Return);
            groupBox2.Controls.Add(btn_Save);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Location = new Point(12, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 87);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(542, 22);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(143, 59);
            btn_Return.TabIndex = 2;
            btn_Return.Text = "Back To Menu";
            btn_Return.UseVisualStyleBackColor = true;
            btn_Return.Click += btn_Return_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(312, 22);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(143, 59);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(75, 22);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(143, 59);
            btn_Update.TabIndex = 0;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // ZooTrainerProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ZooTrainerProfile";
            Text = "ZooTrainerProfile";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Return;
        private Button btn_Save;
        private Button btn_Update;
        private Label lb_welcome;
        private TextBox txt_Experience;
        private TextBox txt_Address;
        private TextBox txt_Phonenumber;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private TextBox txt_Fullname;
    }
}