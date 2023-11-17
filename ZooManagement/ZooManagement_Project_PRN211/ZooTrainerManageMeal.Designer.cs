namespace ZooManagement_Project_PRN211
{
    partial class ZooTrainerManageMeal
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
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            txt_quantity = new TextBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(16, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(777, 243);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_quantity);
            groupBox2.Controls.Add(txt_name);
            groupBox2.Controls.Add(txt_id);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(23, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 146);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food Information";
            // 
            // txt_quantity
            // 
            txt_quantity.Enabled = false;
            txt_quantity.Location = new Point(99, 92);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(119, 23);
            txt_quantity.TabIndex = 5;
            // 
            // txt_name
            // 
            txt_name.Enabled = false;
            txt_name.Location = new Point(327, 35);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(119, 23);
            txt_name.TabIndex = 4;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(99, 35);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(119, 23);
            txt_id.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 95);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 38);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(501, 294);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 146);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            // 
            // button5
            // 
            button5.Location = new Point(101, 117);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "Return";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(179, 78);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 78);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(179, 30);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ZooTrainerManageMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ZooTrainerManageMeal";
            Text = "ZooTrainerManageMeal";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox txt_quantity;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}