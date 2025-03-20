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
    public partial class UpdateSem: Form
    {
        public UpdateSem()
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

        public void updateSem()
        {
            int sem_id = int.Parse(textBox2.Text);
            string sem_type ="";
            int sem_year = int.Parse(textBox1.Text);

            string Sem = comboBox2.SelectedItem?.ToString();
            if (Sem == "Spring")
            {
                sem_type = "Spring";
            }
            else if (Sem == "Fall")
            {
                sem_type = "Fall";
            }
            else if (Sem == "Summer")
            {
                sem_type = "Summer";
            }   

            SemCrud semCrud = new SemCrud(sem_id, sem_type,sem_year);
            semCrud.UpdateSemester();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            updateSem();
            MessageBox.Show("The semester has been updated");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
