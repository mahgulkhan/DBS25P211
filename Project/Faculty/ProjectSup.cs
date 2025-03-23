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
    public partial class ProjectSup: Form
    {
        public ProjectSup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyUI facultyUI = new FacultyUI();
            facultyUI.StartPosition = FormStartPosition.Manual;
            facultyUI.Location = this.Location;
            this.Hide();
            facultyUI.Show();
        }

        public void ViewWork(int faculty_id)
        {
            string query = $"SELECT faculty.faculty_id,faculty.name AS faculty_name, faculty_projects.project_id, projects.title AS project_title, projects.description AS project_description, faculty_projects.semester_id,faculty_projects.supervision_hours FROM faculty JOIN faculty_projects ON faculty.faculty_id = faculty_projects.faculty_id JOIN projects ON faculty_projects.project_id = projects.project_id WHERE faculty.faculty_id ={faculty_id}";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
