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

namespace Assignment_management_system
{
    public partial class Teacher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUYOG\SQLEXPRESS;Initial Catalog=Assignments;Integrated Security=True");
        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string TeacherName = txtname.Text.ToString();
            string Address = txtaddress.Text.ToString();
            string Contact = txtcontact.Text.ToString();
            string Email = txtemail.Text.ToString();

            string sqlquery = "insert into teacher values('" + TeacherName + "','" + Address + "','" + Contact + "','" + Email + "')";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            int n = cmd.ExecuteNonQuery();
            if (n >= 1)
            {
                MessageBox.Show("Success", "Heading", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Fail", "Heading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            viewteacher();
            resetfields();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string TeacherName = txtname.Text.ToString();
            string Address = txtaddress.Text.ToString();
            string Contact = txtcontact.Text.ToString();
            string Email = txtemail.Text.ToString();

            string sqlquery = "update teacher set TeacherName='" + txtname + "',Address='" + txtaddress + "',Contact='" + txtcontact + "',Email='" + txtemail + "where ID ='" + txtid + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            int n = cmd.ExecuteNonQuery();
            if (n >= 1)
            {
                MessageBox.Show("Success", "Heading", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Fail", "Heading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        void viewteacher()
        {
            string sqlquery = "select *from teacher";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
            }
        }
        void resetfields()
        {
            txtname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetfields();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            viewteacher();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtaddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtcontact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            int ID = Convert.ToInt32(txtid.Text.ToString());

            string sqlquery = "delete from teacher where ID ='" + ID + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            int n = cmd.ExecuteNonQuery();
            if (n >= 1)
            {
                MessageBox.Show("Success", "Heading", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Fail", "Heading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            viewteacher();
        }
    }
}
