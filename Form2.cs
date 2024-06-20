using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_management_2
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aliha\OneDrive\Documents\Hotelmangment.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            staff.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            room.Show();
            this.Hide();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();


        }
    }
}
