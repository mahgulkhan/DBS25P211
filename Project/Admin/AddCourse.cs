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
    public partial class AddCourse: Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseAll courseAll = new CourseAll();
            courseAll.StartPosition = FormStartPosition.Manual;
            courseAll.Location = this.Location;
            this.Hide();
            courseAll.Show();
        }
        public void Add()
        {
            string course_name = textBox3.Text;
            string course_type = "";
            int credit_hours = int.Parse(textBox1.Text);
            int contact_hours = int.Parse(textBox6.Text);

            string Course = comboBox2.SelectedItem?.ToString();
            if (Course == "Theory")
            {
                course_type = "Theory";
            }
            else if (Course == "Lab")
            {
                course_type = "Lab";
            }

            CourseCrud courseCrud = new CourseCrud(0,course_name, course_type, credit_hours, contact_hours);
            courseCrud.AddCourrse();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            Add();
            MessageBox.Show("Course Added Successfully");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
