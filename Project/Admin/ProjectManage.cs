using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Admin
{
    public partial class ProjectManage: Form
    {
        public ProjectManage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewProj viewProj = new ViewProj();
            viewProj.StartPosition = FormStartPosition.Manual;
            viewProj.Location = this.Location;
            this.Hide();
            viewProj.Show();
        }
    }
}
