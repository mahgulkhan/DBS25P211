using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Admin;

namespace Project.HOD
{
    public partial class ViewAssignedCourses: Form
    {
        public ViewAssignedCourses()
        {
            InitializeComponent();
            ViewCourses();
        }

        public void ViewCourses()
        {
            string query = $"SELECT faculty_courses.faculty_course_id,faculty.faculty_id,faculty.name , faculty_courses.course_id, courses.course_name , faculty_courses.semester_id FROM faculty_courses JOIN faculty ON faculty.faculty_id = faculty_courses.faculty_id JOIN courses ON faculty_courses.course_id = courses.course_id ";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CourseAssign courseAssign = new CourseAssign();
            courseAssign.StartPosition = FormStartPosition.Manual;
            courseAssign.Location = this.Location;
            this.Hide();
            courseAssign.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
