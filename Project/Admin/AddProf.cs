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
        
        public AddProf()
        {
            InitializeComponent();
        }

        public void AddFacProf()
        {
            string username = textBox8.Text;
            string password = textBox7.Text;
            string email = textBox4.Text;
            int roll_id = 2;
            string contact = textBox2.Text;
            string research_area = textBox1.Text;
            int user_id = int.Parse(textBox3.Text);
            int teaching_hours = int.Parse(textBox5.Text);
            int designation_id = 0;
            
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

            FacCrud facCrud = new FacCrud(username, password, email, roll_id, contact, research_area, teaching_hours, designation_id, user_id,0);
            facCrud.AddProfile();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
