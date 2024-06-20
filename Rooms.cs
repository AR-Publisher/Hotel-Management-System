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
    public partial class Rooms : Form
    { 
        public Rooms()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aliha\OneDrive\Documents\Hotelmangment.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            string Myquery = "select * from room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            clientdatagrid.DataSource = ds.Tables[0];
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yesradio.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into room_tbl values ('" + roomidtbl.Text + "', '" + roomnotbl.Text + "', '" + isfree + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully added");
            con.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from room_tbl where roomid =" + roomidtbl.Text + " ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("room successfully deleted");
            con.Close();

        }

        private void roomEditbtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yesradio.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            con.Open();
            string myquery = "UPDATE room_tbl set roomid='" + roomidtbl.Text + "', roomno='" + roomnotbl.Text + "', roomfree='"+isfree+"' where roomid = " + roomidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("room successfully editted");
            con.Close();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
