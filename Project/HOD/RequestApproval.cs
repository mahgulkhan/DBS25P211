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
    public partial class RequestApproval: Form
    {
        public RequestApproval()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepResAll depResAll = new DepResAll();
            depResAll.StartPosition = FormStartPosition.Manual;
            depResAll.Location = this.Location;
            this.Hide();
            depResAll.Show();
        }

        
        public void ShowReq()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int request_id = int.Parse(textBox1.Text);
            string query = $"UPDATE faculty_admin_roles SET status_id = 9 WHERE request_id = {request_id}";
            DatabaseHelper.Instance.Update(query);
            MessageBox.Show("Request Approved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int request_id = int.Parse(textBox1.Text);
            string query = $"UPDATE faculty_admin_roles SET status_id = 10 WHERE request_id = {request_id}";
            DatabaseHelper.Instance.Update(query);
            MessageBox.Show("Request Rejected");
        }
    }
}
