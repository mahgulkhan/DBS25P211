using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Project.HOD
{
    public partial class DelSchedule: Form
    {
        public DelSchedule()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScheduleAssign scheduleAssign = new ScheduleAssign();
            scheduleAssign.StartPosition = FormStartPosition.Manual;
            scheduleAssign.Location = this.Location;
            this.Hide();
            scheduleAssign.Show();
        }

        public void del()
        {
            int schedule_id = int.Parse(textBox1.Text);
            ScheduleCrud scheduleCrud = new ScheduleCrud(schedule_id, 0, 0, "", "", "");
            scheduleCrud.DeleteSchedule();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill the required fields");
            }
            
            del();
            MessageBox.Show("Schedule Deleted Successfully");
        }
    }
}
