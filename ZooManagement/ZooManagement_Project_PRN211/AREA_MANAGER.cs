using BusinessObject.Models;
using BusinessObject;
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
    public partial class AREA_MANAGER : Form
    {
        private IAreaServise service;
        public AREA_MANAGER()
        {
            InitializeComponent();
            service = new AreaService();
            dtg_listArea.DataSource = service.GetAllAreas();
        }

        private void dtg_listArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_listArea.CurrentRow.Cells["AreaId"].Value.ToString();
            txt_Area_area.Text = dtg_listArea.CurrentRow.Cells["AreaArea"].Value.ToString();
            txt_User_id.Text = dtg_listArea.CurrentRow.Cells["UserId"].Value.ToString();
            txt_Area_Name.Text = dtg_listArea.CurrentRow.Cells["AreaName"].Value.ToString();
            txt_User.Text = dtg_listArea.CurrentRow.Cells["User"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool isValidData = true;
            if (!HRMUtils.isStrNotEmpty(txt_id.Text.Trim()))
            {
                isValidData = false;
                txt_id.Focus();
                txt_id.BackColor = Color.Red;
                MessageBox.Show("AirConditionerID Is Not Empty !");
            }
            try
            {
                if (isValidData)
                {
                    Area area = new Area();
                    area.AreaId = txt_id.Text;
                    area.AreaName = txt_Area_Name.Text;
                    area.AreaArea = txt_Area_area.Text.Trim();



                    MessageBox.Show("Add Area Success !");
                    dtg_listArea.DataSource = service.GetAllAreas();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try

            {

                dtg_listArea.DataSource = service.GetAllAreas()
                .Where(x => x.UserId.Contains(txt_id.Text.Trim()))
                .Select(x => new { x.UserId, x.User, x.AreaName, x.AreaArea, x.AreaId }).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text.Trim().Length > 0)
                {
                    service.RemoveArea(txt_id.Text.Trim());
                    MessageBox.Show("Delete Area Sucess !");
                    dtg_listArea.DataSource = service.GetAllAreas();

                }
                else
                    MessageBox.Show("Areaid IS NOT EXIST !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Area area = service.GetAreaByID(txt_id.Text.Trim());
                if (area != null)
                {
                    area.AreaId = txt_id.Text;
                    area.AreaName = txt_Area_Name.Text;
                    area.AreaArea = txt_Area_area.Text;
                    


                    service.UpdateArea(area);
                    MessageBox.Show("Update Area Success !");
                    dtg_listArea.DataSource = service.GetAllAreas();
                }
                else
                {
                    MessageBox.Show("AreaID is Empty !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
