using BusinessObject;
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
    public partial class CAGE_MANAGER : Form
    {
        private ICageService service;
        public CAGE_MANAGER()
        {
            InitializeComponent();
            service = new CageService();
            dataGridView1.DataSource = service.GetAllCages();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cageid.Text = dataGridView1.CurrentRow.Cells["ageId"].Value.ToString();
            txt_animalid.Text = dataGridView1.CurrentRow.Cells["AnimalSpeciesId"].Value.ToString();
            txt_areaid.Text = dataGridView1.CurrentRow.Cells["AreaId"].Value.ToString();
            txt_as.Text = dataGridView1.CurrentRow.Cells["AnimalSpecies"].Value.ToString();
            txt_user.Text = dataGridView1.CurrentRow.Cells["User"].Value.ToString();
            txt_ageArea.Text = dataGridView1.CurrentRow.Cells["CageArea"].Value.ToString();
            txt_Area.Text = dataGridView1.CurrentRow.Cells["Area"].Value.ToString();
            txt_userid.Text = dataGridView1.CurrentRow.Cells["UserId"].Value.ToString();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cageid.Text.Trim().Length > 0)
                {
                    service.RemoveCage(txt_cageid.Text.Trim());
                    MessageBox.Show("Delete Cage Sucess !");
                    dataGridView1.DataSource = service.GetAllCages();

                }
                else
                    MessageBox.Show("Cageid IS NOT EXIST !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Cage cage = service.GetCageByID(txt_cageid.Text.Trim());
                if (cage != null)
                {
                    cage.CageId = txt_cageid.Text;
                    cage.AreaId = txt_areaid.Text;



                    service.UpdateCage(cage);
                    MessageBox.Show("Update cage Success !");
                    dataGridView1.DataSource = service.GetAllCages();
                }
                else
                {
                    MessageBox.Show("cageID is Empty !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_sreach_TextChanged(object sender, EventArgs e)
        {
            try

            {

                dataGridView1.DataSource = service.GetAllCages()
                .Where(x => x.UserId.Contains(txt_sreach.Text.Trim()))
                .Select(x => new { x.UserId, x.User, x.AnimalSpecies, x.AnimalSpeciesId, x.Area, x.CageId, x.AreaId, x.CageArea }).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            bool isValidData = true;
            if (!HRMUtils.isStrNotEmpty(txt_cageid.Text.Trim()))
            {
                isValidData = false;
                txt_cageid.Focus();
                txt_cageid.BackColor = Color.Red;
                MessageBox.Show("AirConditionerID Is Not Empty !");
            }
            try
            {
                if (isValidData)
                {
                    Cage cage = new Cage();
                    cage.CageId = txt_cageid.Text;
                    cage.AreaId = txt_areaid.Text;
                    cage.UserId = txt_userid.Text.Trim();
                    cage.AnimalSpeciesId= txt_animalid.Text.Trim();
                    

                    MessageBox.Show("Add cage Success !");
                    dataGridView1.DataSource = service.GetAllCages();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
