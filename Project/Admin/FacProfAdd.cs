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
    public partial class FacProfAdd: Form
    {
        public FacProfAdd()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStaffUI facform = new AdminStaffUI();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProf addProf = new AddProf();
            addProf.StartPosition = FormStartPosition.Manual;
            addProf.Location = this.Location;

            this.Hide();
            addProf.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateProf updateProf = new UpdateProf();
            updateProf.StartPosition = FormStartPosition.Manual;
            updateProf.Location = this.Location;
            this.Hide();
            updateProf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelProf delProf = new DelProf();
            delProf.StartPosition = FormStartPosition.Manual;
            delProf.Location = this.Location;
            this.Hide();
            delProf.Show(); 
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ViewAll viewAll = new ViewAll();
            viewAll.StartPosition = FormStartPosition.Manual;
            viewAll.Location = this.Location;
            this.Hide();
            viewAll.Show();
        }
    }
}
