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
    public partial class ViewProj: Form
    {
        public ViewProj()
        {
            InitializeComponent();
            ShowProjects();
        }

        private void ViewProj_Load(object sender, EventArgs e)
        {

        }
        public void ShowProjects()
        {
            string query = $"SELECT * FROM Projects";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectManage projectManage = new ProjectManage();
            projectManage.StartPosition = FormStartPosition.Manual;
            projectManage.Location = this.Location;
            this.Hide();
            projectManage.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
