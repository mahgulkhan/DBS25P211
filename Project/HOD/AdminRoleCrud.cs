using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.HOD
{
    class AdminRoleCrud
    {
        public int admin_role_id { get; set; }
        public int faculty_id { get; set; }
        public string role_name { get; set; }
        public int semester_id { get; set; }

        public AdminRoleCrud(int Admin_role_id, int Faculty_id, string Role_name, int Semester_id)
        {
            admin_role_id = Admin_role_id;
            faculty_id = Faculty_id;
            role_name = Role_name;
            semester_id = Semester_id;
        }

        public void AddAdminRole()
        {
            string query = $"INSERT INTO Faculty_admin_roles (faculty_id,role_name, semester_id) VALUES ({faculty_id}, '{role_name}', {semester_id})";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void UpdateAdminRole()
        {
            string query = $"UPDATE Faculty_admin_roles SET faculty_id = {faculty_id}, role_name = '{role_name}', semester_id = {semester_id} WHERE admin_role_id = {admin_role_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void DeleteAdminRole()
        {
            string query = $"DELETE FROM Faculty_admin_roles WHERE admin_role_id = {admin_role_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
    }
}
