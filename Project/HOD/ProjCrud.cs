using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.HOD
{
    class ProjCrud
    {
        public int faculty_project_id { get; set; }
        public int faculty_id { get; set; }
        public int project_id { get; set; }
        public int semester_id { get; set; }
        public int supervision_hours { get; set; }

        public ProjCrud(int Faculty_project_id, int Faculty_id, int Project_id, int Semester_id, int Supervision_hours)
        {
            faculty_project_id = Faculty_project_id;
            faculty_id = Faculty_id;
            project_id = Project_id;
            semester_id = Semester_id;
            supervision_hours = Supervision_hours;
        }

        public void AddProj()
        {
            string query = $"INSERT INTO Faculty_projects (faculty_id, project_id, semester_id, supervision_hours) VALUES ({faculty_id}, {project_id}, {semester_id}, {supervision_hours})";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void Updateproj()
        {
            string query = $"UPDATE Faculty_projects SET faculty_id = {faculty_id} , project_id = {project_id}, semester_id = {semester_id}, supervision_hours = {supervision_hours} WHERE faculty_project_id = {faculty_project_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
        public void DelProj()
        {
            string query = $"DELETE FROM Faculty_projects WHERE faculty_project_id = {faculty_project_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
    }
}
