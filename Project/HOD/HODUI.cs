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
    public partial class HODUI: Form
    {
        public HODUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Facreqman facreqform = new Facreqman();
            facreqform.StartPosition = FormStartPosition.Manual;
            facreqform.Location = this.Location;

            this.Hide();
            facreqform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WorkLoadAssign workform = new WorkLoadAssign();
            workform.StartPosition = FormStartPosition.Manual;
            workform.Location = this.Location;

            this.Hide();
            workform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepResAll resallform = new DepResAll();
            resallform.StartPosition = FormStartPosition.Manual;
            resallform.Location = this.Location;

            this.Hide();
            resallform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RepAnalysis repform = new RepAnalysis();
            repform.StartPosition = FormStartPosition.Manual;
            repform.Location = this.Location;

            this.Hide();
            repform.Show();
        }
    }
}
