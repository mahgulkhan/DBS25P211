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
    public partial class UpdateCourse: Form
    {
        public UpdateCourse()
        {
            InitializeComponent();
        }
        public void update()
        {
            int course_id = int.Parse(textBox2.Text);
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

            CourseCrud courseCrud = new CourseCrud(course_id, course_name, course_type, credit_hours, contact_hours);
            courseCrud.UpdateCourrse();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            
            update();
            MessageBox.Show("Course Updated Successfully");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseAll courseAll = new CourseAll();
            courseAll.StartPosition = FormStartPosition.Manual;
            courseAll.Location = this.Location;
            courseAll.Name = this.Name;
            this.Hide();
            courseAll.Show();   
        }
    }
}
