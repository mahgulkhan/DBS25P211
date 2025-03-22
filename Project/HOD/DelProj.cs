using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Faculty;

namespace Project.HOD
{
    public partial class DelProj: Form
    {
        public DelProj()
        {
            InitializeComponent();
        }

        public void del()
        {
            int faculty_project_id = int.Parse(textBox1.Text);
            ProjCrud projcrud = new ProjCrud(faculty_project_id, 0, 0, 0, 0);
            projcrud.DelProj();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResearchSup researchSup = new ResearchSup();
            researchSup.StartPosition = FormStartPosition.Manual;
            researchSup.Location = this.Location;
            this.Hide();
            researchSup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            del();
            MessageBox.Show("The Project has been deleted");
        }
    }
}
