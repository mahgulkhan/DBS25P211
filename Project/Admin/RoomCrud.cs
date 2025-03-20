using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    class RoomCrud
    {
        public int room_id { get; set; }
        public string room_name { get; set; }
        public string room_type { get; set; }
        public int capacity { get; set; }

        public RoomCrud(int Room_id, string Room_name, string Room_type, int Capacity)
        {
            room_id = Room_id;
            room_name = Room_name;
            room_type = Room_type;
            capacity = Capacity;
        }

        public void AddRoom()
        {
            string query = $"INSERT INTO Rooms (room_name, room_type, capacity) VALUES ('{room_name}', '{room_type}', {capacity})";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void UpdateRoom()
        {
            string query = $"UPDATE Rooms SET room_name = '{room_name}', room_type = '{room_type}', capacity = {capacity} WHERE room_id = '{room_id}'";
            var conn = DatabaseHelper.Instance.Update(query);
        }
        public void DeleteRoom()
        {
            string query = $"DELETE FROM Rooms WHERE room_id = '{room_id}'";
            var conn = DatabaseHelper.Instance.Update(query);
        }
    }
}
