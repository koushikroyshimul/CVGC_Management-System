using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstprojecT1
{
    public partial class SScience : Form
    {
        public SScience()
        {
            InitializeComponent();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForStudent form2 = new ForStudent();
            form2.Show();
            this.Hide();
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SS student = new SS();
            student.Show();
            this.Hide();
        }

        private void tEACHERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ST Form2 = new ST();
            Form2.Show();
            this.Hide();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPM student = new SPM();
            student.Show();
            this.Hide();
        }

        private void vicePrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SVPM student = new SVPM();
            student.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SResult form2 = new SResult();
            form2.Show();
            this.Hide();
        }

        private void scienchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SScience form2 = new SScience();
            form2.Show();
            this.Hide();
        }

        private void commerceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SCommerce form2 = new SCommerce();
            form2.Show();
            this.Hide();
        }

        private void artsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SArts form2 = new SArts();
            form2.Show();
            this.Hide();
        }

        private void fEESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPayment form2 = new SPayment();
            form2.Show();
            this.Hide();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sabout form2 = new Sabout();
            form2.Show();
            this.Hide();
        }

        private void photoGellaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sphoto form2 = new Sphoto();
            form2.Show();
            this.Hide();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UserProfile form2 = new UserProfile();
            form2.Show();
            this.Hide();
        }
    }
}
