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
            ShowReq();
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
            string query = $"SELECT faculty.faculty_id, faculty.name, faculty_requests.request_id, faculty_requests.item_id, faculty_requests.quantity, faculty_requests.status_id , faculty_requests.request_date FROM faculty_requests JOIN faculty ON faculty.faculty_id = faculty_requests.faculty_id WHERE status_id = 8";
            var conn= DatabaseHelper.Instance.getData(query);
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
            string query = $"UPDATE faculty_requests SET status_id = 9 WHERE request_id = {request_id}";
            DatabaseHelper.Instance.Update(query);
            MessageBox.Show("Request Approved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int request_id = int.Parse(textBox1.Text);
            string query = $"UPDATE faculty_requests SET status_id = 10 WHERE request_id = {request_id}";
            DatabaseHelper.Instance.Update(query);
            MessageBox.Show("Request Rejected");
        }
    }
}
