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
    public partial class WorkloadView: Form
    {
        public WorkloadView()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FacultyUI facform = new FacultyUI();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        public void ViewWork(int faculty_id)
        {
            string query = $"SELECT faculty_course_schedule.schedule_id, faculty_courses.faculty_id, faculty_courses.course_id,courses.course_name, faculty_course_schedule.room_id, rooms.room_name, faculty_course_schedule.day_of_week, faculty_course_schedule.start_time, faculty_course_schedule.end_time FROM faculty_course_schedule JOIN faculty_courses ON faculty_course_schedule.faculty_course_id = faculty_courses.faculty_course_id JOIN courses ON faculty_courses.course_id = courses.course_id JOIN rooms ON faculty_course_schedule.room_id = rooms.room_id WHERE faculty_courses.faculty_id = {faculty_id}";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int faculty_id = int.Parse(textBox1.Text);
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            ViewWork(faculty_id);
        }
    }
}
