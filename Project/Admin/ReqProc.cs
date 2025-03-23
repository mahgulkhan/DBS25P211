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
    public partial class ReqProc: Form
    {
        public ReqProc()
        {
            InitializeComponent();
            ProcessReq();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStaffUI facform = new AdminStaffUI();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ProcessReq()
        {
            string query = $"SELECT faculty.faculty_id, faculty.name, faculty_requests.request_id, faculty_requests.item_id, faculty_requests.quantity, faculty_requests.status_id , faculty_requests.request_date FROM faculty_requests JOIN faculty ON faculty.faculty_id = faculty_requests.faculty_id WHERE status_id = 9";
            var conn = DatabaseHelper.Instance.getData(query) ;
            DataTable dt = new DataTable();
            dt.Load(conn);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int request_id = int.Parse(textBox1.Text);
            string query = $"UPDATE faculty_requests SET status_id = 11 WHERE request_id = {request_id}";
            DatabaseHelper.Instance.Update(query);
            MessageBox.Show("Request Fulfilled");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminStaffUI adminStaffUI = new AdminStaffUI();
            adminStaffUI.StartPosition = FormStartPosition.Manual;
            adminStaffUI.Location = this.Location;
            this.Hide();
            adminStaffUI.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
