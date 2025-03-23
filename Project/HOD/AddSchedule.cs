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
    public partial class AddSchedule: Form
    {
        public AddSchedule()
        {
            InitializeComponent();
            getFaculty_id();
            getRoom_id();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ScheduleAssign scheduleAssign = new ScheduleAssign();
            scheduleAssign.StartPosition = FormStartPosition.Manual;
            scheduleAssign.Location = this.Location;
            this.Hide();
            scheduleAssign.Show();
        }

        public void add()
        {
            string room = comboBox1.SelectedItem.ToString();
            string[] room_id = room.Split('-');
            int room_id1 = int.Parse(room_id[0]);

            string fac = comboBox2.SelectedItem.ToString();
            string[] faculty = fac.Split('-');
            int faculty_id = int.Parse(faculty[0]);

            string start_time = textBox1.Text;
            string end_time = textBox2.Text;

            string day_of_week = "";
            if(comboBox3.Text == "Monday")
            {
                day_of_week = "Monday";
            }
            else if (comboBox3.Text == "Tuesday")
            {
                day_of_week = "Tuesday";
            }
            else if (comboBox3.Text == "Wednesday")
            {
                day_of_week = "Wednesday";
            }
            else if (comboBox3.Text == "Thursday")
            {
                day_of_week = "Thursday";
            }
            else if (comboBox3.Text == "Friday")
            {
                day_of_week = "Friday";
            }
            else if (comboBox3.Text == "Saturday")
            {
                day_of_week = "Saturday";
            }
            else if (comboBox3.Text == "Sunday")
            {
                day_of_week = "Sunday";
            }

            ScheduleCrud scheduleCrud = new ScheduleCrud(0, faculty_id, room_id1, day_of_week, start_time, end_time);
            scheduleCrud.AddSchedule();
        }
        public void getFaculty_id()
        {
            string query = $"SELECT faculty_courses.faculty_course_id,faculty.name AS faculty_name,courses.course_name FROM faculty_courses JOIN faculty ON faculty_courses.faculty_id = faculty.faculty_id JOIN courses ON faculty_courses.course_id = courses.course_id";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox2.Items.Add(conn["faculty_course_id"].ToString() + "-"+ conn["faculty_name"].ToString() + "-"+ conn["course_name"].ToString());
            }
        }
        public void getRoom_id()
        {
            string query = $"SELECT room_id,room_name FROM rooms";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox1.Items.Add(conn["room_id"].ToString() + "-" + conn["room_name"].ToString());
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox2.Text)|| string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            
            add();
            MessageBox.Show("Schedule Added Successfully");
        }
    }
}
