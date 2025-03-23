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
    public partial class ViewAssignRoom: Form
    {
        public ViewAssignRoom()
        {
            InitializeComponent();
            ShowRooms();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomAll roomAll = new RoomAll();
            roomAll.StartPosition = FormStartPosition.Manual;
            roomAll.Location = this.Location;
            this.Hide();
            roomAll.Show();
        }

        public void ShowRooms()
        {
            string query = "SELECT faculty_room_allocations.allocation_id, faculty.faculty_id,faculty.name, rooms.room_id, rooms.room_name, faculty_room_allocations.reserved_hours, semesters.semester_id FROM faculty_room_allocations JOIN faculty ON faculty_room_allocations.faculty_id = faculty.faculty_id JOIN rooms ON faculty_room_allocations.room_id = rooms.room_id JOIN semesters ON faculty_room_allocations.semester_id = semesters.semester_id";
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
