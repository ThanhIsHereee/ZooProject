namespace ZooManagement_Project_PRN211
{
    partial class FeedScheduleForm
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
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(63, 84);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Food:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 28);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Animal:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 300);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(561, 278);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(578, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            // 
            // button3
            // 
            button3.Location = new Point(56, 216);
            button3.Name = "button3";
            button3.Size = new Size(102, 49);
            button3.TabIndex = 6;
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 126);
            button2.Name = "button2";
            button2.Size = new Size(106, 42);
            button2.TabIndex = 5;
            button2.Text = "Checked";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(54, 28);
            button1.Name = "button1";
            button1.Size = new Size(104, 44);
            button1.TabIndex = 4;
            button1.Text = "Add Schedule";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FeedScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FeedScheduleForm";
            Text = "FeedScheduleForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
    }
}