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
    public partial class DelCourse: Form
    {
        public DelCourse()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void del()
        {
            int course_id = int.Parse(textBox3.Text);
            CourseCrud courseCrud = new CourseCrud(course_id, "", "", 0, 0);
            courseCrud.DeleteCourrse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill all the given field");
            }
            
            del();
            MessageBox.Show("The course has been deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseAll courseAll = new CourseAll();
            courseAll.StartPosition = FormStartPosition.Manual;
            courseAll.Location = this.Location;
            this.Hide();
            courseAll.Show();
        }
    }
}
