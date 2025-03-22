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
    public partial class CourseAssign: Form
    {
        public CourseAssign()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkLoadAssign workform = new WorkLoadAssign();
            workform.StartPosition = FormStartPosition.Manual;
            workform.Location = this.Location;
            this.Hide();
            workform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssignCourse assigncourse = new AssignCourse();
            assigncourse.StartPosition = FormStartPosition.Manual;
            assigncourse.Location = this.Location;
            this.Hide();
            assigncourse.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAssignCourse updateAssignCourse = new UpdateAssignCourse();
            updateAssignCourse.StartPosition = FormStartPosition.Manual;
            updateAssignCourse.Location = this.Location;
            this.Hide();
            updateAssignCourse.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelAssignCourse delAssignCourse = new DelAssignCourse();
            delAssignCourse.StartPosition = FormStartPosition.Manual;
            delAssignCourse.Location = this.Location;
            this.Hide();
            delAssignCourse.Show();
        }
    }
}
