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

        private void button3_Click(object sender, EventArgs e)
        {
            AddProj addProj = new AddProj();
            addProj.StartPosition = FormStartPosition.Manual;
            addProj.Location = this.Location;
            this.Hide();
            addProj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateProj updateProj = new UpdateProj();
            updateProj.StartPosition = FormStartPosition.Manual;
            updateProj.Location = this.Location;
            this.Hide();
            updateProj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelProj delProj = new DelProj();
            delProj.StartPosition = FormStartPosition.Manual;
            delProj.Location = this.Location;
            this.Hide();
            delProj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStaffUI adminStaffUI = new AdminStaffUI();
            adminStaffUI.StartPosition = FormStartPosition.Manual;
            adminStaffUI.Location = this.Location;
            this.Hide();
            adminStaffUI.Show();
        }
    }
}
