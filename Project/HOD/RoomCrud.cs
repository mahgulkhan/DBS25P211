using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.HOD
{
    class RoomCrud
    {
        public int allocation_id { get; set; }
        public int faculty_id { get; set; }
        public int room_id { get; set; }
        public int reserved_hours { get; set; }
        public int semester_id { get; set; }

        public RoomCrud(int Allocation_id, int Faculty_id, int Room_id, int Reserved_hours, int Semester_id)
        {
            allocation_id = Allocation_id;
            faculty_id = Faculty_id;
            room_id = Room_id;
            reserved_hours = Reserved_hours;
            semester_id = Semester_id;
        }

        public void AssignRoom()
        {
            string query = $"INSERT INTO room_allocation(faculty_id, room_id, reserved_hours, semester_id) VALUES({faculty_id}, {room_id}, {reserved_hours}, {semester_id})";
            DatabaseHelper.Instance.Update(query);
        }

        public void UpdateRoomAll()
        {
            string query = $"UPDATE room_allocation SET faculty_id = {faculty_id} room_id = {room_id}, reserved_hours = {reserved_hours}, semester_id = {semester_id} WHERE allocation_id = {allocation_id}";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteRoomAll()
        {
            string query = $"DELETE FROM room_allocation WHERE allocation_id = {allocation_id}";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
