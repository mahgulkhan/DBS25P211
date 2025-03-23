using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class ForgotPass: Form
    {
        public string username { get; set; } 
        public string password { get; set; }
        public string email { get; set; } 
        public int roll_id { get; set; }

        public ForgotPass()
        {
            InitializeComponent();
            username = username;
            password = password;
            email = email;
            roll_id = roll_id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3(roll_id);
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;

            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox8.Text;
            password = textBox7.Text;
            email = textBox4.Text;
            roll_id = int.Parse(textBox1.Text);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || roll_id == 0)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else if ( roll_id != 1 && roll_id != 2 && roll_id != 3)
            {
                MessageBox.Show("Please enter a valid role id.");
            }
            else
            {
                UpdatePassword(username, password, email, roll_id);
                MessageBox.Show("Password has been updated.");

                Form3 login = new Form3(roll_id);
                login.StartPosition = FormStartPosition.Manual;
                login.Location = this.Location;

                this.Hide();
                login.Show();
            }

        }
        public void UpdatePassword(string username, string password, string email, int roll_id)
        {
            password = HashPassword(password);
            string query = $"UPDATE Users SET password_hash = '{password}' WHERE username = '{username}' AND email = '{email}' AND role_id = '{roll_id}'";
            var connect= DatabaseHelper.Instance.Update(query);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
