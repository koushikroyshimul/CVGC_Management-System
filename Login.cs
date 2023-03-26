using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstprojecT1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Id = username.Text;
            string Password = password.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-529VT4I\\SQLEXPRESS; database = t ; integrated security =True";

            try
            {

                String Query = "Select * from login_info where username = '" + Id + "' And password ='" + Password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable Data_table = new DataTable();
                sda.Fill(Data_table);

                if (Data_table.Rows.Count > 0)
                {
                    Id = username.Text;
                    Password = password.Text;
                }
                Form2 home = new Form2();
                home.Show();
                this.Hide();
            }

            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Id = username.Text;
            string Password = password.Text;
            SqlConnection Co = new SqlConnection();
            Co.ConnectionString = "data source = DESKTOP-529VT4I\\SQLEXPRESS; database = t ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Co;

            cmd.CommandText = "insert into login_info (username,password) values ('" + Id + "','" + Password + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);
            Co.Close();
            MessageBox.Show("Data Saved.", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Slogin form2 = new Slogin();
            form2.Show();
            this.Hide();
        }
    }
}
