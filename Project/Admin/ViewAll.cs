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
    public partial class ViewAll: Form
    {
        public ViewAll()
        {
            InitializeComponent();
            ShowUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacProfAdd facform = new FacProfAdd();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;
            this.Hide();
            facform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ShowUsers()
        {
            string query = $"SELECT * FROM Faculty";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
    }
}
