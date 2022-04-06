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
    public partial class Faculty : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUYOG\SQLEXPRESS;Initial Catalog=Assignments;Integrated Security=True");
        public Faculty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string facultyName = txtname.Text.ToString();
            string remarks = txtremarks.Text.ToString();

            string sqlquery = "insert into faculty values('" + facultyName + "','" + remarks + "')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            string facultyName = txtname.Text.ToString();
            string remarks = txtremarks.Text.ToString();

            string sqlquery = "update faculty set facultyName='" + txtname + "',remarks='" + txtremarks + "where ID ='" + txtid + "'";
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
        void viewfaculty()
        {
            string sqlquery = "select *from faculty";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
            }
        }
        void resetfields()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtremarks.Text = "";
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            viewfaculty();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetfields();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtremarks.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            int ID = Convert.ToInt32(txtid.Text.ToString());

            string sqlquery = "delete from faculty where ID ='" + ID + "'";
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
            viewfaculty();
        }
    }
}
