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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ZooManagement_Project_PRN211
{
    public partial class ZooTrainerManageAnimal : Form
    {
        private IZooTrainerService _service;
        private User us;
        private string action;
        private string spId;
        public ZooTrainerManageAnimal(User us)
        {
            _service = new ZooTrainerService();
            InitializeComponent();
            Animal_Data.DataSource = _service.GetAnimals();

            Species_Data.DataSource = _service.GetAnimalSpecies();
            List<AnimalSpecies> speciesList = _service.GetAnimalSpecies();
            cb_Species.DataSource = speciesList;
            cb_Species.DisplayMember = "AnimalSpeciesName";
            cb_Species.ValueMember = "AnimalSpeciesId";
            this.us = us;
        }

        //add animal
        private void button1_Click(object sender, EventArgs e)
        {
            txt_Id.Enabled = true;
            txt_Name.Enabled = true;
            dtp_Birth.Enabled = true;
            cb_Species.Enabled = true;
            rb_Male.Enabled = true;
            rb_Female.Enabled = true;
            txt_Des.Enabled = true;
            action = "add";
        }

        //return button
        private void button9_Click(object sender, EventArgs e)
        {
            ZooTrainerMenu menu = new ZooTrainerMenu(us);
            menu.Show();
            this.Hide();
        }

        //save about animal
        private void button4_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {
                var add = new Animal();
                add.AnimailId = txt_Id.Text;
                add.AnimalName = txt_Name.Text;
                add.AnimalDob = dtp_Birth.Text;
                add.AnimalSpeciesId = (string)cb_Species.SelectedValue;
                add.AnimalDescription = txt_Des.Text;
                if (rb_Female.Checked)
                    add.AnimalGender = false;
                else
                    add.AnimalGender = true;
                var result = _service.Add(add);
                if (result != null)
                {
                    MessageBox.Show("Add Success!");
                    txt_Id.Enabled = false;
                    txt_Name.Enabled = false;
                    dtp_Birth.Enabled = false;
                    cb_Species.Enabled = false;
                    rb_Male.Enabled = false;
                    rb_Female.Enabled = false;
                    txt_Des.Enabled = false;

                    txt_Id.Text = null;
                    txt_Name.Text = null;
                    cb_Species.Text = null;
                    rb_Male.Checked = false;
                    rb_Female.Checked = false;
                    txt_Des.Text = null;

                    Animal_Data.DataSource = null;
                    Animal_Data.DataSource = _service.GetAnimals();
                }
            }
            if (action == "update")
            {
                //init an instance to update
                var update = new Animal();
                update.AnimailId = txt_Id.Text;
                update.AnimalName = txt_Name.Text;
                update.AnimalDob = dtp_Birth.Text;
                update.AnimalDescription = txt_Des.Text;
                update.AnimalSpeciesId = spId;
                if (rb_Male.Checked)
                    update.AnimalGender = true;
                else
                    update.AnimalGender = false;
                var result = this._service.UpdateAnimal(update);
                if (result != null)
                {
                    MessageBox.Show("Update Successfully");
                    txt_Id.Enabled = false;
                    txt_Name.Enabled = false;
                    dtp_Birth.Enabled = false;
                    cb_Species.Enabled = false;
                    rb_Male.Enabled = false;
                    rb_Female.Enabled = false;
                    txt_Des.Enabled = false;

                    txt_Id.Text = null;
                    txt_Name.Text = null;
                    cb_Species.Text = null;
                    rb_Male.Checked = false;
                    rb_Female.Checked = false;
                    txt_Des.Text = null;
                    Animal_Data.DataSource = null;
                    Animal_Data.DataSource = _service.GetAnimals();
                }
            }
        }

        //remove animal
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to remove this student?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string id = this.Animal_Data.CurrentRow.Cells[0].Value.ToString();
                var result = this._service.Remove(id);
                if (result != null)
                {
                    MessageBox.Show("Remove Successfully!");
                    Animal_Data.DataSource = null;
                    Animal_Data.DataSource = _service.GetAnimals();
                }
            }
        }

        //update animal
        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.Animal_Data.CurrentRow.Cells[0].Value.ToString();
            if (id == null) MessageBox.Show("Please choose an animal");
            else
            {
                action = "update";

                //get to placeholder
                var found = this._service.GetAnimalById(id);

                //set field
                txt_Name.Enabled = true;
                dtp_Birth.Enabled = true;
                cb_Species.Enabled = false;
                rb_Male.Enabled = true;
                rb_Female.Enabled = true;
                txt_Des.Enabled = true;

                //set placeholder
                txt_Id.Text = id;
                txt_Name.PlaceholderText = found.AnimalName;
                if ((bool)found.AnimalGender)
                    rb_Male.Checked = true;
                else
                    rb_Female.Checked = true;
                spId = found.AnimalSpeciesId;
            }
        }

        //add species
        private void button8_Click(object sender, EventArgs e)
        {
            txt_SpeciesId.Enabled = true;
            txt_SpeciesName.Enabled = true;
            txt_SpeciesDesc.Enabled = true;
            action = "add species";
        }

        //remove species
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to remove this student?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string id = this.Species_Data.CurrentRow.Cells[0].Value.ToString();
                var result = this._service.RemoveSpecies(id);
                if (result != null)
                {
                    MessageBox.Show("Remove Successfully!");
                    Species_Data.DataSource = null;
                    Species_Data.DataSource = _service.GetAnimalSpecies();
                }
            }
        }

        //update species
        private void button7_Click(object sender, EventArgs e)
        {
            string id = this.Species_Data.CurrentRow.Cells[0].Value.ToString();
            if (id == null) MessageBox.Show("Please choose an animal");
            else
            {
                action = "update species";

                //get to placeholder
                var found = this._service.GetSpeciesById(id);

                //set field
                txt_SpeciesName.Enabled = true;
                txt_SpeciesDesc.Enabled = true;

                //set placeholder
                txt_SpeciesId.Text = id;
                txt_SpeciesName.PlaceholderText = found.AnimalSpeciesName;
            }
        }

        //save about species
        private void button5_Click(object sender, EventArgs e)
        {
            if (action == "add species")
            {
                var species = new AnimalSpecies();
                species.AnimalSpeciesId = txt_SpeciesId.Text;
                species.AnimalSpeciesName = txt_SpeciesName.Text;
                species.AnimalSpeciesDecription = txt_SpeciesDesc.Text;

                var result = this._service.AddSpecies(species);
                if (result != null)
                {
                    MessageBox.Show("Add Success!");
                    txt_SpeciesId.Enabled = false;
                    txt_SpeciesName.Enabled = false;
                    txt_SpeciesDesc.Enabled = false;

                    txt_SpeciesId.Text = null;
                    txt_SpeciesName.Text = null;
                    txt_SpeciesDesc.Text = null;

                    Species_Data.DataSource = null;
                    Species_Data.DataSource = _service.GetAnimalSpecies();
                }
            }
            if (action == "update species")
            {
                var species = new AnimalSpecies();
                species.AnimalSpeciesId = txt_SpeciesId.Text;
                species.AnimalSpeciesName = txt_SpeciesName.Text;
                species.AnimalSpeciesDecription = txt_SpeciesDesc.Text;

                var result = this._service.UpdateSpecies(species);
                if (result != null)
                {
                    MessageBox.Show("update Success!");
                    txt_SpeciesId.Enabled = false;
                    txt_SpeciesName.Enabled = false;
                    txt_SpeciesDesc.Enabled = false;

                    txt_SpeciesId.Text = null;
                    txt_SpeciesName.Text = null;
                    txt_SpeciesDesc.Text = null;

                    Species_Data.DataSource = null;
                    Species_Data.DataSource = _service.GetAnimalSpecies();
                }
            }
        }
    }
}
