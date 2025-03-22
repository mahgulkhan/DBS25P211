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
    public partial class UpdateProj: Form
    {
        public UpdateProj()
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

        public void update()
        {
            int project_id = int.Parse(textBox2.Text);
            string project_name = textBox3.Text;
            string description = textBox1.Text;

            ProjCrud projectCrud = new ProjCrud(project_id, project_name, description);
            projectCrud.UpdateProject();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            update();
            MessageBox.Show("The project has been updated");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
