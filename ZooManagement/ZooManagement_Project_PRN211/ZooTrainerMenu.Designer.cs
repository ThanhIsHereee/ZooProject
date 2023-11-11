namespace ZooManagement_Project_PRN211
{
    partial class ZooTrainerMenu
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
            lb_welcome = new Label();
            btn_Profile = new Button();
            btn_Animal = new Button();
            btn_Food = new Button();
            btn_Exit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lb_welcome
            // 
            lb_welcome.AutoSize = true;
            lb_welcome.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_welcome.Location = new Point(228, 62);
            lb_welcome.Name = "lb_welcome";
            lb_welcome.Size = new Size(100, 40);
            lb_welcome.TabIndex = 0;
            lb_welcome.Text = "label1";
            // 
            // btn_Profile
            // 
            btn_Profile.Location = new Point(336, 135);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(141, 50);
            btn_Profile.TabIndex = 1;
            btn_Profile.Text = "View your profile";
            btn_Profile.UseVisualStyleBackColor = true;
            btn_Profile.Click += btn_Profile_Click;
            // 
            // btn_Animal
            // 
            btn_Animal.Location = new Point(336, 209);
            btn_Animal.Name = "btn_Animal";
            btn_Animal.Size = new Size(141, 44);
            btn_Animal.TabIndex = 2;
            btn_Animal.Text = "Manage Animal";
            btn_Animal.UseVisualStyleBackColor = true;
            btn_Animal.Click += btn_Animal_Click;
            // 
            // btn_Food
            // 
            btn_Food.Location = new Point(336, 282);
            btn_Food.Name = "btn_Food";
            btn_Food.Size = new Size(141, 48);
            btn_Food.TabIndex = 3;
            btn_Food.Text = "Manage Meal";
            btn_Food.UseVisualStyleBackColor = true;
            btn_Food.Click += btn_Food_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(57, 371);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(141, 48);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(336, 371);
            button1.Name = "button1";
            button1.Size = new Size(141, 48);
            button1.TabIndex = 5;
            button1.Text = "Feed Schedule";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ZooTrainerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Food);
            Controls.Add(btn_Animal);
            Controls.Add(btn_Profile);
            Controls.Add(lb_welcome);
            Name = "ZooTrainerMenu";
            Text = "ZooTrainerProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_welcome;
        private Button btn_Profile;
        private Button btn_Animal;
        private Button btn_Food;
        private Button btn_Exit;
        private Button button1;
    }
}