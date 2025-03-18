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
    }
}
