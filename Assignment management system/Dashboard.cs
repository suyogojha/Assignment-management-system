using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status st = new Status();
            st.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Show();
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faculty c = new Faculty();
            c.Show();
        }

        private void assignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assignment c = new Assignment();
            c.Show();
        }
    }
}
