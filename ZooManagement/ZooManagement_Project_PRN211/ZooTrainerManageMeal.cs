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
    public partial class ZooTrainerManageMeal : Form
    {
        private User us;
        private string action;
        private string fid;
        private IZooTrainerService _service;
        public ZooTrainerManageMeal(User us)
        {
            InitializeComponent();
            this.us = us;
            _service = new ZooTrainerService();
            dataGridView1.DataSource = _service.GetAllFood();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZooTrainerMenu menu = new ZooTrainerMenu(us);
            menu.Show();
            this.Hide();
        }

        //add button
        private void button1_Click(object sender, EventArgs e)
        {
            action = "add";
            txt_id.Enabled = true;
            txt_name.Enabled = true;
            txt_quantity.Enabled = true;
        }

        //save button
        private void button3_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {
                var add = new Food();
                add.FoodId = txt_id.Text;
                add.FoodName = txt_name.Text;
                add.Quantity = txt_quantity.Text;
                _service.CreateFood(add);
                if (add != null)
                {
                    MessageBox.Show("add success");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _service.GetAllFood();

                    txt_id.Enabled = false;
                    txt_name.Enabled = false;
                    txt_quantity.Enabled = false;

                    txt_id.Text = null;
                    txt_name.Text = null;
                    txt_quantity.Text = null;
                }

            }
            if (action == "update")
            {
                var update = new Food();
                update.FoodId = fid;
                update.FoodName = txt_name.Text;
                update.Quantity = txt_quantity.Text;
                var result = _service.UpdateFood(update);
                if (result != null)
                {
                    MessageBox.Show("update success");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _service.GetAllFood();

                    txt_id.Enabled = false;
                    txt_name.Enabled = false;
                    txt_quantity.Enabled = false;

                    txt_id.Text = null;
                    txt_name.Text = null;
                    txt_quantity.Text = null;
                }
            }
        }

        //update button
        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (id == null) MessageBox.Show("Please choose a food");
            else
            {
                var foundUpdate = this._service.GetFoodById(id);
                txt_id.PlaceholderText = foundUpdate.FoodId;
                fid = foundUpdate.FoodId;
                txt_id.Enabled = false;
                txt_name.PlaceholderText = foundUpdate.FoodName;
                txt_name.Enabled = true;
                txt_quantity.PlaceholderText = foundUpdate.Quantity;
                txt_quantity.Enabled = true;
                action = "update";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to remove this student?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var result = this._service.RemoveFood(id);
                if (result != null)
                {
                    MessageBox.Show("Remove Successfully!");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _service.GetAllFood();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
