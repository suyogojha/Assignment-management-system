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
    public partial class Student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUYOG\SQLEXPRESS;Initial Catalog=Assignments;Integrated Security=True");
        string newGender = "Male";
        int n = 1;
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string StudentName = txtname.Text.ToString();
            string Address = txtaddress.Text.ToString();
            string RollNo = txtrollno.Text.ToString();
            string Class = txtclass.Text.ToString();
            if (newGender == "MALE")
            {
                txtmale.Checked = true;
                txtfemale.Checked = false;
            }
            else
            {
                txtmale.Checked = false;
                txtfemale.Checked = true;
            }
            string Email = txtemail.Text.ToString();
            int FacultyID = Convert.ToInt32(txtfacultyid.Text.ToString());

            string sqlquery = "insert into Students values('" + StudentName + "','" + Address + "','" + RollNo + "','" + Class + "','" + newGender + "','" + Email + "','" + FacultyID + "')";
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
            viewstudent();
            resetfields();
            con.Close();
        }

        private void txtmale_CheckedChanged(object sender, EventArgs e)
        {
            newGender = "MALE";
        }

        private void txtfemale_CheckedChanged(object sender, EventArgs e)
        {
            newGender = "FEMALE";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string StudentName = txtname.Text.ToString();
            string Address = txtaddress.Text.ToString();
            string RollNo = txtrollno.Text.ToString();
            string Class = txtclass.Text.ToString();
            if (newGender == "MALE")
            {
                txtmale.Checked = true;
                txtfemale.Checked = false;
            }
            else
            {
                txtmale.Checked = false;
                txtfemale.Checked = true;
            }
            string Email = txtemail.Text.ToString();
            int FacultyID = Convert.ToInt32(txtfacultyid.Text.ToString());

            string sqlquery = "update Student set StudentName='" + txtname + "',Address='" + txtaddress + "',RollNo='" + txtrollno + "',Class='" + txtclass + "',Email='" + txtemail + "',FacultyID='" + txtfacultyid + "where ID ='" + txtid + "'";
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
        void viewstudent()
        {
            string sqlquery = "select *from Students";
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
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();
            }
        }
        void resetfields()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtrollno.Text = "";
            txtclass.Text = "";
            txtmale.Text = "";
            txtfemale.Text = "";
            txtemail.Text = "";
            txtfacultyid.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetfields();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            viewstudent();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtaddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtrollno.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtclass.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            newGender = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            if (newGender == "MALE")
            {
                txtmale.Checked = true;
                txtfemale.Checked = false;
            }
            else
            {
                txtmale.Checked = false;
                txtfemale.Checked = true;
            }
            txtemail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtfacultyid.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            int ID = Convert.ToInt32(txtid.Text.ToString());

            string sqlquery = "delete from Students where ID ='" + ID + "'";
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
            viewstudent();
        }
    }
}
