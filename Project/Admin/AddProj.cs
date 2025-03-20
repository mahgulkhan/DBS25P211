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
    public partial class AddProj: Form
    {
        public AddProj()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectManage projectManage = new ProjectManage();
            projectManage.StartPosition = FormStartPosition.Manual;
            projectManage.Location = this.Location;
            this.Hide();
            projectManage.Show();
        }

        public void Add()
        {
            string project_name = textBox1.Text;
            string project_description = textBox2.Text;

            ProjCrud projectCrud = new ProjCrud(0, project_name, project_description);
            projectCrud.AddProject();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            Add();
            MessageBox.Show("The project has been added");
        }
    }
}
