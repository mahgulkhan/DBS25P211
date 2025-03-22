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
    }
}
