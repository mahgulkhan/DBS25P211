using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Admin
{
    public partial class UpdateProf: Form
    {
        public UpdateProf()
        {
            InitializeComponent();
        }

        public void editProf()
        {
            string username = textBox8.Text;
            string password = textBox7.Text;
            string email = textBox4.Text;
            int roll_id = 2;
            string contact = textBox2.Text;
            string research_area = textBox1.Text;
            int user_id = int.Parse(textBox3.Text);
            int teaching_hours = int.Parse(textBox5.Text);
            int faculty_id = int.Parse(textBox6.Text);

            FacCrud facCrud = new FacCrud(username, password, email, roll_id, contact, research_area, teaching_hours, 0, user_id, faculty_id);
            facCrud.UpdateProfile();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter a user id");
                return;
            }
            editProf();
            MessageBox.Show("Faculty Profile Updated");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
