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
    public partial class DelRoom: Form
    {
        public DelRoom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomAll roomAll = new RoomAll();
            roomAll.StartPosition = FormStartPosition.Manual;
            roomAll.Location = this.Location;
            this.Hide();
            roomAll.Show();
        }

        public void del()
        {
            int allocation_id = int.Parse(textBox1.Text);
            RoomCrud roomcrud = new RoomCrud(allocation_id, 0, 0, 0, 0);
            roomcrud.DeleteRoomAll();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all fields");
            }

            del();
            MessageBox.Show("Room Deleted");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
