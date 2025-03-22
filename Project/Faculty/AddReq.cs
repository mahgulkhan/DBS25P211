using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Faculty
{
    public partial class AddReq: Form
    {
        public AddReq()
        {
            InitializeComponent();
            getFaculty_id();
            getItem_id();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacReqsub facReqsub = new FacReqsub();
            facReqsub.StartPosition = FormStartPosition.Manual;
            facReqsub.Location = this.Location;
            this.Hide();
            facReqsub.Show();
        }

        public void Addreq()
        {
            string items = comboBox1.SelectedItem.ToString();
            string[] item = items.Split('-');
            int items_id = int.Parse(item[0]);

            string faculty_ID = comboBox2.SelectedItem.ToString();
            string[] faculty = faculty_ID.Split('-');
            int faculty_id = int.Parse(faculty[0]);

            int quantity = int.Parse(textBox1.Text);
            int status_id = 8;

            string date = textBox2.Text;

            ReqCrud reqCrud = new ReqCrud(0, faculty_id, items_id, quantity, status_id, date);
            reqCrud.AddRequest();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void getFaculty_id()
        {
            string query = $"SELECT faculty_id,name FROM faculty";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox2.Items.Add(conn["faculty_id"].ToString() +"-"+ conn["name"].ToString());
            }
        }

        public void getItem_id()
        {
            string query = $"SELECT consumable_id,item_name FROM consumables";
            var conn = DatabaseHelper.Instance.getData(query);
            while (conn.Read())
            {
                comboBox1.Items.Add(conn["consumable_id"].ToString()+"-"+ conn["item_name"].ToString());
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            Addreq();
            MessageBox.Show("The request has been added");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
