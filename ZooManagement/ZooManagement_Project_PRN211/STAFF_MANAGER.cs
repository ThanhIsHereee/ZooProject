using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagement_Project_PRN211
{
    public partial class STAFF_MANAGER : Form
    {
        public STAFF_MANAGER()
        {
            InitializeComponent();
        }

        private void CAGE_Click(object sender, EventArgs e)
        {
            CAGE_MANAGER CAGE = new CAGE_MANAGER();
            CAGE.Show();
        }

        private void AREA_Click(object sender, EventArgs e)
        {
            AREA_MANAGER AREA = new AREA_MANAGER();
            AREA.Show();
        }
    }
}
