using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;

namespace Project
{
    public partial class Rollform: Form
    {
        public Rollform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roll_id = 0;
            string Role = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Please select a role");
                return;
            }
            else if (Role == "Administrative Staff")
            {
                roll_id = 1;
            }
            else if (Role == "Department Head")
            {
                roll_id= 3;
            }
            else if (Role == "Faculty Member")
            {
                roll_id =2;
            } 
            
            Form3 login = new Form3(roll_id);
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;

            this.Hide();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
