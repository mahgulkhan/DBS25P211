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
    public partial class AddAdminRole: Form
    {
        public AddAdminRole()
        {
            InitializeComponent();
            getFaculty_id();
            getSemester_id();
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
                comboBox2.Items.Add(conn["faculty_id"].ToString()+"-"+conn["name"].ToString());
            }
        }

        public void getSemester_id()
        {
            string query = $"SELECT semester_id,term FROM semesters";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox1.Items.Add(conn["semester_id"].ToString()+"-"+ conn["term"].ToString());
            }
        }

        public void Add()
        {
            string fac = comboBox2.SelectedItem.ToString();
            string[] faculty = fac.Split('-');
            int faculty_id = int.Parse(faculty[0]);

            string sem = comboBox1.SelectedItem.ToString();
            string[] semester = sem.Split('-');
            int semester_id = int.Parse(semester[0]);

            string role = textBox1.Text;

            AdminRoleCrud adminRoleCrud = new AdminRoleCrud(0, faculty_id, role, semester_id);
            adminRoleCrud.AddAdminRole();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            Add();
            MessageBox.Show("The Admin Role has been added");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
