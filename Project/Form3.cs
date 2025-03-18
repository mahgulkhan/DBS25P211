using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System.Security.Cryptography;
using Org.BouncyCastle.OpenSsl;

namespace Project
{
    public partial class Form3: Form
    {

        public string username;
        public string password;
        private int selectedroll;
      
        public Form3(int role_id)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.selectedroll = role_id;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        public bool CheckCred(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE username = '{username}' AND role_id = {selectedroll}";
            var conn = DatabaseHelper.Instance.getData(query);

            if (conn.Read())
            {
                string storedHash = conn["password_hash"].ToString();
                conn.Close();

                string hashedInput = HashPassword(password);
                if (storedHash == hashedInput)
                {
                    return true;
                }
            }
            return false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox8.Text.Trim();
            password = textBox3.Text.Trim();

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (CheckCred(username, password))
            {
                MessageBox.Show("Login Successful");

                if (selectedroll == 1)
                {
                    AdminStaffUI Cform = new AdminStaffUI();
                    Cform.StartPosition = FormStartPosition.Manual;
                    Cform.Location = this.Location;

                    this.Hide();
                    Cform.Show();
                }
                else if (selectedroll==3)
                {
                    HODUI Cform = new HODUI();
                    Cform.StartPosition = FormStartPosition.Manual;
                    Cform.Location = this.Location;

                    this.Hide();
                    Cform.Show();
                }
                else if (selectedroll==2)
                {
                    FacultyUI Cform = new FacultyUI();
                    Cform.StartPosition = FormStartPosition.Manual;
                    Cform.Location = this.Location;
                    this.Hide();
                    Cform.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rollform Cform = new Rollform();
            Cform.StartPosition = FormStartPosition.Manual;
            Cform.Location = this.Location;

            this.Hide();
            Cform.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass Cform = new ForgotPass();
            Cform.StartPosition = FormStartPosition.Manual;
            Cform.Location = this.Location;

            this.Hide();
            Cform.Show();
        }
    }
}
