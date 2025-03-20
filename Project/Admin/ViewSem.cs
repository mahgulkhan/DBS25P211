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
    public partial class ViewSem: Form
    {
        public ViewSem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sem sem = new Sem();
            sem.StartPosition = FormStartPosition.Manual;
            sem.Location = this.Location;
            this.Hide();
            sem.Show();
        }
        
        public void Viewsems()
        {
            string query = "SELECT * FROM Semesters";
            var conn = DatabaseHelper.Instance.getData(query);
            DataTable data = new DataTable();
            data.Load(conn);
            dataGridView1.DataSource = data;
        }
    }
}
