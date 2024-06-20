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
    public partial class client : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aliha\OneDrive\Documents\Hotelmangment.mdf;Integrated Security=True;Connect Timeout=30");
        
        public client()
        {
            InitializeComponent();
        }
        public void populate()
        {
            string Myquery = "select * from clientid, clientName";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            clientdatagrid.DataSource = ds.Tables[0];
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void client_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into client_tbl values ('" + clientidtbl.Text + "', '"+clientnametbl.Text+"', '"+clientphonetbl.Text+"','"+clientscnic.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully added");  
            con.Close();
        }

        private void clientdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string myquery = "UPDATE Client_tbl set ClientName='" + clientnametbl.Text + "', ClientPhone='" + clientphonetbl.Text + "' where clientid = " + clientidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("client successfully editted");
            con.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from client_tbl where clientid =" + clientidtbl.Text + " ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();


            MessageBox.Show("client successfully deleted");
            con.Close();
        }

        private void datelbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientphonetbl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 