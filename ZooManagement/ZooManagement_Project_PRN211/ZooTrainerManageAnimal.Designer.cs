namespace ZooManagement_Project_PRN211
{
    partial class ZooTrainerManageAnimal
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
            txt_Des = new RichTextBox();
            rb_Female = new RadioButton();
            rb_Male = new RadioButton();
            cb_Species = new ComboBox();
            dtp_Birth = new DateTimePicker();
            txt_Name = new TextBox();
            txt_Id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txt_SpeciesDesc = new RichTextBox();
            txt_SpeciesName = new TextBox();
            txt_SpeciesId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox4 = new GroupBox();
            button5 = new Button();
            button7 = new Button();
            button6 = new Button();
            button8 = new Button();
            groupBox5 = new GroupBox();
            Animal_Data = new DataGridView();
            groupBox6 = new GroupBox();
            Species_Data = new DataGridView();
            button9 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Animal_Data).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Species_Data).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Des);
            groupBox1.Controls.Add(rb_Female);
            groupBox1.Controls.Add(rb_Male);
            groupBox1.Controls.Add(cb_Species);
            groupBox1.Controls.Add(dtp_Birth);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Controls.Add(txt_Id);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Animal Information";
            // 
            // txt_Des
            // 
            txt_Des.Enabled = false;
            txt_Des.Location = new Point(381, 157);
            txt_Des.Name = "txt_Des";
            txt_Des.Size = new Size(133, 96);
            txt_Des.TabIndex = 12;
            txt_Des.Text = "";
            // 
            // rb_Female
            // 
            rb_Female.AutoSize = true;
            rb_Female.Enabled = false;
            rb_Female.Location = new Point(381, 121);
            rb_Female.Name = "rb_Female";
            rb_Female.Size = new Size(63, 19);
            rb_Female.TabIndex = 11;
            rb_Female.TabStop = true;
            rb_Female.Text = "Female";
            rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            rb_Male.AutoSize = true;
            rb_Male.Enabled = false;
            rb_Male.Location = new Point(381, 86);
            rb_Male.Name = "rb_Male";
            rb_Male.Size = new Size(51, 19);
            rb_Male.TabIndex = 10;
            rb_Male.TabStop = true;
            rb_Male.Text = "Male";
            rb_Male.UseVisualStyleBackColor = true;
            // 
            // cb_Species
            // 
            cb_Species.Enabled = false;
            cb_Species.FormattingEnabled = true;
            cb_Species.Location = new Point(381, 32);
            cb_Species.Name = "cb_Species";
            cb_Species.Size = new Size(127, 23);
            cb_Species.TabIndex = 9;
            // 
            // dtp_Birth
            // 
            dtp_Birth.Enabled = false;
            dtp_Birth.Location = new Point(78, 151);
            dtp_Birth.Name = "dtp_Birth";
            dtp_Birth.Size = new Size(200, 23);
            dtp_Birth.TabIndex = 8;
            // 
            // txt_Name
            // 
            txt_Name.Enabled = false;
            txt_Name.Location = new Point(83, 87);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(195, 23);
            txt_Name.TabIndex = 7;
            // 
            // txt_Id
            // 
            txt_Id.Enabled = false;
            txt_Id.Location = new Point(83, 32);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(195, 23);
            txt_Id.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 157);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 5;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 157);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "BirthDay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 90);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 90);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Species:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_SpeciesDesc);
            groupBox2.Controls.Add(txt_SpeciesName);
            groupBox2.Controls.Add(txt_SpeciesId);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(806, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 275);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Species Information";
            // 
            // txt_SpeciesDesc
            // 
            txt_SpeciesDesc.Enabled = false;
            txt_SpeciesDesc.Location = new Point(106, 159);
            txt_SpeciesDesc.Name = "txt_SpeciesDesc";
            txt_SpeciesDesc.Size = new Size(157, 94);
            txt_SpeciesDesc.TabIndex = 5;
            txt_SpeciesDesc.Text = "";
            // 
            // txt_SpeciesName
            // 
            txt_SpeciesName.Enabled = false;
            txt_SpeciesName.Location = new Point(106, 85);
            txt_SpeciesName.Name = "txt_SpeciesName";
            txt_SpeciesName.Size = new Size(157, 23);
            txt_SpeciesName.TabIndex = 4;
            // 
            // txt_SpeciesId
            // 
            txt_SpeciesId.Enabled = false;
            txt_SpeciesId.Location = new Point(106, 32);
            txt_SpeciesId.Name = "txt_SpeciesId";
            txt_SpeciesId.Size = new Size(157, 23);
            txt_SpeciesId.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 159);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 2;
            label9.Text = "Description:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 95);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 1;
            label8.Text = "Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 35);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 0;
            label7.Text = "Id:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(1328, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(148, 275);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Animal Action";
            // 
            // button4
            // 
            button4.Location = new Point(35, 230);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(35, 156);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(35, 95);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(35, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(button8);
            groupBox4.Location = new Point(1490, 18);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(148, 275);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Species Action";
            // 
            // button5
            // 
            button5.Location = new Point(39, 230);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(39, 95);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "Update";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(39, 156);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 12;
            button6.Text = "Remove";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(39, 32);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 10;
            button8.Text = "Add";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Animal_Data);
            groupBox5.Location = new Point(28, 299);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(772, 591);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Animal Data";
            // 
            // Animal_Data
            // 
            Animal_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Animal_Data.Location = new Point(3, 19);
            Animal_Data.Name = "Animal_Data";
            Animal_Data.RowTemplate.Height = 25;
            Animal_Data.Size = new Size(769, 566);
            Animal_Data.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(Species_Data);
            groupBox6.Location = new Point(806, 299);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(832, 585);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Species Data";
            // 
            // Species_Data
            // 
            Species_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Species_Data.Location = new Point(0, 16);
            Species_Data.Name = "Species_Data";
            Species_Data.RowTemplate.Height = 25;
            Species_Data.Size = new Size(832, 569);
            Species_Data.TabIndex = 1;
            // 
            // button9
            // 
            button9.Location = new Point(627, 97);
            button9.Name = "button9";
            button9.Size = new Size(124, 103);
            button9.TabIndex = 4;
            button9.Text = "Return";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // ZooTrainerManageAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 902);
            Controls.Add(button9);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ZooTrainerManageAnimal";
            Text = "ZooTrainerManageAnimal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Animal_Data).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Species_Data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridView Animal_Data;
        private GroupBox groupBox6;
        private DataGridView Species_Data;
        private RichTextBox txt_Des;
        private RadioButton rb_Female;
        private RadioButton rb_Male;
        private ComboBox cb_Species;
        private DateTimePicker dtp_Birth;
        private TextBox txt_Name;
        private TextBox txt_Id;
        private Label label8;
        private Label label7;
        private RichTextBox txt_SpeciesDesc;
        private TextBox txt_SpeciesName;
        private TextBox txt_SpeciesId;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button button8;
        private Button button9;
    }
}