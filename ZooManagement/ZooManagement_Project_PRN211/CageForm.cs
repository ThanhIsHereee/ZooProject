using BusinessObject;
using BusinessObject.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CageForm : Form
    {
        private ICageService service;
        public CageForm()
        {
            InitializeComponent();
            service = new CageService();
            dataCage.DataSource = service.GetAllListCage();
        }

        private void dataCage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cage.Text = dataCage.CurrentRow.Cells["CageId"].Value.ToString();
            txt_area.Text = dataCage.CurrentRow.Cells["AreaId"].Value.ToString();
            txt_user.Text = dataCage.CurrentRow.Cells["UserId"].Value.ToString();
            txt_animal.Text = dataCage.CurrentRow.Cells["AnimalSpeciesId"].Value.ToString();
            txt_cagearea.Text = dataCage.CurrentRow.Cells["CageArea"].Value.ToString();


        }

        private void search_Click(object sender, EventArgs e)
        {
            dataCage.DataSource = service.GetAllListCage()
           .Where(x => x.CageId.Contains(txt_search.Text.Trim()))
           .Select(x => new { x.CageId, x.UserId, x.AreaId, x.AnimalSpeciesId,x.CageArea }).ToList();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cage.Text.Trim().Length > 0)
                {
                    service.RemoveCage(txt_cage.Text.Trim());
                    MessageBox.Show("Delete cage Sucess !");
                    dataCage.DataSource = service.GetAllListCage();

                }
                else
                    MessageBox.Show("CandidateID IS NOT EXIST !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                Cage cage = service.GetCageById(txt_cage.Text.Trim());
                if (cage != null)
                {
                    cage.CageId = txt_cage.Text.Trim();
                    cage.AreaId = txt_area.Text.Trim();
                    cage.AnimalSpeciesId = txt_animal.Text.Trim();
                    cage.UserId = txt_user.Text.Trim();
                    cage.CageArea = txt_cagearea.Text.Trim();
                    service.UpdateCage(cage);
                    MessageBox.Show("Update cage Success !");
                    dataCage.DataSource = service.GetAllListCage();
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
        private void add_Click(object sender, EventArgs e)
        {
            bool isValidData = true;
            if (!HRMUtils.isStrNotEmpty(txt_cage.Text.Trim()))
            {
                isValidData = false;
                txt_cage.Focus();
                txt_cage.BackColor = Color.Red;
                MessageBox.Show("AirConditionerID Is Not Empty !");
            }
            try
            {
                if (isValidData)
                {
                    Cage cage = new Cage();
                    cage.CageId = txt_cage.Text.Trim();
                    cage.AreaId = txt_area.Text.Trim();
                    cage.AnimalSpeciesId = txt_animal.Text.Trim();
                    cage.UserId = txt_user.Text.Trim();
                    cage.CageArea = txt_cagearea.Text.Trim();
                    service.AddCage(cage);
                    MessageBox.Show("Add cage Success !");
                    dataCage.DataSource = service.GetAllListCage();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cage cage = service.GetCageById(txt_cage.Text.Trim());
                if (cage != null)
                {
                    cage.CageId = txt_cage.Text.Trim();
                    cage.AreaId = txt_area.Text.Trim();
                    cage.AnimalSpeciesId = txt_animal.Text.Trim();
                    cage.UserId = txt_user.Text.Trim();
                    cage.CageArea = txt_cagearea.Text.Trim();
                    service.UpdateCage(cage);
                    MessageBox.Show("Update cage Success !");
                    dataCage.DataSource = service.GetAllListCage();
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

        private void delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_cage.Text.Trim().Length > 0)
                {
                    service.RemoveCage(txt_cage.Text.Trim());
                    MessageBox.Show("Delete cage Sucess !");
                    dataCage.DataSource = service.GetAllListCage();

                }
                else
                    MessageBox.Show("CandidateID IS NOT EXIST !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
