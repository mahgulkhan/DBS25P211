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
    public partial class DelProf: Form
    {
        public DelProf()
        {
            InitializeComponent();
        }
        
        public void Delprof()
        {
            int faculty_id = int.Parse(textBox6.Text);
            int user_id = int.Parse(this.textBox1.Text);
            FacCrud facCrud = new FacCrud("","","",0,"","",0,0,user_id,faculty_id);
            facCrud.DeleteProfile();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacProfAdd facform = new FacProfAdd();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;
            this.Hide();
            facform.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please enter faculty id");
                return;
            }
            Delprof();
            MessageBox.Show("Faculty profile deleted");
        }
    }
}
