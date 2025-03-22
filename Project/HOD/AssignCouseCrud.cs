using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.HOD
{
    class AssignCouseCrud
    {
        public int faculty_course_id { get; set; }
        public int faculty_id { get; set; }
        public int course_id { get; set; }
        public int semester_id { get; set; }

        public AssignCouseCrud(int Faculty_course_id, int Faculty_id, int Course_id, int Semester_id)
        {
            faculty_course_id = Faculty_course_id;
            faculty_id = Faculty_id;
            course_id = Course_id;
            semester_id = Semester_id;
        }

        public void AddCourse()
        {
            string query = $"INSERT INTO Faculty_courses (faculty_id, course_id, semester_id) VALUES ({faculty_id}, {course_id}, {semester_id})";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void UpdateCourse()
        {
            string query = $"UPDATE Faculty_courses SET faculty_id = {faculty_id}, course_id = {course_id}, semester_id = {semester_id} WHERE faculty_course_id = {faculty_course_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void DeleteCourse()
        {
            string query = $"DELETE FROM Faculty_courses WHERE faculty_course_id = {faculty_course_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
    }
}
