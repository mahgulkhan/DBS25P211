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
    public partial class AddSem: Form
    {
        public AddSem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sem sem = new Sem();
            sem.StartPosition = FormStartPosition.Manual;
            sem.Location = this.Location;
            this.Hide();
            sem.Show();
        }

        public void Add()
        {
            int sem_year = int.Parse(textBox1.Text);
            string sem_type = "";

            string Semester = comboBox2.SelectedItem?.ToString();
            if (Semester == "Spring")
            {
                sem_type = "Spring";
            }
            else if (Semester == "Summer")
            {
                sem_type = "Summer";
            }
            else if (Semester == "Fall")
            {
                sem_type = "Fall";
            }

            SemCrud semCrud = new SemCrud(0,sem_type, sem_year);
            semCrud.AddSemester();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            Add();
            MessageBox.Show("The semester has been added");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
