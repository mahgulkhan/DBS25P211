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
    public partial class UpdateRoom: Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
            getFaculty_id();
            getRoom_id();
            getSemester_id();
        }

        public void Updateall()
        {
            string fac = comboBox2.SelectedItem.ToString();
            string[] faculty = fac.Split('-');
            int faculty_id = int.Parse(faculty[0]);

            string room = comboBox3.SelectedItem.ToString();
            string[] roomid = room.Split('_');
            int room_id = int.Parse(roomid[0]);

            string sem = comboBox1.SelectedItem.ToString();
            string[] semester = sem.Split('-');
            int semester_id = int.Parse(semester[0]);

            int faculty_room_all_id = int.Parse(textBox2.Text);
            int reserved_hours = int.Parse(textBox1.Text);

            RoomCrud roomCrud = new RoomCrud(faculty_room_all_id,faculty_id,room_id,reserved_hours,semester_id);
            roomCrud.UpdateRoomAll();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RoomAll roomAll = new RoomAll();
            roomAll.StartPosition = FormStartPosition.Manual;
            roomAll.Location = this.Location;
            this.Hide();
            roomAll.Show();
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
        public void getRoom_id()
        {
            string query = $"SELECT room_id,room_name FROM rooms";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox3.Items.Add(conn["room_id"].ToString() + "_" + conn["room_name"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
