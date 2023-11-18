namespace ZooManagement_Project_PRN211
{
    partial class TrainnerAccountManagement
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
            dtg_TrainerAccount = new DataGridView();
            textBox1 = new TextBox();
            btn_searchtrainer = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_TrainerAccount).BeginInit();
            SuspendLayout();
            // 
            // dtg_TrainerAccount
            // 
            dtg_TrainerAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_TrainerAccount.Location = new Point(-1, 61);
            dtg_TrainerAccount.Name = "dtg_TrainerAccount";
            dtg_TrainerAccount.RowHeadersWidth = 51;
            dtg_TrainerAccount.RowTemplate.Height = 29;
            dtg_TrainerAccount.Size = new Size(1015, 331);
            dtg_TrainerAccount.TabIndex = 0;
            dtg_TrainerAccount.CellContentClick += dtg_TrainerAccount_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 1;
            // 
            // btn_searchtrainer
            // 
            btn_searchtrainer.Location = new Point(358, 25);
            btn_searchtrainer.Name = "btn_searchtrainer";
            btn_searchtrainer.Size = new Size(84, 30);
            btn_searchtrainer.TabIndex = 2;
            btn_searchtrainer.Text = "Search";
            btn_searchtrainer.UseVisualStyleBackColor = true;
            btn_searchtrainer.Click += btn_searchtrainer_Click;
            // 
            // TrainnerAccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 403);
            Controls.Add(btn_searchtrainer);
            Controls.Add(textBox1);
            Controls.Add(dtg_TrainerAccount);
            Name = "TrainnerAccountManagement";
            Text = "TrainnerAccountManagement";
            Load += TrainnerAccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_TrainerAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_TrainerAccount;
        private TextBox textBox1;
        private Button btn_searchtrainer;
    }
}