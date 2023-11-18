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
    public partial class TrainnerAccountManagement : Form
    {
        private IAccountService service;


        public TrainnerAccountManagement()
        {
            InitializeComponent();
            service = new AccountService();
            dtg_TrainerAccount.DataSource = service.GetTrainerACcount();

        }

        private void TrainnerAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void dtg_TrainerAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_searchtrainer_Click(object sender, EventArgs e)
        {
            dtg_TrainerAccount.DataSource = service.GetTrainerACcount()
                .Where(c => c.UserId.Contains(textBox1.Text.Trim()))
                .Select(c => new { c.Fullname, c.Username, c.UserId, c.Pasword, c.Phonenumber, c.Address, c.Role, c.Experience }).ToList();

        }
    }
}
