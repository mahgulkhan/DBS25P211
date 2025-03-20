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
    public partial class AddRoom: Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        public void Add()
        {
            string room_name = textBox3.Text;
            string room_type = "";
            int room_capacity = int.Parse(textBox1.Text);

            string type = comboBox2.SelectedItem?.ToString();
            if (type == "Classroom")
            {
                room_type = "Classroom";
            }
            else if (type == "Lab")
            {
                room_type = "Lab";
            }

            RoomCrud roomCrud = new RoomCrud(0,room_name, room_type, room_capacity);
            roomCrud.AddRoom();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.StartPosition = FormStartPosition.Manual;
            room.Location = this.Location;
            this.Hide();
            room.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox1.Text) || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the fields");
            }

            Add();
            MessageBox.Show("The room has been added");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
