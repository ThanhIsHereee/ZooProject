namespace ZooManagement_Project_PRN211
{
    partial class ListAccount
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
            dtg_listAccount = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_id = new TextBox();
            txt_username = new TextBox();
            txt_pass = new TextBox();
            txt_fullname = new TextBox();
            txt_search = new TextBox();
            txt_phone = new TextBox();
            txt_address = new TextBox();
            txt_role = new TextBox();
            txt_experience = new TextBox();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            radio_id = new RadioButton();
            radio_name = new RadioButton();
            btn_search = new Button();
            radio_role = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dtg_listAccount).BeginInit();
            SuspendLayout();
            // 
            // dtg_listAccount
            // 
            dtg_listAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_listAccount.Location = new Point(12, 143);
            dtg_listAccount.Margin = new Padding(3, 2, 3, 2);
            dtg_listAccount.Name = "dtg_listAccount";
            dtg_listAccount.RowHeadersWidth = 51;
            dtg_listAccount.RowTemplate.Height = 29;
            dtg_listAccount.Size = new Size(802, 250);
            dtg_listAccount.TabIndex = 0;
            dtg_listAccount.CellContentClick += dtg_listAccount_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 7);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "User ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 34);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 59);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 4;
            label4.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 87);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 5;
            label5.Text = "Full Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 7);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 6;
            label6.Text = "Phone Number :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(368, 34);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 7;
            label7.Text = "Address :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(368, 59);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 8;
            label8.Text = "Role :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(368, 87);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 9;
            label9.Text = "Experience :";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(93, 4);
            txt_id.Margin = new Padding(3, 2, 3, 2);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(224, 23);
            txt_id.TabIndex = 10;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(93, 32);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(224, 23);
            txt_username.TabIndex = 11;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(93, 59);
            txt_pass.Margin = new Padding(3, 2, 3, 2);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(224, 23);
            txt_pass.TabIndex = 12;
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(93, 87);
            txt_fullname.Margin = new Padding(3, 2, 3, 2);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(224, 23);
            txt_fullname.TabIndex = 13;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(16, 116);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(301, 23);
            txt_search.TabIndex = 14;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(474, 4);
            txt_phone.Margin = new Padding(3, 2, 3, 2);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(224, 23);
            txt_phone.TabIndex = 15;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(474, 32);
            txt_address.Margin = new Padding(3, 2, 3, 2);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(224, 23);
            txt_address.TabIndex = 16;
            // 
            // txt_role
            // 
            txt_role.Location = new Point(474, 59);
            txt_role.Margin = new Padding(3, 2, 3, 2);
            txt_role.Name = "txt_role";
            txt_role.Size = new Size(224, 23);
            txt_role.TabIndex = 17;
            // 
            // txt_experience
            // 
            txt_experience.Location = new Point(474, 87);
            txt_experience.Margin = new Padding(3, 2, 3, 2);
            txt_experience.Name = "txt_experience";
            txt_experience.Size = new Size(224, 23);
            txt_experience.TabIndex = 18;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(729, 4);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(79, 33);
            btn_add.TabIndex = 19;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(729, 42);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(79, 33);
            btn_delete.TabIndex = 20;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(729, 78);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(79, 33);
            btn_update.TabIndex = 21;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // radio_id
            // 
            radio_id.AutoSize = true;
            radio_id.Checked = true;
            radio_id.Location = new Point(343, 118);
            radio_id.Margin = new Padding(3, 2, 3, 2);
            radio_id.Name = "radio_id";
            radio_id.Size = new Size(36, 19);
            radio_id.TabIndex = 22;
            radio_id.TabStop = true;
            radio_id.Text = "ID";
            radio_id.UseVisualStyleBackColor = true;
            // 
            // radio_name
            // 
            radio_name.AutoSize = true;
            radio_name.Location = new Point(402, 118);
            radio_name.Margin = new Padding(3, 2, 3, 2);
            radio_name.Name = "radio_name";
            radio_name.Size = new Size(76, 19);
            radio_name.TabIndex = 23;
            radio_name.Text = "FullName";
            radio_name.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(582, 111);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(79, 33);
            btn_search.TabIndex = 24;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // radio_role
            // 
            radio_role.AutoSize = true;
            radio_role.Location = new Point(488, 118);
            radio_role.Margin = new Padding(3, 2, 3, 2);
            radio_role.Name = "radio_role";
            radio_role.Size = new Size(48, 19);
            radio_role.TabIndex = 25;
            radio_role.Text = "Role";
            radio_role.UseVisualStyleBackColor = true;
            // 
            // ListAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 400);
            Controls.Add(radio_role);
            Controls.Add(btn_search);
            Controls.Add(radio_name);
            Controls.Add(radio_id);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(txt_experience);
            Controls.Add(txt_role);
            Controls.Add(txt_address);
            Controls.Add(txt_phone);
            Controls.Add(txt_search);
            Controls.Add(txt_fullname);
            Controls.Add(txt_pass);
            Controls.Add(txt_username);
            Controls.Add(txt_id);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtg_listAccount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListAccount";
            Text = "ListAccount";
            ((System.ComponentModel.ISupportInitialize)dtg_listAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_listAccount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_id;
        private TextBox txt_username;
        private TextBox txt_pass;
        private TextBox txt_fullname;
        private TextBox txt_search;
        private TextBox txt_phone;
        private TextBox txt_address;
        private TextBox txt_role;
        private TextBox txt_experience;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private RadioButton radio_id;
        private RadioButton radio_name;
        private Button btn_search;
        private RadioButton radio_role;
    }
}