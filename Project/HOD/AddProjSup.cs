using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Faculty;

namespace Project.HOD
{
    public partial class AddProjSup: Form
    {
        public AddProjSup()
        {
            InitializeComponent();
            getFaculty_id();
            getProject_id();    
            getSemester_id();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResearchSup researchSup = new ResearchSup();
            researchSup.StartPosition = FormStartPosition.Manual;
            researchSup.Location = this.Location;
            this.Hide();
            researchSup.Show();
        }

        public void Addproj()
        {
            string fac = comboBox2.SelectedItem.ToString();
            string[] faculty = fac.Split('-');
            int faculty_id = int.Parse(faculty[0]);

            string proj = comboBox3.SelectedItem.ToString();
            string[] project = proj.Split('-');
            int project_id = int.Parse(project[0]);

            string sem = comboBox1.SelectedItem.ToString();
            string[] semester = sem.Split('-');
            int semester_id = int.Parse(semester[0]);

            int supervison_hours = int.Parse(textBox1.Text);

            ProjCrud projcrud = new ProjCrud(0,faculty_id,project_id,semester_id,supervison_hours);
            projcrud.AddProj();
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
                comboBox1.Items.Add(conn["semester_id"].ToString() + "-" + conn["term"].ToString());
            }
        }
        public void getProject_id()
        {
            string query = $"SELECT project_id,title FROM projects";
            var conn = DatabaseHelper.Instance.getData(query);
            while(conn.Read())
            {
                comboBox3.Items.Add(conn["project_id"].ToString()+"_" + conn["title"].ToString());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            Addproj();
            MessageBox.Show("Project Supervisor Assigned Successfully");
        }
    }
}
