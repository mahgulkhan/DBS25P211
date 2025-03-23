using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Faculty
{
    public partial class ReqStatus: Form
    {
        public ReqStatus()
        {
            InitializeComponent();
        }

        public void ShowStatus(int faculty_id)
        {
            string query = $"SELECT faculty.faculty_id, faculty.name, faculty_requests.request_id, faculty_requests.item_id, faculty_requests.quantity, faculty_requests.status_id , faculty_requests.request_date FROM faculty_requests JOIN faculty ON faculty.faculty_id = faculty_requests.faculty_id WHERE faculty.faculty_id = {faculty_id}";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int faculty_id = int.Parse(textBox1.Text);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            ShowStatus(faculty_id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacReqsub facReqsub = new FacReqsub();
            facReqsub.StartPosition = FormStartPosition.Manual;
            facReqsub.Location = this.Location;
            this.Hide();
            facReqsub.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
