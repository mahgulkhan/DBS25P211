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
    public partial class DelProj: Form
    {
        public DelProj()
        {
            InitializeComponent();
        }

        public void del()
        {
            int project_id = int.Parse(textBox3.Text);
            ProjCrud projectCrud = new ProjCrud(project_id, "", "");
            projectCrud.DeleteProject();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill all the given field");
            }

            del();
            MessageBox.Show("The project has been deleted");
        }
    }
}
