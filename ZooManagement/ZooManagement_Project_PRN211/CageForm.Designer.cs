namespace ZooManagement_Project_PRN211
{
    partial class CageForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_cage = new TextBox();
            txt_area = new TextBox();
            txt_user = new TextBox();
            txt_search = new TextBox();
            txt_animal = new TextBox();
            search = new Button();
            add = new Button();
            delete = new Button();
            update = new Button();
            dataCage = new DataGridView();
            txt_cagearea = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataCage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Cage ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 128);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Area ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 52);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "AnimalSpecies ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 123);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "User_ID:";
            // 
            // txt_cage
            // 
            txt_cage.Location = new Point(118, 44);
            txt_cage.Name = "txt_cage";
            txt_cage.Size = new Size(191, 23);
            txt_cage.TabIndex = 4;
            // 
            // txt_area
            // 
            txt_area.Location = new Point(118, 120);
            txt_area.Name = "txt_area";
            txt_area.Size = new Size(191, 23);
            txt_area.TabIndex = 5;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(485, 115);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(191, 23);
            txt_user.TabIndex = 6;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(118, 183);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(191, 23);
            txt_search.TabIndex = 7;
            // 
            // txt_animal
            // 
            txt_animal.Location = new Point(485, 44);
            txt_animal.Name = "txt_animal";
            txt_animal.Size = new Size(191, 23);
            txt_animal.TabIndex = 8;
            // 
            // search
            // 
            search.Location = new Point(395, 183);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 9;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // add
            // 
            add.Location = new Point(713, 48);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 10;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.Location = new Point(713, 124);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 11;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click_1;
            // 
            // update
            // 
            update.Location = new Point(713, 182);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 12;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click_1;
            // 
            // dataCage
            // 
            dataCage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCage.Location = new Point(6, 245);
            dataCage.Name = "dataCage";
            dataCage.RowTemplate.Height = 25;
            dataCage.Size = new Size(789, 200);
            dataCage.TabIndex = 13;
            dataCage.CellContentClick += dataCage_CellContentClick;
            // 
            // txt_cagearea
            // 
            txt_cagearea.Location = new Point(121, 85);
            txt_cagearea.Name = "txt_cagearea";
            txt_cagearea.Size = new Size(188, 23);
            txt_cagearea.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 85);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 15;
            label5.Text = "Cage area :";
            // 
            // CageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txt_cagearea);
            Controls.Add(dataCage);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(search);
            Controls.Add(txt_animal);
            Controls.Add(txt_search);
            Controls.Add(txt_user);
            Controls.Add(txt_area);
            Controls.Add(txt_cage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CageForm";
            Text = "Cage";
            ((System.ComponentModel.ISupportInitialize)dataCage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_cage;
        private TextBox txt_area;
        private TextBox txt_user;
        private TextBox txt_search;
        private TextBox txt_animal;
        private Button search;
        private Button add;
        private Button delete;
        private Button update;
        private DataGridView dataCage;
        private TextBox txt_cagearea;
        private Label label5;
    }
}