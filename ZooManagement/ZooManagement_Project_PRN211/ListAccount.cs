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
using ZooRepo;
using ZooService;

namespace ZooManagement_Project_PRN211
{
    public partial class ListAccount : Form
    {
        private IAccountService service;

        public ListAccount()
        {
            InitializeComponent();
            service = new AccountService();
            dtg_listAccount.DataSource = service.GetAllListUser();
        }

        private void dtg_listAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_listAccount.CurrentRow.Cells["UserId"].Value.ToString();
            txt_username.Text = dtg_listAccount.CurrentRow.Cells["Username"].Value.ToString();
            txt_pass.Text = dtg_listAccount.CurrentRow.Cells["Pasword"].Value.ToString();
            txt_fullname.Text = dtg_listAccount.CurrentRow.Cells["Fullname"].Value.ToString();
            txt_phone.Text = dtg_listAccount.CurrentRow.Cells["Phonenumber"].Value.ToString();
            txt_address.Text = dtg_listAccount.CurrentRow.Cells["Address"].Value.ToString();
            txt_role.Text = dtg_listAccount.CurrentRow.Cells["Role"].Value.ToString();
            txt_experience.Text = dtg_listAccount.CurrentRow.Cells["Experience"].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text.Trim().Length > 0)
                {
                    service.RemoveAccount(txt_id.Text.Trim());
                    MessageBox.Show("Delete Account Sucess !");
                    dtg_listAccount.DataSource = service.GetAllListUser();

                }
                else
                    MessageBox.Show("CandidateID IS NOT EXIST !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    User user = new User();
                    user.UserId = txt_id.Text.Trim();
                    user.Username = txt_username.Text.Trim();
                    user.Pasword = txt_pass.Text.Trim();
                    user.Fullname = txt_fullname.Text.Trim();
                    user.Phonenumber = txt_phone.Text.Trim();
                    user.Address = txt_address.Text.Trim();
                    user.Role = txt_role.Text.Trim();
                    user.Experience = txt_experience.Text.Trim();
                    service.AddAccount(user);
                    MessageBox.Show("Add Account Success !");
                    dtg_listAccount.DataSource = service.GetAllListUser();


                }

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
                User user = service.GetAccountByID(txt_id.Text.Trim());
                if (user != null)
                {
                    user.Username = txt_username.Text.Trim();
                    user.Pasword = txt_pass.Text.Trim();
                    user.Fullname = txt_fullname.Text.Trim();
                    user.Phonenumber = txt_phone.Text.Trim();
                    user.Role = txt_role.Text.Trim();
                    user.Experience = txt_experience.Text.Trim();
                    service.UpdateAccount(user);
                    MessageBox.Show("Update Account Success !");
                    dtg_listAccount.DataSource = service.GetAllListUser();
                }
                else
                {
                    MessageBox.Show("AccountID is Empty !");
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
                if (radio_id.Checked)
                {
                    dtg_listAccount.DataSource = service.GetAllListUser()
                    .Where(x => x.UserId.Contains(txt_search.Text.Trim()))
                    .Select(x => new { x.Fullname, x.Pasword, x.Role, x.Experience, x.Address, x.UserId, x.Username, x.Phonenumber }).ToList();

                }
                else if (radio_name.Checked)
                {
                    dtg_listAccount.DataSource = service.GetAllListUser()
                   .Where(x => x.Fullname.ToString().Contains(txt_search.Text.Trim()))
                   .Select(x => new { x.Fullname, x.Pasword, x.Role, x.Experience, x.Address, x.UserId, x.Username, x.Phonenumber }).ToList();


                }
                else if (radio_role.Checked)
                {
                    dtg_listAccount.DataSource = service.GetAllListUser()
                  .Where(x => x.Role.ToString().Contains(txt_search.Text.Trim()))
                  .Select(x => new { x.Fullname, x.Pasword, x.Role, x.Experience, x.Address, x.UserId, x.Username, x.Phonenumber }).ToList();

                }else
                {
                    dtg_listAccount.DataSource = null;
                    MessageBox.Show("The Account Is Not Found !....Check Again!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
