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
using Lab2;
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
      
        public Form3()
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        public bool CheckCred(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE username = '{username}'";
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        return false;
                    }
                    string storedHash = result.ToString();
                    string enteredHash = HashPassword(password);

                    return storedHash == enteredHash; 
                }
            }
        }

        private string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); 
                }
                return builder.ToString();
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox8.Text.Trim();
            string password = textBox3.Text.Trim();
            if (CheckCred(username, password))
            {
                Rollform Sform = new Rollform();
                Sform.StartPosition = FormStartPosition.Manual;
                Sform.Location = this.Location;

                this.Hide();
                Sform.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
