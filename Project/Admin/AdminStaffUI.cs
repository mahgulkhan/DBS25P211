using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Admin;

namespace Project
{
    public partial class AdminStaffUI: Form
    {
        public AdminStaffUI()
        {
            InitializeComponent();
        }
        
        public void LoadData()
        {
            string query = "SELECT * FROM Users ";
            var conn = DatabaseHelper.Instance.getData(query);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            CourseAll courseform = new CourseAll();
            courseform.StartPosition = FormStartPosition.Manual;
            courseform.Location = this.Location;

            this.Hide();
            courseform.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FacProfAdd facform = new FacProfAdd();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReqProc reqform = new ReqProc();
            reqform.StartPosition = FormStartPosition.Manual;
            reqform.Location = this.Location;

            this.Hide();
            reqform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.StartPosition = FormStartPosition.Manual;
            inventory.Location = this.Location;
            this.Hide();
            inventory.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.StartPosition = FormStartPosition.Manual;
            room.Location = this.Location;
            this.Hide();
            room.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sem sem = new Sem();
            sem.StartPosition = FormStartPosition.Manual;
            sem.Location = this.Location;
            this.Hide();
            sem.Show();
        }
    }
}
