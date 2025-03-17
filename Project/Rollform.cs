using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string Role = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Please select a role");
                return;
            }
            else if (Role == "Administrative Staff")
            {
                AdminStaffUI Cform = new AdminStaffUI();
                Cform.StartPosition = FormStartPosition.Manual;
                Cform.Location = this.Location;

                this.Hide();
                Cform.Show();
            }
            else if (Role == "Department Head")
            {
                HODUI Cform = new HODUI();
                Cform.StartPosition = FormStartPosition.Manual;
                Cform.Location = this.Location;

                this.Hide();
                Cform.Show();
            }
            else if (Role == "Faculty Member")
            {
                FacultyUI Cform = new FacultyUI();
                Cform.StartPosition = FormStartPosition.Manual;
                Cform.Location = this.Location;
                this.Hide();
                Cform.Show();
            }   
        }
    }
}
