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
    public partial class Assignment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUYOG\SQLEXPRESS;Initial Catalog=Assignments;Integrated Security=True");
        public Assignment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string submissionDate = txtdate.Text.ToString();
            int StudentID = Convert.ToInt32(txtstudent.Text.ToString());
            int TeacherID = Convert.ToInt32(txtteacher.Text.ToString());
            int SubjectID = Convert.ToInt32(txtsubjectid.Text.ToString());
            int StatusID = Convert.ToInt32(txtstatusid.Text.ToString());
            string remarks = txtremarks.Text.ToString();

            string sqlquery = "insert into Assignment values ('"+submissionDate+ "','" + StudentID + "','" + SubjectID + "','" + TeacherID + "','" + StatusID + "','" + remarks + "')";
            SqlCommand cmd = new SqlCommand(sqlquery,con);
            int n = cmd.ExecuteNonQuery();
            if (n >= 1)
            {
                MessageBox.Show("Success", "Heading", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Fail", "Heading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            assignmentview();
            con.Close();
        }
        void studentviewList()
        {
            string sqlquery = "select StudentName from Students";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            txtstudent.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                txtstudent.Items.Add(dr[0].ToString());
            }
        }

        void courseviewList()
        {
            string sqlquery = "select subjectName from course";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            txtsubject.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                txtsubject.Items.Add(dr[0].ToString());
            }
        }

        void teacherviewList()
        {
            string sqlquery = "select TeacherName from teacher";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            txtteacher.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                txtteacher.Items.Add(dr[0].ToString());
            }
        }

        void statusviewList()
        {
            string sqlquery = "select statusName from status";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            txtstatus.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                txtstatus.Items.Add(dr[0].ToString());
            }
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            studentviewList();
            courseviewList();
            teacherviewList();
            studentviewList();

            assignmentview();

        }
        void studentselect(string StudentName)
        {
            string sqlquery = "select ID from Students where StudentName ='" +StudentName+"'";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtsid.Text = dr[0].ToString();
            }
        }

        void subjectselect(string subjectName)
        {
            string sqlquery = "select ID from course where subjectName ='" + subjectName + "'";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtstatusid.Text = dr[0].ToString();
            }
        }

        void Teacherselect(string TeacherName)
        {
            string sqlquery = "select ID from teacher where TeacherName ='" + TeacherName + "'";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txttid.Text = dr[0].ToString();
            }
        }


        void statusName(string statusName)
        {
            string sqlquery = "select ID from status where statusName ='" + statusName + "'";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtstatusid.Text = dr[0].ToString();
            }
        }

        private void txtstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string StudentName = txtstudent.Text.ToString();
            studentselect(StudentName);
        }

        private void txtteacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            string teacherName = txtteacher.Text.ToString();
            studentselect(teacherName);
        }

        private void txtsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subjectName = txtsubject.Text.ToString();
            studentselect(subjectName);
        }

        private void txtstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statusName = txtstatus.Text.ToString();
            studentselect(statusName);
        }

        private void txtsid_Click(object sender, EventArgs e)
        {

        }
        void assignmentview()
        {
            string sqlquery = "select a.ID,a.submission_Date,StudentName,TeacherName,subjectName,statusName,a.Remarks from Assignment as a join Students on a.studentID = Students.ID join course on a.subjectID = course.ID join teacher on a.teacherID = teacher.ID join status on a.statusID = status.ID";
            SqlDataAdapter sd = new SqlDataAdapter(sqlquery,con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtdate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string StudentName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string teacherName = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string subjectName = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string statusName = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtremarks.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            txtstudent.Text = StudentName;
            txtteacher.Text = teacherName;
            txtsubject.Text = subjectName;
            txtstatus.Text = statusName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            int AssignmentID = Convert.ToInt32(txtassignmentID.Text.ToString());
            string submissionDate = txtdate.Text.ToString();
            int StudentID = Convert.ToInt32(txtstudent.Text.ToString());
            int TeacherID = Convert.ToInt32(txtteacher.Text.ToString());
            int SubjectID = Convert.ToInt32(txtsubjectid.Text.ToString());
            int StatusID = Convert.ToInt32(txtstatusid.Text.ToString());
            string remarks = txtremarks.Text.ToString();

            string sqlquery = "update Assignment set submission_Date = '" + submissionDate + "',studentID = '" + StudentID + "',,teacherID = '" + TeacherID + "',subjectID = '" + SubjectID + "',statusID = '" + StatusID + "',Remarks = '" + remarks + "'where ID = '" + txtassignmentID + "'";

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
            assignmentview();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            int AssignmentID = Convert.ToInt32(txtassignmentID.Text.ToString());
            string submissionDate = txtdate.Text.ToString();
            int StudentID = Convert.ToInt32(txtstudent.Text.ToString());
            int TeacherID = Convert.ToInt32(txtteacher.Text.ToString());
            int SubjectID = Convert.ToInt32(txtsubjectid.Text.ToString());
            int StatusID = Convert.ToInt32(txtstatusid.Text.ToString());
            string remarks = txtremarks.Text.ToString();

            string sqlquery = "delete from Assignment where ID = '" + txtassignmentID + "'";

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
            assignmentview();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetfield();
        }
        void resetfield()
        {
            txtassignmentID.Text = "";
            txtstudent.Text = "";
            txtteacher.Text = "";
            txtsubject.Text = "";
            txtstatus.Text = "";
            txtremarks.Text = "";
        }
    }
}
