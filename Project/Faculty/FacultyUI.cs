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

namespace Project
{
    public partial class FacultyUI: Form
    {
        public FacultyUI()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FacReqsub facreqform = new FacReqsub();
            facreqform.StartPosition = FormStartPosition.Manual;
            facreqform.Location = this.Location;

            this.Hide();
            facreqform.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            WorkloadView workviewform = new WorkloadView();
            workviewform.StartPosition = FormStartPosition.Manual;
            workviewform.Location = this.Location;

            this.Hide();
            workviewform.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FacProfile profileform = new FacProfile();
            profileform.StartPosition = FormStartPosition.Manual;
            profileform.Location = this.Location;

            this.Hide();
            profileform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FacReqstat statform = new FacReqstat();
            statform.StartPosition = FormStartPosition.Manual;
            statform.Location = this.Location;

            this.Hide();
            statform.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            ProjectSup projectSup = new ProjectSup();
            projectSup.StartPosition = FormStartPosition.Manual;
            projectSup.Location = this.Location;
            this.Hide();
            projectSup.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
