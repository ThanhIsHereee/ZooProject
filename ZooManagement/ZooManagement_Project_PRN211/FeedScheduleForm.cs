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
    public partial class FeedScheduleForm : Form
    {
        private User us;
        private IZooTrainerService _service;
        public FeedScheduleForm(User begin)
        {
            InitializeComponent();
            this.us = begin;
            _service = new ZooTrainerService();
            dataGridView1.DataSource = _service.GetAllSchedule();
            var animalList = _service.GetAnimals();
            comboBox1.DataSource = animalList;
            comboBox1.DisplayMember = "AnimalName";
            comboBox1.ValueMember = "AnimailId";
            var foodList = _service.GetAllFood();
            comboBox3.DataSource = foodList;
            comboBox3.DisplayMember = "FoodName";
            comboBox3.ValueMember = "FoodId";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZooTrainerMenu menu = new ZooTrainerMenu(us);
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (id == null) MessageBox.Show("Please choose a schedule");
            else
            {
                var result = this._service.Checked(id);
                if (result != null)
                {
                    MessageBox.Show("Check Success");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _service.GetAllSchedule();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = us.UserId;
            string animalId = (string)comboBox1.SelectedValue;
            string foodId = (string)comboBox3.SelectedValue;
            var date = dateTimePicker1.Text;
            var result = _service.CreateSchedule(id, animalId, foodId, date);
            if(result != null)
            {
                MessageBox.Show("Create Successs");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _service.GetAllSchedule();
            }
        }
    }
}
