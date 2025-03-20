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
    public partial class Sem: Form
    {
        public Sem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStaffUI adminStaffUI = new AdminStaffUI();
            adminStaffUI.StartPosition = FormStartPosition.Manual;
            adminStaffUI.Location = this.Location;
            this.Hide();
            adminStaffUI.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewSem viewSem = new ViewSem();
            viewSem.StartPosition = FormStartPosition.Manual;
            viewSem.Location = this.Location;
            this.Hide();
            viewSem.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddSem addSem = new AddSem();
            addSem.StartPosition = FormStartPosition.Manual;
            addSem.Location = this.Location;
            this.Hide();
            addSem.Show();
        }
    }
}
