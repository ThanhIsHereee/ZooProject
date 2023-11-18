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
    public partial class StaffMenu : Form
    {
        private IAccountService accountService;
        public StaffMenu()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainnerAccountManagement trainnerAccount = new TrainnerAccountManagement();
            this.Hide();
            trainnerAccount.Show();

        }
    }
}
