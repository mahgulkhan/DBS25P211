using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FacReqstat: Form
    {
        public FacReqstat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyUI facform = new FacultyUI();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FacultyUI facultyUI = new FacultyUI();
            facultyUI.StartPosition = FormStartPosition.Manual;
            facultyUI.Location = this.Location;
            this.Hide();
            facultyUI.Show();
        }

        public void ViewWork(int faculty_id)
        {
            string query = $"SELECT faculty_admin_roles.admin_role_id, faculty_admin_roles.faculty_id, faculty.name, faculty_admin_roles.role_name, faculty_admin_roles.semester_id FROM Faculty_admin_roles JOIN faculty ON faculty_admin_roles.faculty_id = faculty.faculty_id WHERE faculty_admin_roles.faculty_id= {faculty_id}";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int faculty_id = int.Parse(textBox1.Text);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            ViewWork(faculty_id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
