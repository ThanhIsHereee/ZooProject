namespace ZooManagement_Project_PRN211
{
    partial class STAFF_MANAGER
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
            AREA = new Button();
            CAGE = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AREA);
            groupBox1.Controls.Add(CAGE);
            groupBox1.Location = new Point(12, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // AREA
            // 
            AREA.Location = new Point(537, 22);
            AREA.Name = "AREA";
            AREA.Size = new Size(104, 64);
            AREA.TabIndex = 1;
            AREA.Text = "AREA";
            AREA.UseVisualStyleBackColor = true;
            AREA.Click += AREA_Click;
            // 
            // CAGE
            // 
            CAGE.Location = new Point(137, 25);
            CAGE.Name = "CAGE";
            CAGE.Size = new Size(107, 61);
            CAGE.TabIndex = 0;
            CAGE.Text = "CAGE";
            CAGE.UseVisualStyleBackColor = true;
            CAGE.Click += CAGE_Click;
            // 
            // STAFF_MANAGER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "STAFF_MANAGER";
            Text = "STAFF_MANAGER";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button AREA;
        private Button CAGE;
    }
}