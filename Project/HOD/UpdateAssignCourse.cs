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
    public partial class UpdateAssignCourse: Form
    {
        public UpdateAssignCourse()
        {
            InitializeComponent();
            getFaculty_id();
            getCourse_id();
            getSemester_id();
        }

        public void Updateassigned()
        {
            int faculty_course_id = int.Parse(textBox1.Text);

            string fac = comboBox2.SelectedItem.ToString();
            string[] faculty = fac.Split('-');
            int faculty_id = int.Parse(faculty[0]);

            string proj = comboBox3.SelectedItem.ToString();
            string[] project = proj.Split('-');
            int project_id = int.Parse(project[0]);

            string sem = comboBox1.SelectedItem.ToString();
            string[] semester = sem.Split('-');
            int semester_id = int.Parse(semester[0]);

            AssignCouseCrud assignCouseCrud = new AssignCouseCrud(faculty_course_id, faculty_id, project_id, semester_id);
            assignCouseCrud.UpdateCourse();
        }

        public void getFaculty_id()
        {
            string query = $"SELECT faculty_id,name FROM faculty";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox2.Items.Add(conn["faculty_id"].ToString() + "-" + conn["name"].ToString());
            }
        }
        public void getSemester_id()
        {
            string query = $"SELECT semester_id,term FROM semesters";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox1.Items.Add(conn["semester_id"].ToString() + "-" + conn["term"].ToString());
            }
        }
        public void getCourse_id()
        {
            string query = $"SELECT course_id,course_name FROM courses";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox3.Items.Add(conn["course_id"].ToString() + "-" + conn["course_name"].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            Updateassigned();
            MessageBox.Show("Course Updated Successfully");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CourseAssign courseAll = new CourseAssign();
            courseAll.StartPosition = FormStartPosition.Manual;
            courseAll.Location = this.Location;
            this.Hide();
            courseAll.Show();
        }
    }
}
