using BusinessObject.DTO.ZooTrainer;
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
using ZooService;

namespace ZooManagement_Project_PRN211
{
    public partial class ZooTrainerProfile : Form
    {
        private User us;
        private IZooTrainerService _service;
        public ZooTrainerProfile(User begin)
        {
            InitializeComponent();
            this.us = begin;
            _service = new ZooTrainerService();
            if (this.us != null)
            {
                lb_welcome.Text = "Welcome Trainer " + this.us.Fullname;
                txt_Fullname.Text = us.Fullname;
                txt_Fullname.Enabled = false;
                txt_Username.Text = us.Username;
                txt_Username.Enabled = false;
                txt_Phonenumber.Text = us.Phonenumber;
                txt_Phonenumber.Enabled = false;
                txt_Address.Text = us.Address;
                txt_Address.Enabled = false;
                txt_Experience.Text = us.Experience;
                txt_Experience.Enabled = false;

                txt_Password.Enabled = false;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            ZooTrainerMenu menu = new ZooTrainerMenu(us);
            menu.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txt_Fullname.Enabled = true;
            txt_Username.Enabled = true;
            txt_Password.Enabled = true;
            txt_Phonenumber.Enabled = true;
            txt_Address.Enabled = true;
            txt_Experience.Enabled = true;

            txt_Fullname.Text = null;
            txt_Username.Text = null;
            txt_Password.Text = null;
            txt_Phonenumber.Text = null;
            txt_Address.Text = null;
            txt_Experience.Text = null;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var update = new UpdateZooTrainer();
            update.UserId = us.UserId;
            if (txt_Fullname.Text != "")
                update.Fullname = txt_Fullname.Text;
            if (txt_Username.Text != "")
                update.Username = txt_Username.Text;
            if (txt_Password.Text != "")
                update.Password = txt_Password.Text;
            if (txt_Phonenumber.Text != "")
                update.Phonenumber = txt_Phonenumber.Text;
            if (txt_Address.Text != "")
                update.Address = txt_Address.Text;
            if (txt_Experience.Text != "")
                update.Experience = txt_Experience.Text;

            var result = this._service.UpdateProfile(update);
            if(result != null)
            {
                MessageBox.Show("Update profile successfully!");
                ZooTrainerMenu menu = new ZooTrainerMenu(result);
                menu.Show();
                this.Hide();
            }
        }
    }
}
