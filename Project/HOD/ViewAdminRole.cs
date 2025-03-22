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
    public partial class ViewAdminRole: Form
    {
        public ViewAdminRole()
        {
            InitializeComponent();
            ShowAllRoles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDuty adminDuty = new AdminDuty();
            adminDuty.StartPosition = FormStartPosition.Manual;
            adminDuty.Location = this.Location;
            this.Hide();
            adminDuty.Show();
        }

        public void ShowAllRoles()
        {
            string query = $"SELECT faculty_admin_roles.admin_role_id, faculty_admin_roles.faculty_id, faculty.name, faculty_admin_roles.role_name, faculty_admin_roles.semester_id FROM Faculty_admin_roles JOIN faculty ON faculty_admin_roles.faculty_id = faculty.faculty_id";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable dt = new DataTable();
            dt.Load(conn);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
