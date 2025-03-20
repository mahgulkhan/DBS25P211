using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project.Admin
{
    class FacCrud
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Roll_id { get; set; }
        public string Contact { get; set; }
        public string Research_area { get; set; }
        public int Teaching_hours { get; set; }
        public int Designation_id { get; set; }
        public int User_id { get; set; }
        public int Faculty_id { get; set; }

        public FacCrud(string username, string password,string email, int roll_id, string contact, string research_area, int teaching_hours, int designation_id, int user_id, int faculty_id)
        {
            Username = username;
            Password = password;
            Email = email;
            Roll_id = roll_id;
            Contact = contact;
            Research_area = research_area;
            Teaching_hours = teaching_hours;
            Designation_id = designation_id;
            User_id = user_id;
            Faculty_id = faculty_id;
        }

        public void AddProfile()
        {
            checkuserid();
            Password = HashPassword(Password);

            string query = $"INSERT INTO Users (user_id,username, email, password_hash, role_id) VALUES ( {User_id},'{Username}', '{Email}','{Password}', '{Roll_id}')";
            var conn = DatabaseHelper.Instance.Update(query);

            string query2 = $"INSERT INTO Faculty (name, email,contact, designation_id, research_area, total_teaching_hours, user_id) VALUES ('{Username}','{Email}','{Contact}',{Designation_id},'{Research_area}','{Teaching_hours}',{User_id})";
            var conn2 = DatabaseHelper.Instance.Update(query2);
        }

        public void UpdateProfile()
        {
            Password = HashPassword(Password);

            string query = $"UPDATE Users SET username = '{Username}', email = '{Email}', password_hash = '{Password}' WHERE user_id = {User_id} AND role_id = {Roll_id}";
            var conn = DatabaseHelper.Instance.Update(query);

            string query2 = $"UPDATE Faculty SET name = '{Username}', email = '{Email}', contact = '{Contact}', research_area = '{Research_area}', total_teaching_hours = {Teaching_hours} WHERE user_id = {User_id} AND faculty_id = {Faculty_id}";
            var conn2 = DatabaseHelper.Instance.Update(query2);
        }

        public void DeleteProfile()
        {
            string query2 = $"DELETE FROM Faculty WHERE faculty_id = {Faculty_id}";
            var conn2 = DatabaseHelper.Instance.Update(query2);

            string query = $"DELETE FROM Users WHERE user_id = {User_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        public void checkuserid()
        {
            string query = $"SELECT user_id FROM Users WHERE user_id = {User_id}";
            var conn = DatabaseHelper.Instance.getData(query);
            if (conn.Read())
            {
                MessageBox.Show("User ID already exists,Enter a new User-ID");
            }
        }
    }
}
