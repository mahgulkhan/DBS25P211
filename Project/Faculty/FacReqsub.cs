using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Faculty;

namespace Project
{
    public partial class FacReqsub: Form
    {
        public FacReqsub()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyUI facform = new FacultyUI();
            facform.StartPosition = FormStartPosition.Manual;
            facform.Location = this.Location;

            this.Hide();
            facform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddReq addReq = new AddReq();
            addReq.StartPosition = FormStartPosition.Manual;
            addReq.Location = this.Location;
            this.Hide();
            addReq.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateReq updateReq = new UpdateReq();
            updateReq.StartPosition = FormStartPosition.Manual;
            updateReq.Location = this.Location;
            this.Hide();
            updateReq.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelReq delReq = new DelReq();
            delReq.StartPosition = FormStartPosition.Manual;
            delReq.Location = this.Location;
            this.Hide();
            delReq.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReqStatus reqStatus = new ReqStatus();
            reqStatus.StartPosition = FormStartPosition.Manual;
            reqStatus.Location = this.Location;
            this.Hide();
            reqStatus.Show();
        }
    }
}
