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
    public partial class Science : Form
    {
        public Science()
        {
            InitializeComponent();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void dELETESTUDENTINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D_S_I form2 = new D_S_I();
            form2.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update form2 = new Update();
            form2.Show();
            this.Hide();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student student = new student();
            student.Show();
            this.Hide();
        }

        private void updateStudentClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USI student = new USI();
            student.Show();
            this.Hide();
        }

        private void searchTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher Form2 = new Teacher();
            Form2.Show();
            this.Hide();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Teacher_Info form3 = new Teacher_Info();
            form3.Show();
            this.Hide();
        }

        private void transferRetiredTeacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D_T_I form2 = new D_T_I();
            form2.Show();
            this.Hide();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal student = new Principal();
            student.Show();
            this.Hide();
        }

        private void vicePrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vice_Principal student = new Vice_Principal();
            student.Show();
            this.Hide();
        }

        private void addResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addresult form2 = new Addresult();
            form2.Show();
            this.Hide();
        }

        private void searchResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchresult form2 = new Searchresult();
            form2.Show();
            this.Hide();
        }

        private void updateResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update form2 = new Update();
            form2.Show();
            this.Hide();
        }

        private void scienchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Science form2 = new Science();
            form2.Show();
            this.Hide();
        }

        private void commerceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commerce form2 = new Commerce();
            form2.Show();
            this.Hide();
        }

        private void artsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arts form2 = new Arts();
            form2.Show();
            this.Hide();
        }

        private void newPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment form2 = new Payment();
            form2.Show();
            this.Hide();
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPayment form2 = new ViewPayment();
            form2.Show();
            this.Hide();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form2 = new About();
            form2.Show();
            this.Hide();
        }

        private void photoGellaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Photo form2 = new Photo();
            form2.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AdminProfile form2 = new AdminProfile();
            form2.Show();
            this.Hide();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }
    }
}
