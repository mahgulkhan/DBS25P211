using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Admin
{
    public partial class ViewCourse: Form
    {
        public ViewCourse()
        {
            InitializeComponent();
            ShowCourses();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ShowCourses()
        {
            string query = $"SELECT * FROM Courses";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseAll courseform = new CourseAll();
            courseform.StartPosition = FormStartPosition.Manual;
            courseform.Location = this.Location;
            this.Hide();
            courseform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
