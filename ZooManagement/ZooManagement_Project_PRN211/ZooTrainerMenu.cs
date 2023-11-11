using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagement_Project_PRN211
{
    public partial class ZooTrainerMenu : Form
    {
        User us = new User();
        public ZooTrainerMenu(User begin)
        {
            InitializeComponent();
            this.us = begin;
            if (this.us != null)
            {
                lb_welcome.Text = "Welcome Trainer " + this.us.Fullname;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ZooTrainerProfile profile = new ZooTrainerProfile(us);
            profile.Show();
            this.Hide();
        }

        private void btn_Animal_Click(object sender, EventArgs e)
        {
            ZooTrainerManageAnimal AnimalManage = new ZooTrainerManageAnimal(us);
            AnimalManage.Show();
            this.Hide();
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {
            ZooTrainerManageMeal MealManage = new ZooTrainerManageMeal(us);
            MealManage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedScheduleForm schedule = new FeedScheduleForm(us);
            schedule.Show();
            this.Hide();
        }
    }
}
