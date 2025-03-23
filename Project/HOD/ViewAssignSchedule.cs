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
    public partial class ViewAssignSchedule: Form
    {
        public ViewAssignSchedule()
        {
            InitializeComponent();
            ShowCourses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScheduleAssign scheduleAssign = new ScheduleAssign();
            scheduleAssign.StartPosition = FormStartPosition.Manual;
            scheduleAssign.Location = this.Location;
            this.Hide();
            scheduleAssign.Show();
        }

        public void ShowCourses()
        {
            string query = $"SELECT faculty_course_schedule.schedule_id, faculty.faculty_id,faculty.name AS faculty_name,courses.course_name,faculty_course_schedule.room_id, rooms.room_name, faculty_course_schedule.day_of_week, faculty_course_schedule.start_time, faculty_course_schedule.end_time FROM faculty_course_schedule JOIN faculty_courses ON faculty_course_schedule.faculty_course_id = faculty_courses.faculty_course_id JOIN faculty ON faculty_courses.faculty_id = faculty.faculty_id JOIN courses ON faculty_courses.course_id = courses.course_id JOIN rooms ON faculty_course_schedule.room_id = rooms.room_id";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
