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
    public partial class CourseAll: Form
    {
        public CourseAll()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DelCourse delCourse = new DelCourse();
            delCourse.StartPosition = FormStartPosition.Manual;
            delCourse.Location = this.Location;
            this.Hide();
            delCourse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStaffUI facform = new AdminStaffUI();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewCourse viewCourse = new ViewCourse();
            viewCourse.StartPosition = FormStartPosition.Manual;
            viewCourse.Location = this.Location;
            this.Hide();
            viewCourse.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCourse addCourse = new AddCourse();
            addCourse.StartPosition = FormStartPosition.Manual;
            addCourse.Location = this.Location;
            this.Hide();
            addCourse.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateCourse updateCourse = new UpdateCourse();
            updateCourse.StartPosition = FormStartPosition.Manual;
            updateCourse.Location = this.Location;
            this.Hide();
            updateCourse.Show();
        }
    }
}
