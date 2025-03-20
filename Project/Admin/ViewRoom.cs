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
    public partial class ViewRoom: Form
    {
        public ViewRoom()
        {
            InitializeComponent();
            ShowRooms();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.StartPosition = FormStartPosition.Manual;
            room.Location = this.Location;
            this.Hide();
            room.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ShowRooms()
        {
            string query = $"SELECT * FROM Rooms";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
    }
}
