using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HOD
{
    public partial class AdminDuty: Form
    {
        public AdminDuty()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkLoadAssign workform = new WorkLoadAssign();
            workform.StartPosition = FormStartPosition.Manual;
            workform.Location = this.Location;
            this.Hide();
            workform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddAdminRole addAdminRole = new AddAdminRole();
            addAdminRole.StartPosition = FormStartPosition.Manual;
            addAdminRole.Location = this.Location;
            this.Hide();
            addAdminRole.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAdminRole updateAdminRole = new UpdateAdminRole();
            updateAdminRole.StartPosition = FormStartPosition.Manual;
            updateAdminRole.Location = this.Location;
            this.Hide();
            updateAdminRole.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelAdminRole delAdminRole = new DelAdminRole();
            delAdminRole.StartPosition = FormStartPosition.Manual;
            delAdminRole.Location = this.Location;
            this.Hide();
            delAdminRole.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewAdminRole viewAdminRole = new ViewAdminRole();
            viewAdminRole.StartPosition = FormStartPosition.Manual;
            viewAdminRole.Location = this.Location;
            this.Hide();
            viewAdminRole.Show();
        }
    }
}
