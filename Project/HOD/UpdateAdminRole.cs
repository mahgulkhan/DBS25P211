using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HOD
{
    public partial class UpdateAdminRole: Form
    {
        public UpdateAdminRole()
        {
            InitializeComponent();
            getFaculty_id();
            getSemester_id();
        }

        public void Updaterole()
        {
            int admin_id = int.Parse(textBox2.Text);
            string fac = comboBox2.SelectedItem.ToString();
            string[] faculty = fac.Split('-');
            int faculty_id = int.Parse(faculty[0]);

            string role = textBox1.Text;
            string sem = comboBox1.SelectedItem.ToString();
            string[] semester = sem.Split('-');
            int semester_id = int.Parse(semester[0]);

            AdminRoleCrud adminRoleCrud = new AdminRoleCrud(admin_id, faculty_id, role, semester_id);
            adminRoleCrud.UpdateAdminRole();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdminDuty adminDuty = new AdminDuty();
            adminDuty.StartPosition = FormStartPosition.Manual;
            adminDuty.Location = this.Location;
            this.Hide();
            adminDuty.Show();
        }

        public void getFaculty_id()
        {
            string query = $"SELECT faculty_id,name FROM faculty";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox2.Items.Add(conn["faculty_id"].ToString() + "-" + conn["name"].ToString());
            }
        }
        
        public void getSemester_id()
        {
            string query = $"SELECT semester_id,term FROM semesters";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox1.Items.Add(conn["semester_id"].ToString()+ "-" + conn["term"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            Updaterole();
            MessageBox.Show("The role has been updated");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
