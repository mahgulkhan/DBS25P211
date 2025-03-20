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
    public partial class Inventory: Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStaffUI facform = new AdminStaffUI();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.StartPosition = FormStartPosition.Manual;
            addItem.Location = this.Location;
            this.Hide();
            addItem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelItem delItem = new DelItem();
            delItem.StartPosition = FormStartPosition.Manual;
            delItem.Location = this.Location;
            this.Hide();
            delItem.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewItems viewItems = new ViewItems();
            viewItems.StartPosition = FormStartPosition.Manual;
            viewItems.Location = this.Location;
            this.Hide();
            viewItems.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateItem updateItem = new UpdateItem();
            updateItem.StartPosition = FormStartPosition.Manual;
            updateItem.Location = this.Location;
            this.Hide();
            updateItem.Show();
        }
    }
}
