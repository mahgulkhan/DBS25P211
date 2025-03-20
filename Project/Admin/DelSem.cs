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
    public partial class DelSem: Form
    {
        public DelSem()
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
        public void del()
        {
            int sem_id = int.Parse(textBox3.Text);
            SemCrud semCrud = new SemCrud(sem_id, "",0);
            semCrud.DeleteSemester();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill all the given field");
            }
            del();
            MessageBox.Show("The semester has been deleted");
        }
    }
}
