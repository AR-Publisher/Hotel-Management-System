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
    public partial class staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aliha\OneDrive\Documents\Hotelmangment.mdf;Integrated Security=True;Connect Timeout=30");
        public staff()
        {
            InitializeComponent();
        }
        public void populate()
        {
            string Myquery = "select * from staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            clientdatagrid.DataSource = ds.Tables[0];
        }
        private void stffaddbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into staff_tbl values ('" + staffidtbl.Text + "', '" + staffnametbl.Text + "', '" + staffnotbl.Text + "', '" + staffpasstbl.Text + "', '" + staffgendertbl.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("staff successfully added");
            con.Close();
        }

        private void staffdeletebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from staff_tbl where staffd =" + staffidtbl.Text + " ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("staff's info successfully deleted");
            con.Close();
        }

        private void staffeditbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string myquery = "UPDATE staff_tbl set staffid='" + staffidtbl.Text + "', staffno='" + staffnotbl.Text + "', staffpass='" + staffpasstbl.Text+ "' where staffid = " + staffidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("room successfully editted");
            con.Close();
        }

        private void staffnametbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void staffpasstbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

        }

        private void staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void staffgendertbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
