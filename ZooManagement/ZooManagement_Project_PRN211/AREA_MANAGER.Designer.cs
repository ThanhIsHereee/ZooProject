namespace ZooManagement_Project_PRN211
{
    partial class AREA_MANAGER
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
            btn_search = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            txt_User = new TextBox();
            txt_Area_Name = new TextBox();
            txt_search = new TextBox();
            txt_User_id = new TextBox();
            txt_Area_area = new TextBox();
            txt_id = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtg_listArea = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_listArea).BeginInit();
            SuspendLayout();
            // 
            // btn_search
            // 
            btn_search.Location = new Point(565, 135);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(79, 33);
            btn_search.TabIndex = 49;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(712, 102);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(79, 33);
            btn_update.TabIndex = 46;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(712, 66);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(79, 33);
            btn_delete.TabIndex = 45;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(712, 28);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(79, 33);
            btn_add.TabIndex = 44;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(457, 56);
            txt_User.Margin = new Padding(3, 2, 3, 2);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(224, 23);
            txt_User.TabIndex = 41;
            // 
            // txt_Area_Name
            // 
            txt_Area_Name.Location = new Point(457, 28);
            txt_Area_Name.Margin = new Padding(3, 2, 3, 2);
            txt_Area_Name.Name = "txt_Area_Name";
            txt_Area_Name.Size = new Size(224, 23);
            txt_Area_Name.TabIndex = 40;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(248, 141);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(301, 23);
            txt_search.TabIndex = 39;
            // 
            // txt_User_id
            // 
            txt_User_id.Location = new Point(76, 92);
            txt_User_id.Margin = new Padding(3, 2, 3, 2);
            txt_User_id.Name = "txt_User_id";
            txt_User_id.Size = new Size(224, 23);
            txt_User_id.TabIndex = 38;
            // 
            // txt_Area_area
            // 
            txt_Area_area.Location = new Point(76, 56);
            txt_Area_area.Margin = new Padding(3, 2, 3, 2);
            txt_Area_area.Name = "txt_Area_area";
            txt_Area_area.Size = new Size(224, 23);
            txt_Area_area.TabIndex = 36;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(76, 28);
            txt_id.Margin = new Padding(3, 2, 3, 2);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(224, 23);
            txt_id.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 58);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 32;
            label7.Text = "User:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 31);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 31;
            label6.Text = "Area_Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 100);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 30;
            label5.Text = "User_ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 58);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 28;
            label3.Text = "Area_area :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 31);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 27;
            label2.Text = "Area ID :";
            // 
            // dtg_listArea
            // 
            dtg_listArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_listArea.Location = new Point(-1, 172);
            dtg_listArea.Margin = new Padding(3, 2, 3, 2);
            dtg_listArea.Name = "dtg_listArea";
            dtg_listArea.RowHeadersWidth = 51;
            dtg_listArea.RowTemplate.Height = 29;
            dtg_listArea.Size = new Size(802, 250);
            dtg_listArea.TabIndex = 26;
            dtg_listArea.CellContentClick += dtg_listArea_CellContentClick;
            // 
            // AREA_MANAGER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_search);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(txt_User);
            Controls.Add(txt_Area_Name);
            Controls.Add(txt_search);
            Controls.Add(txt_User_id);
            Controls.Add(txt_Area_area);
            Controls.Add(txt_id);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtg_listArea);
            Name = "AREA_MANAGER";
            Text = "AREA_MANAGER";
            ((System.ComponentModel.ISupportInitialize)dtg_listArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_search;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_add;
        private TextBox txt_experience;
        private TextBox txt_role;
        private TextBox txt_User;
        private TextBox txt_Area_Name;
        private TextBox txt_search;
        private TextBox txt_User_id;
        private TextBox txt_Area_area;
        private TextBox txt_id;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private DataGridView dtg_listArea;
    }
}