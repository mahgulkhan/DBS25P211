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
    public partial class DelRoom: Form
    {
        public DelRoom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.StartPosition = FormStartPosition.Manual;
            room.Location = this.Location;
            this.Hide();
            room.Show();
        }

        public void del()
        {
            int room_id = int.Parse(textBox3.Text);
            RoomCrud roomCrud = new RoomCrud(room_id, "","",0);
            roomCrud.DeleteRoom();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill all the given field");
            }
            
            del();
            MessageBox.Show("The room has been deleted");
        }
    }
}
