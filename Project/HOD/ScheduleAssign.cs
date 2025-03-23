using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HOD
{
    public partial class ScheduleAssign: Form
    {
        public ScheduleAssign()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkLoadAssign workLoadAssign = new WorkLoadAssign();
            workLoadAssign.StartPosition = FormStartPosition.Manual;
            workLoadAssign.Location = this.Location;
            this.Hide();
            workLoadAssign.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule();
            addSchedule.StartPosition = FormStartPosition.Manual;
            addSchedule.Location = this.Location;
            this.Hide();
            addSchedule.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSchedule updateSchedule = new UpdateSchedule();
            updateSchedule.StartPosition = FormStartPosition.Manual;
            updateSchedule.Location = this.Location;
            this.Hide();
            updateSchedule.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelSchedule delSchedule = new DelSchedule();
            delSchedule.StartPosition = FormStartPosition.Manual;
            delSchedule.Location = this.Location;
            this.Hide();
            delSchedule.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewAssignSchedule viewAssignSchedule = new ViewAssignSchedule();
            viewAssignSchedule.StartPosition = FormStartPosition.Manual;
            viewAssignSchedule.Location = this.Location;
            this.Hide();
            viewAssignSchedule.Show();
        }
    }
}
