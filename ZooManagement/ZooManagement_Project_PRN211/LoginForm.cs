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
    public partial class LoginForm : Form
    {
        private IAccountService loginService;
        public LoginForm()
        {
            InitializeComponent();
            loginService = new AccountService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                User newuser = loginService.GetAccountByMail(txt_email.Text.Trim(), txt_password.Text.Trim());
                if (newuser != null)
                {
                    switch (newuser.Role)
                    {
                        case "admin":
                            ListAccount listAccount = new ListAccount();
                            listAccount.Show();
                            this.Hide();
                            break;
                        case "staff":
                            MessageBox.Show("Login with role Staff");
                            break;
                        case "trainer":
                            MessageBox.Show("Login with role ZooTrainer");

                            break;
                        default:
                            MessageBox.Show("Unknow Role !");
                            break;


                    }
                   
                }else
                {
                    MessageBox.Show("Incorrect Username Or PassWord!....Check Again !");
                }    


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
