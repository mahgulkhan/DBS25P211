using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;

namespace Project.Admin
{
    public partial class AddProf: Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int roll_id { get; set; }
        public string contact { get; set; }
        public string research_area { get; set; }
        public int teaching_hours { get; set; }
        public int designation_id { get; set; }
        public int user_id { get; set; }

        public AddProf()
        {
            InitializeComponent();
            username = username;
            password = password;
            email = email;
            roll_id = roll_id;
            contact = contact;
            research_area = research_area;
            teaching_hours = teaching_hours;
            designation_id = designation_id;
            user_id = user_id;
        }

        public void AddFacProf()
        {
            username = textBox8.Text;
            password = textBox7.Text;
            email = textBox4.Text;
            roll_id = 2;
            contact = textBox2.Text;
            research_area = textBox1.Text;
            teaching_hours = int.Parse(textBox5.Text);
            
            string designation = comboBox1.SelectedItem?.ToString();
            if (designation == "Lecturer")
            {
                designation_id = 4;
            }
            else if (designation == "Assistant Professor")
            {
                designation_id = 5;
            }
            else if (designation == "Associate Professor")
            {
                designation_id = 6;
            }
            else if (designation == "Professor")
            {
                designation_id = 7;
            }

            password = HashPassword(password);
            string query = $"INSERT INTO Users (username, password_hash, email, role_id) VALUES ( '{username}', '{password}', '{email}', '{roll_id}')";
            var conn = DatabaseHelper.Instance.Update(query);

            user_id = DatabaseHelper.Instance.GetUserId(username);

            string query2 = $"INSERT INTO FACULTY (name, email,contact, designation_id, research_area, total_teaching_hours, user_id) VALUES ('{username}','{email}','{contact}','{designation_id}','{research_area}','{teaching_hours}','{user_id}')";
            var conn2 = DatabaseHelper.Instance.Update(query2);

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

        private void button1_Click(object sender, EventArgs e)
        {
            AddFacProf();
            MessageBox.Show("Faculty Profile Added");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacProfAdd facform = new FacProfAdd();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
