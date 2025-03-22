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
    public partial class DepResAll: Form
    {
        public DepResAll()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HODUI Hoduiform = new HODUI();
            Hoduiform.StartPosition = FormStartPosition.Manual;
            Hoduiform.Location = this.Location;

            this.Hide();
            Hoduiform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RoomAll roomAll = new RoomAll();
            roomAll.StartPosition = FormStartPosition.Manual;
            roomAll.Location = this.Location;
            this.Hide();
            roomAll.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
