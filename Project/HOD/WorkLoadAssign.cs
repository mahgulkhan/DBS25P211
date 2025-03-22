using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.HOD;

namespace Project
{
    public partial class WorkLoadAssign: Form
    {
        public WorkLoadAssign()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseAssign courseAssign = new CourseAssign();
            courseAssign.StartPosition = FormStartPosition.Manual;
            courseAssign.Location = this.Location;
            this.Hide();
            courseAssign.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScheduleAssign scheduleAssign = new ScheduleAssign();
            scheduleAssign.StartPosition = FormStartPosition.Manual;
            scheduleAssign.Location = this.Location;
            this.Hide();
            scheduleAssign.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResearchSup researchSup = new ResearchSup();
            researchSup.StartPosition = FormStartPosition.Manual;
            researchSup.Location = this.Location;
            this.Hide();
            researchSup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HODUI Hoduiform = new HODUI();
            Hoduiform.StartPosition = FormStartPosition.Manual;
            Hoduiform.Location = this.Location;

            this.Hide();
            Hoduiform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDuty adminDuty = new AdminDuty();
            adminDuty.StartPosition = FormStartPosition.Manual;
            adminDuty.Location = this.Location;
            this.Hide();
            adminDuty.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
