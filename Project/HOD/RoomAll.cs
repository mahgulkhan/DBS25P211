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
    public partial class RoomAll: Form
    {
        public RoomAll()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepResAll depResAll = new DepResAll();
            depResAll.StartPosition = FormStartPosition.Manual;
            depResAll.Location = this.Location;
            this.Hide();
            depResAll.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssignRoom assignRoom = new AssignRoom();
            assignRoom.StartPosition = FormStartPosition.Manual;
            assignRoom.Location = this.Location;
            this.Hide();
            assignRoom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateRoom updateRoom = new UpdateRoom();
            updateRoom.StartPosition = FormStartPosition.Manual;
            updateRoom.Location = this.Location;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelRoom delRoom = new DelRoom();
            delRoom.StartPosition = FormStartPosition.Manual;
            delRoom.Location = this.Location;
            this.Hide();
            delRoom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewAssignRoom viewAssignRoom = new ViewAssignRoom();
            viewAssignRoom.StartPosition = FormStartPosition.Manual;
            viewAssignRoom.Location = this.Location;
            this.Hide();
            viewAssignRoom.Show();
        }
    }
}
