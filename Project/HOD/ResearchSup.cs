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
    public partial class ResearchSup: Form
    {
        public ResearchSup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkLoadAssign workform = new WorkLoadAssign();
            workform.StartPosition = FormStartPosition.Manual;
            workform.Location = this.Location;
            this.Hide();
            workform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewAssignedProj viewAssignedProj = new ViewAssignedProj();
            viewAssignedProj.StartPosition = FormStartPosition.Manual;
            viewAssignedProj.Location = this.Location;
            this.Hide();
            viewAssignedProj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProjSup addProjSup = new AddProjSup();
            addProjSup.StartPosition = FormStartPosition.Manual;
            addProjSup.Location = this.Location;
            this.Hide();
            addProjSup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProj updateProj = new UpdateProj();
            updateProj.StartPosition = FormStartPosition.Manual;
            updateProj.Location = this.Location;
            this.Hide();
            updateProj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelProj delProj = new DelProj();    
            delProj.StartPosition = FormStartPosition.Manual;
            delProj.Location = this.Location;
            this.Hide();
            delProj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
