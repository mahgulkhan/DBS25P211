using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.HOD
{
    class ScheduleCrud
    {
        public int schedule_id { get; set; }
        public int faculty_course_id {  get; set; }
        public int room_id { get; set; }    
        public string day_of_week { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }

        public ScheduleCrud(int Schedule_id,int Faculty_course_id, int Room_id, string Day_of_week, string Dtart_time, string End_time)
        {
            schedule_id = Schedule_id;
            faculty_course_id = Faculty_course_id;
            room_id = Room_id;
            day_of_week = Day_of_week;
            start_time = Dtart_time;
            end_time = End_time;
        }

        public void AddSchedule()
        {
            string query = $"INSERT INTO faculty_course_schedule (faculty_course_id, room_id, day_of_week, start_time, end_time) VALUES ({faculty_course_id}, {room_id}, '{day_of_week}', '{start_time}', '{end_time}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void UpdateSchedule()
        {
            string query = $"UPDATE faculty_course_schedule SET faculty_course_id = {faculty_course_id}, room_id = {room_id}, day_of_week = '{day_of_week}', start_time = '{start_time}', end_time = '{end_time}' WHERE schedule_id = {schedule_id}";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteSchedule()
        {
            string query = $"DELETE FROM faculty_course_schedule WHERE schedule_id = {schedule_id}";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
