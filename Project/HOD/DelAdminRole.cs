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
    public partial class DelAdminRole: Form
    {
        public DelAdminRole()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDuty adminDuty = new AdminDuty();
            adminDuty.StartPosition = FormStartPosition.Manual;
            adminDuty.Location = this.Location;
            this.Hide();
            adminDuty.Show();
        }

        public void Delete()
        {
            int admin_role_id = int.Parse(textBox1.Text);
            AdminRoleCrud adminRoleCrud = new AdminRoleCrud(admin_role_id, 0, "", 0);
            adminRoleCrud.DeleteAdminRole();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            Delete();
            MessageBox.Show("The Admin Role has been deleted");
        }
    }
}
