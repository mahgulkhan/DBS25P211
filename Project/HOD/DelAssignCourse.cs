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
    public partial class DelAssignCourse: Form
    {
        public DelAssignCourse()
        {
            InitializeComponent();
        }

        public void del()
        {
            int faculty_course_id = int.Parse(textBox1.Text);
            AssignCouseCrud assignCouseCrud = new AssignCouseCrud(faculty_course_id, 0, 0, 0);
            assignCouseCrud.DeleteCourse();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sbyte.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Please fill all the fields");
            }

            del();
            MessageBox.Show("The Course has been deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseAssign courseAssign = new CourseAssign();
            courseAssign.StartPosition = FormStartPosition.Manual;
            courseAssign.Location = this.Location;
            this.Hide();
            courseAssign.Show();
        }
    }
}
