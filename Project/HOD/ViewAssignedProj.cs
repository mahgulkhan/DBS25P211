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
    public partial class ViewAssignedProj: Form
    {
        public ViewAssignedProj()
        {
            InitializeComponent();
            ShowProj();
        }

        public void ShowProj()
        {
            string query = "SELECT faculty_projects.faculty_project_id,faculty.faculty_id,projects.project_id, projects.title, semesters.semester_id, faculty_projects.supervision_hours FROM faculty_projects JOIN faculty ON faculty_projects.faculty_id = faculty.faculty_id JOIN projects ON projects.project_id= faculty_projects.project_id";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResearchSup researchSup = new ResearchSup();
            researchSup.StartPosition = FormStartPosition.Manual;
            researchSup.Location = this.Location;
            this.Hide();
            researchSup.Show();
        }
    }
}
