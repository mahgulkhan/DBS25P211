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
    public partial class Room: Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewRoom viewRoom = new ViewRoom();
            viewRoom.StartPosition = FormStartPosition.Manual;
            viewRoom.Location = this.Location;
            this.Hide();
            viewRoom.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.StartPosition = FormStartPosition.Manual;
            addRoom.Location = this.Location;
            this.Hide();
            addRoom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateRoom updateRoom = new UpdateRoom();
            updateRoom.StartPosition = FormStartPosition.Manual;
            updateRoom.Location = this.Location;
            this.Hide();
            updateRoom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelRoom delRoom = new DelRoom();
            delRoom.StartPosition = FormStartPosition.Manual;
            delRoom.Location = this.Location;
            this.Hide();
            delRoom.Show();
        }
    }
}
