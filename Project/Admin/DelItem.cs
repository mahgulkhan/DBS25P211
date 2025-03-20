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
    public partial class DelItem: Form
    {
        public DelItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.StartPosition = FormStartPosition.Manual;
            inventory.Location = this.Location;
            this.Hide();
            inventory.Show();
        }

        public void del()
        {
            int consumable_id = int.Parse(textBox3.Text);
            InventoryCrud inventoryCrud = new InventoryCrud(consumable_id, "");
            inventoryCrud.DeleteConsumable();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill all the given field");
            }

            del();
            MessageBox.Show("The item has been deleted");
        }
    }
}
