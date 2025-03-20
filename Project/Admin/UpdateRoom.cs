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
    public partial class UpdateRoom: Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
        }

        public void Updateroom()
        {
            int room_id = int.Parse(textBox2.Text);
            string room_name = textBox3.Text;
            string Room_type = "";
            int capacity = int.Parse(textBox1.Text);

            string Room = comboBox2.SelectedItem?.ToString();
            if (Room == "Classroom")
            {
                Room_type = "Classroom";
            }
            else if (Room == "Lab")
            {
                Room_type = "Lab";
            }

            RoomCrud roomCrud = new RoomCrud(room_id, room_name,Room_type,capacity);
            roomCrud.UpdateRoom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            Updateroom();
            MessageBox.Show("The room has been updated");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.StartPosition = FormStartPosition.Manual;
            room.Location = this.Location;
            this.Hide();
            room.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
